using System;
using System.Linq;
using System.Windows.Forms;

namespace projectFinalAppdev
{
    public partial class FrmMyProfile : Form
    {
        public FrmMyProfile()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Keep this form visible; activate or create single Dash instance
            OpenUniqueForm<Dash>();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void OpenUniqueForm<T>() where T : Form, new()
        {

            var openForms = Application.OpenForms.Cast<Form>().ToList();

            T existing = null;

            foreach (var f in openForms)
            {

                if (f is FrmMyProfile || f is Dash)
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
      
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<FrmSignOut>();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
