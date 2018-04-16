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

namespace VocabularyProNamespace
{
    public partial class WordList : UserControl
    {
        /// <summary>
        /// Variable Declaration
        /// </summary>
        #region
        int currentPageIndex = 1; // always >= 1
        Button[] btnEditArr = null;
        CheckBox[] chkBoxArray = null;
        LinkLabel[] linkLettersArr = null;
        LinkLabel[] linkWordsArr = null;
        Button[] moreBtnArr = null;
        bool fromAllCheckOrUncheck = false;
        bool isFromLetterLink = false;
        int baloonIndex = -1;
        WordUtil wordUtil = null;

        #endregion

        public WordList()
        {
            this.wordUtil = new WordUtil();
            
            InitializeComponent();
            AssignButtonsToArr();
            AssignChkBoxToArray();
            AssignLettersLinkToArray();
            AssignWordsLinkToArray();

            this.gbMainContainer.Visible = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">1-based page index</param>
        public WordList(int index)
        {
            this.currentPageIndex = index;
            this.wordUtil = new WordUtil();
            this.wordUtil.CurrentWordIndex = (index - 1) * 10;

            InitializeComponent();
            AssignButtonsToArr();
            AssignChkBoxToArray();
            AssignLettersLinkToArray();
            AssignWordsLinkToArray();

            this.gbMainContainer.Visible = true;
        }

        private void AssignButtonsToArr()
        {
            this.btnEditArr = new Button[10];

            for (int i = 0; i < 10; i++)
            {
                btnEditArr[i] = (Button)this.tlpWordsMeaning.Controls.Find("btnEdit" + (i + 1), false)[0];
                this.toolTip1.SetToolTip(btnEditArr[i], "Click to view details or edit word.");
            }
        }

        private void AssignMoreButtonsToArr()
        {
            this.moreBtnArr = new Button[10];

            for (int i = 0; i < 10; i++)
            {
                moreBtnArr[i] = (Button)this.tlpWordsMeaning.Controls.Find("btnMore" + (i + 1), true)[0];
                this.toolTip1.SetToolTip(moreBtnArr[i], "Click to view more meanings.");
            }
        }

        private void AssignChkBoxToArray()
        {
            this.chkBoxArray = new CheckBox[10];

            for (int i = 0; i < 10; i++)
            {
                chkBoxArray[i] = (CheckBox)this.tlpWordsMeaning.Controls.Find("checkBox" + (i + 1), false)[0];
            }
        }

        private void AssignLettersLinkToArray()
        {
            this.linkLettersArr = new LinkLabel[26];

            //ASCII value for 'A' = 65
            for (int i = 0; i < 26; i++)
            {
                linkLettersArr[i] = (LinkLabel)this.flpLetters.Controls.Find("link" + ((char)(65 + i)), false)[0];
                this.toolTip1.SetToolTip(linkLettersArr[i], "Go to word " + ((char)(65 + i)));
            }
        }

        private void AssignWordsLinkToArray()
        {
            this.linkWordsArr = new LinkLabel[10];

            for (int i = 0; i < 10; i++)
            {
                linkWordsArr[i] = (LinkLabel)this.tlpWordsMeaning.Controls.Find("word" + (i + 1), false)[0];
            }
        }

        private void PopulatePagesCB()
        {
            // clear all pages first
            this.cbPages.Items.Clear();

            for (int i = 0;
                i < (((this.wordUtil.TotalWords % 10) == 0) ?
                (this.wordUtil.TotalWords / 10) : ((this.wordUtil.TotalWords / 10) + 1));
                i++)
            {
                this.cbPages.Items.Add((i + 1).ToString());
            }
            this.cbPages.SelectedIndex = this.currentPageIndex - 1;

            this.cbPages.SelectedIndexChanged -= new EventHandler(this.cbPages_SelectedIndexChanged);
            this.cbPages.SelectedIndexChanged += new System.EventHandler(this.cbPages_SelectedIndexChanged);
        }

        private void UpdatePageLinks()
        {
            int startPage = 0;

            if ((this.currentPageIndex % 10) == 0)
                startPage = this.currentPageIndex - 9;
            else
                startPage = ((this.currentPageIndex / 10) * 10) + 1;

            page1.Text = (startPage).ToString();
            page2.Text = (startPage + 1).ToString();
            page3.Text = (startPage + 2).ToString();
            page4.Text = (startPage + 3).ToString();
            page5.Text = (startPage + 4).ToString();
            page6.Text = (startPage + 5).ToString();
            page7.Text = (startPage + 6).ToString();
            page8.Text = (startPage + 7).ToString();
            page9.Text = (startPage + 8).ToString();
            page10.Text = (startPage + 9).ToString();

            //update combo box pages
            this.cbPages.SelectedIndex = this.currentPageIndex - 1;

            //make sure the link to empty pages are disabled
            foreach (Control c in this.gbPageLinks.Controls)
            {
                if (Char.IsDigit(c.Text[0]))
                {
                    if (((Int32.Parse(c.Text) * 10) - 10) > this.wordUtil.TotalWords)
                    {
                        c.Enabled = false;
                    }
                    else
                        c.Enabled = true;

                    if (c.Text == this.currentPageIndex.ToString())
                    {
                        c.BackColor = Color.SkyBlue;
                        c.Enabled = false;
                    }
                    else
                    {
                        c.BackColor = Color.Transparent;
                    }
                }
            }

            //disable previous page link if this is the first page
            if (this.currentPageIndex > 1)
            {
                this.btnPrevious.Enabled = true;
            }
            else
            {
                this.btnPrevious.Enabled = false;
            }

            // disable next button if there are no more pages to display
            if ((this.wordUtil.TotalWords) > (this.currentPageIndex * 10))
            {
                this.btnNext.Enabled = true;
            }
            else
            {
                this.btnNext.Enabled = false;
            }

            //disable next ellipse if there is no more page-set
            if ((Int32.Parse(this.page10.Text) * 10) < this.wordUtil.TotalWords)
            {
                this.ellipseNext.Enabled = true;
            }
            else
            {
                this.ellipseNext.Enabled = false;
            }

            //disable previous page link if this is the first page
            if (this.currentPageIndex > 10)
            {
                this.ellipsePrev.Enabled = true;
            }
            else
            {
                this.ellipsePrev.Enabled = false;
            }

            //deselect all checkboxes
            this.btnSelectAll.Text = "Deselect All";
            SelectOrDeselectAllCheckboxes();
        }

        private bool AreAllCheckboxesChecked()
        {
            bool isChecked = false;

            foreach (CheckBox cb in this.chkBoxArray)
            {
                if (!cb.Checked)
                {
                    isChecked = false;
                    break;
                }
                else
                {
                    isChecked = true;
                }
            }
            return isChecked;
        }

        private bool AreAllCheckboxesUnchecked()
        {
            bool isUnchecked = true;

            foreach (CheckBox cb in this.chkBoxArray)
            {
                if (cb.Checked)
                {
                    isUnchecked = false;
                    break;
                }
                else
                {
                    isUnchecked = true;
                }
            }
            return isUnchecked;
        }

        private void SelectOrDeselectAllCheckboxes()
        {
            this.fromAllCheckOrUncheck = true;

            foreach (CheckBox cb in this.chkBoxArray)
            {
                if (!cb.Checked && (this.btnSelectAll.Text == "Select All"))
                {
                    cb.Checked = true;
                }
                else if (cb.Checked && (this.btnSelectAll.Text == "Deselect All"))
                {
                    cb.Checked = false;
                }
            }

            this.fromAllCheckOrUncheck = false;

            if (AreAllCheckboxesChecked())
                this.btnSelectAll.Text = "Deselect All";
            else
                this.btnSelectAll.Text = "Select All";
        }

        private void FillWords()
        {
            // hide table until controls in it are loaded properly
            this.tlpWordsMeaning.Visible = false;

            // make all the empty words invisible
            if ((this.currentPageIndex * 10) >= this.wordUtil.TotalWords)
            {
                if ((this.wordUtil.TotalWords % 10) != 0)
                {
                    foreach (Control c in this.tlpWordsMeaning.Controls)
                    {
                        if ((tlpWordsMeaning.GetCellPosition(c).Row + 1) > (this.wordUtil.TotalWords % 10))
                        {
                            c.Visible = false;
                        }
                    }
                }
            }
            else
            {
                // make all the word/meanings controls visible
                foreach (Control c in this.tlpWordsMeaning.Controls)
                {
                    if (!c.Visible)
                        c.Visible = true;
                }
            }


            int count = 1;
            int index = 1;

            // make sure the selecting of nodes are not done twice during load
            //if (!firstLoaded)
            //   SelectAllWords();

            while (true)
            {
                // move the iterator to the first word of the current page 
                if ((((this.currentPageIndex - 1) * 10) + 1) > index)
                {
                    index += 1;
                    continue;
                }

                this.wordUtil.CurrentWordIndex = (index + count) - 2;

                WordContents wc = this.wordUtil.GetWordContents();

                // add word Id as a tag for the link
                ((LinkLabel)this.tlpWordsMeaning.Controls.Find("word" + count.ToString(),
                    false)[0]).Tag = wc.ID;
                
                // populate words 
                ((LinkLabel)this.tlpWordsMeaning.Controls.Find("word" + count.ToString(),
                    false)[0]).Text = wc.Word;

                if (this.isFromLetterLink)
                {
                    this.toolTip1.IsBalloon = true;
                    this.toolTip1.Show("Starts from here.", this.gbWordsContainer,
                        linkWordsArr[this.baloonIndex - 1].Location.X + 45,
                        linkWordsArr[this.baloonIndex - 1].Location.Y + 30, 1500);
                }

                System.Random randomNum = new System.Random();

                int rNum = randomNum.Next(0, wc.WordAttr.Count());

                StringBuilder str = new StringBuilder();

                // pick the word type randomly
                WordContents.WordAttribute wAttr = wc.WordAttr[rNum];

                // get all the meanings 
                foreach (string m in wAttr.Meanings)
                {
                    str.AppendLine(m.Trim());
                }

                string[] meanings = str.ToString().Trim().Split(new char[] { '\r', '\n' },
                        StringSplitOptions.RemoveEmptyEntries);

                // randomize the meaning pick
                rNum = randomNum.Next(0, meanings.Count());


                // populate meaning
                ((Label)this.tlpWordsMeaning.Controls.Find("meaning" + count.ToString(),
                    true)[0]).Text = meanings[rNum];


                if (count == 10)
                {
                    count = 1;
                    break;
                }
                else
                    count += 1;

            }

            // show the table after controls in it are loaded properly
            this.tlpWordsMeaning.Visible = true;

            if ((this.currentPageIndex * 10) + (this.wordUtil.TotalWords % 10) <= this.wordUtil.TotalWords)
            {
                this.lblWords.Text = "[ " + (this.currentPageIndex * 10).ToString() + " of " +
                    this.wordUtil.TotalWords + " words.]";
            }
            else
            {
                this.lblWords.Text = "[ " + this.wordUtil.TotalWords + " of " + this.wordUtil.TotalWords + " words.]";
            }

            this.lblPages.Text = "[ " + this.currentPageIndex + " of " +
                this.cbPages.Items.Count + " pages.]";
        }

        private void LoadWordList()
        {
            PopulatePagesCB();
            UpdatePageLinks();
            FillWords();
            this.lblPages.Text = "[ " + this.currentPageIndex + " of " +
                this.cbPages.Items.Count + " pages.]";
        }

        private void WordList_Load(object sender, EventArgs e)
        {
            LoadWordList();
            this.tlpWordsMeaning.Visible = true;
        }

        private void btnPrevious_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.currentPageIndex -= 1;
            UpdatePageLinks();
            this.FillWords();
        }

