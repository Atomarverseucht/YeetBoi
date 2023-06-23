namespace endlesrunner
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btDarkmode = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.tmUpdate = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbVolume = new System.Windows.Forms.Label();
            this.btShop = new System.Windows.Forms.Button();
            this.btSkins = new System.Windows.Forms.Button();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.btWhitemode = new System.Windows.Forms.Button();
            this.btLanguage = new System.Windows.Forms.Button();
            this.lbCoins = new System.Windows.Forms.Label();
            this.tbCodeInput = new System.Windows.Forms.TextBox();
            this.btSubmitCode = new System.Windows.Forms.Button();
            this.lbCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btDarkmode
            // 
            this.btDarkmode.Location = new System.Drawing.Point(96, 308);
            this.btDarkmode.Margin = new System.Windows.Forms.Padding(6);
            this.btDarkmode.Name = "btDarkmode";
            this.btDarkmode.Size = new System.Drawing.Size(166, 56);
            this.btDarkmode.TabIndex = 0;
            this.btDarkmode.Text = "Darkmode";
            this.btDarkmode.UseVisualStyleBackColor = true;
            this.btDarkmode.Click += new System.EventHandler(this.btDarkmode_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(1146, 727);
            this.btExit.Margin = new System.Windows.Forms.Padding(6);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(180, 83);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(408, 169);
            this.btStart.Margin = new System.Windows.Forms.Padding(6);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(476, 144);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Play";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(1094, 42);
            this.lbTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(71, 26);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Time:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(1094, 106);
            this.lbDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(69, 26);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "Date:";
            // 
            // tmUpdate
            // 
            this.tmUpdate.Enabled = true;
            this.tmUpdate.Tick += new System.EventHandler(this.tmUpdate_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "YeetBoi";
            // 
            // lbVolume
            // 
            this.lbVolume.AutoSize = true;
            this.lbVolume.Location = new System.Drawing.Point(590, 610);
            this.lbVolume.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(84, 25);
            this.lbVolume.TabIndex = 8;
            this.lbVolume.Text = "Volume";
            // 
            // btShop
            // 
            this.btShop.Location = new System.Drawing.Point(408, 394);
            this.btShop.Margin = new System.Windows.Forms.Padding(6);
            this.btShop.Name = "btShop";
            this.btShop.Size = new System.Drawing.Size(210, 73);
            this.btShop.TabIndex = 9;
            this.btShop.Text = "Shop";
            this.btShop.UseVisualStyleBackColor = true;
            this.btShop.Click += new System.EventHandler(this.btShop_Click);
            // 
            // btSkins
            // 
            this.btSkins.Location = new System.Drawing.Point(652, 394);
            this.btSkins.Margin = new System.Windows.Forms.Padding(6);
            this.btSkins.Name = "btSkins";
            this.btSkins.Size = new System.Drawing.Size(232, 73);
            this.btSkins.TabIndex = 10;
            this.btSkins.Text = "Skins";
            this.btSkins.UseVisualStyleBackColor = true;
            this.btSkins.Click += new System.EventHandler(this.BtSkins_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(372, 640);
            this.tbVolume.Margin = new System.Windows.Forms.Padding(6);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(532, 90);
            this.tbVolume.TabIndex = 11;
            this.tbVolume.TickFrequency = 10;
            // 
            // btWhitemode
            // 
            this.btWhitemode.Location = new System.Drawing.Point(96, 375);
            this.btWhitemode.Margin = new System.Windows.Forms.Padding(6);
            this.btWhitemode.Name = "btWhitemode";
            this.btWhitemode.Size = new System.Drawing.Size(166, 50);
            this.btWhitemode.TabIndex = 12;
            this.btWhitemode.Text = "Whitemode";
            this.btWhitemode.UseVisualStyleBackColor = true;
            this.btWhitemode.Click += new System.EventHandler(this.btWhitemode_Click);
            // 
            // btLanguage
            // 
            this.btLanguage.Location = new System.Drawing.Point(408, 479);
            this.btLanguage.Margin = new System.Windows.Forms.Padding(6);
            this.btLanguage.Name = "btLanguage";
            this.btLanguage.Size = new System.Drawing.Size(476, 81);
            this.btLanguage.TabIndex = 7;
            this.btLanguage.Text = "Change to German";
            this.btLanguage.UseVisualStyleBackColor = true;
            this.btLanguage.Click += new System.EventHandler(this.BtLanguage_Click);
            // 
            // lbCoins
            // 
            this.lbCoins.AutoSize = true;
            this.lbCoins.Location = new System.Drawing.Point(80, 42);
            this.lbCoins.Name = "lbCoins";
            this.lbCoins.Size = new System.Drawing.Size(24, 25);
            this.lbCoins.TabIndex = 13;
            this.lbCoins.Text = "_";
            // 
            // tbCodeInput
            // 
            this.tbCodeInput.Location = new System.Drawing.Point(134, 745);
            this.tbCodeInput.Name = "tbCodeInput";
            this.tbCodeInput.Size = new System.Drawing.Size(371, 31);
            this.tbCodeInput.TabIndex = 14;
            // 
            // btSubmitCode
            // 
            this.btSubmitCode.Location = new System.Drawing.Point(511, 745);
            this.btSubmitCode.Name = "btSubmitCode";
            this.btSubmitCode.Size = new System.Drawing.Size(107, 38);
            this.btSubmitCode.TabIndex = 15;
            this.btSubmitCode.Text = "Submit";
            this.btSubmitCode.UseVisualStyleBackColor = true;
            this.btSubmitCode.Click += new System.EventHandler(this.btSubmitCode_Click);
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(134, 783);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(63, 25);
            this.lbCode.TabIndex = 16;
            this.lbCode.Text = "Code";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1550, 833);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.btSubmitCode);
            this.Controls.Add(this.tbCodeInput);
            this.Controls.Add(this.lbCoins);
            this.Controls.Add(this.btWhitemode);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.btSkins);
            this.Controls.Add(this.btShop);
            this.Controls.Add(this.lbVolume);
            this.Controls.Add(this.btLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDarkmode);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainMenu";
            this.Text = "YeetBoi";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDarkmode;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Timer tmUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.Button btShop;
        private System.Windows.Forms.Button btSkins;
        private System.Windows.Forms.Button btWhitemode;
        public System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Button btLanguage;
        private System.Windows.Forms.Label lbCoins;
        private System.Windows.Forms.TextBox tbCodeInput;
        private System.Windows.Forms.Button btSubmitCode;
        private System.Windows.Forms.Label lbCode;
    }
}