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
    public partial class Review : UserControl
    {
        string [] question = null;
        string []response = null;
        int pageIndex = 0;

        public Review()
        {
            InitializeComponent();
        }

        public Review(string question, string response)
        {
            InitializeComponent();
            this.question = question.Split(new string[]{";", "\r\n"}, StringSplitOptions.None);
            this.response = response.Split(new string[] { ";", "\r\n" }, StringSplitOptions.None);
            this.btnPrev.Enabled = false;
            this.lblCorrect.BackColor = Color.LightGreen;
            this.lblIncorrect.BackColor = Color.LightSalmon;
        }

        private void LoadReview()
        {
            string[] splits = this.question[this.pageIndex].Split(new string[] { "->", "&&", "\r\n" }, StringSplitOptions.None);
            this.label1.Text = splits[0];
            this.radioButton1.Text = splits[1];
            this.radioButton2.Text = splits[2];
            this.radioButton3.Text = splits[3];
            this.radioButton4.Text = splits[4];

            splits = null;
            splits = this.response[this.pageIndex].Split(new string[] { ":", ";", "\r\n" }, StringSplitOptions.None);


            if (splits[0] != splits[1])
            {
                switch (Int32.Parse(splits[0]))
                {
                    case 0:
                        this.radioButton1.BackColor = Color.LightSalmon;
                        this.radioButton1.Checked = true;
                        break;
                    case 1:
                        this.radioButton2.BackColor = Color.LightSalmon;
                        this.radioButton2.Checked = true;
                        break;
                    case 2:
                        this.radioButton3.BackColor = Color.LightSalmon;
                        this.radioButton3.Checked = true;
                        break;
                    case 3:
                        this.radioButton4.BackColor = Color.LightSalmon;
                        this.radioButton4.Checked = true;
                        break;
                }

                switch (Int32.Parse(splits[1]))
                {
                    case 0:
                        this.radioButton1.BackColor = Color.LightGreen;
                        break;
                    case 1:
                        this.radioButton2.BackColor = Color.LightGreen;
                        break;
                    case 2:
                        this.radioButton3.BackColor = Color.LightGreen;
                        break;
                    case 3:
                        this.radioButton4.BackColor = Color.LightGreen;
                        break;
                }
            }
            else
            {
                switch (Int32.Parse(splits[1]))
                {
                    case 0:
                        this.radioButton1.BackColor = Color.LightGreen;
                        this.radioButton1.Checked = true;
                        break;
                    case 1:
                        this.radioButton2.BackColor = Color.LightGreen;
                        this.radioButton2.Checked = true;
                        break;
                    case 2:
                        this.radioButton3.BackColor = Color.LightGreen;
                        this.radioButton3.Checked = true;
                        break;
                    case 3:
                        this.radioButton4.BackColor = Color.LightGreen;
                        this.radioButton4.Checked = true;
                        break;
                }
            }
                   
        }

        private void Review_Load(object sender, EventArgs e)
        {
            LoadReview();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.btnPrev.Enabled = true;
            this.radioButton1.BackColor = Color.Transparent;
            this.radioButton2.BackColor = Color.Transparent;
            this.radioButton3.BackColor = Color.Transparent;
            this.radioButton4.BackColor = Color.Transparent;
            pageIndex += 1;

            LoadReview();

            if ((pageIndex + 1) >= (this.question.Length - 1))
                this.btnNext.Enabled = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.btnNext.Enabled = true;
            this.radioButton1.BackColor = Color.Transparent;
            this.radioButton2.BackColor = Color.Transparent;
            this.radioButton3.BackColor = Color.Transparent;
            this.radioButton4.BackColor = Color.Transparent;
            pageIndex -= 1;

            LoadReview();

            if (pageIndex <= 0)
            {
                this.btnPrev.Enabled = false;
            }
        }

    }
}
