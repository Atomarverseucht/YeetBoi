﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace endlesrunner
{
    public partial class shop : Form
    {
        public SoundPlayer ShopPlayer;
        public shop()
        {
            InitializeComponent();
            ShopPlayer = new SoundPlayer("Main Menu.wav");
            ShopPlayer.PlayLooping();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            mainMenu M = new mainMenu();
            M.Show();
            this.Hide();
        }

        private void shop_Load(object sender, EventArgs e)
        {
            if (Memory.mode)
            {
                BackColor = Color.Black;
                ForeColor = Color.White;
                btMenu.BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
                btMenu.BackColor = Color.White;
            }

            lbCoins.Text = "Coins: " + Memory.coinvalue;
            if (Memory.language)
            {
                lbBack1.Text = "besseren Hintergrund \n (150 Münzen)";
                lbBlueDude.Text = "Blauer Kerl \n (100 Münzen)";
                lbDino.Text = "Dino \n (250 Münzen)";
                lbCoins.Text = "Münzen: " + Memory.coinvalue;
            }
            if (Memory.ownedItems[0, 1])                                    // Anzeige, was bereits gekauft wurde
            { 
                lbBlueDude.Text = "$$$"; 
            }       
            if (Memory.ownedItems[1, 1]) 
            { 
                lbBack1.Text = "$$$"; 
            }
            if (Memory.ownedItems[0, 2])
            {
                lbDino.Text = "$$$";
            }
        }

        private void pbBlue_Click(object sender, EventArgs e)
        {
            if (Memory.ownedItems[0, 1] == false && Memory.coinvalue>=100)
            {
                Memory.coinvalue -= 100;
                Memory.ownedItems[0, 1] = true;
                lbBlueDude.Text = "$$$";
                lbBlueDude.ForeColor = Color.Red;
            }
            else
            {
                lbBlueDude.Text = "Error";
            }
        }

        private void lbBlueDude_Click(object sender, EventArgs e)
        {
            lbBlueDude.Text = "Please click on the picture";
        }

        private void pbBack1_Click(object sender, EventArgs e)
        {
            if (Memory.ownedItems[1, 1] == false && Memory.coinvalue >= 150)
            {
                Memory.coinvalue -= 150;
                Memory.ownedItems[1, 1] = true;
                lbBack1.Text = "$$$";
                lbBack1.ForeColor = Color.Red;
            }
            else
            {
                lbBack1.Text = "Error";
            }
        }

        private void lbBack1_Click(object sender, EventArgs e)
        {
            lbBack1.Text = "Please click on the picture";
        }

        private void pbDino_Click(object sender, EventArgs e)
        {
            if (Memory.ownedItems[0, 2] == false && Memory.coinvalue >= 250
                )
            {
                Memory.coinvalue -= 150;
                Memory.ownedItems[0, 2] = true;
                lbDino.Text = "$$$";
                lbDino.ForeColor = Color.Red;
            }
            else
            {
                lbDino.Text = "Error";
            }
        }

        private void lbDino_Click(object sender, EventArgs e)
        {
            lbBack1.Text = "Please click on the picture";
        }
    }
}
