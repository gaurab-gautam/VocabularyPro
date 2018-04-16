

namespace VocabularyProNamespace
{
    partial class Quiz
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
            this.gbMainContainer = new System.Windows.Forms.GroupBox();
            this.gbQuestions = new System.Windows.Forms.GroupBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbAnswerChoices = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblWordType = new System.Windows.Forms.Label();
            this.gbMainContainer.SuspendLayout();
            this.gbQuestions.SuspendLayout();
            this.gbAnswerChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMainContainer
            // 
            this.gbMainContainer.Controls.Add(this.gbQuestions);
            this.gbMainContainer.Controls.Add(this.gbResult);
            this.gbMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMainContainer.Location = new System.Drawing.Point(7, 7);
            this.gbMainContainer.Name = "gbMainContainer";
            this.gbMainContainer.Padding = new System.Windows.Forms.Padding(0);
            this.gbMainContainer.Size = new System.Drawing.Size(564, 407);
            this.gbMainContainer.TabIndex = 0;
            this.gbMainContainer.TabStop = false;
            // 
            // gbQuestions
            // 
            this.gbQuestions.Controls.Add(this.lblWordType);
            this.gbQuestions.Controls.Add(this.lblWord);
            this.gbQuestions.Controls.Add(this.lblPage);
            this.gbQuestions.Controls.Add(this.btnNext);
            this.gbQuestions.Controls.Add(this.gbAnswerChoices);
            this.gbQuestions.Location = new System.Drawing.Point(8, 10);
            this.gbQuestions.Name = "gbQuestions";
            this.gbQuestions.Size = new System.Drawing.Size(548, 242);
            this.gbQuestions.TabIndex = 4;
            this.gbQuestions.TabStop = false;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPage.Location = new System.Drawing.Point(6, 213);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(62, 17);
            this.lblPage.TabIndex = 15;
            this.lblPage.Text = "lblPage";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(458, 210);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbAnswerChoices
            // 
            this.gbAnswerChoices.Controls.Add(this.radioButton4);
            this.gbAnswerChoices.Controls.Add(this.radioButton3);
            this.gbAnswerChoices.Controls.Add(this.radioButton2);
            this.gbAnswerChoices.Controls.Add(this.radioButton1);
            this.gbAnswerChoices.Location = new System.Drawing.Point(7, 30);
            this.gbAnswerChoices.Name = "gbAnswerChoices";
            this.gbAnswerChoices.Padding = new System.Windows.Forms.Padding(10);
            this.gbAnswerChoices.Size = new System.Drawing.Size(535, 169);
            this.gbAnswerChoices.TabIndex = 1;
            this.gbAnswerChoices.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radioButton4.FlatAppearance.BorderSize = 2;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Location = new System.Drawing.Point(14, 134);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "choice4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.answer_Clicked);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radioButton3.FlatAppearance.BorderSize = 2;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Location = new System.Drawing.Point(14, 96);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "choice 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.answer_Clicked);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radioButton2.FlatAppearance.BorderSize = 2;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(14, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "choice 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.answer_Clicked);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radioButton1.FlatAppearance.BorderSize = 2;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(14, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "choice 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.answer_Clicked);
            // 
            // gbResult
            // 
            this.gbResult.Location = new System.Drawing.Point(8, 250);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(548, 146);
            this.gbResult.TabIndex = 3;
            this.gbResult.TabStop = false;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(9, 20);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(35, 13);
            this.lblWord.TabIndex = 16;
            this.lblWord.Text = "label1";
            // 
            // lblWordType
            // 
            this.lblWordType.AutoSize = true;
            this.lblWordType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordType.Location = new System.Drawing.Point(50, 20);
            this.lblWordType.Name = "lblWordType";
            this.lblWordType.Size = new System.Drawing.Size(53, 13);
            this.lblWordType.TabIndex = 17;
            this.lblWordType.Text = "      label2";
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbMainContainer);
            this.Name = "Quiz";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 0, 0);
            this.Size = new System.Drawing.Size(571, 414);
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.gbMainContainer.ResumeLayout(false);
            this.gbQuestions.ResumeLayout(false);
            this.gbQuestions.PerformLayout();
            this.gbAnswerChoices.ResumeLayout(false);
            this.gbAnswerChoices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMainContainer;
        private System.Windows.Forms.GroupBox gbAnswerChoices;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.GroupBox gbQuestions;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblWordType;
        private System.Windows.Forms.Label lblWord;
    }
}
