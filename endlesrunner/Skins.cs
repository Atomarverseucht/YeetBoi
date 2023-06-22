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
    }
}
