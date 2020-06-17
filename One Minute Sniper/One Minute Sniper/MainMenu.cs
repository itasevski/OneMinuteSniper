/*
    Created by: Ivo Tasevski
    * Main Menu form - the starting point of the application. Access to other forms granted.
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
    public partial class MainMenu : Form
    {
        // ==================== INIT ===================== //

        Settings settingsDialog = new Settings();

        // =============================================== //

        public MainMenu()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            Cursor.Show();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            GamertagPrompt GTprompt = new GamertagPrompt(settingsDialog);
            GTprompt.ShowDialog();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            About aboutDialog = new About();
            aboutDialog.ShowDialog();
        }

        private void followUsBtn_Click(object sender, EventArgs e)
        {
            FollowUs followUsDialog = new FollowUs();
            followUsDialog.ShowDialog();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            settingsDialog.ShowDialog();
        }

        private void newGameBtn_MouseEnter(object sender, EventArgs e)
        {
            newGameBtn.ForeColor = Color.White;
        }

        private void newGameBtn_MouseLeave(object sender, EventArgs e)
        {
            newGameBtn.ForeColor = Color.Black;
        }

        private void settingsBtn_MouseEnter(object sender, EventArgs e)
        {
            settingsBtn.ForeColor = Color.White;
        }

        private void settingsBtn_MouseLeave(object sender, EventArgs e)
        {
            settingsBtn.ForeColor = Color.Black;
        }

        private void aboutBtn_MouseEnter(object sender, EventArgs e)
        {
            aboutBtn.ForeColor = Color.White;
        }

        private void aboutBtn_MouseLeave(object sender, EventArgs e)
        {
            aboutBtn.ForeColor = Color.Black;
        }

        private void followUsBtn_MouseEnter(object sender, EventArgs e)
        {
            followUsBtn.ForeColor = Color.White;
        }

        private void followUsBtn_MouseLeave(object sender, EventArgs e)
        {
            followUsBtn.ForeColor = Color.Black;
        }
    }
}
