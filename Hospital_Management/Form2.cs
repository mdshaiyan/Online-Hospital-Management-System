using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class adminForm : Form
    {
        private string currentType = "";
        public adminForm()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is mainForm)
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            currentType = "Cashier";

            try
            {
                DataTable cashiers = DatabaseHelper.GetCashiers();

                dgvStaff.DataSource = cashiers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading cashiers:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            currentType = "Doctor";

            try
            {
                DataTable doctors = DatabaseHelper.GetDoctors();

                dgvStaff.DataSource = doctors;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading doctors:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvStaff.Rows[e.RowIndex];

            if (currentType == "Doctor")
            {
                int id = Convert.ToInt32(row.Cells["DoctorID"].Value);

                string name = row.Cells["DoctorName"].Value?.ToString();
                string speciality = row.Cells["Specialization"].Value?.ToString();
                string age = row.Cells["Age"].Value?.ToString();

                profileDetailsForm detailsForm = new profileDetailsForm();

                detailsForm.LoadDoctorDetails(
                    id,
                    name,
                    speciality,
                    age
                );

                detailsForm.ShowDialog();

                DataTable doctors = DatabaseHelper.GetDoctors();
                dgvStaff.DataSource = doctors;
            }
            else if (currentType == "Cashier")
            {
                int id = Convert.ToInt32(row.Cells["CashierID"].Value);

                string name = row.Cells["CashierName"].Value?.ToString();
                string specialization = row.Cells["Specialization"].Value?.ToString();
                string age = row.Cells["Age"].Value?.ToString();

                profileDetailsForm detailsForm = new profileDetailsForm();

                detailsForm.LoadCashierDetails(id, name, specialization, age);

                detailsForm.ShowDialog();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            createForm cForm = new createForm();
            cForm.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
