namespace Hospital_Management
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            // -------------------------------
            // FORM BACKGROUND IMAGE SETTINGS
            // -------------------------------
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // -------------------------------
            // HOSPITAL LOGO SETTINGS
            // -------------------------------
            if (pictureBox1 != null)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BorderStyle = BorderStyle.None;
            }

            // -------------------------------
            // DEFAULT ROLE
            // -------------------------------
            if (cbRole.Items.Count > 0)
            {
                cbRole.SelectedIndex = 0;
            }
        }

        // ==========================================
        // LOGIN BUTTON
        // ==========================================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = tbxId.Text.Trim();
            string password = tbxPass.Text;

            // Check role selection
            if (cbRole.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a role.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string role = cbRole.SelectedItem.ToString();

            // Check ID and password
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // Check login details from database
                bool loginSuccessful =
                    DatabaseHelper.Login(id, password, role);

                if (!loginSuccessful)
                {
                    MessageBox.Show(
                        "Invalid ID, password, or role.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                MessageBox.Show(
                    "Login Successful!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // ==========================================
                // ADMIN
                // ==========================================
                if (role == "Admin")
                {
                    adminForm aForm = new adminForm();
                    aForm.Show();
                }

                // ==========================================
                // DOCTOR
                // ==========================================
                else if (role == "Doctor")
                {
                    doctorForm dForm = new doctorForm();
                    dForm.Show();
                }

                // ==========================================
                // CASHIER
                // ==========================================
                else if (role == "Cashier")
                {
                    cashierForm cForm = new cashierForm();
                    cForm.Show();
                }

                // ==========================================
                // PATIENT
                // ==========================================
                else if (role == "Patient")
                {
                    int patientID = DatabaseHelper.GetPatientID(id);

                    if (patientID == -1)
                    {
                        MessageBox.Show(
                            "Patient profile not found.",
                            "Login Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    Patient pForm = new Patient(patientID);
                    pForm.Show();
                }

                // Hide login form
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // BACK MENU
        // ==========================================
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add back action here if required
        }

        // ==========================================
        // SIGN UP BUTTON
        // ==========================================
        private void btnRSignup_Click(object sender, EventArgs e)
        {
            signUpForm suForm = new signUpForm();

            suForm.Show();

            this.Hide();
        }

        // ==========================================
        // FORM CLOSING
        // ==========================================
        private void mainForm_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // ==========================================
        // LABEL EVENTS
        // ==========================================
        private void lblPass_Click(object sender, EventArgs e)
        {
        }

        private void lblId_Click(object sender, EventArgs e)
        {
        }

        // ==========================================
        // TEXTBOX EVENTS
        // ==========================================
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxPass_TextChanged(object sender, EventArgs e)
        {
        }

        // ==========================================
        // LOGO CLICK
        // ==========================================
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // ==========================================
        // FORM LOAD
        // ==========================================
        private void mainForm_Load(object sender, EventArgs e)
        {
            // Make sure the background fills the entire form
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Make sure the hospital logo fits properly
            if (pictureBox1 != null)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}