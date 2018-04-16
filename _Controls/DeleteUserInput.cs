using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VocabularyProNamespace
{
    public partial class DeleteUserInput : Form
    {
        string userChoice = "";

        public DeleteUserInput(string word, string type)
        {
            string wordType = type;

            if (!Enum.IsDefined(typeof(Constants.WordType), type.ToUpper()))
                wordType = "unknown type";

            InitializeComponent();
            this.pictureBox1.Image = (Image)SystemIcons.Warning.ToBitmap();


            this.lblWarning.Text = String.Format(this.lblWarning.Text,word, wordType);
            this.radioButton1.Text = String.Format(this.radioButton1.Text, word, wordType);
            this.radioButton2.Text = String.Format(this.radioButton2.Text, word);
        }

        private void SetUserChoice()
        {
            Form f = Form.ActiveForm.Owner;

            GroupBox gb = (GroupBox)(f.Controls.Find("DisplayArea", true)[0]);
            FlashCard fc = (FlashCard)(gb.Controls.Find("FlashCard", false)[0]);

            fc.userChoice = this.userChoice;            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.userChoice = "";

            if (radioButton1.Checked)
                this.userChoice = "wordtype";
            else
                this.userChoice = "word";

            SetUserChoice();
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
            this.userChoice = "";
            SetUserChoice();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                this.btnDelete.Enabled = true;
            else
                this.btnDelete.Enabled = false;
        }

        private void DeleteUserInput_Load(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
        }

    }
}
