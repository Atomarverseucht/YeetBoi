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
    }
}
