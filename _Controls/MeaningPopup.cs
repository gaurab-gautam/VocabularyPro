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
    public partial class MeaningPopup : Form
    {
        string word = "";
        WordUtil wordUtil = null;
        TreeView tvMeanings;

        #region MOUSE EVENT CONSTANTS AND DECLARATIONS

        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
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
                    Form f = Form.ActiveForm;
                    f.Close();
                }

            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        #endregion

        protected override void OnMove(EventArgs e)
        {
            //
            // Don't allow moving form outside of desktop bounds
            //
            int x = this.Location.X;
            int y = this.Location.Y;

            if (this.Right > SystemInformation.VirtualScreen.Right)
                x = Cursor.Position.X - this.Width;
            if (this.Bottom > SystemInformation.VirtualScreen.Bottom)
                y = Cursor.Position.Y - this.Height;

            this.Location = new Point(x, y);

            base.OnMove(e);
        }

        public MeaningPopup(Point P, string _word, Control c)
        {
            if (c is TreeView)
            {
                this.tvMeanings = (TreeView)c;
            }

            InitializeComponent();
            this.splitContainer1.Panel2.Controls.Add(this.tvMeanings);
            this.word = _word;
            this.Location = P;

            this.wordUtil = new WordUtil();
            LoadMeanings();

            
            // set the window hook
            _hookID = SetHook(_proc);
        }

        private string[] MeaningWrap(string meaning)
        {
            int numLines = (meaning.Length / 70) + 1;
            int length = 0;
            int startSpaceIndex = 0;
            int spaceLastIndex = 0;
            int startIndex = 0;
            string[] meaningWrap = new string[numLines];
            
            for (int i = 0; i < numLines; i++)
            {
                startIndex = spaceLastIndex;
                length = ((i + 1) != numLines) ? (70 + ((i * 70) - spaceLastIndex)) : (meaning.Length % 70) + ((i * 70) - spaceLastIndex) - 1;
                startSpaceIndex = spaceLastIndex + length + 1;                
                spaceLastIndex = meaning.LastIndexOf(" ", startSpaceIndex, 20);
                length = ((i + 1) != numLines) ?  spaceLastIndex - startIndex  : meaning.Length - startIndex;
                
                /*MessageBox.Show("Length of string: " + meaning.Length +
                       "\r\nline [ " + (i + 1) + " of " + numLines + " ]" +
                       "\r\nlength of substring = " + length +
                       "\r\nlast index of space = " + spaceLastIndex +
                       "\r\nstart index of substring = " + startIndex
                       );*/


                meaningWrap[i] = meaning.Substring(startIndex, length);
            }

            return meaningWrap;
        }

        private void LoadMeanings()
        {
            WordContents wc = this.wordUtil.GetWordContents(this.word);
            
            foreach (WordContents.WordAttribute wAttr in wc.WordAttr)
            {
                StringBuilder str = new StringBuilder();
                TreeNode node = new TreeNode();


                // get all the meanings 
                foreach (string m in wAttr.Meanings)
                {
                    str.AppendLine(m.Trim());
                }

                // get the word and word type
                if (Enum.IsDefined(typeof(Constants.WordType), wAttr.WordType.ToUpper()))
                {
                   node.Text = (wc.Word + "   ( " + wAttr.WordType.Trim() + " )");
                }
                else
                    node.Text = wc.Word + "   (?)";

                
                // parse all the meanings
                string[] meaningArr = str.ToString().Trim().Split(new char[] { '\n', '\r' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string m in meaningArr)
                {
                    if (m.Trim().Length > 0) // ignore the last period
                    {
                        if (m.Trim().Length > 70)
                        {
                            string[] wordwrap = MeaningWrap(m);
                            int i = 0;

                            for (i = 0; i < wordwrap.Length; i++)
                            {
                                if (i == 0)
                                {
                                    node.Nodes.Add(" »  " + wordwrap[i]);
                                }
                                else
                                {
                                    node.Nodes.Add("    " + wordwrap[i]);
                                }
                            }
                        }
                        else
                            node.Nodes.Add(" »  " + m);
                    }
                }

                this.tvMeanings.Nodes.Add(node);
                // add an empty separator node
                this.tvMeanings.Nodes.Add("");
            }

            this.tvMeanings.ExpandAll();
        }

        private void Pop_upControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnhookWindowsHookEx(_hookID);
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            this.btnClose.ForeColor = Color.Firebrick;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.ForeColor = Color.DarkRed;
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tvMeanings_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void tvMeanings_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //e.Node.BackColor = SystemColors.Window;
            e.Cancel = true;
        }


    }
}
