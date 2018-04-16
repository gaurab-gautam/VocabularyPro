using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using VocabularyProNamespace._Controls;

namespace VocabularyProNamespace
{
    public partial class PrintWords : Form
    {
        public PrintWords()
        {
            InitializeComponent();
            this.pictureBox1.Location = new Point(Screen.FromControl(this).WorkingArea.Width / 2, 
                Screen.FromControl(this).WorkingArea.Height / 2);
            HideTabs();
        }

        private void PrintWords_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
            this.crystalReportViewer1.Visible = true;
        }

        public void HideTabs()
        {
            System.Diagnostics.Debug.Assert(crystalReportViewer1.ReportSource != null,
                "you have to set the ReportSource first");

            foreach (Control control in this.crystalReportViewer1.Controls)
            {
                if (control is CrystalDecisions.Windows.Forms.PageView)
                {
                    TabControl tab = (TabControl)((CrystalDecisions.Windows.Forms.PageView)control).Controls[0];
                    tab.ItemSize = new Size(0, 1);
                    tab.SizeMode = TabSizeMode.Fixed;
                    tab.Appearance = TabAppearance.Buttons;

                }
            }
        }
    }
}
