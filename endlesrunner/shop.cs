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
            ShopPlayer = new SoundPlayer("GameMainMenu.wav");
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
                lbBlueDude.Text = "$$$";
                lbBlueDude.ForeColor = Color.Red;
            }
            else
            {
                lbBlueDude.Text = "Error";
            }
        }

        private void lbBack1_Click(object sender, EventArgs e)
        {
            lbBlueDude.Text = "Please click on the picture";
        }
    }
}
