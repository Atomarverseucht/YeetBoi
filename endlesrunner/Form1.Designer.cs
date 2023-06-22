namespace endlesrunner
{
    partial class game
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
            this.lbscore = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.lbzumenü = new System.Windows.Forms.Label();
            this.lbcoins = new System.Windows.Forms.Label();
            this.lbhscore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // lbscore
            // 
            this.lbscore.AutoSize = true;
            this.lbscore.BackColor = System.Drawing.Color.SkyBlue;
            this.lbscore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbscore.Location = new System.Drawing.Point(12, 9);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(106, 24);
            this.lbscore.TabIndex = 1;
            this.lbscore.Text = "Score: 0";
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // lbzumenü
            // 
            this.lbzumenü.AutoSize = true;
            this.lbzumenü.BackColor = System.Drawing.Color.SkyBlue;
            this.lbzumenü.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbzumenü.Location = new System.Drawing.Point(484, 9);
            this.lbzumenü.Name = "lbzumenü";
            this.lbzumenü.Size = new System.Drawing.Size(196, 19);
            this.lbzumenü.TabIndex = 4;
            this.lbzumenü.Text = "Press M to go back to Menu";
            // 
            // lbcoins
            // 
            this.lbcoins.AutoSize = true;
            this.lbcoins.BackColor = System.Drawing.Color.SkyBlue;
            this.lbcoins.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcoins.Location = new System.Drawing.Point(13, 37);
            this.lbcoins.Name = "lbcoins";
            this.lbcoins.Size = new System.Drawing.Size(106, 24);
            this.lbcoins.TabIndex = 6;
            this.lbcoins.Text = "Coins: 0";
            // 
            // lbhscore
            // 
            this.lbhscore.AutoSize = true;
            this.lbhscore.BackColor = System.Drawing.Color.SkyBlue;
            this.lbhscore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhscore.Location = new System.Drawing.Point(149, 61);
            this.lbhscore.Name = "lbhscore";
            this.lbhscore.Size = new System.Drawing.Size(118, 24);
            this.lbhscore.TabIndex = 8;
            this.lbhscore.Text = "Highscore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Highscore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Press S and C to change skin";
            // 
            // item
            // 
            this.item.BackColor = System.Drawing.Color.Transparent;
            this.item.Image = global::endlesrunner.Properties.Resources.coin__10;
            this.item.Location = new System.Drawing.Point(564, 301);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(61, 50);
            this.item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item.TabIndex = 10;
            this.item.TabStop = false;
            this.item.Tag = "boost";
            // 
            // ptcoin
            // 
            this.ptcoin.Image = global::endlesrunner.Properties.Resources.münze_2;
            this.ptcoin.Location = new System.Drawing.Point(440, 220);
            this.ptcoin.Name = "ptcoin";
            this.ptcoin.Size = new System.Drawing.Size(50, 50);
            this.ptcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcoin.TabIndex = 5;
            this.ptcoin.TabStop = false;
            this.ptcoin.Tag = "coin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::endlesrunner.Properties.Resources.stein_2;
            this.pictureBox2.Location = new System.Drawing.Point(408, 387);
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
            this.character.Location = new System.Drawing.Point(-3, 369);
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
            this.pictureBox1.Location = new System.Drawing.Point(-3, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbhscore);
            this.Controls.Add(this.lbcoins);
            this.Controls.Add(this.ptcoin);
            this.Controls.Add(this.lbzumenü);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.character);
            this.Controls.Add(this.lbscore);
            this.Controls.Add(this.pictureBox1);
            this.Name = "game";
            this.Text = "YeetBoi";
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
        private System.Windows.Forms.Label lbscore;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbzumenü;
        private System.Windows.Forms.PictureBox ptcoin;
        private System.Windows.Forms.Label lbcoins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbhscore;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.PictureBox item;
        private System.Windows.Forms.Label label2;
    }
}

