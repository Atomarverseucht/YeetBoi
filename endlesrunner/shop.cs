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
    }
}
