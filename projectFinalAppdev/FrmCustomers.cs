using System;
using System.Linq;
using System.Windows.Forms;

namespace projectFinalAppdev
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        private void OpenUniqueForm<T>() where T : Form, new()
        {

            var existing = Application.OpenForms.OfType<T>().FirstOrDefault();
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
            // Keep this form visible; activate or create single Dash instance
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<Report>();
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
