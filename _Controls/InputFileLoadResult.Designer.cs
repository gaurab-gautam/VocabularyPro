namespace VocabularyProNamespace
{
    partial class InputFileLoadResult
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cblWordsAlreadyPresent = new System.Windows.Forms.CheckedListBox();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Beige;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.lblWordCount);
            this.splitContainer1.Panel2.Controls.Add(this.cblWordsAlreadyPresent);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(459, 342);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "The following words are already present in your vocabulary list,\r\nand are hence, " +
                "not added from the input file.";
            // 
            // cblWordsAlreadyPresent
            // 
            this.cblWordsAlreadyPresent.Dock = System.Windows.Forms.DockStyle.Top;
            this.cblWordsAlreadyPresent.FormattingEnabled = true;
            this.cblWordsAlreadyPresent.Location = new System.Drawing.Point(10, 10);
            this.cblWordsAlreadyPresent.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cblWordsAlreadyPresent.Name = "cblWordsAlreadyPresent";
            this.cblWordsAlreadyPresent.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.cblWordsAlreadyPresent.Size = new System.Drawing.Size(437, 259);
            this.cblWordsAlreadyPresent.TabIndex = 0;
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Font = new System.Drawing.Font("Mangal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblWordCount.Location = new System.Drawing.Point(8, 273);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(181, 17);
            this.lblWordCount.TabIndex = 1;
            this.lblWordCount.Text = "Total duplicate words: {0}";
            // 
            // InputFileLoadResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 342);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputFileLoadResult";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplicate Words Found";
            this.Load += new System.EventHandler(this.InputFileLoadResult_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox cblWordsAlreadyPresent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWordCount;
    }
}