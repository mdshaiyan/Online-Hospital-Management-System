using System;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class signUpForm : Form
    {
        public signUpForm()
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = tbxSName.Text.Trim();
            string password = tbxSPass.Text.Trim();

            // Check username and password
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Check role selection
            if (cbSignUp.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a role.",
                    "Missing Role",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string role = cbSignUp.SelectedItem.ToString();

            try
            {
                // Check if username already exists
                if (DatabaseHelper.UsernameExists(username))
                {
                    MessageBox.Show(
                        "Username already exists. Please choose another username.",
                        "Username Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Create account
                bool success =
                    DatabaseHelper.SignUp(username, password, role);

                if (success)
                {
                    MessageBox.Show(
                        "Account created successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Return to existing login form
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is mainForm)
                        {
                            form.Show();
                            this.Close();
                            return;
                        }
                    }

                    // Fallback if mainForm is not already open
                    mainForm mForm = new mainForm();
                    mForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Account creation failed.",
                        "Signup Failed",
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

        
    }
}