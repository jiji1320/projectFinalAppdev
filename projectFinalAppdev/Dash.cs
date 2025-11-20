using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectFinalAppdev
{
    
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 200)
            {
                MenuVertical.Width = 35;
            }
            else
            {
                MenuVertical.Width = 200;
            }
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        public void OpenUniqueForm<T>() where T : Form, new()
        {


            var openForms = Application.OpenForms.Cast<Form>().ToList();

            T existing = null;

            foreach (var f in openForms)
            {

                if (f is Dash || f is LogIn)
                    continue;

               
                if (f is T)
                    existing = (T)f;
                else
                    f.Hide();
            }

            if (existing != null)
            {
                if (existing.WindowState == FormWindowState.Minimized)
                    existing.WindowState = FormWindowState.Normal;
                existing.BringToFront();
                existing.Activate();
            }
            else
            {
                var form = new T();
                form.Show();
            }
        }
        

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            var profileForm = new FrmMyProfile();
            profileForm.FormClosed += (s, args) => this.Show();
            profileForm.Show();
            this.Hide(); // keep instance for later Show()
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<FrmSalesHistory>();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<FrmProducts>();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<FrmReport>();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<FrmCustomers>();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<FrmMaterials>();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<FrmSignOut>();
        }
    }
}
