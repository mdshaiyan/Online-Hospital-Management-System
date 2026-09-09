using Microsoft.Data.SqlClient;
using System;
using System.Text.RegularExpressions;
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

            // Check username and password are not empty
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

            // Reject purely numeric usernames (e.g. "12345")
            if (username.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Username cannot consist of numbers only. Please include at least one letter.",
                    "Invalid Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Optional but recommended: restrict to sensible characters only
            // (letters, digits, underscore), so usernames like "###" or "!!!" are also blocked
            if (!Regex.IsMatch(username, @"^[a-zA-Z][a-zA-Z0-9_]{2,19}$"))
            {
                MessageBox.Show(
                    "Username must start with a letter and be 3-20 characters long " +
                    "(letters, numbers, underscores only).",
                    "Invalid Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Minimum password length as a sanity check
            if (password.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters long.",
                    "Weak Password",
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
                if (DatabaseHelper.UsernameExists(username))
                {
                    MessageBox.Show(
                        "Username already exists. Please choose another username.",
                        "Username Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                bool success = DatabaseHelper.SignUp(username, password, role);

                if (success)
                {
                    MessageBox.Show(
                        "Account created successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is mainForm)
                        {
                            form.Show();
                            this.Close();
                            return;
                        }
                    }

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
            catch (SqlException sqlEx)
            {
                MessageBox.Show(
                    "Database error:\n\n" + sqlEx.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unexpected error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}