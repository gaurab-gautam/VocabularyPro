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
    public partial class WordUI : UserControl
    {
        public WordUI()
        {
            InitializeComponent();
        }

        public string word 
        {
            get
            {
                return this.txtWord.Text;
            }

            set
            {
                this.txtWord.Text = value;
            }
        }

        public string meaning
        {
            get
            {
                return this.txtMeaning.Text;
            }

            set
            {
                this.txtMeaning.Text = value;
            }
        }

        public string sentence
        {
            get
            {
                return this.txtSentence.Text;
            }

            set
            {
                this.txtSentence.Text = value;
            }
        }

        public string synonyms
        {
            get
            {
                return this.txtSynonyms.Text;
            }

            set
            {
                this.txtSynonyms.Text = value;
            }
        }
    }
}
