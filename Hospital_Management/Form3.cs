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
    public partial class doctorForm : Form
    {
        public doctorForm()
        {
            InitializeComponent();
            dgvPatient.CellContentClick += dgvPatient_CellContentClick;
        }

        private void doctorForm_Load(object sender, EventArgs e)
        {

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string patientName = tbxDPatient.Text.Trim();

            if (string.IsNullOrWhiteSpace(patientName))
            {
                MessageBox.Show("Please enter a patient name.");
                return;
            }

            try
            {
                DataTable patients =
                    DatabaseHelper.SearchPatient(patientName);

                dgvPatient.DataSource = patients;

                if (patients.Rows.Count == 0)
                {
                    MessageBox.Show("No patient found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error searching patient:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void dgvPatient_CellContentClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvPatient.Rows[e.RowIndex];

            // =========================
            // VIEW HISTORY
            // =========================
            if (dgvPatient.Columns[e.ColumnIndex].Name == "ViewHistory")
            {
                int patientID =
                    Convert.ToInt32(row.Cells["PatientID"].Value);

                string patientName =
                    row.Cells["PatientName"].Value?.ToString() ?? "";

                try
                {
                    string history =
                        DatabaseHelper.GetPatientHistory(patientID);

                    if (string.IsNullOrWhiteSpace(history))
                    {
                        history =
                            "No previous medical history available.";
                    }

                    MessageBox.Show(
                        "Patient: " + patientName +
                        "\n\nPrevious Medical History:\n\n" +
                        history,
                        "Patient History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading patient history:\n\n" +
                        ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            // =========================
            // PRESCRIPTION
            // =========================
            if (dgvPatient.Columns[e.ColumnIndex].Name == "Prescription")
            {
                int patientID =
                    Convert.ToInt32(row.Cells["PatientID"].Value);

                PrescriptionForm pForm = new PrescriptionForm(patientID);

                pForm.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
