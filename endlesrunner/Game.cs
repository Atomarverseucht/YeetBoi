using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace endlesrunner
{    
    public partial class game : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int coin = 0;
        int obstaclespeed = 10;
        int coinspeed = 10;
        Random rand = new Random();
        int position;
        bool isGameover = false;
        int boostspeed = 10;

        public SoundPlayer GameOver;
        public SoundPlayer Ingame;
        public SoundPlayer Dead;
        private WaveStream JumpSound;
        private WaveOut out1;
        private WaveStream CoinSound;
        private WaveOut out2;

        public game()
        {
            InitializeComponent();
            GameOver = new SoundPlayer("Bubblaine.wav");
            Ingame = new SoundPlayer("Ingame Music.wav");
            Dead = new SoundPlayer("Game Over.wav");
            CoinSound = new WaveFileReader("Coin.wav");
            JumpSound = new WaveFileReader("Jump.wav");
            out1= new WaveOut();
            out2= new WaveOut();
            out1.Init(JumpSound);
            out2.Init(CoinSound);
            GameReset();
            lbhscore.Text = Properties.Settings.Default.h_score;
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            character.Top += jumpSpeed;
            lbscore.Text = "Score: " + score;
            lbcoins.Text = "Coins: " + coin;

            if(jumping == true && force <= 0)
            {
                jumping = false;        // Blockiert Springen in der Luft
            }

            if(jumping == true)         // Sprung gravitation
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;         // Fallgeschwindigkeit
            }
            if (character.Top > 363 && jumping == false)        // Bestimmt die Minimal Höhe des Spielers (Boden)
            {
                force = 12;                                     // Maximale Sprunghöhe
                character.Top = 364;
                jumpSpeed = 0;

                if (out1.PlaybackState is PlaybackState.Playing) out1.Stop();       // Spielt Sprung Sound ab ohne Musik abzubrechen
                {
                    JumpSound.CurrentTime = new TimeSpan(0L);
                    out1.Play();
                }
            }

            int s = Int32.Parse(lbhscore.Text);
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstaclespeed;

                    if(x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (character.Bounds.IntersectsWith(x.Bounds))          // Gameover Sequence
                    {
                        gametimer.Stop();
                        Dead.Play();
                        character.Image = Properties.Resources.Player_dead;
                        lbscore.Text += "  Press R to restart the game!";
                        isGameover = true;

                        if (score > s)                                      // Highscore wird erfasst und gespeichert
                        {
                            lbhscore.Text = score.ToString();
                            Properties.Settings.Default.h_score = lbhscore.Text;
                            Properties.Settings.Default.Save();
                        }

                       
                        Memory.coinvalue = Memory.coinvalue + coin;                   // Kontostand aktualisieren
                    }
                }
            }

            if (score > 10)
            {
                obstaclespeed = 15;
            }
            
            foreach(Control a in this.Controls)
            {
                if (a is PictureBox && (string)a.Tag == "coin")
                {
                    a.Left -= coinspeed;
                    if (a.Left < -50)
                    {
                        a.Left = this.ClientSize.Width + rand.Next(200, 500) + (a.Width * 15);
                    }
                    if (character.Bounds.IntersectsWith(a.Bounds))
                    {
                        a.Left = this.ClientSize.Width + rand.Next(200, 500) + (a.Width * 15);
                        coin += 1;

                        if (out2.PlaybackState is PlaybackState.Playing) out2.Stop();           // Spielt Coin Sound ab ohne Musik abzubrechen
                        {
                            CoinSound.CurrentTime = new TimeSpan(0L);
                            out2.Play();
                        }
                    }
                }
            }

            foreach (Control b in this.Controls)
            {
                if (b is PictureBox && (string)b.Tag == "boost")
                {
                    b.Left -= boostspeed;
                    if (b.Left < -50)
                    {
                        b.Left = this.ClientSize.Width + rand.Next(200, 500) + (b.Width * 15);
                    }
                    if (character.Bounds.IntersectsWith(b.Bounds))
                    {
                        b.Left = this.ClientSize.Width + rand.Next(200, 500) + (b.Width * 15);
                        coin += 10;

                        if (out2.PlaybackState is PlaybackState.Playing) out2.Stop();           // Spielt Coin Sound ab ohne Musik abzubrechen
                        {
                            CoinSound.CurrentTime = new TimeSpan(0L);
                            out2.Play();
                        }
                    }
                }
            }
        }

        mainMenu M = new mainMenu();
        SoundPlayer MenuPlayer = new SoundPlayer("Main Menu.wav");
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }

            if(e.KeyCode == Keys.M == true)                                  // der Key M wird so ausgerichtet das er beim drücken zu Form2 leitet
            {
                M.Show();
                this.Hide();
                MenuPlayer.PlayLooping();                                                   // startet Musik wenn man ins Menü zurückkommt
            }

            if(e.KeyCode == Keys.S == true)
            {
                character.Image = Properties.Resources.chasrkter_3;
            }
            if(e.KeyCode == Keys.C == true)
            {
                character.Image = Properties.Resources.chrakter_neu_2;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if(jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameover == true)
            {
                GameReset();
            }
        }
    
        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstaclespeed = 10;
            coinspeed = 10;
            coin = 0;
            lbscore.Text = "Score:  " + score;
            lbcoins.Text = "Coins:  " + coin;
            character.Image = Properties.Resources.chrakter_neu_2;         
            isGameover = false;
            character.Top = 363;
            Ingame.PlayLooping();
            
            foreach ( Control x in this.Controls)
            {
                if(x is PictureBox && ( string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }

            foreach (Control a in this.Controls)
            {
                if (a is PictureBox && (string)a.Tag == "coin")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (a.Width * 10);
                    a.Left = position;
                }
            }
            gametimer.Start();
        }
    }
}
