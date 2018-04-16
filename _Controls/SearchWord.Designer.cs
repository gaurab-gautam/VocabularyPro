
namespace VocabularyProNamespace
{
    partial class SearchWord
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
            this.components = new System.ComponentModel.Container();
            this.gbMainContainer = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbMainContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMainContainer
            // 
            this.gbMainContainer.Controls.Add(this.lblError);
            this.gbMainContainer.Controls.Add(this.btnSearch);
            this.gbMainContainer.Controls.Add(this.groupBox2);
            this.gbMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMainContainer.Location = new System.Drawing.Point(7, 7);
            this.gbMainContainer.Margin = new System.Windows.Forms.Padding(10);
            this.gbMainContainer.Name = "gbMainContainer";
            this.gbMainContainer.Size = new System.Drawing.Size(447, 120);
            this.gbMainContainer.TabIndex = 1;
            this.gbMainContainer.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(31, 89);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(66, 15);
            this.lblError.TabIndex = 21;
            this.lblError.Text = "* Required";
            this.lblError.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(340, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtWord);
            this.groupBox2.Location = new System.Drawing.Point(16, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 39);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word: ";
            // 
            // txtWord
            // 
            this.txtWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtWord.BackColor = System.Drawing.Color.White;
            this.txtWord.Location = new System.Drawing.Point(67, 12);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(335, 20);
            this.txtWord.TabIndex = 4;
            this.txtWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWord_KeyDown);
            this.txtWord.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SearchWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbMainContainer);
            this.Name = "SearchWord";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 0, 0);
            this.Size = new System.Drawing.Size(454, 127);
            this.gbMainContainer.ResumeLayout(false);
            this.gbMainContainer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMainContainer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSearch;
    }
}