        private void btnNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPageIndex += 1;
            UpdatePageLinks();
            this.FillWords();
        }

        private void page_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //just make sure the empty page is not displayed
            if (((Int32.Parse(((LinkLabel)sender).Text) * 10) - 10) > this.wordUtil.TotalWords)
                return;

            this.currentPageIndex = Int32.Parse(((LinkLabel)sender).Text);

            UpdatePageLinks();
            FillWords();
        }

        private void word_LinkClicked(object sender, EventArgs e)
        {
            /*
            LinkLabel lnkWord = (LinkLabel)sender;
            WordDetails wd = new WordDetails(lnkWord.Tag.ToString());
            wd.ShowDialog();*/
        }

        private void ellipseNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((this.currentPageIndex % 10) == 0)
                this.currentPageIndex += 1;
            else
                this.currentPageIndex = this.currentPageIndex + (10 - this.currentPageIndex % 10) + 1;

            UpdatePageLinks();
            this.FillWords();
        }

        /*private void WordList_VisibleChanged(object sender, EventArgs e)
        {
            //release the memory
            if (!this.Visible)
                 this.Dispose();
        }*/

        private void cbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //igonore if program changes the index
            if ((this.currentPageIndex - 1) == this.cbPages.SelectedIndex)
                return;

            //proceed only if the user changes the index
            this.currentPageIndex = this.cbPages.SelectedIndex + 1;
            UpdatePageLinks();
            FillWords();

            if (this.currentPageIndex > 1)
                this.btnPrevious.Enabled = true;
            else
                this.btnPrevious.Enabled = false;
        }

        private void ellipsePrev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((this.currentPageIndex % 10) == 0)
                this.currentPageIndex -= 10;
            else
                //
                this.currentPageIndex = (this.currentPageIndex / 10) * 10;

            UpdatePageLinks();
            this.FillWords();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //string word = "word" + ((Button)sender).Name.Substring(7);
            //word = ((LinkLabel)(this.tlpWordsMeaning.Controls.Find(word, false)[0])).Text;
            int index = Int32.Parse(((Button)sender).Name.Substring(7)) -1;

            Form f = Form.ActiveForm;
            GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
            FlashCard fc = new FlashCard(((this.currentPageIndex -1) *10) + index, this.Name, null);
            gb.Controls.Add(fc);
            this.Dispose();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SelectOrDeselectAllCheckboxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.AreAllCheckboxesUnchecked())
            {
                MessageBox.Show("Select at least one word to delete!", "WORD NOT SELECTED",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult res = MessageBox.Show("The word(s) will be permanantly removed from the list.\r\n" +
                "Delete Now?", "DELETE WORD?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.No)
                    return;

                foreach (CheckBox c in this.chkBoxArray)
                {
                    if (c.Checked)
                    {
                        int deleteIndex = this.tlpWordsMeaning.GetPositionFromControl(c).Row + 1;
                        LinkLabel wordToDelete = (LinkLabel)this.tlpWordsMeaning.Controls.Find(
                            "word" + deleteIndex, false)[0];

                        try
                        {
                            this.wordUtil.DeleteWord(wordToDelete.Text.Trim());
                        }
                        catch
                        {
                            MessageBox.Show("Deletion Failed", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }

                //deselect all checkboxes
                this.btnSelectAll.Text = "Deselect All";
                SelectOrDeselectAllCheckboxes();
                LoadWordList();
            }
        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {
            //ignore and return for select/deselect all
            if (this.fromAllCheckOrUncheck)
                return;

            //check to see if all checkboxes are checked
            if (((CheckBox)sender).Checked)
            {
                if (AreAllCheckboxesChecked())
                {
                    this.btnSelectAll.Text = "Deselect All";
                }
            }
            //check to see if all checkboxes are unchecked
            else
            {
                if (AreAllCheckboxesUnchecked())
                {
                    this.btnSelectAll.Text = "Select All";
                }
            }
        }

        private void linkLetters_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //letter to search
            char letter = char.ToLower(((LinkLabel)sender).Text.Trim()[0]);

            // index => from 1 to n
            string index = this.wordUtil.GetFirstIndexOfWordStartingWithChar(letter);

            if (index != null)
            {
                int i = Int32.Parse(index);
                this.currentPageIndex = (i % 10) == 0 ? (i / 10) : (i / 10) + 1;
                this.baloonIndex = (i % 10) == 0 ? 10 : (i % 10);
                this.isFromLetterLink = true;
                this.UpdatePageLinks();
                this.FillWords();
                this.isFromLetterLink = false;
                this.baloonIndex = -1;
            }
            else
            {
                MessageBox.Show("There are no word that starts with '" + char.ToUpper(letter) + "' in your word list",
                    "WORD NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            if (!this.isFromLetterLink)
            {
                this.isFromLetterLink = false;
                this.toolTip1.IsBalloon = false;
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            string word = "word" + ((Button)sender).Name.Substring(7);
            word = ((LinkLabel)(this.tlpWordsMeaning.Controls.Find(word, false)[0])).Text;

            CreateMeaningPopup(word);
            
        }

        private void CreateMeaningPopup(string word)
        {
            TreeView tv = new TreeView();
            tv.Dock = DockStyle.Fill;
            tv.Indent = 5;
            tv.FullRowSelect = true;
            tv.BorderStyle = BorderStyle.None;
            tv.ShowLines = false;
            tv.ShowPlusMinus = false;
            tv.ShowRootLines = false;

            MeaningPopup p = new MeaningPopup(System.Windows.Forms.Cursor.Position, word, tv);

            p.Show();
        }

    }
}
