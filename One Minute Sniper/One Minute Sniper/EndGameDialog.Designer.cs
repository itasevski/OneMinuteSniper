namespace One_Minute_Sniper
{
    partial class EndGameDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGameDialog));
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbHighscore = new System.Windows.Forms.Label();
            this.lbHighscoreBeaten = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yesBtn
            // 
            this.yesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.yesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesBtn.Location = new System.Drawing.Point(42, 206);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(142, 36);
            this.yesBtn.TabIndex = 0;
            this.yesBtn.Text = "YES";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            this.yesBtn.MouseEnter += new System.EventHandler(this.yesBtn_MouseEnter);
            this.yesBtn.MouseLeave += new System.EventHandler(this.yesBtn_MouseLeave);
            // 
            // noBtn
            // 
            this.noBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.noBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.noBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.Location = new System.Drawing.Point(256, 206);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(140, 36);
            this.noBtn.TabIndex = 1;
            this.noBtn.Text = "NO";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            this.noBtn.MouseEnter += new System.EventHandler(this.noBtn_MouseEnter);
            this.noBtn.MouseLeave += new System.EventHandler(this.noBtn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "GAME OVER!";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbScore.Location = new System.Drawing.Point(39, 87);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(42, 17);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "label2";
            // 
            // lbHighscore
            // 
            this.lbHighscore.AutoSize = true;
            this.lbHighscore.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbHighscore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbHighscore.Location = new System.Drawing.Point(39, 117);
            this.lbHighscore.Name = "lbHighscore";
            this.lbHighscore.Size = new System.Drawing.Size(43, 17);
            this.lbHighscore.TabIndex = 4;
            this.lbHighscore.Text = "label3";
            // 
            // lbHighscoreBeaten
            // 
            this.lbHighscoreBeaten.AutoSize = true;
            this.lbHighscoreBeaten.Font = new System.Drawing.Font("Miriam CLM", 14.25F);
            this.lbHighscoreBeaten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbHighscoreBeaten.Location = new System.Drawing.Point(191, 7);
            this.lbHighscoreBeaten.Name = "lbHighscoreBeaten";
            this.lbHighscoreBeaten.Size = new System.Drawing.Size(49, 21);
            this.lbHighscoreBeaten.TabIndex = 5;
            this.lbHighscoreBeaten.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans Cond", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(37, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Start a new game?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::One_Minute_Sniper.Properties.Resources.star21;
            this.pictureBox1.Location = new System.Drawing.Point(15, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // EndGameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 273);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbHighscoreBeaten);
            this.Controls.Add(this.lbHighscore);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndGameDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time is up!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbHighscore;
        private System.Windows.Forms.Label lbHighscoreBeaten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}