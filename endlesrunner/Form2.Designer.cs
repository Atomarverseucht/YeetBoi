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
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btDarkmode
            // 
            this.btDarkmode.Location = new System.Drawing.Point(48, 160);
            this.btDarkmode.Name = "btDarkmode";
            this.btDarkmode.Size = new System.Drawing.Size(83, 29);
            this.btDarkmode.TabIndex = 0;
            this.btDarkmode.Text = "Darkmode";
            this.btDarkmode.UseVisualStyleBackColor = true;
            this.btDarkmode.Click += new System.EventHandler(this.btDarkmode_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(573, 378);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(90, 43);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(204, 88);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(238, 75);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Play";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(547, 22);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(38, 13);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Time:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(547, 55);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(38, 13);
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
            this.label1.Location = new System.Drawing.Point(263, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "YeetBoi";
            // 
            // lbVolume
            // 
            this.lbVolume.AutoSize = true;
            this.lbVolume.Location = new System.Drawing.Point(295, 317);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(42, 13);
            this.lbVolume.TabIndex = 8;
            this.lbVolume.Text = "Volume";
            // 
            // btShop
            // 
            this.btShop.Location = new System.Drawing.Point(204, 205);
            this.btShop.Name = "btShop";
            this.btShop.Size = new System.Drawing.Size(105, 38);
            this.btShop.TabIndex = 9;
            this.btShop.Text = "Shop";
            this.btShop.UseVisualStyleBackColor = true;
            // 
            // btSkins
            // 
            this.btSkins.Location = new System.Drawing.Point(326, 205);
            this.btSkins.Name = "btSkins";
            this.btSkins.Size = new System.Drawing.Size(116, 38);
            this.btSkins.TabIndex = 10;
            this.btSkins.Text = "Skins";
            this.btSkins.UseVisualStyleBackColor = true;
            this.btSkins.Click += new System.EventHandler(this.BtSkins_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(186, 333);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(266, 45);
            this.tbVolume.TabIndex = 11;
            this.tbVolume.TickFrequency = 10;
            // 
            // btWhitemode
            // 
            this.btWhitemode.Location = new System.Drawing.Point(48, 195);
            this.btWhitemode.Name = "btWhitemode";
            this.btWhitemode.Size = new System.Drawing.Size(83, 26);
            this.btWhitemode.TabIndex = 12;
            this.btWhitemode.Text = "Whitemode";
            this.btWhitemode.UseVisualStyleBackColor = true;
            this.btWhitemode.Click += new System.EventHandler(this.btWhitemode_Click);
            // 
            // btLanguage
            // 
            this.btLanguage.Location = new System.Drawing.Point(204, 249);
            this.btLanguage.Name = "btLanguage";
            this.btLanguage.Size = new System.Drawing.Size(238, 42);
            this.btLanguage.TabIndex = 7;
            this.btLanguage.Text = "Change to German";
            this.btLanguage.UseVisualStyleBackColor = true;
            this.btLanguage.Click += new System.EventHandler(this.BtLanguage_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 433);
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
    }
}