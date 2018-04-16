

namespace VocabularyProNamespace
{
    partial class FlashCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashCard));
            this.gbWordContainer = new System.Windows.Forms.GroupBox();
            this.tabWord = new System.Windows.Forms.TabControl();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbMainContainer = new System.Windows.Forms.GroupBox();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.gbLetters = new System.Windows.Forms.GroupBox();
            this.flpLetters = new System.Windows.Forms.FlowLayoutPanel();
            this.linkA = new System.Windows.Forms.LinkLabel();
            this.linkB = new System.Windows.Forms.LinkLabel();
            this.linkC = new System.Windows.Forms.LinkLabel();
            this.linkD = new System.Windows.Forms.LinkLabel();
            this.linkE = new System.Windows.Forms.LinkLabel();
            this.linkF = new System.Windows.Forms.LinkLabel();
            this.linkG = new System.Windows.Forms.LinkLabel();
            this.linkH = new System.Windows.Forms.LinkLabel();
            this.linkI = new System.Windows.Forms.LinkLabel();
            this.linkJ = new System.Windows.Forms.LinkLabel();
            this.linkK = new System.Windows.Forms.LinkLabel();
            this.linkL = new System.Windows.Forms.LinkLabel();
            this.linkM = new System.Windows.Forms.LinkLabel();
            this.linkN = new System.Windows.Forms.LinkLabel();
            this.linkO = new System.Windows.Forms.LinkLabel();
            this.linkP = new System.Windows.Forms.LinkLabel();
            this.linkQ = new System.Windows.Forms.LinkLabel();
            this.linkR = new System.Windows.Forms.LinkLabel();
            this.linkS = new System.Windows.Forms.LinkLabel();
            this.linkT = new System.Windows.Forms.LinkLabel();
            this.linkU = new System.Windows.Forms.LinkLabel();
            this.linkV = new System.Windows.Forms.LinkLabel();
            this.linkW = new System.Windows.Forms.LinkLabel();
            this.linkX = new System.Windows.Forms.LinkLabel();
            this.linkY = new System.Windows.Forms.LinkLabel();
            this.linkZ = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddNewWordType = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbWordContainer.SuspendLayout();
            this.gbMainContainer.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.gbLetters.SuspendLayout();
            this.flpLetters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbWordContainer
            // 
            this.gbWordContainer.Controls.Add(this.tabWord);
            this.gbWordContainer.Location = new System.Drawing.Point(8, 79);
            this.gbWordContainer.Margin = new System.Windows.Forms.Padding(10);
            this.gbWordContainer.Name = "gbWordContainer";
            this.gbWordContainer.Size = new System.Drawing.Size(454, 330);
            this.gbWordContainer.TabIndex = 1;
            this.gbWordContainer.TabStop = false;
            // 
            // tabWord
            // 
            this.tabWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWord.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabWord.Location = new System.Drawing.Point(3, 16);
            this.tabWord.Name = "tabWord";
            this.tabWord.SelectedIndex = 0;
            this.tabWord.Size = new System.Drawing.Size(448, 311);
            this.tabWord.TabIndex = 0;
            this.tabWord.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabWord_DrawItem);
            // 
            // btnRandom
            // 
            this.btnRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandom.Location = new System.Drawing.Point(231, 15);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 15;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPage.Location = new System.Drawing.Point(9, 18);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(52, 17);
            this.lblPage.TabIndex = 14;
            this.lblPage.Text = "label5";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(312, 15);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(393, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbMainContainer
            // 
            this.gbMainContainer.Controls.Add(this.btnAddNewWordType);
            this.gbMainContainer.Controls.Add(this.btnDelete);
            this.gbMainContainer.Controls.Add(this.gbButtons);
            this.gbMainContainer.Controls.Add(this.gbLetters);
            this.gbMainContainer.Controls.Add(this.btnEdit);
            this.gbMainContainer.Controls.Add(this.gbWordContainer);
            this.gbMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMainContainer.Location = new System.Drawing.Point(7, 7);
            this.gbMainContainer.Name = "gbMainContainer";
            this.gbMainContainer.Padding = new System.Windows.Forms.Padding(5);
            this.gbMainContainer.Size = new System.Drawing.Size(496, 463);
            this.gbMainContainer.TabIndex = 2;
            this.gbMainContainer.TabStop = false;
            this.gbMainContainer.Enter += new System.EventHandler(this.gbMainContainer_Enter);
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btnRandom);
            this.gbButtons.Controls.Add(this.btnNext);
            this.gbButtons.Controls.Add(this.btnPrevious);
            this.gbButtons.Controls.Add(this.lblPage);
            this.gbButtons.Location = new System.Drawing.Point(8, 407);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(480, 49);
            this.gbButtons.TabIndex = 3;
            this.gbButtons.TabStop = false;
            // 
            // gbLetters
            // 
            this.gbLetters.Controls.Add(this.flpLetters);
            this.gbLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLetters.Location = new System.Drawing.Point(8, 7);
            this.gbLetters.Margin = new System.Windows.Forms.Padding(0);
            this.gbLetters.Name = "gbLetters";
            this.gbLetters.Padding = new System.Windows.Forms.Padding(0);
            this.gbLetters.Size = new System.Drawing.Size(480, 74);
            this.gbLetters.TabIndex = 2;
            this.gbLetters.TabStop = false;
            // 
            // flpLetters
            // 
            this.flpLetters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpLetters.Controls.Add(this.linkA);
            this.flpLetters.Controls.Add(this.linkB);
            this.flpLetters.Controls.Add(this.linkC);
            this.flpLetters.Controls.Add(this.linkD);
            this.flpLetters.Controls.Add(this.linkE);
            this.flpLetters.Controls.Add(this.linkF);
            this.flpLetters.Controls.Add(this.linkG);
            this.flpLetters.Controls.Add(this.linkH);
            this.flpLetters.Controls.Add(this.linkI);
            this.flpLetters.Controls.Add(this.linkJ);
            this.flpLetters.Controls.Add(this.linkK);
            this.flpLetters.Controls.Add(this.linkL);
            this.flpLetters.Controls.Add(this.linkM);
            this.flpLetters.Controls.Add(this.linkN);
            this.flpLetters.Controls.Add(this.linkO);
            this.flpLetters.Controls.Add(this.linkP);
            this.flpLetters.Controls.Add(this.linkQ);
            this.flpLetters.Controls.Add(this.linkR);
            this.flpLetters.Controls.Add(this.linkS);
            this.flpLetters.Controls.Add(this.linkT);
            this.flpLetters.Controls.Add(this.linkU);
            this.flpLetters.Controls.Add(this.linkV);
            this.flpLetters.Controls.Add(this.linkW);
            this.flpLetters.Controls.Add(this.linkX);
            this.flpLetters.Controls.Add(this.linkY);
            this.flpLetters.Controls.Add(this.linkZ);
            this.flpLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLetters.Location = new System.Drawing.Point(0, 13);
            this.flpLetters.Name = "flpLetters";
            this.flpLetters.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.flpLetters.Size = new System.Drawing.Size(480, 61);
            this.flpLetters.TabIndex = 4;
            // 
            // linkA
            // 
            this.linkA.AutoSize = true;
            this.linkA.Location = new System.Drawing.Point(15, 10);
            this.linkA.Margin = new System.Windows.Forms.Padding(5);
            this.linkA.Name = "linkA";
            this.linkA.Size = new System.Drawing.Size(14, 13);
            this.linkA.TabIndex = 0;
            this.linkA.TabStop = true;
            this.linkA.Text = "A";
            this.linkA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkB
            // 
            this.linkB.AutoSize = true;
            this.linkB.Location = new System.Drawing.Point(39, 10);
            this.linkB.Margin = new System.Windows.Forms.Padding(5);
            this.linkB.Name = "linkB";
            this.linkB.Size = new System.Drawing.Size(14, 13);
            this.linkB.TabIndex = 1;
            this.linkB.TabStop = true;
            this.linkB.Text = "B";
            this.linkB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkC
            // 
            this.linkC.AutoSize = true;
            this.linkC.Location = new System.Drawing.Point(63, 10);
            this.linkC.Margin = new System.Windows.Forms.Padding(5);
            this.linkC.Name = "linkC";
            this.linkC.Size = new System.Drawing.Size(14, 13);
            this.linkC.TabIndex = 2;
            this.linkC.TabStop = true;
            this.linkC.Text = "C";
            this.linkC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkD
            // 
            this.linkD.AutoSize = true;
            this.linkD.Location = new System.Drawing.Point(87, 10);
            this.linkD.Margin = new System.Windows.Forms.Padding(5);
            this.linkD.Name = "linkD";
            this.linkD.Size = new System.Drawing.Size(15, 13);
            this.linkD.TabIndex = 3;
            this.linkD.TabStop = true;
            this.linkD.Text = "D";
            this.linkD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkE
            // 
            this.linkE.AutoSize = true;
            this.linkE.Location = new System.Drawing.Point(112, 10);
            this.linkE.Margin = new System.Windows.Forms.Padding(5);
            this.linkE.Name = "linkE";
            this.linkE.Size = new System.Drawing.Size(14, 13);
            this.linkE.TabIndex = 4;
            this.linkE.TabStop = true;
            this.linkE.Text = "E";
            this.linkE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkF
            // 
            this.linkF.AutoSize = true;
            this.linkF.Location = new System.Drawing.Point(136, 10);
            this.linkF.Margin = new System.Windows.Forms.Padding(5);
            this.linkF.Name = "linkF";
            this.linkF.Size = new System.Drawing.Size(13, 13);
            this.linkF.TabIndex = 5;
            this.linkF.TabStop = true;
            this.linkF.Text = "F";
            this.linkF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkG
            // 
            this.linkG.AutoSize = true;
            this.linkG.Location = new System.Drawing.Point(159, 10);
            this.linkG.Margin = new System.Windows.Forms.Padding(5);
            this.linkG.Name = "linkG";
            this.linkG.Size = new System.Drawing.Size(15, 13);
            this.linkG.TabIndex = 6;
            this.linkG.TabStop = true;
            this.linkG.Text = "G";
            this.linkG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkH
            // 
            this.linkH.AutoSize = true;
            this.linkH.Location = new System.Drawing.Point(184, 10);
            this.linkH.Margin = new System.Windows.Forms.Padding(5);
            this.linkH.Name = "linkH";
            this.linkH.Size = new System.Drawing.Size(15, 13);
            this.linkH.TabIndex = 7;
            this.linkH.TabStop = true;
            this.linkH.Text = "H";
            this.linkH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkI
            // 
            this.linkI.AutoSize = true;
            this.linkI.Location = new System.Drawing.Point(209, 10);
            this.linkI.Margin = new System.Windows.Forms.Padding(5);
            this.linkI.Name = "linkI";
            this.linkI.Size = new System.Drawing.Size(10, 13);
            this.linkI.TabIndex = 8;
            this.linkI.TabStop = true;
            this.linkI.Text = "I";
            this.linkI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkJ
            // 
            this.linkJ.AutoSize = true;
            this.linkJ.Location = new System.Drawing.Point(229, 10);
            this.linkJ.Margin = new System.Windows.Forms.Padding(5);
            this.linkJ.Name = "linkJ";
            this.linkJ.Size = new System.Drawing.Size(12, 13);
            this.linkJ.TabIndex = 9;
            this.linkJ.TabStop = true;
            this.linkJ.Text = "J";
            this.linkJ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkK
            // 
            this.linkK.AutoSize = true;
            this.linkK.Location = new System.Drawing.Point(251, 10);
            this.linkK.Margin = new System.Windows.Forms.Padding(5);
            this.linkK.Name = "linkK";
            this.linkK.Size = new System.Drawing.Size(14, 13);
            this.linkK.TabIndex = 10;
            this.linkK.TabStop = true;
            this.linkK.Text = "K";
            this.linkK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkL
            // 
            this.linkL.AutoSize = true;
            this.linkL.Location = new System.Drawing.Point(275, 10);
            this.linkL.Margin = new System.Windows.Forms.Padding(5);
            this.linkL.Name = "linkL";
            this.linkL.Size = new System.Drawing.Size(13, 13);
            this.linkL.TabIndex = 11;
            this.linkL.TabStop = true;
            this.linkL.Text = "L";
            this.linkL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkM
            // 
            this.linkM.AutoSize = true;
            this.linkM.Location = new System.Drawing.Point(298, 10);
            this.linkM.Margin = new System.Windows.Forms.Padding(5);
            this.linkM.Name = "linkM";
            this.linkM.Size = new System.Drawing.Size(16, 13);
            this.linkM.TabIndex = 12;
            this.linkM.TabStop = true;
            this.linkM.Text = "M";
            this.linkM.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkN
            // 
            this.linkN.AutoSize = true;
            this.linkN.Location = new System.Drawing.Point(324, 10);
            this.linkN.Margin = new System.Windows.Forms.Padding(5);
            this.linkN.Name = "linkN";
            this.linkN.Size = new System.Drawing.Size(15, 13);
            this.linkN.TabIndex = 13;
            this.linkN.TabStop = true;
            this.linkN.Text = "N";
            this.linkN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkO
            // 
            this.linkO.AutoSize = true;
            this.linkO.Location = new System.Drawing.Point(349, 10);
            this.linkO.Margin = new System.Windows.Forms.Padding(5);
            this.linkO.Name = "linkO";
            this.linkO.Size = new System.Drawing.Size(15, 13);
            this.linkO.TabIndex = 14;
            this.linkO.TabStop = true;
            this.linkO.Text = "O";
            this.linkO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkP
            // 
            this.linkP.AutoSize = true;
            this.linkP.Location = new System.Drawing.Point(374, 10);
            this.linkP.Margin = new System.Windows.Forms.Padding(5);
            this.linkP.Name = "linkP";
            this.linkP.Size = new System.Drawing.Size(14, 13);
            this.linkP.TabIndex = 15;
            this.linkP.TabStop = true;
            this.linkP.Text = "P";
            this.linkP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkQ
            // 
            this.linkQ.AutoSize = true;
            this.linkQ.Location = new System.Drawing.Point(398, 10);
            this.linkQ.Margin = new System.Windows.Forms.Padding(5);
            this.linkQ.Name = "linkQ";
            this.linkQ.Size = new System.Drawing.Size(15, 13);
            this.linkQ.TabIndex = 16;
            this.linkQ.TabStop = true;
            this.linkQ.Text = "Q";
            this.linkQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkR
            // 
            this.linkR.AutoSize = true;
            this.linkR.Location = new System.Drawing.Point(423, 10);
            this.linkR.Margin = new System.Windows.Forms.Padding(5);
            this.linkR.Name = "linkR";
            this.linkR.Size = new System.Drawing.Size(15, 13);
            this.linkR.TabIndex = 17;
            this.linkR.TabStop = true;
            this.linkR.Text = "R";
            this.linkR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkS
            // 
            this.linkS.AutoSize = true;
            this.linkS.Location = new System.Drawing.Point(448, 10);
            this.linkS.Margin = new System.Windows.Forms.Padding(5);
            this.linkS.Name = "linkS";
            this.linkS.Size = new System.Drawing.Size(14, 13);
            this.linkS.TabIndex = 18;
            this.linkS.TabStop = true;
            this.linkS.Text = "S";
            this.linkS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkT
            // 
            this.linkT.AutoSize = true;
            this.linkT.Location = new System.Drawing.Point(15, 33);
            this.linkT.Margin = new System.Windows.Forms.Padding(5);
            this.linkT.Name = "linkT";
            this.linkT.Size = new System.Drawing.Size(14, 13);
            this.linkT.TabIndex = 19;
            this.linkT.TabStop = true;
            this.linkT.Text = "T";
            this.linkT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkU
            // 
            this.linkU.AutoSize = true;
            this.linkU.Location = new System.Drawing.Point(39, 33);
            this.linkU.Margin = new System.Windows.Forms.Padding(5);
            this.linkU.Name = "linkU";
            this.linkU.Size = new System.Drawing.Size(15, 13);
            this.linkU.TabIndex = 20;
            this.linkU.TabStop = true;
            this.linkU.Text = "U";
            this.linkU.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkV
            // 
            this.linkV.AutoSize = true;
            this.linkV.Location = new System.Drawing.Point(64, 33);
            this.linkV.Margin = new System.Windows.Forms.Padding(5);
            this.linkV.Name = "linkV";
            this.linkV.Size = new System.Drawing.Size(14, 13);
            this.linkV.TabIndex = 21;
            this.linkV.TabStop = true;
            this.linkV.Text = "V";
            this.linkV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkW
            // 
            this.linkW.AutoSize = true;
            this.linkW.Location = new System.Drawing.Point(88, 33);
            this.linkW.Margin = new System.Windows.Forms.Padding(5);
            this.linkW.Name = "linkW";
            this.linkW.Size = new System.Drawing.Size(18, 13);
            this.linkW.TabIndex = 22;
            this.linkW.TabStop = true;
            this.linkW.Text = "W";
            this.linkW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkX
            // 
            this.linkX.AutoSize = true;
            this.linkX.Location = new System.Drawing.Point(116, 33);
            this.linkX.Margin = new System.Windows.Forms.Padding(5);
            this.linkX.Name = "linkX";
            this.linkX.Size = new System.Drawing.Size(14, 13);
            this.linkX.TabIndex = 23;
            this.linkX.TabStop = true;
            this.linkX.Text = "X";
            this.linkX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkY
            // 
            this.linkY.AutoSize = true;
            this.linkY.Location = new System.Drawing.Point(140, 33);
            this.linkY.Margin = new System.Windows.Forms.Padding(5);
            this.linkY.Name = "linkY";
            this.linkY.Size = new System.Drawing.Size(14, 13);
            this.linkY.TabIndex = 24;
            this.linkY.TabStop = true;
            this.linkY.Text = "Y";
            this.linkY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // linkZ
            // 
            this.linkZ.AutoSize = true;
            this.linkZ.Location = new System.Drawing.Point(164, 33);
            this.linkZ.Margin = new System.Windows.Forms.Padding(5);
            this.linkZ.Name = "linkZ";
            this.linkZ.Size = new System.Drawing.Size(14, 13);
            this.linkZ.TabIndex = 25;
            this.linkZ.TabStop = true;
            this.linkZ.Text = "Z";
            this.linkZ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLetters_LinkClicked);
            // 
            // btnAddNewWordType
            // 
            this.btnAddNewWordType.AutoSize = true;
            this.btnAddNewWordType.BackgroundImage = global::VocabularyProNamespace.Properties.Resources.add;
            this.btnAddNewWordType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewWordType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewWordType.FlatAppearance.BorderSize = 0;
            this.btnAddNewWordType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewWordType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewWordType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewWordType.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewWordType.Location = new System.Drawing.Point(467, 130);
            this.btnAddNewWordType.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewWordType.Name = "btnAddNewWordType";
            this.btnAddNewWordType.Size = new System.Drawing.Size(14, 14);
            this.btnAddNewWordType.TabIndex = 18;
            this.btnAddNewWordType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewWordType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnAddNewWordType, "Add new word type");
            this.btnAddNewWordType.UseVisualStyleBackColor = false;
            this.btnAddNewWordType.Click += new System.EventHandler(this.btnAddNewWordType_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(467, 110);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(14, 14);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.TabStop = false;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete this word");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit.Location = new System.Drawing.Point(467, 91);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(14, 13);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.TabStop = false;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit this word");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FlashCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbMainContainer);
            this.Name = "FlashCard";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 0, 0);
            this.Size = new System.Drawing.Size(503, 470);
            this.Load += new System.EventHandler(this.FlashCard_Load);
            this.gbWordContainer.ResumeLayout(false);
            this.gbMainContainer.ResumeLayout(false);
            this.gbMainContainer.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.gbButtons.PerformLayout();
            this.gbLetters.ResumeLayout(false);
            this.flpLetters.ResumeLayout(false);
            this.flpLetters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWordContainer;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbMainContainer;
        private System.Windows.Forms.GroupBox gbLetters;
        private System.Windows.Forms.FlowLayoutPanel flpLetters;
        private System.Windows.Forms.LinkLabel linkA;
        private System.Windows.Forms.LinkLabel linkB;
        private System.Windows.Forms.LinkLabel linkC;
        private System.Windows.Forms.LinkLabel linkD;
        private System.Windows.Forms.LinkLabel linkE;
        private System.Windows.Forms.LinkLabel linkF;
        private System.Windows.Forms.LinkLabel linkG;
        private System.Windows.Forms.LinkLabel linkH;
        private System.Windows.Forms.LinkLabel linkI;
        private System.Windows.Forms.LinkLabel linkJ;
        private System.Windows.Forms.LinkLabel linkK;
        private System.Windows.Forms.LinkLabel linkL;
        private System.Windows.Forms.LinkLabel linkM;
        private System.Windows.Forms.LinkLabel linkN;
        private System.Windows.Forms.LinkLabel linkO;
        private System.Windows.Forms.LinkLabel linkP;
        private System.Windows.Forms.LinkLabel linkQ;
        private System.Windows.Forms.LinkLabel linkR;
        private System.Windows.Forms.LinkLabel linkS;
        private System.Windows.Forms.LinkLabel linkT;
        private System.Windows.Forms.LinkLabel linkU;
        private System.Windows.Forms.LinkLabel linkV;
        private System.Windows.Forms.LinkLabel linkW;
        private System.Windows.Forms.LinkLabel linkX;
        private System.Windows.Forms.LinkLabel linkY;
        private System.Windows.Forms.LinkLabel linkZ;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.TabControl tabWord;
        private System.Windows.Forms.Button btnAddNewWordType;
    }
}
