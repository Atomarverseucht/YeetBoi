namespace endlesrunner
{
    partial class Game
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbScore = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.lbMenu = new System.Windows.Forms.Label();
            this.lbcoins = new System.Windows.Forms.Label();
            this.lbhscore = new System.Windows.Forms.Label();
            this.lbHighscore = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.PictureBox();
            this.ptcoin = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.SkyBlue;
            this.lbScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(24, 17);
            this.lbScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(206, 50);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "Score: 0";
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.Location = new System.Drawing.Point(968, 17);
            this.lbMenu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(386, 34);
            this.lbMenu.TabIndex = 4;
            this.lbMenu.Text = "Press M to go back to Menu";
            // 
            // lbcoins
            // 
            this.lbcoins.AutoSize = true;
            this.lbcoins.BackColor = System.Drawing.Color.SkyBlue;
            this.lbcoins.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcoins.Location = new System.Drawing.Point(26, 71);
            this.lbcoins.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbcoins.Name = "lbcoins";
            this.lbcoins.Size = new System.Drawing.Size(206, 50);
            this.lbcoins.TabIndex = 6;
            this.lbcoins.Text = "Coins: 0";
            // 
            // lbhscore
            // 
            this.lbhscore.AutoSize = true;
            this.lbhscore.BackColor = System.Drawing.Color.SkyBlue;
            this.lbhscore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhscore.Location = new System.Drawing.Point(298, 117);
            this.lbhscore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbhscore.Name = "lbhscore";
            this.lbhscore.Size = new System.Drawing.Size(229, 50);
            this.lbhscore.TabIndex = 8;
            this.lbhscore.Text = "Highscore";
            // 
            // lbHighscore
            // 
            this.lbHighscore.AutoSize = true;
            this.lbHighscore.BackColor = System.Drawing.Color.SkyBlue;
            this.lbHighscore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighscore.Location = new System.Drawing.Point(26, 117);
            this.lbHighscore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHighscore.Name = "lbHighscore";
            this.lbHighscore.Size = new System.Drawing.Size(252, 50);
            this.lbHighscore.TabIndex = 9;
            this.lbHighscore.Text = "Highscore:";
            // 
            // item
            // 
            this.item.BackColor = System.Drawing.Color.Transparent;
            this.item.Image = global::endlesrunner.Properties.Resources.coin__10;
            this.item.Location = new System.Drawing.Point(1128, 579);
            this.item.Margin = new System.Windows.Forms.Padding(6);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(122, 96);
            this.item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item.TabIndex = 10;
            this.item.TabStop = false;
            this.item.Tag = "boost";
            // 
            // ptcoin
            // 
            this.ptcoin.Image = global::endlesrunner.Properties.Resources.münze_2;
            this.ptcoin.Location = new System.Drawing.Point(880, 423);
            this.ptcoin.Margin = new System.Windows.Forms.Padding(6);
            this.ptcoin.Name = "ptcoin";
            this.ptcoin.Size = new System.Drawing.Size(100, 96);
            this.ptcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcoin.TabIndex = 5;
            this.ptcoin.TabStop = false;
            this.ptcoin.Tag = "coin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::endlesrunner.Properties.Resources.stein_2;
            this.pictureBox2.Location = new System.Drawing.Point(816, 744);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "obstacle";
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.Image = global::endlesrunner.Properties.Resources.chrakter_neu_2;
            this.character.Location = new System.Drawing.Point(-6, 710);
            this.character.Margin = new System.Windows.Forms.Padding(6);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(64, 64);
            this.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.character.TabIndex = 2;
            this.character.TabStop = false;
            this.character.Tag = "Skin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::endlesrunner.Properties.Resources.Game_Background;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1486, 904);
            this.Controls.Add(this.item);
            this.Controls.Add(this.lbHighscore);
            this.Controls.Add(this.lbhscore);
            this.Controls.Add(this.lbcoins);
            this.Controls.Add(this.ptcoin);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.character);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Game";
            this.Text = "YeetBoi";
            this.Load += new System.EventHandler(this.game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.PictureBox ptcoin;
        private System.Windows.Forms.Label lbcoins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbhscore;
        private System.Windows.Forms.Label lbHighscore;
        public System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.PictureBox item;
    }
}

