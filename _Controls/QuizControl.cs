using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;

namespace VocabularyProNamespace
{
    public partial class QuizControl : Form
    {
        /// <summary>
        /// VARIABLE DECLARATIONS AND MOUSE EVENTS CONSTANTS AND DLL IMPORTS
        /// </summary>
        #region

        private static int numBlink = 0;
        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private static Timer timer1 = null;
        private static Timer timer2 = null;
        private Timer timer3 = null;

        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int HideCaret(int hwnd);

        #endregion

        /// <summary>
        /// MOUSE EVENTS METHODS
        /// </summary>
        #region
        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if ((nCode >= 0) &&
                ((MouseMessages)wParam != MouseMessages.WM_MOUSEMOVE) &&
                ((MouseMessages)wParam != MouseMessages.WM_MOUSEWHEEL))
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                Form tempForm = Form.ActiveForm;
                if (!tempForm.DesktopBounds.Contains(new Point(hookStruct.pt.x, hookStruct.pt.y)))
                {
                    numBlink = 0;
                    timer1.Start();
                    System.Media.SystemSounds.Hand.Play();

                    //(((Label)(tempForm.Controls.Find("label2", true)[0]))).Text = hookStruct.pt.x + ", " + hookStruct.pt.y;
                }

            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        #endregion

        public QuizControl()
        {
            InitializeComponent();
            // 
            // timer1
            // 
            timer1 = new Timer();
            timer1.Interval = 15;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            // 
            // timer2
            // 
            timer2 = new Timer();
            timer2.Interval = 15;
            timer2.Tick += new System.EventHandler(timer2_Tick);
            //
            // timer3
            //
            timer3 = new Timer();
            timer3.Interval = 1;
            timer3.Enabled = true;
            timer3.Start();
            timer3.Tick += new System.EventHandler(timer3_Tick);

            _hookID = SetHook(_proc);
            this.numericUpDown1.Controls[0].Cursor = Cursors.Default;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ((VocabularyPro)this.Owner).SetNumQuizQuestions(Int32.Parse(this.numericUpDown1.Value.ToString()));
            this.Close();
        }

        private static void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                Form f = Form.ActiveForm;

                if (numBlink > 8)
                {
                    timer2.Stop();
                    f.BackColor = Color.White;
                    f.Opacity = 0.95;
                    return;
                }

                numBlink++;

                f.BackColor = Color.White;
                f.Opacity = 0.95;
                timer2.Stop();
                timer1.Start();
            }
            catch { }
        }

        private static void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (numBlink > 8)
                {
                    timer1.Stop();
                    return;
                }
                numBlink++;
                Form f = Form.ActiveForm;  
                f.BackColor = SystemColors.ActiveCaption;
                f.Opacity = 0.10;
                timer1.Stop();
                timer2.Start();
            }
            catch { }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            HideCaret(this.numericUpDown1.Controls[1].Handle.ToInt32());
        }

        private void QuizControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnhookWindowsHookEx(_hookID);
            timer1.Dispose();
            timer2.Dispose();
            timer3.Dispose();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            HideCaret(this.numericUpDown1.Controls[1].Handle.ToInt32());
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
