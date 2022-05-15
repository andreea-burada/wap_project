namespace wap_Project.Forms
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.timerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbWhiteBackground = new System.Windows.Forms.Label();
            this.pbHotelLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSplashScreen
            // 
            this.timerSplashScreen.Enabled = true;
            this.timerSplashScreen.Interval = 5000;
            this.timerSplashScreen.Tick += new System.EventHandler(this.timerSplashScreen_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(48, 437);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbWhiteBackground
            // 
            this.lbWhiteBackground.BackColor = System.Drawing.Color.White;
            this.lbWhiteBackground.Location = new System.Drawing.Point(1, 419);
            this.lbWhiteBackground.Name = "lbWhiteBackground";
            this.lbWhiteBackground.Size = new System.Drawing.Size(873, 101);
            this.lbWhiteBackground.TabIndex = 1;
            // 
            // pbHotelLogo
            // 
            this.pbHotelLogo.BackColor = System.Drawing.Color.White;
            this.pbHotelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHotelLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbHotelLogo.Image")));
            this.pbHotelLogo.Location = new System.Drawing.Point(714, 419);
            this.pbHotelLogo.Name = "pbHotelLogo";
            this.pbHotelLogo.Size = new System.Drawing.Size(118, 101);
            this.pbHotelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHotelLogo.TabIndex = 2;
            this.pbHotelLogo.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 519);
            this.Controls.Add(this.pbHotelLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbWhiteBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotelLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSplashScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbWhiteBackground;
        private System.Windows.Forms.PictureBox pbHotelLogo;
    }
}