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
    public partial class ProgressReport : UserControl
    {
        int currentPage = 1;
        int TOTALWORDS = 0;
        int TOTALPAGES = 1;
        int startItemIndex = 0;
        int endItemIndex = 0;
        const int ITEMS_PER_PAGE = 15;
        DataRow[] words = null;

        public ProgressReport()
        {
            InitializeComponent();

            string filePath = Environment.CurrentDirectory + Constants.XMLFILEPATH;

            this.dsWords.ReadXml(filePath);
        }

        private void SetItemIndices()
        {
            this.endItemIndex = (currentPage == 1) ?
                ((currentPage == this.TOTALPAGES) ? TOTALWORDS - 1 : ITEMS_PER_PAGE - 1) :
                // if in the last page
                (((currentPage * ITEMS_PER_PAGE) >= TOTALWORDS) ?
                        ((currentPage - 1) * ITEMS_PER_PAGE) + (TOTALWORDS % ITEMS_PER_PAGE) - 1 :
                        (currentPage * ITEMS_PER_PAGE) - 1);

            this.startItemIndex = (currentPage == 1) ? 0 : (currentPage - 1) * ITEMS_PER_PAGE;
        }

        private void EvaluateTotalPages()
        {
            this.TOTALPAGES = ((TOTALWORDS % ITEMS_PER_PAGE) == 0) ? 
                TOTALWORDS / ITEMS_PER_PAGE : (TOTALWORDS / ITEMS_PER_PAGE) + 1;
        }

        private void UpdatePageLabels()
        {
            this.lblTotalPages.Text = "of " + this.TOTALPAGES.ToString();
            this.txtPagePosition.Text = this.currentPage.ToString();
            this.lblWordCount.Text = ((this.currentPage == this.TOTALPAGES) ? 
                this.TOTALWORDS : (this.currentPage * ITEMS_PER_PAGE)).ToString() + " of " +
                this.TOTALWORDS.ToString() + " words";
        }

        private void UpdatePageButtons()
        {
            if ((this.currentPage == this.TOTALPAGES) && (currentPage == 1))
            {
                this.btnPrevPage.Enabled = false;
                this.btnNextPage.Enabled = false;
                this.btnFirstPage.Enabled = false;
                this.btnLastPage.Enabled = false;
            }
            else if (this.currentPage == 1)
            {
                this.btnPrevPage.Enabled = false;
                this.btnFirstPage.Enabled = false;
                this.btnLastPage.Enabled = true;
                this.btnNextPage.Enabled = true;
            }
            else if (this.currentPage == this.TOTALPAGES)
            {
                this.btnNextPage.Enabled = false;
                this.btnLastPage.Enabled = false;
                this.btnPrevPage.Enabled = true;
                this.btnFirstPage.Enabled = true;
            }
            else
            {
                this.btnNextPage.Enabled = true;
                this.btnLastPage.Enabled = true;
                this.btnPrevPage.Enabled = true;
                this.btnFirstPage.Enabled = true;
            }
        }

        private void DoDataGrivViewSettings()
        {
            // set column and column headers
            this.dataGridView1.ColumnCount = 3;
            this.dataGridView1.Columns[0].HeaderText = "Word";
            this.dataGridView1.Columns[1].HeaderText = "Correct Answers";
            this.dataGridView1.Columns[2].HeaderText = "Total Attempts";

            // set column width
            this.dataGridView1.Columns[0].Width = 180;
            this.dataGridView1.Columns[1].Width = 107;
            this.dataGridView1.Columns[2].Width = 107;

            // set the alignment 
            this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            // hide row header
            this.dataGridView1.RowHeadersVisible = false;

            // dock the table in datagridview
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // select the full row and only one
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

            // set the background and font color of selected item
            this.dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Lavender;
            this.dataGridView1.RowsDefaultCellStyle.SelectionForeColor = SystemColors.HotTrack;
            
            // make cells non-resizable and read only
            this.dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            
            // make column header unsortable
            this.dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            // change the apperance of the column header
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.GhostWhite;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            this.dataGridView1.EnableHeadersVisualStyles = false;

        }

        private void SelectAllQuizzedWords()
        {
            this.words = this.dsWords.Tables["word"].Select("TOTALATTEMPT <> 0");
        }

        private void SelectBasedOnMissedAnswer()
        {
            this.words = this.dsWords.Tables["word"].Select("TOTALATTEMPT <> 0", "NumCorrect ASC");
        }

        private void BindDataGrid()
        {
            // clear data first
            this.dataGridView1.Rows.Clear();

            // display items in pages
            for (int i = this.startItemIndex; i <= this.endItemIndex; i++)
            {
                //this.dataGridView1.Rows.Add(this.dsWords.Tables["_word"].Rows[i].ItemArray);
                this.dataGridView1.Rows.Add(words[i].ItemArray);
            }
        }

        private void PopulateData()
        {
            //this.TOTALWORDS = this.dsWords.Tables["_word"].Rows.Count;
            //EvaluateTotalPages();

            if (this.words.Count() <= 0)
            {
                MessageBox.Show("There is no report to display. You must take\r\n" +
                    "the quiz before viewing report.", "NO REPORT TO DISPLAY",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            this.gbMainContainer.Visible = true;
            this.TOTALWORDS = this.words.Count();
            EvaluateTotalPages();
            SetItemIndices();

            //MessageBox.Show(this.startItemIndex + " : " +this.endItemIndex + " [#pages = " + this.TOTALPAGES + " ]");

            BindDataGrid();
        }

        private void ProgressReport_Load(object sender, EventArgs e)
        {
            DoDataGrivViewSettings();
            ///SetItemIndices();
            SelectAllQuizzedWords();
            PopulateData();
            UpdatePageLabels();
            UpdatePageButtons();
        }
        
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            this.currentPage = 1;
            SetItemIndices();
            UpdatePageLabels();
            UpdatePageButtons();
            PopulateData();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            this.currentPage -= 1;
            SetItemIndices();
            UpdatePageLabels();
            UpdatePageButtons();
            PopulateData();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            this.currentPage += 1;
            SetItemIndices();
            UpdatePageLabels();
            UpdatePageButtons();
            PopulateData();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            this.currentPage = this.TOTALPAGES;
            SetItemIndices();
            UpdatePageLabels();
            UpdatePageButtons();
            PopulateData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string id = this.dsWords.Tables[0].Rows[this.startItemIndex + e.RowIndex].ItemArray[4].ToString();

            string id = this.words[this.startItemIndex + e.RowIndex].ItemArray[4].ToString();
            
            WordDetails wd = new WordDetails(id);
            wd.ShowDialog();
        }

        private void allQuizzedMI_Click(object sender, EventArgs e)
        {
            if (this.allQuizzedMI.Checked)
                return;

            this.allQuizzedMI.Checked = true;
            this.mostIncorrectlyAnsweredMI.Checked = false;
            this.currentPage = 1;
            this.startItemIndex = 0;
            this.endItemIndex = 0;
            SelectAllQuizzedWords();
            PopulateData();
            UpdatePageLabels();
            UpdatePageButtons();
        }

        private void mostIncorrectlyAnsweredMI_Click(object sender, EventArgs e)
        {
            if (this.mostIncorrectlyAnsweredMI.Checked)
                return;

            this.mostIncorrectlyAnsweredMI.Checked = true;
            this.allQuizzedMI.Checked = false;
            this.currentPage = 1;
            this.startItemIndex = 0;
            this.endItemIndex = 0;
            SelectBasedOnMissedAnswer();
            PopulateData();
            UpdatePageLabels();
            UpdatePageButtons();
        }
    }
}
