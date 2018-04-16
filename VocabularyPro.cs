using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VocabularyProNamespace;
using System.Xml;
using System.Xml.XPath;

namespace VocabularyProNamespace
{
    public partial class VocabularyPro : Form
    {
        private int numQuizQuestions = 0;
        
        public VocabularyPro()
        {
            InitializeComponent();
        }

        private void ViewWordList()
        {
            // get the current control and destroy it
            if (this.DisplayArea.Controls.Count > 0)
            {
                Control c = this.DisplayArea.Controls[0];
                c.Dispose();
            }

            WordList wl = new WordList();
            this.DisplayArea.Controls.Add(wl);
        }

        private void ViewFlashCard()
        {
            // get the current control and destroy it
            if (this.DisplayArea.Controls.Count > 0)
            {
                Control c = this.DisplayArea.Controls[0];
                c.Dispose();
            }
            
            FlashCard fc = new FlashCard();
            this.DisplayArea.Controls.Add(fc);
        }

        private void TakeQuiz()
        {
            // get the current control and destroy it
            if (this.DisplayArea.Controls.Count > 0)
            {
                Control c = this.DisplayArea.Controls[0];
                c.Dispose();
            }
            
            QuizControl qC = new QuizControl();
            qC.Owner = this;

            DialogResult res = qC.ShowDialog();

            if (res == DialogResult.Cancel)
            {
                qC.Dispose();
            }
            else if (res == DialogResult.OK)
            {
                Quiz q = new Quiz(this.numQuizQuestions);
                this.DisplayArea.Controls.Add(q);
            }
        }

        private void SearchAndEditWord()
        {
            // get the current control and destroy it
            if (this.DisplayArea.Controls.Count > 0)
            {
                Control c = this.DisplayArea.Controls[0];
                c.Dispose();
            }

            SearchWord se = new SearchWord();
            this.DisplayArea.Controls.Add(se);
        }

        private void AddWordsFromFile()
        {
            // get the current control and destroy it
            if (this.DisplayArea.Controls.Count > 0)
            {
                Control c = this.DisplayArea.Controls[0];
                c.Dispose();
            }
            
            AddNewWordList nwl = new AddNewWordList();
            this.DisplayArea.Controls.Add(nwl);
        }

        private void AddNewWord()
        {
            // get the current control and destroy it
            if (this.DisplayArea.Controls.Count > 0)
            {
                Control c = this.DisplayArea.Controls[0];
                c.Dispose();
            }

            AddNewWord word = new AddNewWord();
            this.DisplayArea.Controls.Add(word);
        }

        private void ViewProgressReport()
        {
            // get the current control and destroy it
            if (this.DisplayArea.Controls.Count > 0)
            {
                Control c = this.DisplayArea.Controls[0];
                c.Dispose();
            }

            ProgressReport pr = new ProgressReport();
            this.DisplayArea.Controls.Add(pr);
        }

        public void SetNumQuizQuestions(int num)
        {
            this.numQuizQuestions = num;
        }

        private void dictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseOnlineDictionary onlineDic = new BrowseOnlineDictionary();
            onlineDic.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void btnAddNewWord_Click(object sender, EventArgs e)
        {
            AddNewWord();
        }

