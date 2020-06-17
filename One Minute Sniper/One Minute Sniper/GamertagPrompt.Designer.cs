namespace One_Minute_Sniper
{
    partial class GamertagPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamertagPrompt));
            this.label1 = new System.Windows.Forms.Label();
            this.tbGamertag = new System.Windows.Forms.TextBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.lbLenMessage = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Arabic UI", 9.749999F);
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your gamertag:";
            // 
            // tbGamertag
            // 
            this.tbGamertag.Location = new System.Drawing.Point(31, 84);
            this.tbGamertag.MaxLength = 12;
            this.tbGamertag.Name = "tbGamertag";
            this.tbGamertag.Size = new System.Drawing.Size(269, 20);
            this.tbGamertag.TabIndex = 1;
            this.tbGamertag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGamertag_KeyPress);
            // 
            // OKbtn
            // 
            this.OKbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OKbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.OKbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.OKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbtn.Location = new System.Drawing.Point(125, 136);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(89, 34);
            this.OKbtn.TabIndex = 2;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            this.OKbtn.MouseEnter += new System.EventHandler(this.OKbtn_MouseEnter);
            this.OKbtn.MouseLeave += new System.EventHandler(this.OKbtn_MouseLeave);
            // 
            // lbLenMessage
            // 
            this.lbLenMessage.AutoSize = true;
            this.lbLenMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLenMessage.Location = new System.Drawing.Point(28, 28);
            this.lbLenMessage.Name = "lbLenMessage";
            this.lbLenMessage.Size = new System.Drawing.Size(233, 13);
            this.lbLenMessage.TabIndex = 3;
            this.lbLenMessage.Text = "*Gamertag length must be 12 or less characters.";
            this.lbLenMessage.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GamertagPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 218);
            this.Controls.Add(this.lbLenMessage);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.tbGamertag);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GamertagPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamertag Prompt";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGamertag;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Label lbLenMessage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}