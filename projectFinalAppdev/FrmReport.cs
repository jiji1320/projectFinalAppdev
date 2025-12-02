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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        private void OpenUniqueForm<T>() where T : Form, new()
        {

            var openForms = Application.OpenForms.Cast<Form>().ToList();

            T existing = null;

            foreach (var f in openForms)
            {

                if (f is FrmReport || f is FrmProducts)
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
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<Dash>();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<FrmMyProfile>();
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
          OpenUniqueForm<FrmSalesHistory>();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
          OpenUniqueForm<FrmProducts>();

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
   
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
       
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
           OpenUniqueForm<FrmSignOut>();
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
    }
}
