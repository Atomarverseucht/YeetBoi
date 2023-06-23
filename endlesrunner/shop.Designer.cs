namespace endlesrunner
{
    partial class shop
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
            this.btMenu = new System.Windows.Forms.Button();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.lbBlueDude = new System.Windows.Forms.Label();
            this.pbBack1 = new System.Windows.Forms.PictureBox();
            this.lbBack1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack1)).BeginInit();
            this.SuspendLayout();
            // 
            // btMenu
            // 
            this.btMenu.Location = new System.Drawing.Point(1202, 737);
            this.btMenu.Margin = new System.Windows.Forms.Padding(6);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(202, 88);
            this.btMenu.TabIndex = 3;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // pbBlue
            // 
            this.pbBlue.Image = global::endlesrunner.Properties.Resources.chasrkter_3;
            this.pbBlue.Location = new System.Drawing.Point(129, 68);
            this.pbBlue.Margin = new System.Windows.Forms.Padding(6);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(328, 288);
            this.pbBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBlue.TabIndex = 6;
            this.pbBlue.TabStop = false;
            this.pbBlue.Click += new System.EventHandler(this.pbBlue_Click);
            // 
            // lbBlueDude
            // 
            this.lbBlueDude.AutoSize = true;
            this.lbBlueDude.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlueDude.Location = new System.Drawing.Point(185, 384);
            this.lbBlueDude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbBlueDude.Name = "lbBlueDude";
            this.lbBlueDude.Size = new System.Drawing.Size(251, 90);
            this.lbBlueDude.TabIndex = 7;
            this.lbBlueDude.Text = "BlueDude\r\n(100 Coins)\r\n";
            this.lbBlueDude.Click += new System.EventHandler(this.lbBlueDude_Click);
            // 
            // pbBack1
            // 
            this.pbBack1.Image = global::endlesrunner.Properties.Resources.welt;
            this.pbBack1.Location = new System.Drawing.Point(73, 528);
            this.pbBack1.Margin = new System.Windows.Forms.Padding(6);
            this.pbBack1.Name = "pbBack1";
            this.pbBack1.Size = new System.Drawing.Size(423, 288);
            this.pbBack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack1.TabIndex = 8;
            this.pbBack1.TabStop = false;
            this.pbBack1.Click += new System.EventHandler(this.pbBack1_Click);
            // 
            // lbBack1
            // 
            this.lbBack1.AutoSize = true;
            this.lbBack1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack1.Location = new System.Drawing.Point(92, 822);
            this.lbBack1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbBack1.Name = "lbBack1";
            this.lbBack1.Size = new System.Drawing.Size(377, 90);
            this.lbBack1.TabIndex = 9;
            this.lbBack1.Text = "Tree / Background\r\n(150 Coins)\r\n";
            this.lbBack1.Click += new System.EventHandler(this.lbBack1_Click);
            // 
            // shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 962);
            this.Controls.Add(this.lbBack1);
            this.Controls.Add(this.pbBack1);
            this.Controls.Add(this.lbBlueDude);
            this.Controls.Add(this.pbBlue);
            this.Controls.Add(this.btMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "shop";
            this.Text = "shop";
            this.Load += new System.EventHandler(this.shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.Label lbBlueDude;
        private System.Windows.Forms.PictureBox pbBack1;
        private System.Windows.Forms.Label lbBack1;
    }
}