
namespace VocabularyProNamespace
{
    partial class AddNewWordList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewWordList));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.spinningProgress1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.spinningProgress1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // spinningProgress1
            // 
            this.spinningProgress1.Image = ((System.Drawing.Image)(resources.GetObject("spinningProgress1.Image")));
            this.spinningProgress1.Location = new System.Drawing.Point(275, 112);
            this.spinningProgress1.Name = "spinningProgress1";
            this.spinningProgress1.Size = new System.Drawing.Size(32, 32);
            this.spinningProgress1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.spinningProgress1.TabIndex = 0;
            this.spinningProgress1.TabStop = false;
            this.spinningProgress1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // AddNewWordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.spinningProgress1);
            this.Name = "AddNewWordList";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 0, 0);
            this.Size = new System.Drawing.Size(580, 317);
            this.Load += new System.EventHandler(this.AddNewWordList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinningProgress1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox spinningProgress1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
