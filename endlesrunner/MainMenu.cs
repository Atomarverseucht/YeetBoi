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
using System.Net.Mail;
using System.Net;
using System.Globalization;

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
            lbCoins.Text = "Coins: " + Memory.coinvalue.ToString();              // Geldanzeige

            if (Memory.mode == true)                                              // Dark-/Lightmode
            {
                Darkmode();
            }

            if (Memory.language == true)                                          // German-English
            {
                changeToGerman();
            }
        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            CultureInfo usa = new CultureInfo("en-US");
            CultureInfo de = new CultureInfo("de");
            if (Memory.language)
            {
                lbDate.Text = DateTime.Now.ToString(de.DateTimeFormat.LongDatePattern, de);
                lbTime.Text = DateTime.Now.ToString(de.DateTimeFormat.LongTimePattern, de);
            }
            else
            {
                lbDate.Text = DateTime.Now.ToString(usa.DateTimeFormat.LongDatePattern, usa);
                lbTime.Text = DateTime.Now.ToString(usa.DateTimeFormat.LongTimePattern, usa);
            }

            tmUpdate.Start();
            if (Memory.mode == false) { Whitemode(); }
            else { Darkmode(); }
            lbCode.Text = getCode();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Game G = new Game();
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
            if (Memory.language == false)
            {
                changeToGerman();
                Memory.language = true;
            }
            else
            {
                changeToEnglish();
                Memory.language = false;
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
            lbCoins.Text = "Münzen: " + Memory.coinvalue;
            btSubmitCode.Text = "Bestätigen";
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
            lbCoins.Text = "Coins: " + Memory.coinvalue;
            btSubmitCode.Text = "Submit";
        }

        private void btShop_Click(object sender, EventArgs e)
        {
            shop shop = new shop();
            shop.Show();
            this.Hide();
        }

        public string getCode()
        {
            string variables = "";

            for (int i = 0; i < Memory.encodeVariables().Length; i++)
            {
                variables = variables + Memory.encodeVariables()[i] + ".";
            }
            return variables;
        }

        private void btSubmitCode_Click(object sender, EventArgs e)
        {
            Memory.decodeVariables(tbCodeInput.Text.Split('.'));
            lbCoins.Text = "Coins: " + Memory.coinvalue.ToString();              // Geldanzeige

            if (Memory.mode == true)                                              // Dark-/Lightmode
            {
                Darkmode();
            }

            if (Memory.language == true)                                          // German-English
            {
                changeToGerman();
            }
        }

        private void lbCode_Click(object sender, EventArgs e)
        {
            if(tbCodeInput.Text.Contains("Copy to clipboard!"))
            {
                tbCodeInput.Text = "";
            }
            else
            {
                Clipboard.SetText(getCode());
                tbCodeInput.Text = "Copy to clipboard!";                
            }
        }
    }
}
