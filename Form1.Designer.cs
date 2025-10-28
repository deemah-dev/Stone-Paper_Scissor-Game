namespace StonePaperScissorGameWinForm
{
    partial class Form1
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
            this.airForm1 = new ReaLTaiizor.Forms.AirForm();
            this.hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            this.tabPGame = new System.Windows.Forms.TabPage();
            this.numRounds = new ReaLTaiizor.Controls.CrownNumeric();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.btnStartGame = new ReaLTaiizor.Controls.Button();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.tabPPlay = new System.Windows.Forms.TabPage();
            this.lblRound = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit7 = new ReaLTaiizor.Controls.LabelEdit();
            this.lblComputerChoice = new ReaLTaiizor.Controls.LabelEdit();
            this.lblPlayerChoice = new ReaLTaiizor.Controls.LabelEdit();
            this.btnNext = new ReaLTaiizor.Controls.Button();
            this.labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.btnScissor = new ReaLTaiizor.Controls.Button();
            this.btnPaper = new ReaLTaiizor.Controls.Button();
            this.btnStone = new ReaLTaiizor.Controls.Button();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.tabPResult = new System.Windows.Forms.TabPage();
            this.lblFinalWinner = new ReaLTaiizor.Controls.LabelEdit();
            this.lblDrawTimes = new ReaLTaiizor.Controls.LabelEdit();
            this.lblComputerWonTimes = new ReaLTaiizor.Controls.LabelEdit();
            this.lblPlayerWonTimes = new ReaLTaiizor.Controls.LabelEdit();
            this.lblRoundsNumber = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit13 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit12 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit11 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit10 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit9 = new ReaLTaiizor.Controls.LabelEdit();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.WaitForComputerChoice = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.airForm1.SuspendLayout();
            this.hopeTabPage1.SuspendLayout();
            this.tabPGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRounds)).BeginInit();
            this.tabPPlay.SuspendLayout();
            this.tabPResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // airForm1
            // 
            this.airForm1.BackColor = System.Drawing.Color.White;
            this.airForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.airForm1.Controls.Add(this.hopeTabPage1);
            this.airForm1.Customization = "AAAA/1paWv9ycnL/";
            this.airForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airForm1.Image = null;
            this.airForm1.Location = new System.Drawing.Point(0, 0);
            this.airForm1.MinimumSize = new System.Drawing.Size(112, 35);
            this.airForm1.Movable = true;
            this.airForm1.Name = "airForm1";
            this.airForm1.NoRounding = false;
            this.airForm1.Sizable = true;
            this.airForm1.Size = new System.Drawing.Size(566, 589);
            this.airForm1.SmartBounds = true;
            this.airForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.airForm1.TabIndex = 0;
            this.airForm1.Text = "Stone Paper Scissor Game";
            this.airForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.Transparent = false;
            // 
            // hopeTabPage1
            // 
            this.hopeTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTabPage1.Controls.Add(this.tabPGame);
            this.hopeTabPage1.Controls.Add(this.tabPPlay);
            this.hopeTabPage1.Controls.Add(this.tabPResult);
            this.hopeTabPage1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeTabPage1.ForeColorA = System.Drawing.Color.Silver;
            this.hopeTabPage1.ForeColorB = System.Drawing.Color.Gray;
            this.hopeTabPage1.ForeColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeTabPage1.ItemSize = new System.Drawing.Size(120, 40);
            this.hopeTabPage1.Location = new System.Drawing.Point(12, 40);
            this.hopeTabPage1.Name = "hopeTabPage1";
            this.hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopeTabPage1.SelectedIndex = 0;
            this.hopeTabPage1.Size = new System.Drawing.Size(542, 537);
            this.hopeTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopeTabPage1.TabIndex = 2;
            this.hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hopeTabPage1.ThemeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTabPage1.ThemeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabPGame
            // 
            this.tabPGame.Controls.Add(this.numRounds);
            this.tabPGame.Controls.Add(this.labelEdit1);
            this.tabPGame.Controls.Add(this.btnStartGame);
            this.tabPGame.Controls.Add(this.bigLabel1);
            this.tabPGame.Location = new System.Drawing.Point(0, 40);
            this.tabPGame.Name = "tabPGame";
            this.tabPGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPGame.Size = new System.Drawing.Size(542, 497);
            this.tabPGame.TabIndex = 0;
            this.tabPGame.Text = "Game";
            this.tabPGame.UseVisualStyleBackColor = true;
            // 
            // numRounds
            // 
            this.numRounds.AutoSize = true;
            this.numRounds.Location = new System.Drawing.Point(227, 218);
            this.numRounds.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRounds.Name = "numRounds";
            this.numRounds.Size = new System.Drawing.Size(70, 34);
            this.numRounds.TabIndex = 3;
            this.numRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRounds.ValueChanged += new System.EventHandler(this.numRounds_ValueChanged);
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit1.Location = new System.Drawing.Point(88, 116);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(355, 27);
            this.labelEdit1.TabIndex = 2;
            this.labelEdit1.Text = "Choose How Many Round";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartGame.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStartGame.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Image = null;
            this.btnStartGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartGame.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStartGame.Location = new System.Drawing.Point(93, 374);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartGame.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartGame.Size = new System.Drawing.Size(358, 79);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(187, 31);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(157, 50);
            this.bigLabel1.TabIndex = 1;
            this.bigLabel1.Text = "Game";
            // 
            // tabPPlay
            // 
            this.tabPPlay.Controls.Add(this.WaitForComputerChoice);
            this.tabPPlay.Controls.Add(this.lblRound);
            this.tabPPlay.Controls.Add(this.labelEdit7);
            this.tabPPlay.Controls.Add(this.lblComputerChoice);
            this.tabPPlay.Controls.Add(this.lblPlayerChoice);
            this.tabPPlay.Controls.Add(this.btnNext);
            this.tabPPlay.Controls.Add(this.labelEdit4);
            this.tabPPlay.Controls.Add(this.labelEdit3);
            this.tabPPlay.Controls.Add(this.btnScissor);
            this.tabPPlay.Controls.Add(this.btnPaper);
            this.tabPPlay.Controls.Add(this.btnStone);
            this.tabPPlay.Controls.Add(this.labelEdit2);
            this.tabPPlay.Controls.Add(this.bigLabel2);
            this.tabPPlay.Location = new System.Drawing.Point(0, 40);
            this.tabPPlay.Name = "tabPPlay";
            this.tabPPlay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPPlay.Size = new System.Drawing.Size(542, 497);
            this.tabPPlay.TabIndex = 1;
            this.tabPPlay.Text = "Play";
            this.tabPPlay.UseVisualStyleBackColor = true;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.BackColor = System.Drawing.Color.Transparent;
            this.lblRound.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblRound.Location = new System.Drawing.Point(110, 43);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(28, 27);
            this.lblRound.TabIndex = 13;
            this.lblRound.Text = "0";
            // 
            // labelEdit7
            // 
            this.labelEdit7.AutoSize = true;
            this.labelEdit7.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit7.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit7.Location = new System.Drawing.Point(6, 43);
            this.labelEdit7.Name = "labelEdit7";
            this.labelEdit7.Size = new System.Drawing.Size(98, 27);
            this.labelEdit7.TabIndex = 12;
            this.labelEdit7.Text = "Round";
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.AutoSize = true;
            this.lblComputerChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerChoice.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblComputerChoice.Location = new System.Drawing.Point(284, 389);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(247, 27);
            this.lblComputerChoice.TabIndex = 11;
            this.lblComputerChoice.Text = "Computer Choice";
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblPlayerChoice.Location = new System.Drawing.Point(284, 342);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(178, 27);
            this.lblPlayerChoice.TabIndex = 10;
            this.lblPlayerChoice.Text = "Your Choice";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnNext.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = null;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnNext.Location = new System.Drawing.Point(38, 429);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.Size = new System.Drawing.Size(269, 49);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelEdit4
            // 
            this.labelEdit4.AutoSize = true;
            this.labelEdit4.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit4.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit4.Location = new System.Drawing.Point(33, 389);
            this.labelEdit4.Name = "labelEdit4";
            this.labelEdit4.Size = new System.Drawing.Size(247, 27);
            this.labelEdit4.TabIndex = 8;
            this.labelEdit4.Text = "Computer Choice";
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit3.Location = new System.Drawing.Point(33, 342);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(204, 27);
            this.labelEdit3.TabIndex = 7;
            this.labelEdit3.Text = "Player Choice";
            // 
            // btnScissor
            // 
            this.btnScissor.BackColor = System.Drawing.Color.Transparent;
            this.btnScissor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnScissor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScissor.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnScissor.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnScissor.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissor.Image = null;
            this.btnScissor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScissor.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnScissor.Location = new System.Drawing.Point(174, 235);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnScissor.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnScissor.Size = new System.Drawing.Size(194, 79);
            this.btnScissor.TabIndex = 6;
            this.btnScissor.Text = "Scissor";
            this.btnScissor.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnScissor.Click += new System.EventHandler(this.PlayerChoice_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.Transparent;
            this.btnPaper.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaper.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPaper.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnPaper.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Image = null;
            this.btnPaper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaper.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnPaper.Location = new System.Drawing.Point(268, 150);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPaper.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPaper.Size = new System.Drawing.Size(155, 79);
            this.btnPaper.TabIndex = 5;
            this.btnPaper.Text = "Paper";
            this.btnPaper.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPaper.Click += new System.EventHandler(this.PlayerChoice_Click);
            // 
            // btnStone
            // 
            this.btnStone.BackColor = System.Drawing.Color.Transparent;
            this.btnStone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStone.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStone.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStone.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStone.Image = null;
            this.btnStone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStone.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStone.Location = new System.Drawing.Point(98, 150);
            this.btnStone.Name = "btnStone";
            this.btnStone.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStone.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStone.Size = new System.Drawing.Size(164, 79);
            this.btnStone.TabIndex = 4;
            this.btnStone.Text = "Stone";
            this.btnStone.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnStone.Click += new System.EventHandler(this.PlayerChoice_Click);
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit2.Location = new System.Drawing.Point(169, 100);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(188, 27);
            this.labelEdit2.TabIndex = 3;
            this.labelEdit2.Text = "Make Choice";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(192, 20);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(135, 50);
            this.bigLabel2.TabIndex = 2;
            this.bigLabel2.Text = "Play";
            // 
            // tabPResult
            // 
            this.tabPResult.Controls.Add(this.lblFinalWinner);
            this.tabPResult.Controls.Add(this.lblDrawTimes);
            this.tabPResult.Controls.Add(this.lblComputerWonTimes);
            this.tabPResult.Controls.Add(this.lblPlayerWonTimes);
            this.tabPResult.Controls.Add(this.lblRoundsNumber);
            this.tabPResult.Controls.Add(this.labelEdit13);
            this.tabPResult.Controls.Add(this.labelEdit12);
            this.tabPResult.Controls.Add(this.labelEdit11);
            this.tabPResult.Controls.Add(this.labelEdit10);
            this.tabPResult.Controls.Add(this.labelEdit9);
            this.tabPResult.Controls.Add(this.bigLabel3);
            this.tabPResult.Location = new System.Drawing.Point(0, 40);
            this.tabPResult.Name = "tabPResult";
            this.tabPResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPResult.Size = new System.Drawing.Size(542, 497);
            this.tabPResult.TabIndex = 2;
            this.tabPResult.Text = "Result";
            this.tabPResult.UseVisualStyleBackColor = true;
            // 
            // lblFinalWinner
            // 
            this.lblFinalWinner.AutoSize = true;
            this.lblFinalWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalWinner.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblFinalWinner.Location = new System.Drawing.Point(334, 409);
            this.lblFinalWinner.Name = "lblFinalWinner";
            this.lblFinalWinner.Size = new System.Drawing.Size(28, 27);
            this.lblFinalWinner.TabIndex = 13;
            this.lblFinalWinner.Text = "0";
            // 
            // lblDrawTimes
            // 
            this.lblDrawTimes.AutoSize = true;
            this.lblDrawTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblDrawTimes.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblDrawTimes.Location = new System.Drawing.Point(334, 338);
            this.lblDrawTimes.Name = "lblDrawTimes";
            this.lblDrawTimes.Size = new System.Drawing.Size(28, 27);
            this.lblDrawTimes.TabIndex = 12;
            this.lblDrawTimes.Text = "0";
            // 
            // lblComputerWonTimes
            // 
            this.lblComputerWonTimes.AutoSize = true;
            this.lblComputerWonTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerWonTimes.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWonTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblComputerWonTimes.Location = new System.Drawing.Point(334, 266);
            this.lblComputerWonTimes.Name = "lblComputerWonTimes";
            this.lblComputerWonTimes.Size = new System.Drawing.Size(28, 27);
            this.lblComputerWonTimes.TabIndex = 11;
            this.lblComputerWonTimes.Text = "0";
            // 
            // lblPlayerWonTimes
            // 
            this.lblPlayerWonTimes.AutoSize = true;
            this.lblPlayerWonTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerWonTimes.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWonTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblPlayerWonTimes.Location = new System.Drawing.Point(334, 190);
            this.lblPlayerWonTimes.Name = "lblPlayerWonTimes";
            this.lblPlayerWonTimes.Size = new System.Drawing.Size(28, 27);
            this.lblPlayerWonTimes.TabIndex = 10;
            this.lblPlayerWonTimes.Text = "0";
            // 
            // lblRoundsNumber
            // 
            this.lblRoundsNumber.AutoSize = true;
            this.lblRoundsNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundsNumber.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundsNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblRoundsNumber.Location = new System.Drawing.Point(334, 121);
            this.lblRoundsNumber.Name = "lblRoundsNumber";
            this.lblRoundsNumber.Size = new System.Drawing.Size(28, 27);
            this.lblRoundsNumber.TabIndex = 9;
            this.lblRoundsNumber.Text = "0";
            // 
            // labelEdit13
            // 
            this.labelEdit13.AutoSize = true;
            this.labelEdit13.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit13.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit13.Location = new System.Drawing.Point(19, 409);
            this.labelEdit13.Name = "labelEdit13";
            this.labelEdit13.Size = new System.Drawing.Size(192, 27);
            this.labelEdit13.TabIndex = 8;
            this.labelEdit13.Text = "Final Winner";
            // 
            // labelEdit12
            // 
            this.labelEdit12.AutoSize = true;
            this.labelEdit12.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit12.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit12.Location = new System.Drawing.Point(19, 338);
            this.labelEdit12.Name = "labelEdit12";
            this.labelEdit12.Size = new System.Drawing.Size(183, 27);
            this.labelEdit12.TabIndex = 7;
            this.labelEdit12.Text = "Draw Times";
            // 
            // labelEdit11
            // 
            this.labelEdit11.AutoSize = true;
            this.labelEdit11.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit11.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit11.Location = new System.Drawing.Point(19, 266);
            this.labelEdit11.Name = "labelEdit11";
            this.labelEdit11.Size = new System.Drawing.Size(311, 27);
            this.labelEdit11.TabIndex = 6;
            this.labelEdit11.Text = "Computer Won Times";
            // 
            // labelEdit10
            // 
            this.labelEdit10.AutoSize = true;
            this.labelEdit10.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit10.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit10.Location = new System.Drawing.Point(19, 190);
            this.labelEdit10.Name = "labelEdit10";
            this.labelEdit10.Size = new System.Drawing.Size(268, 27);
            this.labelEdit10.TabIndex = 5;
            this.labelEdit10.Text = "Player Won Times";
            // 
            // labelEdit9
            // 
            this.labelEdit9.AutoSize = true;
            this.labelEdit9.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit9.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit9.Location = new System.Drawing.Point(19, 121);
            this.labelEdit9.Name = "labelEdit9";
            this.labelEdit9.Size = new System.Drawing.Size(231, 27);
            this.labelEdit9.TabIndex = 4;
            this.labelEdit9.Text = "Rounds Number";
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel3.Location = new System.Drawing.Point(176, 34);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(195, 50);
            this.bigLabel3.TabIndex = 2;
            this.bigLabel3.Text = "Result";
            // 
            // WaitForComputerChoice
            // 
            this.WaitForComputerChoice.AutoStart = true;
            this.WaitForComputerChoice.Location = new System.Drawing.Point(289, 389);
            this.WaitForComputerChoice.Name = "WaitForComputerChoice";
            this.WaitForComputerChoice.ProgressColor = System.Drawing.Color.Black;
            this.WaitForComputerChoice.Size = new System.Drawing.Size(36, 40);
            this.WaitForComputerChoice.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 589);
            this.Controls.Add(this.airForm1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(112, 35);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.ResumeLayout(false);
            this.hopeTabPage1.ResumeLayout(false);
            this.tabPGame.ResumeLayout(false);
            this.tabPGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRounds)).EndInit();
            this.tabPPlay.ResumeLayout(false);
            this.tabPPlay.PerformLayout();
            this.tabPResult.ResumeLayout(false);
            this.tabPResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.Button btnStartGame;
        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private System.Windows.Forms.TabPage tabPGame;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.TabPage tabPPlay;
        private System.Windows.Forms.TabPage tabPResult;
        private ReaLTaiizor.Controls.CrownNumeric numRounds;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.Button btnScissor;
        private ReaLTaiizor.Controls.Button btnPaper;
        private ReaLTaiizor.Controls.Button btnStone;
        private ReaLTaiizor.Controls.LabelEdit lblRound;
        private ReaLTaiizor.Controls.LabelEdit labelEdit7;
        private ReaLTaiizor.Controls.LabelEdit lblComputerChoice;
        private ReaLTaiizor.Controls.LabelEdit lblPlayerChoice;
        private ReaLTaiizor.Controls.Button btnNext;
        private ReaLTaiizor.Controls.LabelEdit lblFinalWinner;
        private ReaLTaiizor.Controls.LabelEdit lblDrawTimes;
        private ReaLTaiizor.Controls.LabelEdit lblComputerWonTimes;
        private ReaLTaiizor.Controls.LabelEdit lblPlayerWonTimes;
        private ReaLTaiizor.Controls.LabelEdit lblRoundsNumber;
        private ReaLTaiizor.Controls.LabelEdit labelEdit13;
        private ReaLTaiizor.Controls.LabelEdit labelEdit12;
        private ReaLTaiizor.Controls.LabelEdit labelEdit11;
        private ReaLTaiizor.Controls.LabelEdit labelEdit10;
        private ReaLTaiizor.Controls.LabelEdit labelEdit9;
        private Guna.UI2.WinForms.Guna2ProgressIndicator WaitForComputerChoice;
    }
}

