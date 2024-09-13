namespace Games_Club
{
    partial class fmPaperRockScissors
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPaperRockScissors));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Prepare = new System.Windows.Forms.TabPage();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.nRounds = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Play = new System.Windows.Forms.TabPage();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lbWinner = new System.Windows.Forms.Label();
            this.lbDraws = new System.Windows.Forms.Label();
            this.lbLoses = new System.Windows.Forms.Label();
            this.lbWins = new System.Windows.Forms.Label();
            this.lbRounds = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbComputer = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbPlayer1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCurrentRound = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbBack = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.Prepare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRounds)).BeginInit();
            this.Play.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Prepare);
            this.tabControl1.Controls.Add(this.Play);
            this.tabControl1.Location = new System.Drawing.Point(-6, -31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 780);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Prepare
            // 
            this.Prepare.BackColor = System.Drawing.Color.White;
            this.Prepare.Controls.Add(this.tbName);
            this.Prepare.Controls.Add(this.nRounds);
            this.Prepare.Controls.Add(this.label3);
            this.Prepare.Controls.Add(this.label2);
            this.Prepare.Controls.Add(this.label1);
            this.Prepare.Controls.Add(this.btnPlay);
            this.Prepare.Location = new System.Drawing.Point(4, 28);
            this.Prepare.Name = "Prepare";
            this.Prepare.Padding = new System.Windows.Forms.Padding(3);
            this.Prepare.Size = new System.Drawing.Size(639, 748);
            this.Prepare.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbName.BorderRadius = 10;
            this.tbName.BorderThickness = 2;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.FocusedState.Parent = this.tbName;
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.Location = new System.Drawing.Point(288, 225);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            this.tbName.Size = new System.Drawing.Size(127, 32);
            this.tbName.TabIndex = 26;
            // 
            // nRounds
            // 
            this.nRounds.BackColor = System.Drawing.Color.Transparent;
            this.nRounds.BorderColor = System.Drawing.Color.Transparent;
            this.nRounds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nRounds.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nRounds.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nRounds.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nRounds.DisabledState.Parent = this.nRounds;
            this.nRounds.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nRounds.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nRounds.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nRounds.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nRounds.FocusedState.Parent = this.nRounds;
            this.nRounds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRounds.ForeColor = System.Drawing.Color.Black;
            this.nRounds.Location = new System.Drawing.Point(370, 166);
            this.nRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRounds.Name = "nRounds";
            this.nRounds.ShadowDecoration.Parent = this.nRounds;
            this.nRounds.Size = new System.Drawing.Size(127, 32);
            this.nRounds.TabIndex = 25;
            this.nRounds.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(77, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Enter  Your  Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(77, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Choose  the  number  of  rounds :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 63);
            this.label1.TabIndex = 22;
            this.label1.Text = "Paper Rock Scissors";
            // 
            // btnPlay
            // 
            this.btnPlay.CheckedState.Parent = this.btnPlay;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.CustomImages.Parent = this.btnPlay;
            this.btnPlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPlay.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.HoverState.Parent = this.btnPlay;
            this.btnPlay.Location = new System.Drawing.Point(142, 346);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPlay.ShadowDecoration.Parent = this.btnPlay;
            this.btnPlay.Size = new System.Drawing.Size(242, 196);
            this.btnPlay.TabIndex = 21;
            this.btnPlay.Text = "Play";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Lime;
            this.Play.Controls.Add(this.gbStatus);
            this.Play.Controls.Add(this.pbComputer);
            this.Play.Controls.Add(this.pbPlayer1);
            this.Play.Controls.Add(this.label8);
            this.Play.Controls.Add(this.lbName);
            this.Play.Controls.Add(this.btnScissors);
            this.Play.Controls.Add(this.btnPaper);
            this.Play.Controls.Add(this.btnRock);
            this.Play.Controls.Add(this.label6);
            this.Play.Controls.Add(this.lbCurrentRound);
            this.Play.Controls.Add(this.label4);
            this.Play.Controls.Add(this.pbBack);
            this.Play.Cursor = System.Windows.Forms.Cursors.Default;
            this.Play.Location = new System.Drawing.Point(4, 28);
            this.Play.Name = "Play";
            this.Play.Padding = new System.Windows.Forms.Padding(3);
            this.Play.Size = new System.Drawing.Size(639, 748);
            this.Play.TabIndex = 1;
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbStatus.Controls.Add(this.lbWinner);
            this.gbStatus.Controls.Add(this.lbDraws);
            this.gbStatus.Controls.Add(this.lbLoses);
            this.gbStatus.Controls.Add(this.lbWins);
            this.gbStatus.Controls.Add(this.lbRounds);
            this.gbStatus.Controls.Add(this.label13);
            this.gbStatus.Controls.Add(this.label12);
            this.gbStatus.Controls.Add(this.label11);
            this.gbStatus.Controls.Add(this.label10);
            this.gbStatus.Controls.Add(this.label9);
            this.gbStatus.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(6, 381);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(627, 329);
            this.gbStatus.TabIndex = 11;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.Location = new System.Drawing.Point(297, 284);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(147, 24);
            this.lbWinner.TabIndex = 9;
            this.lbWinner.Text = "On Progressing";
            // 
            // lbDraws
            // 
            this.lbDraws.AutoSize = true;
            this.lbDraws.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDraws.Location = new System.Drawing.Point(297, 226);
            this.lbDraws.Name = "lbDraws";
            this.lbDraws.Size = new System.Drawing.Size(21, 24);
            this.lbDraws.TabIndex = 8;
            this.lbDraws.Text = "0";
            // 
            // lbLoses
            // 
            this.lbLoses.AutoSize = true;
            this.lbLoses.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoses.Location = new System.Drawing.Point(297, 168);
            this.lbLoses.Name = "lbLoses";
            this.lbLoses.Size = new System.Drawing.Size(21, 24);
            this.lbLoses.TabIndex = 7;
            this.lbLoses.Text = "0";
            // 
            // lbWins
            // 
            this.lbWins.AutoSize = true;
            this.lbWins.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWins.Location = new System.Drawing.Point(297, 110);
            this.lbWins.Name = "lbWins";
            this.lbWins.Size = new System.Drawing.Size(21, 24);
            this.lbWins.TabIndex = 6;
            this.lbWins.Text = "0";
            // 
            // lbRounds
            // 
            this.lbRounds.AutoSize = true;
            this.lbRounds.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRounds.Location = new System.Drawing.Point(297, 52);
            this.lbRounds.Name = "lbRounds";
            this.lbRounds.Size = new System.Drawing.Size(21, 24);
            this.lbRounds.TabIndex = 5;
            this.lbRounds.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "The Winner           : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 24);
            this.label12.TabIndex = 3;
            this.label12.Text = "Draws                     : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Loses                      : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Wins                       :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Game Rounds       : ";
            // 
            // pbComputer
            // 
            this.pbComputer.Image = ((System.Drawing.Image)(resources.GetObject("pbComputer.Image")));
            this.pbComputer.Location = new System.Drawing.Point(401, 251);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.ShadowDecoration.Parent = this.pbComputer;
            this.pbComputer.Size = new System.Drawing.Size(97, 85);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputer.TabIndex = 10;
            this.pbComputer.TabStop = false;
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.Image = global::Games_Club.Properties.Resources.question;
            this.pbPlayer1.Location = new System.Drawing.Point(77, 251);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.ShadowDecoration.Parent = this.pbPlayer1;
            this.pbPlayer1.Size = new System.Drawing.Size(97, 85);
            this.pbPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer1.TabIndex = 9;
            this.pbPlayer1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Computer";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(85, 203);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(104, 31);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Player1";
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.Silver;
            this.btnScissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScissors.FlatAppearance.BorderSize = 0;
            this.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScissors.Location = new System.Drawing.Point(386, 133);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(163, 44);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.Silver;
            this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaper.FlatAppearance.BorderSize = 0;
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaper.Location = new System.Drawing.Point(198, 133);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(163, 44);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.Silver;
            this.btnRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRock.FlatAppearance.BorderSize = 0;
            this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRock.Location = new System.Drawing.Point(12, 133);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(163, 44);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "What do you choose?";
            // 
            // lbCurrentRound
            // 
            this.lbCurrentRound.AutoSize = true;
            this.lbCurrentRound.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentRound.Location = new System.Drawing.Point(540, 6);
            this.lbCurrentRound.Name = "lbCurrentRound";
            this.lbCurrentRound.Size = new System.Drawing.Size(20, 22);
            this.lbCurrentRound.TabIndex = 2;
            this.lbCurrentRound.Text = "1";
            this.lbCurrentRound.TextChanged += new System.EventHandler(this.lbCurrentRound_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "This is round :";
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(6, 6);
            this.pbBack.Name = "pbBack";
            this.pbBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbBack.ShadowDecoration.Parent = this.pbBack;
            this.pbBack.Size = new System.Drawing.Size(45, 41);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 0;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fmPaperRockScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 743);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmPaperRockScissors";
            this.Text = "Paper Rock Scissors";
            this.Load += new System.EventHandler(this.fmPaperRockScissors_Load);
            this.tabControl1.ResumeLayout(false);
            this.Prepare.ResumeLayout(false);
            this.Prepare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRounds)).EndInit();
            this.Play.ResumeLayout(false);
            this.Play.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Prepare;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private Guna.UI2.WinForms.Guna2NumericUpDown nRounds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton btnPlay;
        private System.Windows.Forms.TabPage Play;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCurrentRound;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2PictureBox pbPlayer1;
        private Guna.UI2.WinForms.Guna2PictureBox pbComputer;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbRounds;
        private System.Windows.Forms.Label lbWins;
        private System.Windows.Forms.Label lbDraws;
        private System.Windows.Forms.Label lbLoses;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}