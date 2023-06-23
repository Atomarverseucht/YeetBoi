namespace endlesrunner
{
    partial class Skins
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
            this.lbRedDude = new System.Windows.Forms.Label();
            this.lbBlueDude = new System.Windows.Forms.Label();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            this.SuspendLayout();
            // 
            // btMenu
            // 
            this.btMenu.Location = new System.Drawing.Point(1169, 720);
            this.btMenu.Margin = new System.Windows.Forms.Padding(6);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(202, 88);
            this.btMenu.TabIndex = 2;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.BtMenu_Click);
            // 
            // lbRedDude
            // 
            this.lbRedDude.AutoSize = true;
            this.lbRedDude.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRedDude.Location = new System.Drawing.Point(224, 452);
            this.lbRedDude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRedDude.Name = "lbRedDude";
            this.lbRedDude.Size = new System.Drawing.Size(167, 45);
            this.lbRedDude.TabIndex = 3;
            this.lbRedDude.Text = "RedDude";
            // 
            // lbBlueDude
            // 
            this.lbBlueDude.AutoSize = true;
            this.lbBlueDude.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlueDude.Location = new System.Drawing.Point(596, 452);
            this.lbBlueDude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbBlueDude.Name = "lbBlueDude";
            this.lbBlueDude.Size = new System.Drawing.Size(188, 45);
            this.lbBlueDude.TabIndex = 4;
            this.lbBlueDude.Text = "BlueDude";
            // 
            // pbBlue
            // 
            this.pbBlue.Image = global::endlesrunner.Properties.Resources.chasrkter_3;
            this.pbBlue.Location = new System.Drawing.Point(528, 140);
            this.pbBlue.Margin = new System.Windows.Forms.Padding(6);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(328, 288);
            this.pbBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBlue.TabIndex = 5;
            this.pbBlue.TabStop = false;
            this.pbBlue.Click += new System.EventHandler(this.pbBlue_Click);
            // 
            // pbRed
            // 
            this.pbRed.Image = global::endlesrunner.Properties.Resources.chrakter_neu;
            this.pbRed.Location = new System.Drawing.Point(148, 140);
            this.pbRed.Margin = new System.Windows.Forms.Padding(6);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(328, 288);
            this.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRed.TabIndex = 0;
            this.pbRed.TabStop = false;
            this.pbRed.Tag = "";
            this.pbRed.Click += new System.EventHandler(this.pbRed_Click);
            // 
            // Skins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1698, 865);
            this.Controls.Add(this.pbBlue);
            this.Controls.Add(this.lbBlueDude);
            this.Controls.Add(this.lbRedDude);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.pbRed);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Skins";
            this.Text = "Skins";
            this.Load += new System.EventHandler(this.Skins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Label lbRedDude;
        private System.Windows.Forms.Label lbBlueDude;
        private System.Windows.Forms.PictureBox pbBlue;
    }
}