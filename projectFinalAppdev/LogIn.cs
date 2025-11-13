using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.Adapters;
using System.Windows.Forms;

namespace projectFinalAppdev
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            tbPassword.PlaceholderText = "Password";
            this.tbPassword.UseSystemPasswordChar = true;
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            Hide();

        }

        private void BtnLogIn_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dash dashboard = new Dash();
                dashboard.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Hide(); 
        }
       
        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
