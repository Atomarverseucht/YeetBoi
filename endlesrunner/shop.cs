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
    }
}