        private void btnViewFlashCard_Click(object sender, EventArgs e)
        {
            this.ViewFlashCard();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewWordList_Click(object sender, EventArgs e)
        {
            this.ViewWordList();
        }

        private void btnAddWordList_Click(object sender, EventArgs e)
        {
            this.AddWordsFromFile();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            this.TakeQuiz();
        }

        private void VocabularyPro_Load(object sender, EventArgs e)
        {
            
        }

        private void VocabularyPro_Shown(object sender, EventArgs e)
        {
            if (WordUtil.IsWordListEmpty())
            {
                DisableUtilControls();
                MessageBox.Show("There are no words added in the program to " +
                    "use it any further!\r\n" +
                    "Please add more words to create your vocabulary list.\r\n",
                    "Not Enough Words", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (WordUtil.CheckForMinimumWordsCount())
            {
                DisableUtilControls();
                MessageBox.Show("NOT enough words to create selected " +
                        "number of quiz questions!\r\n" +
                        "Please add more words to create your vocabulary list.\r\n" +
                        "Only [" + WordUtil.TotalWordsCount() + "] word(s) added till now.",
                        "Not Enough Words", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DisableUtilControls()
        {
            try
            {
                //make sure that the user have added enough words into the program
                if (WordUtil.IsWordListEmpty() || (WordUtil.CheckForMinimumWordsCount()))
                {
                    this.btnViewFlashCard.BackColor = Color.WhiteSmoke;
                    this.btnViewWordList.BackColor = Color.WhiteSmoke;
                    this.btnQuiz.BackColor = Color.WhiteSmoke;
                    this.btnViewProgressReport.BackColor = Color.WhiteSmoke;
                    this.btnSearch.BackColor = Color.WhiteSmoke;
                    

                    this.btnViewFlashCard.Enabled = false;
                    this.btnViewWordList.Enabled = false;
                    this.btnQuiz.Enabled = false;
                    this.btnViewProgressReport.Enabled = false;
                    this.btnSearch.Enabled = false;

                    if (WordUtil.IsWordListEmpty())
                    {
                        this.btnDeleteAll.BackColor = Color.WhiteSmoke;
                        this.btnDeleteAll.Enabled = false;
                        this.deleteAllWordsToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        this.deleteAllWordsToolStripMenuItem.Enabled = true;
                        this.btnDeleteAll.Enabled = true;
                        this.btnDeleteAll.BackColor = Color.Lavender;
                    }

                    this.wordListToolStripMenuItem.Enabled = false;
                    this.flashCardToolStripMenuItem.Enabled = false;
                    this.quizToolStripMenuItem.Enabled = false;
                    this.searchToolStripMenuItem.Enabled = false;
                    this.progressReportToolStripMenuItem.Enabled = false;
                }
                else
                {
                    this.btnViewFlashCard.BackColor = Color.Lavender;
                    this.btnViewWordList.BackColor = Color.Lavender;
                    this.btnQuiz.BackColor = Color.Lavender;
                    this.btnViewProgressReport.BackColor = Color.Lavender;
                    this.btnSearch.BackColor = Color.Lavender;
                    this.btnDeleteAll.BackColor = Color.Lavender;
                    
                    this.btnViewFlashCard.Enabled = true;
                    this.btnViewWordList.Enabled = true;
                    this.btnQuiz.Enabled = true;
                    this.btnViewProgressReport.Enabled = true;
                    this.btnSearch.Enabled = true;
                    this.btnDeleteAll.Enabled = true;
                    
                    this.deleteAllWordsToolStripMenuItem.Enabled = true;
                    this.flashCardToolStripMenuItem.Enabled = true;
                    this.wordListToolStripMenuItem.Enabled = true;
                    this.quizToolStripMenuItem.Enabled = true;
                    this.searchToolStripMenuItem.Enabled = true;
                    this.progressReportToolStripMenuItem.Enabled = true;
                }
            }
            catch (XPathException)
            {
                return;
            }
        }

        private void wordListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewWordList();
        }

        private void flashCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFlashCard();
        }

        private void quizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeQuiz();
        }

        private void btnSearchEdit_Click(object sender, EventArgs e)
        {
            SearchAndEditWord();
        }

        private void searchAndEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAndEditWord();
        }

        private void addWordsFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWordsFromFile();
        }

        private void btnViewProgressReport_Click(object sender, EventArgs e)
        {
            ViewProgressReport();
        }

        private void progressReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProgressReport();
        }

        private void DisplayArea_Enter(object sender, EventArgs e)
        {

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            this.DeleteAllWords();
        }

        private void deleteAllWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DeleteAllWords();
        }

        private void DeleteAllWords()
        {
            DialogResult res = MessageBox.Show("This will delete your vocabulary list permanently.\r\n" +
                "Delete Now?", "DELETE ALL WORD?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.No)
                return;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Environment.CurrentDirectory + Constants.XMLFILEPATH);
                xmlDoc.DocumentElement.RemoveAll();
    
                // save changes to the xml file
                xmlDoc.Save(Environment.CurrentDirectory + Constants.XMLFILEPATH);

                if (this.DisplayArea.Controls.Count > 0)
                {
                    Control c = this.DisplayArea.Controls[0];
                    c.Dispose();
                }

                DisableUtilControls();

                MessageBox.Show("There are no words added in the program to " +
                    "use it any further!\r\n" +
                    "Please add more words to create your vocabulary list.\r\n",
                    "Not Enough Words", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch //(Exception e)
            {
                MessageBox.Show("Deletion Failed!\r\n", "DELETION FAILED", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

        }

        private void deleteAllWordsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.DeleteAllWords();
        }

        private void printWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PrintWords pw = new PrintWords();
            //pw.Show();
        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


    }
}
