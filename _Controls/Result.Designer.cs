

namespace VocabularyProNamespace
{
    partial class Result
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalQ = new System.Windows.Forms.Label();
            this.lblIncorrectAns = new System.Windows.Forms.Label();
            this.lblCorrectAns = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalQ);
            this.groupBox2.Controls.Add(this.lblIncorrectAns);
            this.groupBox2.Controls.Add(this.lblCorrectAns);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblIncorrect);
            this.groupBox2.Controls.Add(this.lblCorrect);
            this.groupBox2.Location = new System.Drawing.Point(22, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lblTotalQ
            // 
            this.lblTotalQ.AutoSize = true;
            this.lblTotalQ.Location = new System.Drawing.Point(156, 72);
            this.lblTotalQ.Name = "lblTotalQ";
            this.lblTotalQ.Size = new System.Drawing.Size(35, 13);
            this.lblTotalQ.TabIndex = 6;
            this.lblTotalQ.Text = "label5";
            // 
            // lblIncorrectAns
            // 
            this.lblIncorrectAns.AutoSize = true;
            this.lblIncorrectAns.Location = new System.Drawing.Point(156, 43);
            this.lblIncorrectAns.Name = "lblIncorrectAns";
            this.lblIncorrectAns.Size = new System.Drawing.Size(35, 13);
            this.lblIncorrectAns.TabIndex = 5;
            this.lblIncorrectAns.Text = "label4";
            // 
            // lblCorrectAns
            // 
            this.lblCorrectAns.AutoSize = true;
            this.lblCorrectAns.Location = new System.Drawing.Point(156, 16);
            this.lblCorrectAns.Name = "lblCorrectAns";
            this.lblCorrectAns.Size = new System.Drawing.Size(35, 13);
            this.lblCorrectAns.TabIndex = 4;
            this.lblCorrectAns.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Questions: ";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Location = new System.Drawing.Point(6, 43);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(98, 13);
            this.lblIncorrect.TabIndex = 2;
            this.lblIncorrect.Text = "Incorrect Answers: ";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(6, 16);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(90, 13);
            this.lblCorrect.TabIndex = 1;
            this.lblCorrect.Text = "Correct Answers: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz Result";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Name = "Result";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 0, 0);
            this.Size = new System.Drawing.Size(590, 138);
            this.Load += new System.EventHandler(this.Result_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalQ;
        private System.Windows.Forms.Label lblIncorrectAns;
        private System.Windows.Forms.Label lblCorrectAns;
    }
}
