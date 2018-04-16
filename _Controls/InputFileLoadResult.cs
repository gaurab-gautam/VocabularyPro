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
    public partial class InputFileLoadResult : Form
    {
        StringBuilder wordsAlreadyPresent;

        public InputFileLoadResult(StringBuilder words)
        {
            this.wordsAlreadyPresent = words;
            InitializeComponent();
        }

        private void InputFileLoadResult_Load(object sender, EventArgs e)
        {
            string[] words = this.wordsAlreadyPresent.ToString().Split(new char[] { '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string w in words)
            {
                if (w.Contains(';'))
                {
                    this.cblWordsAlreadyPresent.Items.Add("   " + w.Substring(0, w.IndexOf(';')) +
                        "  (" + w.Substring(w.IndexOf(';') + 1) + ")", true);
                }
            }
            this.lblWordCount.Text = String.Format(this.lblWordCount.Text, words.Count());
        }
    }
}
