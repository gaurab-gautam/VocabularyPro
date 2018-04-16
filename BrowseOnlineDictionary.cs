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
    public partial class BrowseOnlineDictionary : Form
    {
        public BrowseOnlineDictionary()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.pictureBox1.Visible = false;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.pictureBox1.Visible = true;
        }
    }
}
