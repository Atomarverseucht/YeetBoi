using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace endlesrunner
{
    public partial class Skins : Form
    {
        public SoundPlayer ShopPlayer;
        public Skins()
        {   
            InitializeComponent();
            ShopPlayer = new SoundPlayer("Main Menu.wav");
            ShopPlayer.PlayLooping();
        }

        private void BtMenu_Click(object sender, EventArgs e)
        {
            mainMenu M = new mainMenu();
            M.Show();
            this.Hide();
        }

public void showMode()
        {
        if (Memory.mode)                                            // Darkmode
            {
                BackColor = Color.Black;
                ForeColor = Color.White;
                lbBlueDude.ForeColor = Color.White;
                lbRedDude.ForeColor = Color.White;
                lbBack1.ForeColor = Color.White;
                lbBasicBack.ForeColor = Color.White;
                btMenu.BackColor = Color.Black;
            }
            else                                                        // Lightmode
            {
                BackColor= Color.White;
                ForeColor= Color.Black;
                lbRedDude.ForeColor = Color.Black;
                lbBlueDude.ForeColor = Color.Black;
                lbBasicBack.ForeColor= Color.Black;
                lbBack1.ForeColor= Color.Black;
                btMenu.BackColor = Color.White;
            }
        }

private void Skins_Load(object sender, EventArgs e)
        {
            showMode();
            if (Memory.language)
            {
                lbRedDude.Text = "Roter Kerl";
                lbBlueDude.Text = "Blauer Kerl";
                lbBack1.Text = "Baum / Hintergrund";
                lbBasicBack.Text = "klassischer Hintergrund";
            }

            if (Memory.ownedItems[0, 1] == false)
            {
                pbBlue.Hide();
                lbBlueDude.ForeColor= Color.DarkRed;
            }
            if (Memory.ownedItems[1, 1] == false)
            {
                pbBack1.Hide();
                lbBack1.ForeColor = Color.DarkRed;
            }

            switch (Memory.selectedSkin)                                //Anzeige des bereits ausgewählten Skins / Backgrounds
            {
                case 0: lbRedDude.ForeColor = Color.Gold; break;
                case 1: lbBlueDude.ForeColor = Color.Gold; break;
                default: lbRedDude.ForeColor = Color.Gold; break;
            }
            switch (Memory.selectedBackground)
            {
                case 0: lbBasicBack.ForeColor = Color.Gold; break;
                case 1: lbBack1.ForeColor = Color.Gold; break;
                default: lbBasicBack.ForeColor = Color.Gold; break;
            }
        }

        private void pbRed_Click(object sender, EventArgs e)
        {
            showMode();
            lbRedDude.ForeColor = Color.Gold;
            Memory.selectedSkin = 0;
        }

        private void pbBlue_Click(object sender, EventArgs e)
        {
            if (Memory.ownedItems[0, 1] == true)
            {
            showMode();
            lbBlueDude.ForeColor= Color.Gold;
            Memory.selectedSkin = 1;
            }

        }
        private void pbBasicBack_Click(object sender, EventArgs e)
        {
            showMode();
            lbBasicBack.ForeColor = Color.Gold;
            Memory.selectedBackground = 0;
        }
        private void pbBack1_Click(object sender, EventArgs e)
        {
            if (Memory.ownedItems[1,1] == true)
            {
                showMode();
                lbBack1.ForeColor = Color.Gold;
                Memory.selectedBackground = 1;
            }
        }


    }
}
