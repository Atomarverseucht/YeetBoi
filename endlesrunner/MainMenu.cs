using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace endlesrunner
{
    public partial class mainMenu : Form
    {
        public SoundPlayer MenuPlayer;
        public SoundPlayer Ingame;

        public mainMenu()
        {
            InitializeComponent();
            MenuPlayer = new SoundPlayer("Main Menu.wav");
            MenuPlayer.PlayLooping();                                      // Startet Musik beim öffnen des Menüs
            Ingame = new SoundPlayer("Ingame Music.wav");
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            tmUpdate.Start();
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToLongDateString();
            Memory.language = false;

            lbCoins.Text = "Coins: " + Memory.coinvalue.ToString();              // Geldanzeige

            if(Memory.mode == true)                                              // Dark-/Lightmode
            { 
                Darkmode(); 
            }                           

            if(Memory.language == true)                                          // German-English
            {
                changeToGerman();
            }
        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            tmUpdate.Start();
            if (Memory.mode == false) { Whitemode(); }
            else { Darkmode(); }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            game G = new game();
            G.Show();
            this.Hide();
            MenuPlayer.Stop();                                      //Stoppt Musik beim drücken des Start Buttons
            Ingame.PlayLooping();
        }

        private void btDarkmode_Click(object sender, EventArgs e)
        {
            Darkmode();
            Memory.mode = true;
        }
        private void Darkmode()
        {
            BackColor = Color.Black;
            ForeColor = Color.White;
            lbTime.ForeColor = Color.White;
            lbDate.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            btStart.BackColor = Color.FromArgb(20, 20, 20);
            btStart.ForeColor = Color.White;
            btDarkmode.BackColor = Color.FromArgb(20, 20, 20);
            btDarkmode.ForeColor = Color.White;
            btLanguage.BackColor = Color.FromArgb(20, 20, 20);
            btLanguage.ForeColor = Color.White;
            btExit.BackColor = Color.FromArgb(20, 20, 20);
            btExit.ForeColor = Color.White;
            btShop.BackColor = Color.FromArgb(20, 20, 20);
            btShop.ForeColor = Color.White;
            btSkins.BackColor = Color.FromArgb(20, 20, 20);
            btSkins.ForeColor = Color.White;
            btWhitemode.BackColor = Color.FromArgb(20, 20, 20);
            btWhitemode.ForeColor = Color.White;
            lbVolume.ForeColor = Color.White;
        }

        private void btWhitemode_Click(object sender, EventArgs e)
        {
            Whitemode();
            Memory.mode = false;
        }
        public void Whitemode()
        {
            BackColor = Color.White;
            ForeColor = Color.Black;
            lbTime.ForeColor = Color.Black;
            lbDate.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            btStart.BackColor = Color.Transparent;
            btStart.ForeColor = Color.Black;
            btDarkmode.BackColor = Color.Transparent;
            btDarkmode.ForeColor = Color.Black;
            btLanguage.BackColor = Color.Transparent;
            btLanguage.ForeColor = Color.Black;
            btExit.BackColor = Color.Transparent;
            btExit.ForeColor = Color.Black;
            btShop.BackColor = Color.Transparent;
            btShop.ForeColor = Color.Black;
            btSkins.BackColor = Color.Transparent;
            btSkins.ForeColor = Color.Black;
            btWhitemode.BackColor = Color.Transparent;
            btWhitemode.ForeColor = Color.Black;
            lbVolume.ForeColor = Color.Black;
        }

        private void BtSkins_Click(object sender, EventArgs e)
        {
            Skins S = new Skins();
            S.Show();
            this.Hide();
        }

        // Language-Switch English/German
        private void BtLanguage_Click(object sender, EventArgs e)
        {
            if (Memory.language == true)
            {
                changeToGerman();
                Memory.language = false;
            }
            else
            {
                changeToEnglish();
                Memory.language = true;
            }
        }
        private void changeToGerman()
        {
                lbTime.Text = "Uhrzeit: ";
                btStart.Text = "Spielen";
                btDarkmode.Text = "Dunkel";
                btLanguage.Text = "Ändern auf Englisch";
                btExit.Text = "Beenden";
                btShop.Text = "Marktplatz";
                btSkins.Text = "Kostüme";
                btWhitemode.Text = "Hell";
                lbVolume.Text = "Lautstärke";
                lbCoins.Text = "Münzen: " + Memory.coinvalue;
        }
        private void changeToEnglish()
        {
                lbTime.Text = "Time: ";
                btStart.Text = "Play";
                btDarkmode.Text = "Darkmode";
                btLanguage.Text = "Change to German";
                btExit.Text = "Exit";
                btShop.Text = "Shop";
                btSkins.Text = "Skins";
                btWhitemode.Text = "LightMode";
                lbVolume.Text = "Volume";
                lbCoins.Text = "Coins: " + Memory.coinvalue;
        }

        private void btShop_Click(object sender, EventArgs e)
        {
            shop shop = new shop();
            shop.Show();
            this.Hide();
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {

        }
    }
}
