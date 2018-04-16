using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VocabularyProNamespace
{
    public partial class Result : UserControl
    {
        string response = "";
        int correctAnsCount = 0;

        public Result()
        {
            InitializeComponent();
        }

        public Result(string resp)
        {
            InitializeComponent();
            this.response = resp;
            this.groupBox1.Visible = true;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            string[] splits = this.response.Split(new string[] { ";" }, StringSplitOptions.None);
            int i = 0;

            foreach (string s in splits)
            {
                // segmentation fault check
                if (++i >= splits.Length)  
                    break;

                string [] temp = s.Split(new char[] { ':' });
                
                if (temp[0] == temp[1])
                {
                    this.correctAnsCount += 1;
                }
            }

            this.lblCorrectAns.Text = this.correctAnsCount.ToString();
            this.lblIncorrectAns.Text = (splits.Length - this.correctAnsCount - 1).ToString();
            this.lblTotalQ.Text = (splits.Length - 1).ToString();
        }

    }
}
