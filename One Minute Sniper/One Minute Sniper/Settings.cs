/*
    Created by: Ivo Tasevski
    * Settings form - Enables the user to customize his enviroment to suit his preferences.
    * Last Revised: 17.06.2020
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Minute_Sniper
{
    public partial class Settings : Form
    {
        // ==================== INIT ===================== //

        string audio = "";
        string reticleStyle = "";
        string reticleColor = "";
        string target = "";
        string background = "";

        public string Audio
        {
            get { return audio; }
        }

        public string ReticleStyle
        {
            get { return reticleStyle; }
        }

        public string ReticleColor
        {
            get { return reticleColor; }
        }

        public string Target
        {
            get { return target; }
        }

        public string Background
        {
            get { return background; }
        }

        // ============================================== //

        public Settings()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            reticleGroupColor.Paint += removeBorders;
        }

        private void removeBorders(object sender, PaintEventArgs p)
        {
            GroupBox grBox = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            saveSettings();
            this.applyBtn.Enabled = false;
        }

        private void saveSettings()
        {
            foreach (Control c in audioGroup.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rbtn = (RadioButton)c;
                    if (rbtn.Checked == true)
                    {
                        audio = rbtn.Text;
                    }
                }
            }
            foreach (Control c in reticleGroup.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rbtn = (RadioButton)c;
                    if (rbtn.Checked == true)
                    {
                        reticleStyle = rbtn.Text;
                    }
                }
            }
            foreach (Control c in reticleGroupColor.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rbtn = (RadioButton)c;
                    if (rbtn.Checked == true)
                    {
                        reticleColor = rbtn.Text;
                    }
                }
            }
            foreach (Control c in targetGroup.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rbtn = (RadioButton)c;
                    if (rbtn.Checked == true)
                    {
                        target = rbtn.Text;
                    }
                }
            }
            foreach (Control c in bgGroup.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rbtn = (RadioButton)c;
                    if (rbtn.Checked == true)
                    {
                        background = rbtn.Text;
                    }
                }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.applyBtn.Enabled = true;
            this.Close();
        }
    }
}
