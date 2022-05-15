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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            
            InitializeComponent();
        }

        private void chkbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxPassword.Checked == true)
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '●';
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SignupForm signupWindow = new SignupForm();
            if (signupWindow.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("it worked");
            }
        }
    }
}
