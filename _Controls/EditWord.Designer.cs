

namespace VocabularyProNamespace
{
    partial class EditWord
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbMainContainer = new System.Windows.Forms.GroupBox();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.gbWordType = new System.Windows.Forms.GroupBox();
            this.rbVerb = new System.Windows.Forms.RadioButton();
            this.rbNoun = new System.Windows.Forms.RadioButton();
            this.rbAdverb = new System.Windows.Forms.RadioButton();
            this.rbAdjective = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSynonyms = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbMainContainer.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.gbContainer.SuspendLayout();
            this.gbWordType.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbMainContainer
            // 
            this.gbMainContainer.Controls.Add(this.gbButtons);
            this.gbMainContainer.Controls.Add(this.gbContainer);
            this.gbMainContainer.Controls.Add(this.groupBox2);
            this.gbMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMainContainer.Location = new System.Drawing.Point(0, 0);
            this.gbMainContainer.Margin = new System.Windows.Forms.Padding(10);
            this.gbMainContainer.Name = "gbMainContainer";
            this.gbMainContainer.Size = new System.Drawing.Size(474, 459);
            this.gbMainContainer.TabIndex = 2;
            this.gbMainContainer.TabStop = false;
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.lblError);
            this.gbButtons.Controls.Add(this.btnCancel);
            this.gbButtons.Controls.Add(this.btnSave);
            this.gbButtons.Location = new System.Drawing.Point(16, 402);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(452, 48);
            this.gbButtons.TabIndex = 17;
            this.gbButtons.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(30, 14);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(66, 15);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "* Required";
            this.lblError.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(258, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(339, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.gbWordType);
            this.gbContainer.Controls.Add(this.groupBox5);
            this.gbContainer.Controls.Add(this.groupBox4);
            this.gbContainer.Controls.Add(this.groupBox3);
            this.gbContainer.Location = new System.Drawing.Point(16, 49);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(453, 352);
            this.gbContainer.TabIndex = 15;
            this.gbContainer.TabStop = false;
            // 
            // gbWordType
            // 
            this.gbWordType.Controls.Add(this.rbVerb);
            this.gbWordType.Controls.Add(this.rbNoun);
            this.gbWordType.Controls.Add(this.rbAdverb);
            this.gbWordType.Controls.Add(this.rbAdjective);
            this.gbWordType.Location = new System.Drawing.Point(6, 7);
            this.gbWordType.Name = "gbWordType";
            this.gbWordType.Size = new System.Drawing.Size(441, 67);
            this.gbWordType.TabIndex = 19;
            this.gbWordType.TabStop = false;
            // 
            // rbVerb
            // 
            this.rbVerb.AutoSize = true;
            this.rbVerb.Location = new System.Drawing.Point(244, 42);
            this.rbVerb.Name = "rbVerb";
            this.rbVerb.Size = new System.Drawing.Size(47, 17);
            this.rbVerb.TabIndex = 4;
            this.rbVerb.Text = "Verb";
            this.rbVerb.UseVisualStyleBackColor = true;
            this.rbVerb.CheckedChanged += new System.EventHandler(this.rbWordTypes_CheckedChange);
            // 
            // rbNoun
            // 
            this.rbNoun.AutoSize = true;
            this.rbNoun.Location = new System.Drawing.Point(54, 42);
            this.rbNoun.Name = "rbNoun";
            this.rbNoun.Size = new System.Drawing.Size(51, 17);
            this.rbNoun.TabIndex = 2;
            this.rbNoun.Text = "Noun";
            this.rbNoun.UseVisualStyleBackColor = true;
            this.rbNoun.CheckedChanged += new System.EventHandler(this.rbWordTypes_CheckedChange);
            // 
            // rbAdverb
            // 
            this.rbAdverb.AutoSize = true;
            this.rbAdverb.Location = new System.Drawing.Point(244, 12);
            this.rbAdverb.Name = "rbAdverb";
            this.rbAdverb.Size = new System.Drawing.Size(59, 17);
            this.rbAdverb.TabIndex = 1;
            this.rbAdverb.Text = "Adverb";
            this.rbAdverb.UseVisualStyleBackColor = true;
            this.rbAdverb.CheckedChanged += new System.EventHandler(this.rbWordTypes_CheckedChange);
            // 
            // rbAdjective
            // 
            this.rbAdjective.AutoSize = true;
            this.rbAdjective.Location = new System.Drawing.Point(54, 12);
            this.rbAdjective.Name = "rbAdjective";
            this.rbAdjective.Size = new System.Drawing.Size(69, 17);
            this.rbAdjective.TabIndex = 0;
            this.rbAdjective.Text = "Adjective";
            this.rbAdjective.UseVisualStyleBackColor = true;
            this.rbAdjective.CheckedChanged += new System.EventHandler(this.rbWordTypes_CheckedChange);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtSynonyms);
            this.groupBox5.Location = new System.Drawing.Point(0, 271);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(447, 80);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Synonyms: ";
            // 
            // txtSynonyms
            // 
            this.txtSynonyms.Location = new System.Drawing.Point(67, 13);
            this.txtSynonyms.Multiline = true;
            this.txtSynonyms.Name = "txtSynonyms";
            this.txtSynonyms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSynonyms.Size = new System.Drawing.Size(350, 61);
            this.txtSynonyms.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtSentence);
            this.groupBox4.Location = new System.Drawing.Point(0, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(447, 80);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sentence: ";
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(67, 13);
            this.txtSentence.Multiline = true;
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSentence.Size = new System.Drawing.Size(350, 61);
            this.txtSentence.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.elementHost1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(0, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 125);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(57, 16);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(360, 103);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meanings: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtWord);
            this.groupBox2.Location = new System.Drawing.Point(16, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 39);
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
            this.txtWord.AcceptsReturn = true;
            this.txtWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtWord.BackColor = System.Drawing.Color.White;
            this.txtWord.Location = new System.Drawing.Point(67, 12);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(350, 20);
            this.txtWord.TabIndex = 4;
            // 
            // EditWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbMainContainer);
            this.Name = "EditWord";
            this.Size = new System.Drawing.Size(474, 459);
            this.Load += new System.EventHandler(this.EditWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbMainContainer.ResumeLayout(false);
            this.gbButtons.ResumeLayout(false);
            this.gbButtons.PerformLayout();
            this.gbContainer.ResumeLayout(false);
            this.gbWordType.ResumeLayout(false);
            this.gbWordType.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbMainContainer;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.GroupBox gbWordType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSynonyms;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.RadioButton rbVerb;
        private System.Windows.Forms.RadioButton rbNoun;
        private System.Windows.Forms.RadioButton rbAdverb;
        private System.Windows.Forms.RadioButton rbAdjective;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private EditListBoxControl editListBoxControl;
    }
}
