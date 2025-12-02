using projectFinalAppdev.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:" +
            "\\Users\\FranciscoNathan\\Documents\\LoginsDB.mdf;Integrated " +
            "Security=True;Connect Timeout=30;Encrypt=True";
        

        private DataGridView dgvData;

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
            // Load Dashboard UserControl
            DisplayPanel.Controls.Clear();
            Instance.dashboard.Dock = DockStyle.Fill;
            Instance.dashboard.TopLevel = false;
            Instance.dashboard.Show();
            DisplayPanel.Controls.Add(Instance.dashboard);
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

        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
 
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            OpenUniqueForm<FrmSignOut>();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void DatatoViewLoad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectQuery = "SELECT EmployeeID, FirstName, LastName, Department FROM Employees";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Use a SqlDataAdapter to execute the query and fill a DataTable
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, conn))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable); // Fill the DataTable with results

                        // 2. Set the DataTable as the DataSource for the DataGridView
                        dgvData.DataSource = dataTable; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dash_Load(object sender, EventArgs e)
        {
            Instance.dashboard = new Dashboard();
            DisplayPanel.Controls.Clear();
        }
    }
}
