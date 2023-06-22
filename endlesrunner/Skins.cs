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

        private void Skins_Load(object sender, EventArgs e)
        {
            if (Memory.mode)                                            // Darkmode
            {
                BackColor = Color.Black;
                ForeColor = Color.White;
                btMenu.BackColor = Color.Black;
            }
            else                                                        // Lightmode
            {
                BackColor= Color.White;
                ForeColor= Color.Black;
                btMenu.BackColor = Color.White;
            }

            if (Memory.language)
            {
                lbRedDude.Text = "Roter Kerl";
                lbBlueDude.Text = "Blauer Kerl";
            }
        }
    }
}
