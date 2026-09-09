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
    public partial class Blood : Form
    {
        public Blood()
        {
            InitializeComponent();
            LoadBloodGroups();
        }

        private void LoadBloodGroups()
        {
            try
            {
                DataTable patients = DatabaseHelper.GetPatientsWithBloodGroup();

                flpBlood.Controls.Clear();

                foreach (DataRow row in patients.Rows)
                {
                    string patientName = row["PatientName"].ToString();
                    string bloodGroup = row["BloodGroup"].ToString();

                    Label patientLabel = new Label();

                    patientLabel.Text =
                        "Patient:         " + patientName +
                        "     Blood Group: " + bloodGroup;

                    patientLabel.AutoSize = false;
                    patientLabel.Width = flpBlood.ClientSize.Width - 30;
                    patientLabel.Height = 45;

                    patientLabel.Font = new Font(
                        "Segoe UI",
                        11F,
                        FontStyle.Regular);

                    patientLabel.Padding = new Padding(10, 10, 5, 5);

                    patientLabel.Margin = new Padding(5);

                    flpBlood.Controls.Add(patientLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading blood group information:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
