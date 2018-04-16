namespace VocabularyProNamespace
{
    partial class VocabularyPro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VocabularyPro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordsFromFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnViewProgressReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddNewWord = new System.Windows.Forms.Button();
            this.btnViewFlashCard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnViewWordList = new System.Windows.Forms.Button();
            this.btnAddWordList = new System.Windows.Forms.Button();
            this.DisplayArea = new System.Windows.Forms.GroupBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.quizToolStripMenuItem,
            this.tToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWordsFromFileToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addWordsFromFileToolStripMenuItem1
            // 
            this.addWordsFromFileToolStripMenuItem1.Name = "addWordsFromFileToolStripMenuItem1";
            this.addWordsFromFileToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.addWordsFromFileToolStripMenuItem1.Text = "Add Words From File";
            this.addWordsFromFileToolStripMenuItem1.ToolTipText = "Text or Excel File";
            this.addWordsFromFileToolStripMenuItem1.Click += new System.EventHandler(this.addWordsFromFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordListToolStripMenuItem,
            this.flashCardToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.progressReportToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // wordListToolStripMenuItem
            // 
            this.wordListToolStripMenuItem.Name = "wordListToolStripMenuItem";
            this.wordListToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.wordListToolStripMenuItem.Text = "Word List";
            this.wordListToolStripMenuItem.Click += new System.EventHandler(this.wordListToolStripMenuItem_Click);
            // 
            // flashCardToolStripMenuItem
            // 
            this.flashCardToolStripMenuItem.Name = "flashCardToolStripMenuItem";
            this.flashCardToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.flashCardToolStripMenuItem.Text = "Flash Card";
            this.flashCardToolStripMenuItem.Click += new System.EventHandler(this.flashCardToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.searchToolStripMenuItem.Text = "Search Word";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchAndEditToolStripMenuItem_Click);
            // 
            // progressReportToolStripMenuItem
            // 
            this.progressReportToolStripMenuItem.Name = "progressReportToolStripMenuItem";
            this.progressReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.progressReportToolStripMenuItem.Text = "Progress Report";
            this.progressReportToolStripMenuItem.Click += new System.EventHandler(this.progressReportToolStripMenuItem_Click);
            // 
            // quizToolStripMenuItem
            // 
            this.quizToolStripMenuItem.Name = "quizToolStripMenuItem";
            this.quizToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.quizToolStripMenuItem.Text = "Quiz";
            this.quizToolStripMenuItem.Click += new System.EventHandler(this.quizToolStripMenuItem_Click);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteAllWordsToolStripMenuItem,
            this.printWordsToolStripMenuItem});
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tToolStripMenuItem.Text = "Tools";
            // 
            // deleteAllWordsToolStripMenuItem
            // 
            this.deleteAllWordsToolStripMenuItem.Name = "deleteAllWordsToolStripMenuItem";
            this.deleteAllWordsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteAllWordsToolStripMenuItem.Text = "Delete All Words";
            this.deleteAllWordsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllWordsToolStripMenuItem_Click_1);
            // 
            // printWordsToolStripMenuItem
            // 
            this.printWordsToolStripMenuItem.Name = "printWordsToolStripMenuItem";
            this.printWordsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.printWordsToolStripMenuItem.Text = "Print Words";
            this.printWordsToolStripMenuItem.Click += new System.EventHandler(this.printWordsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.howToToolStripMenuItem,
            this.dictionaryToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.howToToolStripMenuItem.Text = "How To";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.dictionaryToolStripMenuItem.Text = "Online Dictionary";
            this.dictionaryToolStripMenuItem.Click += new System.EventHandler(this.dictionaryToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Enabled = false;
            this.splitContainer1.Panel1MinSize = 40;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(834, 576);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Controls.Add(this.splitter2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnDeleteAll);
            this.splitContainer2.Panel1.Controls.Add(this.btnViewProgressReport);
            this.splitContainer2.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddNewWord);
            this.splitContainer2.Panel1.Controls.Add(this.btnViewFlashCard);
            this.splitContainer2.Panel1.Controls.Add(this.btnExit);
            this.splitContainer2.Panel1.Controls.Add(this.btnQuiz);
            this.splitContainer2.Panel1.Controls.Add(this.btnViewWordList);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddWordList);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.DisplayArea);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(7, 1, 4, 5);
            this.splitContainer2.Size = new System.Drawing.Size(828, 491);
            this.splitContainer2.SplitterDistance = 169;
            this.splitContainer2.TabIndex = 4;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Lavender;
            this.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAll.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAll.Location = new System.Drawing.Point(0, 182);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(169, 25);
            this.btnDeleteAll.TabIndex = 18;
            this.btnDeleteAll.Text = "Delete All Words";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnViewProgressReport
            // 
            this.btnViewProgressReport.BackColor = System.Drawing.Color.Lavender;
            this.btnViewProgressReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProgressReport.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnViewProgressReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btnViewProgressReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProgressReport.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnViewProgressReport.Location = new System.Drawing.Point(0, 57);
            this.btnViewProgressReport.Margin = new System.Windows.Forms.Padding(5);
            this.btnViewProgressReport.Name = "btnViewProgressReport";
            this.btnViewProgressReport.Size = new System.Drawing.Size(169, 25);
            this.btnViewProgressReport.TabIndex = 17;
            this.btnViewProgressReport.Text = "View Progress Report";
            this.btnViewProgressReport.UseVisualStyleBackColor = false;
            this.btnViewProgressReport.Click += new System.EventHandler(this.btnViewProgressReport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lavender;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Location = new System.Drawing.Point(0, 132);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 25);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search Word";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchEdit_Click);
            // 
            // btnAddNewWord
            // 
            this.btnAddNewWord.BackColor = System.Drawing.Color.Lavender;
            this.btnAddNewWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewWord.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNewWord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btnAddNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewWord.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewWord.Location = new System.Drawing.Point(0, 32);
            this.btnAddNewWord.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNewWord.Name = "btnAddNewWord";
            this.btnAddNewWord.Size = new System.Drawing.Size(169, 25);
            this.btnAddNewWord.TabIndex = 15;
            this.btnAddNewWord.Text = "Add a  New Word";
            this.btnAddNewWord.UseVisualStyleBackColor = false;
            this.btnAddNewWord.Click += new System.EventHandler(this.btnAddNewWord_Click);
            // 
            // btnViewFlashCard
            // 
            this.btnViewFlashCard.BackColor = System.Drawing.Color.Lavender;
            this.btnViewFlashCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewFlashCard.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnViewFlashCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btnViewFlashCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFlashCard.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnViewFlashCard.Location = new System.Drawing.Point(0, 82);
            this.btnViewFlashCard.Margin = new System.Windows.Forms.Padding(5);
            this.btnViewFlashCard.Name = "btnViewFlashCard";
            this.btnViewFlashCard.Size = new System.Drawing.Size(169, 25);
            this.btnViewFlashCard.TabIndex = 14;
            this.btnViewFlashCard.Text = "View Flash Card";
            this.btnViewFlashCard.UseVisualStyleBackColor = false;
            this.btnViewFlashCard.Click += new System.EventHandler(this.btnViewFlashCard_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnExit.Location = new System.Drawing.Point(0, 207);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 25);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.Lavender;
            this.btnQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuiz.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnQuiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btnQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnQuiz.Location = new System.Drawing.Point(0, 157);
            this.btnQuiz.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(169, 25);
            this.btnQuiz.TabIndex = 11;
            this.btnQuiz.Text = "Take a Quiz";
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnViewWordList
            // 
            this.btnViewWordList.BackColor = System.Drawing.Color.Lavender;
            this.btnViewWordList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewWordList.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnViewWordList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btnViewWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWordList.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnViewWordList.Location = new System.Drawing.Point(0, 107);
            this.btnViewWordList.Margin = new System.Windows.Forms.Padding(5);
            this.btnViewWordList.Name = "btnViewWordList";
            this.btnViewWordList.Size = new System.Drawing.Size(169, 25);
            this.btnViewWordList.TabIndex = 10;
            this.btnViewWordList.Text = "View Word List";
            this.btnViewWordList.UseVisualStyleBackColor = false;
            this.btnViewWordList.Click += new System.EventHandler(this.btnViewWordList_Click);
            // 
            // btnAddWordList
            // 
            this.btnAddWordList.BackColor = System.Drawing.Color.Lavender;
            this.btnAddWordList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWordList.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAddWordList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.btnAddWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWordList.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddWordList.Location = new System.Drawing.Point(0, 7);
            this.btnAddWordList.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddWordList.Name = "btnAddWordList";
            this.btnAddWordList.Size = new System.Drawing.Size(169, 25);
            this.btnAddWordList.TabIndex = 13;
            this.btnAddWordList.Text = "Add Word List From File";
            this.btnAddWordList.UseVisualStyleBackColor = false;
            this.btnAddWordList.Click += new System.EventHandler(this.btnAddWordList_Click);
            // 
            // DisplayArea
            // 
            this.DisplayArea.BackColor = System.Drawing.Color.White;
            this.DisplayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayArea.Location = new System.Drawing.Point(7, 1);
            this.DisplayArea.Name = "DisplayArea";
            this.DisplayArea.Size = new System.Drawing.Size(644, 485);
            this.DisplayArea.TabIndex = 0;
            this.DisplayArea.TabStop = false;
            this.DisplayArea.Enter += new System.EventHandler(this.DisplayArea_Enter);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(3, 507);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(828, 20);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VocabularyPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "VocabularyPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VocabularyPro";
            this.Load += new System.EventHandler(this.VocabularyPro_Load);
            this.Shown += new System.EventHandler(this.VocabularyPro_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnAddNewWord;
        private System.Windows.Forms.Button btnViewFlashCard;
        private System.Windows.Forms.Button btnAddWordList;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnViewWordList;
        private System.Windows.Forms.GroupBox DisplayArea;
        private System.Windows.Forms.ToolStripMenuItem wordListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashCardToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordsFromFileToolStripMenuItem1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewProgressReport;
        private System.Windows.Forms.ToolStripMenuItem progressReportToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printWordsToolStripMenuItem;
    }
}