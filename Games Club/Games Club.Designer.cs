namespace Games_Club
{
    partial class fmGamesClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmGamesClub));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PaperRockScissors = new System.Windows.Forms.PictureBox();
            this.WordsOfWonders = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperRockScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordsOfWonders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(118, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Games Club";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(28, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose  The  game  you  want  to  play";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(624, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PaperRockScissors
            // 
            this.PaperRockScissors.BackColor = System.Drawing.Color.Transparent;
            this.PaperRockScissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaperRockScissors.Image = ((System.Drawing.Image)(resources.GetObject("PaperRockScissors.Image")));
            this.PaperRockScissors.Location = new System.Drawing.Point(634, 372);
            this.PaperRockScissors.Name = "PaperRockScissors";
            this.PaperRockScissors.Size = new System.Drawing.Size(288, 238);
            this.PaperRockScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaperRockScissors.TabIndex = 3;
            this.PaperRockScissors.TabStop = false;
            this.PaperRockScissors.Click += new System.EventHandler(this.PaperRockScissors_Click);
            // 
            // WordsOfWonders
            // 
            this.WordsOfWonders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WordsOfWonders.Image = ((System.Drawing.Image)(resources.GetObject("WordsOfWonders.Image")));
            this.WordsOfWonders.Location = new System.Drawing.Point(324, 372);
            this.WordsOfWonders.Name = "WordsOfWonders";
            this.WordsOfWonders.Size = new System.Drawing.Size(288, 238);
            this.WordsOfWonders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WordsOfWonders.TabIndex = 4;
            this.WordsOfWonders.TabStop = false;
            this.WordsOfWonders.Click += new System.EventHandler(this.WordsOfWonders_Click);
            // 
            // pb3
            // 
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(12, 372);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(288, 238);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 5;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.Maze_Click);
            // 
            // fmGamesClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(924, 622);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.WordsOfWonders);
            this.Controls.Add(this.PaperRockScissors);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmGamesClub";
            this.Text = "Games Club";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmGamesClub_FormClosing);
            this.Load += new System.EventHandler(this.fmGamesClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperRockScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordsOfWonders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PaperRockScissors;
        private System.Windows.Forms.PictureBox WordsOfWonders;
        private System.Windows.Forms.PictureBox pb3;
    }
}

