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
    public partial class FrmSignOut : Form
    {
        public FrmSignOut()
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

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<FrmCustomers>();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<FrmMaterials>();
        }
    }
}
