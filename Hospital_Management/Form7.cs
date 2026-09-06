using System;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class createForm : Form
    {
        public createForm()
        {
            InitializeComponent();

            // Select the first role by default
            if (cbCRole.Items.Count > 0)
            {
                cbCRole.SelectedIndex = 0;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string id = tbxCId.Text.Trim();
            string password = tbxCPass.Text.Trim();

            // Check ID and password
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Check role
            if (cbCRole.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a role.",
                    "Missing Role",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string role = cbCRole.SelectedItem.ToString();

            try
            {
                // Check whether ID already exists
                if (DatabaseHelper.UsernameExists(id))
                {
                    MessageBox.Show(
                        "This ID already exists. Please choose another ID.",
                        "ID Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Create account
                bool success =
                    DatabaseHelper.SignUp(id, password, role);

                if (success)
                {
                    MessageBox.Show(
                        role + " account created successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Clear fields
                    tbxCId.Clear();
                    tbxCPass.Clear();

                    if (cbCRole.Items.Count > 0)
                    {
                        cbCRole.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Account creation failed.",
                        "Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm mForm=new mainForm();
            mForm.Show();
            this.Hide();
        }
    }
}