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
    public partial class FlashCard : UserControl
    {
        LinkLabel[] linkLettersArr = null;
        WordUtil wordUtil = null;
        string parentControl = "";
        private string wordType = "";
        public string userChoice = "";
        int initWordIndex = -1;
        
        // to adjust tab width
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        
        void TabWord_HandleCreated(object sender, System.EventArgs e)
        {
            // Send TCM_SETMINTABWIDTH (last argument)
            SendMessage((sender as TabControl).Handle, 0x1300 + 49, IntPtr.Zero, (IntPtr)88);
        }

        private void TabWord_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = this.tabWord.TabPages[e.Index];
            Color bc;
            Color fc;
            Font f;

            if (e.Index == this.tabWord.SelectedIndex)
            {
                bc = Color.LightBlue;
                fc = Color.Navy;
                f = new Font(this.Font, FontStyle.Bold);
            }
            else
            {
                bc = page.BackColor;
                fc = page.ForeColor;
                f = new Font(this.Font, FontStyle.Italic);
            }

            e.Graphics.FillRectangle(new SolidBrush(bc), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);

            TextRenderer.DrawText(e.Graphics, page.Text, f, paddedBounds, fc);
        }

        public FlashCard()
        {
            InitializeComponent();

            this.tabWord.HandleCreated += new System.EventHandler(TabWord_HandleCreated);

            AssignLettersLinkToArray();

            this.wordUtil = new WordUtil();
            this.wordUtil.CurrentWordIndex = 0;
        }

        public FlashCard(int index, string parent, string wordType)
        {
            InitializeComponent();
            this.wordType = wordType;
            this.parentControl = parent;
            this.tabWord.HandleCreated += new System.EventHandler(TabWord_HandleCreated);

            AssignLettersLinkToArray();

            this.wordUtil = new WordUtil();
            this.wordUtil.CurrentWordIndex = index;
            this.initWordIndex = index;

            if ((parent == "SearchWord") || (parent == "WordList"))
            {
                // if this component is created from search word , hide the unnecessary
                // functionalities and look and feel
                this.lblPage.Visible = false;
                this.btnRandom.Visible = false;
                this.btnPrevious.Visible = false;

                this.btnNext.Text = "Back";
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

        public void LoadTheWord()
        {
            #region  codes
            /*
            if (this.TOTALWORDS > 0)
            {
                // currentwordIndex is 0-based, while word index is 1-based
                MoveIteratorToIndex(this.currentWordIndex + 1);

                // get the word
                string word = this.nodeIter.Current.GetAttribute("Value", "");
                this.nodeIter.Current.MoveToFirstChild();
                //this.nodeIter.Current.MoveToParent();

                int type = WordType.GetType(this.nodeIter.Current.Value.Trim());

                // get the type
                if (type != (int)Constants.WordType.NOTDEFINED)
                {
                    this.nodeIter.Current.MoveToChild("type", "");
                    this.WordControl.word = word;

                    this.nodeIter.Current.MoveToParent();
                }
                else
                {
                    this.WordControl.word = word;
                }

                // get the meaning
                this.nodeIter.Current.MoveToChild("meaning", "");
                this.WordControl.meaning = this.nodeIter.Current.Value;
                this.nodeIter.Current.MoveToParent();

                // get the synonym(s)
                this.nodeIter.Current.MoveToChild("synonyms", "");
                this.WordControl.synonyms = this.nodeIter.Current.Value;
                this.nodeIter.Current.MoveToParent();

                // get the sentence(s)
                this.nodeIter.Current.MoveToChild("sentence", "");
                this.WordControl.sentence = this.nodeIter.Current.Value;
                // this.nodeIter.Current.MoveToParent();

            }*/
            #endregion

            WordContents  wc = this.wordUtil.GetWordContents();
            int tabIndex = 0;

            // exclude the undefined type
            if (wc.WordAttr.Count() == (Enum.GetNames(typeof(Constants.WordType)).Count()) - 1)
            {
                this.btnAddNewWordType.Visible = false;
            }
            else
            {
                this.btnAddNewWordType.Visible = true;
            }

            TabPage[] tpArr = new TabPage[wc.WordAttr.Count()];

            this.tabWord.TabPages.Clear();
            TabPage selectedTab = null;
            
            foreach (WordContents.WordAttribute wAttr in wc.WordAttr)
            {
                // set the tab page header
                TabPage tp = new TabPage(wAttr.WordType);

                if (this.wordType == wAttr.WordType)
                {
                    selectedTab = tp;
                }

                StringBuilder str = new StringBuilder();
                WordUI w = new WordUI();

                // settings for a tab page
                w.Dock = DockStyle.Fill;
                w.BackColor = Color.White;
                tp.BackColor = Color.White;
                
                // get all the meanings 
                foreach (string m in wAttr.Meanings)
                {
                    str.AppendLine(m.Trim());
                }

                // assign all the values to wordcontrol
                w.word = wc.Word;
                w.meaning = str.ToString();
                w.synonyms = wAttr.Synonyms;
                w.sentence = wAttr.Sentence;

                tp.Controls.Add(w);
                tpArr[tabIndex++] = tp;
            }
            

            this.tabWord.TabPages.AddRange(tpArr);

            if (selectedTab == null)
            {
                this.tabWord.SelectTab(0);
                this.wordType = this.tabWord.TabPages[0].Text.ToLower().Trim();
            }
            else
            {
                this.tabWord.SelectTab(selectedTab);
                this.wordType = selectedTab.Text;
            }

            
            this.lblPage.Text = "[ " + (this.wordUtil.CurrentWordIndex + 1).ToString() + " of " +
                this.wordUtil.TotalWords + " words.]";

            if (this.wordUtil.CurrentWordIndex == 0)
                this.btnPrevious.Enabled = false;
            else
                this.btnPrevious.Enabled = true;

            if ((this.wordUtil.CurrentWordIndex + 1) == this.wordUtil.TotalWords)
                this.btnNext.Enabled = false;
            else
                this.btnNext.Enabled = true;
        }

        private void GoBackToParentControl()
        {
            if (this.parentControl == "SearchWord")
            {
                SearchWord sw = new SearchWord(this.wordUtil.CurrentWordIndex);
                Form f = Form.ActiveForm;
                GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
                gb.Controls.Add(sw);
                this.Dispose();
            }
            else if (this.parentControl == "WordList")
            {
                int i = this.initWordIndex + 1;
                this.initWordIndex = (i % 10) == 0 ? (i / 10) : (i / 10) + 1;

                Form f = Form.ActiveForm;
                GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
                WordList wListI = new WordList(this.initWordIndex);
                gb.Controls.Add(wListI);
                this.Dispose();
                return;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // reset word type
            this.wordType = "";
            this.wordUtil.CurrentWordIndex -= 1;

            if (this.wordUtil.CurrentWordIndex <= 0)
            {
                this.btnPrevious.Enabled = false;
            }

            if (this.wordUtil.CurrentWordIndex < this.wordUtil.TotalWords - 1)
                this.btnNext.Enabled = true;

            this.LoadTheWord();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // if this control is called from other control
            // go back to the control upon button click

            if (this.btnNext.Text == "Back")
            {
                GoBackToParentControl();
                
                return;
            }

            // reset word type
            this.wordType = "";
            
            this.wordUtil.CurrentWordIndex += 1;

            if (this.wordUtil.CurrentWordIndex >= (this.wordUtil.TotalWords - 1))
            {
                this.btnNext.Enabled = false;
            }

            if (this.wordUtil.CurrentWordIndex > 0)
                this.btnPrevious.Enabled = true;

            this.LoadTheWord();
        }

        private void FlashCard_Load(object sender, EventArgs e)
        {
            LoadTheWord();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            // reset word type
            this.wordType = "";

            System.Random rNum = new System.Random();
            int rNumber = rNum.Next(0, this.wordUtil.TotalWords);

            if (this.wordUtil.TotalWords > 0)
            {
                this.wordUtil.CurrentWordIndex = rNumber;
                this.LoadTheWord();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // word with only one word type
            if (this.wordUtil.GetWordContents().WordAttr.Count() <= 1)
            {
                DialogResult res = MessageBox.Show("This word will be permanantly removed from the list.\r\n" +
                    "Delete Now?", "DELETE WORD?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.No)
                    return;

                string word = this.wordUtil.GetWordByIndex(this.wordUtil.CurrentWordIndex);

                if (!this.wordUtil.DeleteWord(word))
                {
                    MessageBox.Show("Deletion Failed");
                }
                else
                {
                    if (this.parentControl != String.Empty)
                    {
                        GoBackToParentControl();
                    }
                    else
                    {
                        LoadTheWord();
                    }
                }

                return;
            }

            else  // for words with more than one type
            {
                DeleteUserInput dI = new DeleteUserInput(this.wordUtil.GetWordByIndex(
                    this.wordUtil.CurrentWordIndex), this.tabWord.SelectedTab.Text);

                this.userChoice = "";
                dI.Owner = Form.ActiveForm;

                DialogResult res = dI.ShowDialog();

                if (res == DialogResult.Cancel)
                    return;

                if (this.userChoice == "word")
                {
                    string word = this.wordUtil.GetWordByIndex(this.wordUtil.CurrentWordIndex);

                    if (!this.wordUtil.DeleteWord(word))
                    {
                        MessageBox.Show("Deletion Failed");
                    }
                    else
                    {
                        if (this.parentControl != String.Empty)
                        {
                            GoBackToParentControl();
                        }
                        else
                        {
                            LoadTheWord();
                        }
                    }
                }
                else if (this.userChoice == "wordtype")
                {
                    string word = this.wordUtil.GetWordByIndex(this.wordUtil.CurrentWordIndex);

                    if (!this.wordUtil.DeleteWordTypeNode(word, this.tabWord.SelectedTab.Text))
                    {
                        MessageBox.Show("Deletion Failed");
                    }
                    else
                    {
                        if (this.parentControl != String.Empty)
                        {
                            GoBackToParentControl();
                        }
                        else
                        {
                            LoadTheWord();
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.wordType = this.tabWord.SelectedTab.Text;
            EditWord edit = new EditWord(this.wordType, this.Name, 
                this.wordUtil.CurrentWordIndex);
            Form f = Form.ActiveForm;
            GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
            gb.Controls.Add(edit);
            this.Dispose();
        }

        private void linkLetters_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // reset word type
            this.wordType = "";

            //letter to search
            char letter = char.ToLower(((LinkLabel)sender).Text.Trim()[0]);

            // index => from 1 to n
            string index = this.wordUtil.GetFirstIndexOfWordStartingWithChar(letter);

            if (index != null)
            {
                this.wordUtil.CurrentWordIndex = Int32.Parse(index) - 1;
                LoadTheWord();
            }
            else
            {
                MessageBox.Show("There are no word that starts with '" + char.ToUpper(letter) + "' in your word list",
                    "WORD NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gbMainContainer_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddNewWordType_Click(object sender, EventArgs e)
        {
            EditWord edit = new EditWord(null, this.Name, this.wordUtil.CurrentWordIndex);
            Form f = Form.ActiveForm;
            GroupBox gb = ((GroupBox)(f.Controls.Find("DisplayArea", true)[0]));
            gb.Controls.Add(edit);
            this.Dispose();
        }


    }
}
