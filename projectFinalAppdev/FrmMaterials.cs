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
    public partial class FrmMaterials : Form
    {
        public FrmMaterials()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormManager.ShowUnique<Dash>();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
           FormManager.ShowUnique<FrmMyProfile>();
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            FormManager.ShowUnique<FrmSalesHistory>();  
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormManager.ShowUnique<FrmProducts>();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           FormManager.ShowUnique<Report>();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
         FormManager.ShowUnique<FrmCustomers>();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            FormManager.ShowUnique<FrmSignOut>();
        }
    }
}
