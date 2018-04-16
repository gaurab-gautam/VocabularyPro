using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;

namespace VocabularyProNamespace
{
    public partial class SearchWord : UserControl
    {
        WordUtil wordUtil = null;
        
        
        public SearchWord()
        {
            InitializeComponent();
            this.wordUtil = new WordUtil();
            LoadAutoCompleteSource();
            this.txtWord.Select();
        }

        public SearchWord(int wordIndex)
        {
            InitializeComponent();
            this.wordUtil = new WordUtil();
            LoadAutoCompleteSource();

            string word = this.wordUtil.GetWordByIndex(wordIndex);
            this.txtWord.Text = word;
            this.txtWord.Select();
        }

        private void LoadAutoCompleteSource()
        {
            string[] words = this.wordUtil.GetAllWords();
            
            AutoCompleteStringCollection txtWordAutoCompleteCollection = new AutoCompleteStringCollection();

            txtWordAutoCompleteCollection.AddRange(words);
            this.txtWord.AutoCompleteCustomSource = txtWordAutoCompleteCollection;
        }

        private void DoSearch()
        {
            if (this.txtWord.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtWord, "Enter a word to search.");
                this.lblError.Text = "* Required";
                this.lblError.Visible = true;
                return;
            }
            else
            {
                this.errorProvider1.SetError(this.txtWord, null);
                this.lblError.Visible = false;
            }

            int index = SearchXML(this.txtWord.Text.Trim());

            if (index == -1)
            {
                this.lblError.Text = "The word is not in your vocabulary list.";
                lblError.Visible = true;
                return;
            }

            // instantiate a new flash card object
            FlashCard fc = new FlashCard(index, this.Name, null);
            Form f = Form.ActiveForm;
            GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
            gb.Controls.Add(fc);
            this.Dispose();  
        }

        private int SearchXML(string word)
        {
            int index = this.wordUtil.GetWordIndex(word);

            return index;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void txtWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DoSearch();
            }
        }


        /*
         * 
         * 
         * private void DoSearch()
        {
            if (this.btnSearchEdit.Text == "Save")
            {
                if (CheckForEmptyEntry())
                {
                    this.lblError.Visible = true;
                    return;
                }

                //save the edited meanings, etc.
                SaveXML();

                //return back to flash card/word list if edit was requested from it
                if (this.parentControl == "FlashCard")
                {
                    FlashCard fCard = new FlashCard(this.wordOrPageIndex, this.Name);
                    Form f = Form.ActiveForm;
                    GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
                    gb.Controls.Add(fCard);
                    this.Dispose();
                    return;
                }
                else if (this.parentControl == "WordList")
                {
                    Form f = Form.ActiveForm;
                    GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
                    WordList wListI = new WordList(this.wordOrPageIndex);
                    gb.Controls.Add(wListI);
                    this.Dispose();
                    return;
                }
                

                this.txtWord.Focus();
                this.txtWord.ReadOnly = false;
                this.lblError.Visible = false;
                this.btnCancel.Visible = false;
                this.gbContainer.Visible = false;
                this.gbButtons.Location = new Point(16, 369);
            }
            else if (this.btnSearchEdit.Text == "Search")
            {
                if (this.txtWord.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtWord, "Enter a word to search.");
                    this.lblError.Visible = true;
                    return;
                }
                else
                {
                    this.errorProvider1.SetError(this.txtWord, null);
                    this.lblError.Visible = false;
                }


                  if (!SearchXML())
                {
                    this.lblError.Text = "The word is not in your vocabulary list.";
                    lblError.Visible = true;
                    return;
                }

                this.gbContainer.Visible = true;
                this.txtWord.ReadOnly = true;
                this.gbButtons.Location = new Point(16, 369);
                this.btnCancel.Visible = true;
            }
        } 
        
        private bool CheckForEmptyEntry()
        {
            int numErrors = 0;

            if (this.txtWord.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtWord, "Enter a word to search!");
                numErrors++;
            }
            else
            {
                this.errorProvider1.SetError(this.txtWord, null);
            }

            if (this.txtMeaning.Text.Trim().Length <= 0)
            {
                numErrors++;
                this.errorProvider1.SetError(this.txtMeaning, "Enter meaning!");
            }
            else
            {
                this.errorProvider1.SetError(this.txtMeaning, null);
            }

            if (this.txtSentence.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtSentence, "Enter a sentence!");
                numErrors++;
            }
            else
            {
                this.errorProvider1.SetError(this.txtSentence, null);
            }
            if (this.txtSynonyms.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtSynonyms, "Enter synonyms!");
                numErrors++;
            }
            else
            {
                this.errorProvider1.SetError(this.txtSynonyms, null);
            }

            if (numErrors > 0)
                return true;
            else
                return false;
        }

        private void AssignRadioButtonArr()
        {
            this.rbWordTypeArr = new RadioButton[5];

            this.rbWordTypeArr[0] = this.rbAdjective;
            this.rbWordTypeArr[1] = this.rbAdverb;
            this.rbWordTypeArr[2] = this.rbNoun;
            this.rbWordTypeArr[3] = this.rbPhrase;
            this.rbWordTypeArr[4] = this.rbVerb;
        }

        private void SaveXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Environment.CurrentDirectory + Constants.XMLFILEPATH);
            XmlNode root = doc.DocumentElement;
            XmlNode node = root.SelectSingleNode("descendant::word[@Value='" +
                this.txtWord.Text.Trim() + "']");

            node.FirstChild.FirstChild.InnerXml = this.wordType.ToLower();
            node.FirstChild.FirstChild.NextSibling.InnerXml = this.txtMeaning.Text.Trim();
            node.FirstChild.FirstChild.NextSibling.NextSibling.InnerXml = this.txtSynonyms.Text.Trim();
            node.FirstChild.FirstChild.NextSibling.NextSibling.NextSibling.InnerXml = this.txtSentence.Text.Trim();
            doc.Save(Environment.CurrentDirectory + Constants.XMLFILEPATH);
        }
          
         
        private void gbContainer_VisibleChanged(object sender, EventArgs e)
        {
            if (((GroupBox)sender).Visible)
            {
                this.btnSearchEdit.Text = "Save";
                this.errorProvider1.Clear();
                this.lblError.Visible = false;
            }
            else
            {
                this.btnSearchEdit.Text = "Search";
            }
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //return back from edit mode after cancelling edit
            if (this.parentControl == "FlashCard")
            {
                FlashCard fCard = new FlashCard(this.wordOrPageIndex, this.Name);
                Form f = Form.ActiveForm;
                GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
                //gb.Controls.Clear();
                gb.Controls.Add(fCard);
                this.Dispose();
                return;
            }
            else if (this.parentControl == "WordList")
            {
                Form f = Form.ActiveForm;
                GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
                WordList wListI = new WordList(this.wordOrPageIndex);
                gb.Controls.Add(wListI);
                this.Dispose();
                return;
            }

            this.txtWord.Focus();
            this.txtWord.ReadOnly = false;
            this.lblError.Visible = false;
            this.gbContainer.Visible = false;
            this.btnCancel.Visible = false; 
            this.gbButtons.Location = new Point(16, 49);
        }

        
        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            if (this.lblError.Visible == true)
            {
                this.lblError.Text = "* Required";
                this.lblError.Visible = false;
            }
        }

        private void rbWordTypes_CheckedChange(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.wordType = ((RadioButton)sender).Text;
            }
        }*/
    }
}
