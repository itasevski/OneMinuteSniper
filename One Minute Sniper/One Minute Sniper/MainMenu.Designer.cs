namespace One_Minute_Sniper
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.newGameBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.followUsBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newGameBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newGameBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.newGameBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.newGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameBtn.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newGameBtn.Location = new System.Drawing.Point(166, 155);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(462, 41);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.TabStop = false;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            this.newGameBtn.MouseEnter += new System.EventHandler(this.newGameBtn_MouseEnter);
            this.newGameBtn.MouseLeave += new System.EventHandler(this.newGameBtn_MouseLeave);
            // 
            // settingsBtn
            // 
            this.settingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.Location = new System.Drawing.Point(166, 237);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(462, 41);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            this.settingsBtn.MouseEnter += new System.EventHandler(this.settingsBtn_MouseEnter);
            this.settingsBtn.MouseLeave += new System.EventHandler(this.settingsBtn_MouseLeave);
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.aboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.aboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Location = new System.Drawing.Point(166, 320);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(462, 41);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.TabStop = false;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            this.aboutBtn.MouseEnter += new System.EventHandler(this.aboutBtn_MouseEnter);
            this.aboutBtn.MouseLeave += new System.EventHandler(this.aboutBtn_MouseLeave);
            // 
            // followUsBtn
            // 
            this.followUsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.followUsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.followUsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.followUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.followUsBtn.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followUsBtn.Location = new System.Drawing.Point(166, 398);
            this.followUsBtn.Name = "followUsBtn";
            this.followUsBtn.Size = new System.Drawing.Size(462, 41);
            this.followUsBtn.TabIndex = 3;
            this.followUsBtn.TabStop = false;
            this.followUsBtn.Text = "Follow us";
            this.followUsBtn.UseVisualStyleBackColor = true;
            this.followUsBtn.Click += new System.EventHandler(this.followUsBtn_Click);
            this.followUsBtn.MouseEnter += new System.EventHandler(this.followUsBtn_MouseEnter);
            this.followUsBtn.MouseLeave += new System.EventHandler(this.followUsBtn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::One_Minute_Sniper.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(136, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVersion.AutoSize = true;
            this.lbVersion.ForeColor = System.Drawing.Color.Black;
            this.lbVersion.Location = new System.Drawing.Point(739, 465);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(69, 13);
            this.lbVersion.TabIndex = 10;
            this.lbVersion.Text = "Version 1.0.0";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(805, 477);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.followUsBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.newGameBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button followUsBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbVersion;
    }
}

