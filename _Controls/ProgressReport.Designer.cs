
namespace VocabularyProNamespace
{
    partial class ProgressReport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressReport));
            this.dsWords = new System.Data.DataSet();
            this.word_table = new System.Data.DataTable();
            this.word = new System.Data.DataColumn();
            this.NumCorrect = new System.Data.DataColumn();
            this.TotalAttempt = new System.Data.DataColumn();
            this.ID = new System.Data.DataColumn();
            this.NumCorrectByTotalAttempt = new System.Data.DataColumn();
            this.gbMainContainer = new System.Windows.Forms.GroupBox();
            this.gbDataContainer = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewLinkColumn();
            this.toolStripPages = new System.Windows.Forms.ToolStrip();
            this.btnFirstPage = new System.Windows.Forms.ToolStripButton();
            this.btnPrevPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtPagePosition = new System.Windows.Forms.ToolStripTextBox();
            this.lblTotalPages = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnLastPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblWordCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.allQuizzedMI = new System.Windows.Forms.ToolStripMenuItem();
            this.mostIncorrectlyAnsweredMI = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dsWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.word_table)).BeginInit();
            this.gbMainContainer.SuspendLayout();
            this.gbDataContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStripPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsWords
            // 
            this.dsWords.DataSetName = "dsWords";
            this.dsWords.Tables.AddRange(new System.Data.DataTable[] {
            this.word_table});
            // 
            // word_table
            // 
            this.word_table.Columns.AddRange(new System.Data.DataColumn[] {
            this.word,
            this.NumCorrect,
            this.TotalAttempt,
            this.ID,
            this.NumCorrectByTotalAttempt});
            this.word_table.MinimumCapacity = 10;
            this.word_table.TableName = "word";
            // 
            // word
            // 
            this.word.Caption = "Word";
            this.word.ColumnMapping = System.Data.MappingType.Attribute;
            this.word.ColumnName = "Value";
            this.word.ReadOnly = true;
            // 
            // NumCorrect
            // 
            this.NumCorrect.Caption = "Correctly Answered";
            this.NumCorrect.ColumnName = "NumCorrect";
            this.NumCorrect.DataType = typeof(int);
            this.NumCorrect.ReadOnly = true;
            // 
            // TotalAttempt
            // 
            this.TotalAttempt.Caption = "Total Attempt";
            this.TotalAttempt.ColumnName = "TotalAttempt";
            this.TotalAttempt.DataType = typeof(int);
            this.TotalAttempt.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.ColumnMapping = System.Data.MappingType.Attribute;
            this.ID.ColumnName = "ID";
            this.ID.ReadOnly = true;
            // 
            // NumCorrectByTotalAttempt
            // 
            this.NumCorrectByTotalAttempt.ColumnMapping = System.Data.MappingType.Hidden;
            this.NumCorrectByTotalAttempt.ColumnName = "NumCorrect/TotalAttempt";
            this.NumCorrectByTotalAttempt.DataType = typeof(double);
            this.NumCorrectByTotalAttempt.ReadOnly = true;
            // 
            // gbMainContainer
            // 
            this.gbMainContainer.Controls.Add(this.gbDataContainer);
            this.gbMainContainer.Controls.Add(this.toolStripPages);
            this.gbMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMainContainer.Location = new System.Drawing.Point(5, 5);
            this.gbMainContainer.Name = "gbMainContainer";
            this.gbMainContainer.Padding = new System.Windows.Forms.Padding(7, 7, 10, 7);
            this.gbMainContainer.Size = new System.Drawing.Size(591, 445);
            this.gbMainContainer.TabIndex = 0;
            this.gbMainContainer.TabStop = false;
            this.gbMainContainer.Visible = false;
            // 
            // gbDataContainer
            // 
            this.gbDataContainer.Controls.Add(this.dataGridView1);
            this.gbDataContainer.Location = new System.Drawing.Point(5, 48);
            this.gbDataContainer.Name = "gbDataContainer";
            this.gbDataContainer.Padding = new System.Windows.Forms.Padding(7);
            this.gbDataContainer.Size = new System.Drawing.Size(581, 387);
            this.gbDataContainer.TabIndex = 5;
            this.gbDataContainer.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(567, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Value
            // 
            this.Value.ActiveLinkColor = System.Drawing.Color.Blue;
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Word";
            this.Value.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Value.LinkColor = System.Drawing.Color.Blue;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.ToolTipText = "Go to {0}";
            this.Value.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // toolStripPages
            // 
            this.toolStripPages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirstPage,
            this.btnPrevPage,
            this.toolStripSeparator1,
            this.txtPagePosition,
            this.lblTotalPages,
            this.toolStripSeparator2,
            this.btnNextPage,
            this.btnLastPage,
            this.toolStripSeparator3,
            this.lblWordCount,
            this.toolStripSeparator4,
            this.toolStripDropDownButton1});
            this.toolStripPages.Location = new System.Drawing.Point(7, 20);
            this.toolStripPages.Name = "toolStripPages";
            this.toolStripPages.Size = new System.Drawing.Size(574, 25);
            this.toolStripPages.TabIndex = 4;
            this.toolStripPages.Text = "toolStrip1";
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("btnFirstPage.Image")));
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.RightToLeftAutoMirrorImage = true;
            this.btnFirstPage.Size = new System.Drawing.Size(23, 22);
            this.btnFirstPage.Text = "First Page";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevPage.Image")));
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.RightToLeftAutoMirrorImage = true;
            this.btnPrevPage.Size = new System.Drawing.Size(23, 22);
            this.btnPrevPage.Text = "Previous Page";
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtPagePosition
            // 
            this.txtPagePosition.BackColor = System.Drawing.Color.White;
            this.txtPagePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagePosition.Name = "txtPagePosition";
            this.txtPagePosition.ReadOnly = true;
            this.txtPagePosition.Size = new System.Drawing.Size(40, 25);
            this.txtPagePosition.Text = "1";
            // 
            // lblTotalPages
            // 
            this.lblTotalPages.Name = "lblTotalPages";
            this.lblTotalPages.Size = new System.Drawing.Size(35, 22);
            this.lblTotalPages.Text = "of {0}";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNextPage
            // 
            this.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.RightToLeftAutoMirrorImage = true;
            this.btnNextPage.Size = new System.Drawing.Size(23, 22);
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLastPage.Image = ((System.Drawing.Image)(resources.GetObject("btnLastPage.Image")));
            this.btnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.RightToLeftAutoMirrorImage = true;
            this.btnLastPage.Size = new System.Drawing.Size(23, 22);
            this.btnLastPage.Text = "Last Page";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lblWordCount
            // 
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(87, 22);
            this.lblWordCount.Text = "{0} of {1} words";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allQuizzedMI,
            this.mostIncorrectlyAnsweredMI});
            this.toolStripDropDownButton1.Image = global::VocabularyProNamespace.Properties.Resources.Search;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ToolTipText = "Choose to view: ";
            // 
            // allQuizzedMI
            // 
            this.allQuizzedMI.Checked = true;
            this.allQuizzedMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allQuizzedMI.Name = "allQuizzedMI";
            this.allQuizzedMI.Size = new System.Drawing.Size(215, 22);
            this.allQuizzedMI.Text = "All Quizzed";
            this.allQuizzedMI.Click += new System.EventHandler(this.allQuizzedMI_Click);
            // 
            // mostIncorrectlyAnsweredMI
            // 
            this.mostIncorrectlyAnsweredMI.Name = "mostIncorrectlyAnsweredMI";
            this.mostIncorrectlyAnsweredMI.Size = new System.Drawing.Size(215, 22);
            this.mostIncorrectlyAnsweredMI.Text = "Most Incorrectly Answered";
            this.mostIncorrectlyAnsweredMI.Click += new System.EventHandler(this.mostIncorrectlyAnsweredMI_Click);
            // 
            // ProgressReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbMainContainer);
            this.Location = new System.Drawing.Point(7, 7);
            this.Name = "ProgressReport";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(601, 455);
            this.Load += new System.EventHandler(this.ProgressReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.word_table)).EndInit();
            this.gbMainContainer.ResumeLayout(false);
            this.gbMainContainer.PerformLayout();
            this.gbDataContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStripPages.ResumeLayout(false);
            this.toolStripPages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dsWords;
        private System.Data.DataTable word_table;
        private System.Windows.Forms.GroupBox gbMainContainer;
        private System.Windows.Forms.ToolStrip toolStripPages;
        private System.Windows.Forms.ToolStripButton btnFirstPage;
        private System.Windows.Forms.ToolStripButton btnPrevPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtPagePosition;
        private System.Windows.Forms.ToolStripLabel lblTotalPages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNextPage;
        private System.Windows.Forms.ToolStripButton btnLastPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblWordCount;
        private System.Windows.Forms.GroupBox gbDataContainer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem allQuizzedMI;
        private System.Windows.Forms.ToolStripMenuItem mostIncorrectlyAnsweredMI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn Value;
        private System.Data.DataColumn NumCorrect;
        private System.Data.DataColumn TotalAttempt;
        private System.Data.DataColumn ID;
        private System.Data.DataColumn NumCorrectByTotalAttempt;
        private System.Data.DataColumn word;


    }
}
