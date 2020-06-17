/*
    Created by: Ivo Tasevski
    * End Game Dialog form - the ending point of the application. Prompts the user with his score and notifies him if his high score is beaten.
    * Last Revised: 17.06.2020
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Minute_Sniper
{
    public partial class EndGameDialog : Form
    {
        // =========== INIT =========== //

        private NewGame mainForm = null;

        // ============================ //

        public EndGameDialog(Form callingForm)
        {
            mainForm = callingForm as NewGame;
            // inicijaliziraj ja null instancata od formata NewGame na povikuvackata forma, koja se tretira soodvetno kako NewGame instanca
            InitializeComponent();
            Cursor.Show();
            this.ControlBox = false;

            lbHighscoreBeaten.Hide();
            pictureBox1.Hide();

            checkHighScore();
        }

        private void checkHighScore()
        {
            if(this.mainForm.IsHighScoreBeaten == true)
            {
                if (this.mainForm.Audio == "On" || this.mainForm.Audio == "")
                {
                    SoundPlayer beatenHighScoreSound = new SoundPlayer(@"..\\..\\..\\correct.wav");
                    beatenHighScoreSound.Play();
                }

                pictureBox1.Show();

                lbHighscoreBeaten.Text = "CONGRATULATIONS, " + this.mainForm.LbGamertag.Text + "!\nYOU BEAT YOUR HIGH SCORE!";
                lbHighscoreBeaten.Show();

                lbScore.Text = String.Format("SCORE: {0}", this.mainForm.Score);
                lbHighscore.Text = String.Format("YOUR NEW HIGH SCORE: {0}", this.mainForm.HighScore);
            }
            else
            {
                lbScore.Text = String.Format("SCORE: {0}", this.mainForm.Score);
                lbHighscore.Text = String.Format("YOUR HIGH SCORE: {0}", this.mainForm.HighScore);
            }
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            reset();
            this.Close();
        }

        private void reset()
        {
            this.mainForm.LbTimer = "01:00";
            this.mainForm.LbScore.Text = "SCORE: 0";
            this.mainForm.LbMultiplier.Hide();
            Cursor.Hide();
            this.mainForm.LbTimerColor = System.Drawing.Color.Black;
            this.mainForm.LbInstuctions.Show();
            this.mainForm.IsHighScoreBeaten = false;
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainForm.Close();
        }

        private void yesBtn_MouseEnter(object sender, EventArgs e)
        {
            yesBtn.ForeColor = Color.White;
        }

        private void yesBtn_MouseLeave(object sender, EventArgs e)
        {
            yesBtn.ForeColor = Color.Black;
        }

        private void noBtn_MouseEnter(object sender, EventArgs e)
        {
            noBtn.ForeColor = Color.White;
        }

        private void noBtn_MouseLeave(object sender, EventArgs e)
        {
            noBtn.ForeColor = Color.Black;
        }
    }
}
