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
using System.Diagnostics;

namespace endlesrunner
{    
    public partial class Game : Form
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
        public Game()
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
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            character.Top += jumpSpeed;
            if (!Memory.language)
            {
                lbScore.Text = "Score: " + score;
                lbcoins.Text = "Coins: " + coin;
            }
            else
            {
                lbScore.Text = "Punkte: " + score;
                lbcoins.Text = "Münzen: " + coin;
            }
            
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

                    if (score > Memory.hs_score)                             // Highscore wird erfasst und gespeichert
                    {
                        lbhscore.Text = score.ToString();
                        Memory.hs_score = score;
                    }

                    if (character.Bounds.IntersectsWith(x.Bounds))          // Gameover Sequenz
                    {
                        gametimer.Stop();
                        Dead.Play();
                        character.Image = Properties.Resources.Player_dead;

                        if(Memory.language == false)                            //Gameover Text Englisch/Deutsch
                        {
                            lbScore.Text += "  Press R to restart the game!";
                        }
                        else
                        {
                            lbScore.Text += "  Drücke R um das Spiel neuzustarten!";
                        }

                        Memory.coinvalue = Memory.coinvalue + coin;                   // Kontostand aktualisieren
                        lbMenu.Show();                                                // Zeige, dass man mit "M" ins Menü kommt
                        isGameover = true;
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

            if(e.KeyCode == Keys.M == true && isGameover == true)                                  // der Key M wird so ausgerichtet das er beim drücken zu Form2 leitet
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

            if(Memory.language == false)                        // Anzeige in Englisch/Deutsch
            {
                lbScore.Text = "Score:  " + score;
                lbcoins.Text = "Coins:  " + coin;
            }
            else 
            {
                lbScore.Text = "Punkte:  " + score;
                lbcoins.Text = "Münzen:  " + coin;
            }
            lbhscore.Text = Memory.hs_score.ToString();
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

        private void game_Load(object sender, EventArgs e)
        {
            lbMenu.Hide();
            lbhscore.Text = Memory.hs_score.ToString();

            if (Memory.language == true)
            {
                lbHighscore.Text = "Rekord:";
                lbMenu.Text = "Drücke M um zum Menü zurückzukehren";
                lbhscore.Location = new Point(110, 60);
            }

            switch (Memory.selectedSkin)
            {
                case 0: character.Image = Properties.Resources.chrakter_neu_2; break;
                case 1: character.Image = Properties.Resources.chasrkter_3; break;
                default: character.Image = Properties.Resources.chrakter_neu_2; break;
            }
        
            switch (Memory.selectedBackground)
            {
                case 0: pbBackground.Image = Properties.Resources.Game_Background; break;
                case 1: pbBackground.Image = Properties.Resources.welt; break;
                default: pbBackground.Image = Properties.Resources.Game_Background; break;
            }
        }
    }
}
