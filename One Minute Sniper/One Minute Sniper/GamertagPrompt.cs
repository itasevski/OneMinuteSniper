/*
    Created by: Ivo Tasevski
    * Gamertag Prompt form - Enables the user to use a custom gamertag.
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
using System.IO;

namespace One_Minute_Sniper
{
    public partial class GamertagPrompt : Form
    {
        // ================ INIT ================ //

        int charCounter = 0;
        string gamertag = null;
        int highScore = 0;

        public string Gamertag
        {
            get { return gamertag; }
        }

        public int HighScore
        {
            get { return highScore; }
            set { highScore = value; }
        }

        private Settings settingsDialog = null;

        public Settings SettingsForm
        {
            get { return settingsDialog; }
        }

        // ====================================== //

        public GamertagPrompt(Form callingForm)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Cursor.Show();

            settingsDialog = callingForm as Settings;
        }


        private void tbGamertag_KeyPress(object sender, KeyPressEventArgs e)
        {
            charCounter = tbGamertag.Text.Length;

            if (e.KeyChar == (char)Keys.Back)
            {
                charCounter = tbGamertag.Text.Length - 1;
                if (charCounter < 12)
                {
                    lbLenMessage.Hide();
                }
            }

            if (charCounter == 12)
            {
                lbLenMessage.Show();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                validate();
                e.Handled = true;
            }
        }

        private void validate()
        {
            if (tbGamertag.Text.Length == 0)
            {
                errorProvider1.SetError(tbGamertag, "Gamertag required.");
                return;
            }

            gamertag = tbGamertag.Text;
            if (checkDatabase(gamertag) == false)
            {
                Player player = new Player(gamertag, 0);
                writeToDatabase(player);
                highScore = 0;
            }

            Cursor.Hide();

            NewGame newGameDialog = new NewGame(this);
            newGameDialog.Show();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            validate();
        }

        public bool checkDatabase(String player_gt)
        {
            return readFromDatabase(player_gt);
        }

        public void writeToDatabase(Player p)
        {
            TextWriter writer = new StreamWriter(@"..\\..\\..\\PlayerDatabase.txt", true);

            writer.WriteLine(p);
            writer.Close();
        }

        public bool readFromDatabase(String gamertag)
        {
            TextReader reader = new StreamReader(@"..\\..\\..\\PlayerDatabase.txt");
            string line = null;
            string[] player_attr = new string[2];

            bool flag = false;

            while((line = reader.ReadLine()) != null)
            {
                if(line.Contains(gamertag))
                {
                    player_attr = line.Split(' ');
                    flag = true;
                }
            }

            if(flag == false)
            {
                reader.Close();
                return false;
            }

            gamertag = player_attr[0];

            bool isConverted;
            isConverted = int.TryParse(player_attr[1], out highScore);

            reader.Close();
            return true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Cursor.Show();
        }

        private void OKbtn_MouseEnter(object sender, EventArgs e)
        {
            OKbtn.ForeColor = Color.White;
        }

        private void OKbtn_MouseLeave(object sender, EventArgs e)
        {
            OKbtn.ForeColor = Color.Black;
        }
    }
}
