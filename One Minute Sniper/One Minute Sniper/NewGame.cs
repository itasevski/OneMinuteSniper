/*
    Created by: Ivo Tasevski
    * New Game form - the heart of the application itself.
    * Last Revised: 17.06.2020
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Minute_Sniper
{
    public partial class NewGame : Form
    {
        // ==================== INIT ===================== //

        Reticle reticle = new Reticle(Color.Black, "Style 1"); // default
        Target target = new Target(Color.Red); // default

        Random generateSpawn = new Random();

        int x_location;
        int y_location;

        int x_location_target;
        int y_location_target;

        int x_location_target_temp;
        int y_location_target_temp;

        bool flag = false;
        bool targetFlag = false;
        bool isHighScoreBeaten = false;

        int elapsedTime = 0;
        static readonly int MAX_TIME = 60;

        int score = 0;
        int scoreCopy = 0;
        int highScoreCopy = 0;
        int multiplier = 1;
        int multiplier_counter = 0;

        public String LbTimer
        {
            get { return lbTimer.Text; }
            set { lbTimer.Text = value; }
        } // geter i seter za labelata lbTimer sto treba da se zeme ili smeni

        public Color LbTimerColor
        {
            set { lbTimer.ForeColor = value; }
        }

        public Label LbInstuctions
        {
            get { return lbInstructions; }
        }

        public Label LbScore
        {
            get { return lbScore; }
        }

        public Label LbMultiplier
        {
            get { return lbMultiplier; }
        }

        public Label LbGamertag
        {
            get { return lbGamertag; }
        }

        public bool IsHighScoreBeaten
        {
            get { return isHighScoreBeaten; }
            set { isHighScoreBeaten = value; }
        }

        public int Score
        {
            get { return scoreCopy; }
        }

        public int HighScore
        {
            get { return highScoreCopy; }
        }

        public string Audio
        {
            get { return isAudioOn; }
        }


        private GamertagPrompt gtPrompt = null;

        Graphics pomGraphics = null;

        string isAudioOn = "";
        string reticleStyle = "";
        string reticleColor = "";
        string targetStyle = "";
        string bgStyle = "";

        // ============================================== //


        public NewGame(Form callingForm)
        {   
            DoubleBuffered = true;
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            gtPrompt = callingForm as GamertagPrompt;
            lbGamertag.Text = this.gtPrompt.Gamertag;
            lbHighScore.Text = String.Format("HIGH SCORE: {0}", this.gtPrompt.HighScore);

            isAudioOn = this.gtPrompt.SettingsForm.Audio;
            reticleStyle = this.gtPrompt.SettingsForm.ReticleStyle;
            reticleColor = this.gtPrompt.SettingsForm.ReticleColor;
            targetStyle = this.gtPrompt.SettingsForm.Target;
            bgStyle = this.gtPrompt.SettingsForm.Background;

            adjustSettingsReticle();
            adjustSettingsTarget();
            adjustSettingsBackground();

            x_location = ClientSize.Width;
            y_location = ClientSize.Height;

            x_location_target = generateSpawn.Next(0, ClientSize.Width - (int)target.RADIUS * 3);
            y_location_target = generateSpawn.Next(0, ClientSize.Height - (int)target.RADIUS * 3);

            x_location_target_temp = ClientSize.Width - (int)target.RADIUS * 3;
            y_location_target_temp = ClientSize.Height - (int)target.RADIUS * 3;

            pomGraphics = CreateGraphics();

            lbMultiplier.Hide();

            Cursor.Hide();
        }

        private void adjustSettingsReticle()
        {
            if (reticleStyle == "" || reticleStyle == "Style 1")
            {
                reticle.reticleStyle = "Style 1";
            }
            else if (reticleStyle == "Style 2")
            {
                reticle.reticleStyle = "Style 2";
            }
            else if (reticleStyle == "Style 3")
            {
                reticle.reticleStyle = "Style 3";
            }


            if (reticleColor == "Red")
            {
                reticle.reticleColor = Color.Red;
            }
            else if (reticleColor == "Green")
            {
                reticle.reticleColor = Color.Green;
            }
            else if (reticleColor == "Blue")
            {
                reticle.reticleColor = Color.Blue;
            }
            else if (reticleColor == "" || reticleColor == "Black")
            {
                reticle.reticleColor = Color.Black;
            }
        }

        private void adjustSettingsTarget()
        {
            if (targetStyle == "Blue")
            {
                target.targetColor = Color.Blue;
            }
            else if (targetStyle == "" || targetStyle == "Red")
            {
                target.targetColor = Color.Red;
            }
            else if (targetStyle == "Green")
            {
                target.targetColor = Color.Green;
            }
            else if (targetStyle == "Black")
            {
                target.targetColor = Color.Black;
            }
        }

        private void adjustSettingsBackground()
        {
            if (bgStyle == "" || bgStyle == "White") // default
            {
                BackColor = Color.White;
            }
            else if (bgStyle == "Aquamarine")
            {
                BackColor = Color.Aquamarine;
            }
            else if (bgStyle == "Gray")
            {
                BackColor = Color.Gray;
            }
            else if (bgStyle == "Lime Green")
            {
                BackColor = Color.LimeGreen;
            }
         }

        private void NewGame_Paint(object sender, PaintEventArgs e)
        {
            reticle.drawReticle(e.Graphics, x_location, y_location);
            if (targetFlag == true)
            {
                target.drawTarget(e.Graphics, x_location_target, y_location_target);
            }
        }

        private void NewGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                if (isAudioOn == "" || isAudioOn == "On")
                {
                    SoundPlayer shotFiredSound = new SoundPlayer(@"..\\..\\..\\bulletimpact.wav");
                    shotFiredSound.Play();
                }

                if (target.isTargetShot(e.Location))
                {
                    ++multiplier_counter;

                    x_location_target = generateSpawn.Next(0, x_location_target_temp);
                    y_location_target = generateSpawn.Next(0, y_location_target_temp);

                    target.RADIUS -= 0.75F;

                    if(multiplier_counter == 15)
                    {
                        lbMultiplier.Show();
                        multiplier = 2;
                        lbMultiplier.Text = "2X MULTIPLIER";
                    }
                    else if(multiplier_counter == 35)
                    {
                        multiplier = 3;
                        lbMultiplier.Text = "3X MULTIPLIER";
                    }
                    else if(multiplier_counter == 60)
                    {
                        multiplier = 4;
                        lbMultiplier.Text = "4X MULTIPLIER";
                    }
                    

                    score += multiplier * 100;
                    scoreCopy = score;
                    lbScore.Text = String.Format("SCORE: {0}", score);
                }
                else
                {
                    lbMultiplier.Hide();
                    multiplier = 1;
                    multiplier_counter = 0;
                    if (score < 1000)
                    {
                        score -= score;
                        lbScore.Text = String.Format("SCORE: {0}", score);
                        return;
                    }
                    score -= 1000;
                    lbScore.Text = String.Format("SCORE: {0}", score);
                }
                Invalidate(true);
            }
        }

        private void NewGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                x_location = e.X;
                y_location = e.Y;

                Invalidate(true);
            }
            else
            {
                return;
            }
        }

        private void NewGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                flag = true;
                reticle.startMoving = true;
                targetFlag = true;
                Cursor.Hide();

                lbScore.Text = String.Format("SCORE: {0}", score);

                timer1.Start();
            }
            else if(e.KeyCode == Keys.P)
            {
                flag = false;
                reticle.startMoving = false;

                timer1.Stop();
            }
            else if(e.KeyCode == Keys.B)
            {
                resetVars();
                Cursor.Show();
                this.Close();
                this.gtPrompt.Close();
            }
            else
            {
                return;
            }

            lbInstructions.Hide();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            ++elapsedTime;
            if(elapsedTime == MAX_TIME)
            {
                timer1.Stop();
                Cursor.Show();
                updateHighScore();
                resetVars();

                EndGameDialog endGameDialog = new EndGameDialog(this); 
                // prati ja momentalnata instanca od NewGame formata kako argument vo konstruktorot na druga forma
                endGameDialog.ShowDialog();
            }
            else if (elapsedTime <= 50)
            {
                lbTimer.Text = String.Format("0{0}:{1}", elapsedTime / 60, MAX_TIME - elapsedTime);
            }
            else
            {
                lbTimer.Text = String.Format("0{0}:0{1}", elapsedTime / 60, MAX_TIME - elapsedTime);
            }

            checkTimer(elapsedTime);
        }

        private void updateHighScore()
        {
            if(score > this.gtPrompt.HighScore)
            {
                highScoreCopy = score;
                this.gtPrompt.HighScore = score;
                isHighScoreBeaten = true;
                lbHighScore.Text = String.Format("HIGH SCORE: {0}", score);
                Player player = new Player(this.gtPrompt.Gamertag, score);
                this.gtPrompt.writeToDatabase(player);
            }
            else
            {
                highScoreCopy = this.gtPrompt.HighScore;
                return;
            }
        }

        private void checkTimer(int currentTime)
        {
            if(currentTime >= 40)
            {
                lbTimer.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void resetVars()
        {
            lbTimer.Text = "00:00";
            elapsedTime = 0;
            score = 0;
            multiplier = 1;
            multiplier_counter = 0;
            flag = false;
            reticle.startMoving = false;
            targetFlag = false;

            target.RADIUS = 65;

            x_location = ClientSize.Width;
            y_location = ClientSize.Height;

            Invalidate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Cursor.Show();
            this.gtPrompt.Close();
        }

        private void NewGame_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void NewGame_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void lbTimer_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }

        private void NewGame_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }
    }
}
