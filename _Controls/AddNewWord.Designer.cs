
namespace VocabularyProNamespace
{
    partial class AddNewWord
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbWordType = new System.Windows.Forms.GroupBox();
            this.rbVerb = new System.Windows.Forms.RadioButton();
            this.rbNoun = new System.Windows.Forms.RadioButton();
            this.rbAdverb = new System.Windows.Forms.RadioButton();
            this.rbAdjective = new System.Windows.Forms.RadioButton();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.gbWordType.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbWordType);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gbWordType
            // 
            this.gbWordType.Controls.Add(this.rbVerb);
            this.gbWordType.Controls.Add(this.rbNoun);
            this.gbWordType.Controls.Add(this.rbAdverb);
            this.gbWordType.Controls.Add(this.rbAdjective);
            this.gbWordType.Location = new System.Drawing.Point(16, 48);
            this.gbWordType.Name = "gbWordType";
            this.gbWordType.Size = new System.Drawing.Size(436, 67);
            this.gbWordType.TabIndex = 20;
            this.gbWordType.TabStop = false;
            // 
            // rbVerb
            // 
            this.rbVerb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbVerb.AutoSize = true;
            this.rbVerb.Location = new System.Drawing.Point(68, 44);
            this.rbVerb.Name = "rbVerb";
            this.rbVerb.Size = new System.Drawing.Size(47, 17);
            this.rbVerb.TabIndex = 4;
            this.rbVerb.Text = "Verb";
            this.rbVerb.UseVisualStyleBackColor = true;
            this.rbVerb.CheckedChanged += new System.EventHandler(this.rbWordTypes_CheckedChange);
            // 
            // rbNoun
            // 
            this.rbNoun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNoun.AutoSize = true;
            this.rbNoun.Location = new System.Drawing.Point(261, 44);
            this.rbNoun.Name = "rbNoun";
            this.rbNoun.Size = new System.Drawing.Size(51, 17);
            this.rbNoun.TabIndex = 2;
            this.rbNoun.Text = "Noun";
            this.rbNoun.UseVisualStyleBackColor = true;
            this.rbNoun.CheckedChanged += new System.EventHandler(this.rbWordTypes_CheckedChange);
            // 
            // rbAdverb
            // 
            this.rbAdverb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAdverb.AutoSize = true;
            this.rbAdverb.Location = new System.Drawing.Point(261, 15);
            this.rbAdverb.Name = "rbAdverb";
            this.rbAdverb.Size = new System.Drawing.Size(59, 17);
            this.rbAdverb.TabIndex = 1;
            this.rbAdverb.Text = "Adverb";
            this.rbAdverb.UseVisualStyleBackColor = true;
            this.rbAdverb.CheckedChanged += new System.EventHandler(this.rbWordTypes_CheckedChange);
            // 
            // rbAdjective
            // 
            this.rbAdjective.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAdjective.AutoSize = true;
            this.rbAdjective.Location = new System.Drawing.Point(68, 15);
            this.rbAdjective.Name = "rbAdjective";
            this.rbAdjective.Size = new System.Drawing.Size(69, 17);
            this.rbAdjective.TabIndex = 0;
            this.rbAdjective.Text = "Adjective";
            this.rbAdjective.UseVisualStyleBackColor = true;
            this.rbAdjective.CheckedChanged += new System.EventHandler(this.rbWordTypes_CheckedChange);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblError.Location = new System.Drawing.Point(26, 372);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(66, 15);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "* Required";
            this.lblError.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(259, 377);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(355, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtSynonyms);
            this.groupBox5.Location = new System.Drawing.Point(16, 278);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(436, 80);
            this.groupBox5.TabIndex = 11;
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
            this.txtSynonyms.Size = new System.Drawing.Size(347, 61);
            this.txtSynonyms.TabIndex = 4;
            this.txtSynonyms.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            this.txtSynonyms.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtSentence);
            this.groupBox4.Location = new System.Drawing.Point(16, 197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 80);
            this.groupBox4.TabIndex = 10;
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
            this.txtSentence.Size = new System.Drawing.Size(347, 61);
            this.txtSentence.TabIndex = 4;
            this.txtSentence.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            this.txtSentence.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.elementHost1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(16, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 80);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(56, 10);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(358, 65);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meaning:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtWord);
            this.groupBox2.Location = new System.Drawing.Point(16, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 39);
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
            this.txtWord.Location = new System.Drawing.Point(67, 12);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(347, 20);
            this.txtWord.TabIndex = 4;
            this.txtWord.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            this.txtWord.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddNewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewWord";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 0, 0);
            this.Size = new System.Drawing.Size(470, 420);
            this.Load += new System.EventHandler(this.AddNewWord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSynonyms;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox gbWordType;
        private System.Windows.Forms.RadioButton rbVerb;
        private System.Windows.Forms.RadioButton rbNoun;
        private System.Windows.Forms.RadioButton rbAdverb;
        private System.Windows.Forms.RadioButton rbAdjective;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}
