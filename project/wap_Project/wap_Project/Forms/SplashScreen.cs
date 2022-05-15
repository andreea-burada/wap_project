using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wap_Project.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            
            //this.Width = this.BackgroundImage.Width;
            //this.Height = this.BackgroundImage.Height;
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            timerSplashScreen.Start();
            this.Close();
        }
    }
}
