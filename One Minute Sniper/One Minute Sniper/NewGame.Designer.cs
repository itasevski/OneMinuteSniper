namespace One_Minute_Sniper
{
    partial class NewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbInstructions = new System.Windows.Forms.Label();
            this.lbGamertag = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbHighScore = new System.Windows.Forms.Label();
            this.lbMultiplier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Miriam Libre", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(1117, 0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(68, 28);
            this.lbTimer.TabIndex = 2;
            this.lbTimer.Text = "01:00";
            this.lbTimer.Resize += new System.EventHandler(this.lbTimer_Resize);
            // 
            // lbInstructions
            // 
            this.lbInstructions.AutoSize = true;
            this.lbInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInstructions.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbInstructions.Location = new System.Drawing.Point(12, 15);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(327, 15);
            this.lbInstructions.TabIndex = 4;
            this.lbInstructions.Text = "Press S to Start, P to Pause, B to go back to the Main Menu";
            // 
            // lbGamertag
            // 
            this.lbGamertag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGamertag.AutoSize = true;
            this.lbGamertag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGamertag.Location = new System.Drawing.Point(1096, 26);
            this.lbGamertag.Name = "lbGamertag";
            this.lbGamertag.Size = new System.Drawing.Size(90, 15);
            this.lbGamertag.TabIndex = 5;
            this.lbGamertag.Text = "Gamertag1234";
            // 
            // lbScore
            // 
            this.lbScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScore.Location = new System.Drawing.Point(1097, 45);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(52, 15);
            this.lbScore.TabIndex = 6;
            this.lbScore.Text = "SCORE:";
            // 
            // lbHighScore
            // 
            this.lbHighScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHighScore.AutoSize = true;
            this.lbHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHighScore.Location = new System.Drawing.Point(1063, 63);
            this.lbHighScore.Name = "lbHighScore";
            this.lbHighScore.Size = new System.Drawing.Size(85, 15);
            this.lbHighScore.TabIndex = 7;
            this.lbHighScore.Text = "HIGH SCORE:";
            // 
            // lbMultiplier
            // 
            this.lbMultiplier.AutoSize = true;
            this.lbMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMultiplier.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbMultiplier.Location = new System.Drawing.Point(1080, 81);
            this.lbMultiplier.Name = "lbMultiplier";
            this.lbMultiplier.Size = new System.Drawing.Size(58, 15);
            this.lbMultiplier.TabIndex = 8;
            this.lbMultiplier.Text = "Multiplier";
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lbMultiplier);
            this.Controls.Add(this.lbHighScore);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbGamertag);
            this.Controls.Add(this.lbInstructions);
            this.Controls.Add(this.lbTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NewGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewGame_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NewGame_MouseClick);
            this.MouseEnter += new System.EventHandler(this.NewGame_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NewGame_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewGame_MouseMove);
            this.Resize += new System.EventHandler(this.NewGame_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbInstructions;
        private System.Windows.Forms.Label lbGamertag;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbHighScore;
        private System.Windows.Forms.Label lbMultiplier;
    }
}