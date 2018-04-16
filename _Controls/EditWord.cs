using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace VocabularyProNamespace
{
    public partial class EditWord : UserControl
    {
        RadioButton[] rbWordTypeArr = null;
        string wordType = "";
        string parentControl = "";
        WordUtil wordUtil = null;
        string newWordType = "";
        int currentWordIndex = -1;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wordType"></param>
        /// <param name="parent"></param>
        /// <param name="index">0-based word index</param>
        public EditWord(string wordType, string parent, int index)
        {
            InitializeComponent();
            AssignRadioButtonArr();
            this.wordUtil = new WordUtil();
            this.wordUtil.CurrentWordIndex = index;
            this.currentWordIndex = index;
            this.parentControl = parent;
            this.wordType = wordType;
        }

        private string[] MeaningWrap(string meaning)
        {
            const int SENTENCE_LENGTH = 65;
            int numLines = (meaning.Length / SENTENCE_LENGTH) + 1;
            int length = 0;
            int startSpaceIndex = 0;
            int spaceLastIndex = 0;
            int startIndex = 0;
            string[] meaningWrap = new string[numLines];

            for (int i = 0; i < numLines; i++)
            {
                startIndex = spaceLastIndex;
                length = ((i + 1) != numLines) ? (SENTENCE_LENGTH + ((i * SENTENCE_LENGTH) - spaceLastIndex)) : (meaning.Length % SENTENCE_LENGTH) + ((i * SENTENCE_LENGTH) - spaceLastIndex) - 1;
                startSpaceIndex = spaceLastIndex + length + 1;
                spaceLastIndex = meaning.LastIndexOf(" ", startSpaceIndex, SENTENCE_LENGTH);
                length = ((i + 1) != numLines) ? spaceLastIndex - startIndex : meaning.Length - startIndex;

                meaningWrap[i] = meaning.Substring(startIndex, length);
            }

            return meaningWrap;
        }

        private void LoadMeanings(string meaning)
        {
            // parse all the meanings
            string[] meaningArr = meaning.Trim().ToString().Split(new char[] { '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);
            
            this.editListBoxControl = new EditListBoxControl(meaningArr);
            this.elementHost1.Child = this.editListBoxControl;

            #region unused code ...
            /*foreach (string m in meaningArr)
            {


                //TreeNode node = new TreeNode();
                if (m.Trim().Length > 0) // ignore the last period
                {
                    if (m.Trim().Length > 65)
                    {
                        string[] wordwrap = MeaningWrap(m);
                        int i = 0;

                        for (i = 0; i < wordwrap.Length; i++)
                        {
                            if (i == 0)
                            {
                                node.Text = wordwrap[i];
                            }
                            else
                            {
                                node.Text += wordwrap[i];
                                //node.Nodes.Add("  " + wordwrap[i]);
                            }
                        }
                        this.tvUserControl.tvMeaning.Items.Add(node);
                        // add an empty separator node
                        this.tvUserControl.tvMeaning.Items.Add("");
                    }
                    else
                    {
                        node.Text = m;
                        this.tvUserControl.tvMeaning.Items.Add(node);
                        // add an empty separator node
                        this.tvUserControl.tvMeaning.Items.Add("");
                    }
                }
            }*/
            #endregion
        }

        // Updates all child tree nodes recursively. 
       /* private void SelectAllChildNodes(TreeNode treeNode, bool nodeSelected)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.IsSelected = nodeSelected;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the SelectAllChildsNodes method recursively. 
                    this.SelectAllChildNodes(node, nodeSelected);
                }
            }
        }*/

        private void CheckForExistingWordType(WordContents wc)
        {
            foreach (WordContents.WordAttribute wAttr in wc.WordAttr)
            {
                if (Enum.IsDefined(typeof(Constants.WordType), wAttr.WordType.ToUpper()))
                {
                    this.rbWordTypeArr[(int)Enum.Parse(typeof(Constants.WordType),
                        wAttr.WordType.ToUpper())].Enabled = false;
                }
            }
        }

        private void LoadWord()
        {
            WordContents wc = this.wordUtil.GetWordContents(this.txtWord.Text.Trim());

            CheckForExistingWordType(wc);
                    
            foreach (WordContents.WordAttribute wAttr in wc.WordAttr)
            {
                if (this.wordType == wAttr.WordType)
                {
                    StringBuilder str = new StringBuilder();

                    // get all the meanings 
                    foreach (string m in wAttr.Meanings)
                    {
                        str.AppendLine(m.Trim());
                    }

                    // assign all the values to wordcontrol
                    this.txtWord.Text = wc.Word;
                    LoadMeanings(str.ToString());
                    this.txtSynonyms.Text = wAttr.Synonyms;
                    this.txtSentence.Text = wAttr.Sentence;

                    if (Enum.IsDefined(typeof(Constants.WordType), wAttr.WordType.ToUpper()))
                    {
                        this.rbWordTypeArr[(int)Enum.Parse(typeof(Constants.WordType),
                            wAttr.WordType.ToUpper())].Checked = true;
                    }

                    break;
                }

                else if (this.wordType == null)
                {
                    this.txtWord.Text = wc.Word;
                    LoadMeanings("");
                    
                    break;
                }
            }

            //this.tvUserControl.tvMeaning.ExpandAll();
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

            if (this.editListBoxControl.GetMeanings().Length <= 0)
            {
                numErrors++;
                this.errorProvider1.SetError(this.elementHost1, "Enter meaning!");
            }
            else
            {
                this.errorProvider1.SetError(this.elementHost1, null);
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
            this.rbWordTypeArr = new RadioButton[4];

            this.rbWordTypeArr[0] = this.rbAdjective;
            this.rbWordTypeArr[1] = this.rbAdverb;
            this.rbWordTypeArr[2] = this.rbNoun;
            this.rbWordTypeArr[3] = this.rbVerb;
        }

        private void SaveXML()
        {
            if (this.newWordType == "")
                this.newWordType = this.wordType;


            if (this.wordType == null)
            {
                string[] meaningArr = this.editListBoxControl.GetMeanings(); 
                string meanings = meaningArr.Aggregate("", (s, i) => s + "\r\n" + i.ToString());
                this.wordUtil.AddNewWordType(this.txtWord.Text.Trim(), meanings,
                    this.txtSynonyms.Text.Trim(), this.txtSentence.Text.Trim(), this.newWordType);
                return;
            }

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Environment.CurrentDirectory + Constants.XMLFILEPATH);
                XmlNode root = doc.DocumentElement;
                XmlNode node = root.SelectSingleNode("/word_table/word[@Value='" +
                    this.txtWord.Text.Trim() + "']/word_type[@Value='" + this.wordType.Trim() + "']");


                node.Attributes["Value"].Value = this.newWordType;
                
                /*string[] meanings = meaningArr[0].Trim().Split(new char[] { '\r', '\n' }, 
                    StringSplitOptions.RemoveEmptyEntries);*/

                string[] meanings = this.editListBoxControl.GetMeanings();
                int i = 0;
                
                // if there needs to create new node for meaning, do so.
                if (meanings.Count() > node.FirstChild.ChildNodes.Count)
                {
                    // for already existed node, update the meaning
                    foreach (XmlNode n in node.FirstChild.ChildNodes)
                    {
                        n.InnerXml = meanings[i++];
                    }

                    for (i = node.FirstChild.ChildNodes.Count;
                        i < meanings.Count(); i++)
                    {
                        int j = i;

                        // disregard empty string/row
                        if (meanings[i].Trim() == "")
                        {
                            j = i - 1;
                        }

                        XmlElement newMeaning = doc.CreateElement("m" + (j + 1));
                        newMeaning.InnerText = meanings[i];
                        node.FirstChild.AppendChild(newMeaning);
                    }
                }
                // delete nodes according to update
                else if (meanings.Count() < node.FirstChild.ChildNodes.Count)
                {
                    i = 0;
                    // for already existed node, update the meaning
                    foreach (XmlNode n in node.FirstChild.ChildNodes)
                    {
                        n.InnerXml = meanings[i++];

                        if (i == meanings.Count())
                            break;
                    }

                    for (i = meanings.Count();
                        i < node.FirstChild.ChildNodes.Count; i++)
                    {
                        node.FirstChild.RemoveChild(
                            node.FirstChild.ChildNodes[i]);
                    }
                }

                node.FirstChild.NextSibling.InnerXml = this.txtSynonyms.Text.Trim();
                node.FirstChild.NextSibling.NextSibling.InnerXml = this.txtSentence.Text.Trim();

                doc.Save(Environment.CurrentDirectory + Constants.XMLFILEPATH);

                MessageBox.Show("Updates successfully saved.", "SAVE SUCCEEDED", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Couldn't save the updates.", "SAVE FAILED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void DoSave()
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
                FlashCard fCard = new FlashCard(this.wordUtil.CurrentWordIndex, this.Name, this.newWordType);
                Form f = Form.ActiveForm;
                GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
                gb.Controls.Add(fCard);
                this.Dispose();
                return;
            }
            else if (this.parentControl == "WordList")
            {
                int i = this.currentWordIndex + 1;
                this.currentWordIndex = (i % 10) == 0 ? (i / 10) : (i / 10) + 1;
                Form f = Form.ActiveForm;
                GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
                WordList wListI = new WordList(this.wordUtil.CurrentWordIndex);
                gb.Controls.Add(wListI);
                this.Dispose();
                return;
            }
        }

        private void rbWordTypes_CheckedChange(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.newWordType = ((RadioButton)sender).Text.ToLower();
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //return back from edit mode after cancelling edit
            if (this.parentControl == "FlashCard")
            {
                FlashCard fCard = new FlashCard(this.wordUtil.CurrentWordIndex, this.Name, this.newWordType);
                Form f = Form.ActiveForm;
                GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
                
                gb.Controls.Add(fCard);
                this.Dispose();
                return;
            }
            else if (this.parentControl == "WordList")
            {
                int i = this.currentWordIndex + 1;
                this.currentWordIndex = (i % 10) == 0 ? (i / 10) : (i / 10) + 1;

                Form f = Form.ActiveForm;
                GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
                WordList wListI = new WordList(this.currentWordIndex);
                gb.Controls.Add(wListI);
                this.Dispose();
                return;
            }

            this.txtWord.Focus();
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            if (this.lblError.Visible == true)
            {
                this.lblError.Text = "* Required";
                this.lblError.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DoSave();
        }

        private void EditWord_Load(object sender, EventArgs e)
        {
            LoadWord();
        }
       
        private void tvMeaning_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }

    }
}
