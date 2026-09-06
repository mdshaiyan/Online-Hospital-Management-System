using System;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class profileDetailsForm : Form
    {
        private string staffType = "";

        public profileDetailsForm()
        {
            InitializeComponent();
        }

        public void LoadDoctorDetails(int id, string name, string speciality, string age)
        {
            staffType = "Doctor";

            tbxPId.Text = id.ToString();
            tbxPName.Text = name;
            tbxPSpeciality.Text = speciality;
            tbxAge.Text = age;
        }

        public void LoadCashierDetails(int id,string name,string specialization,string age)
        {
            staffType = "Cashier";

            tbxPId.Text = id.ToString();
            tbxPName.Text = name;
            tbxPSpeciality.Text = specialization;
            tbxAge.Text = age;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxPId.Text, out int id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxPName.Text))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            if (!int.TryParse(tbxAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            try
            {
                bool success = false;

                if (staffType == "Doctor")
                {
                    success = DatabaseHelper.UpdateDoctor(
                        id,
                        tbxPName.Text.Trim(),
                        tbxPSpeciality.Text.Trim(),
                        age
                    );
                }
                else if (staffType == "Cashier")
                {
                    success = DatabaseHelper.UpdateCashier(
                        id,
                        tbxPName.Text.Trim(),
                        tbxPSpeciality.Text.Trim(),
                        age
                    );
                }

                if (success)
                {
                    MessageBox.Show(
                        staffType + " updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Update failed.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating " + staffType + ":\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxPId.Text, out int id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this " +
                staffType.ToLower() + "?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                bool success = false;

                if (staffType == "Doctor")
                {
                    success = DatabaseHelper.DeleteDoctor(id);
                }
                else if (staffType == "Cashier")
                {
                    success = DatabaseHelper.DeleteCashier(id);
                }

                if (success)
                {
                    MessageBox.Show(
                        staffType + " deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Delete failed.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deleting " + staffType + ":\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
    }
}