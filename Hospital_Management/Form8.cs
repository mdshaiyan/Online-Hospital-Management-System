using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class PrescriptionForm : Form
    {
        private int patientID;
        private int rowCount = 0;

        // Store the first row separately
        private Panel firstRow;

        public PrescriptionForm(int patientID)
        {
            InitializeComponent();

            this.patientID = patientID;

            // Create first row automatically
            AddFirstRow();

            // Button events
            btnAddP.Click += btnAddP_Click;
            btnPrescribe.Click += btnPrescribe_Click;
        }

        // =====================================================
        // FIRST ROW
        // Disease + Medicine + Time + Days
        // =====================================================
        private void AddFirstRow()
        {
            Panel row = new Panel();

            row.Width = itemPanel.ClientSize.Width - 10;
            row.Height = 45;

            row.Location = new Point(
                5,
                rowCount * 45
            );

            // -------------------------
            // Disease
            // -------------------------
            TextBox tbxDisease = new TextBox();

            tbxDisease.Width = 130;
            tbxDisease.Height = 30;
            tbxDisease.Location = new Point(5, 7);
            tbxDisease.PlaceholderText = "Disease";

            // -------------------------
            // Medicine
            // -------------------------
            TextBox tbxMedicine = new TextBox();

            tbxMedicine.Width = 150;
            tbxMedicine.Height = 30;
            tbxMedicine.Location = new Point(145, 7);
            tbxMedicine.PlaceholderText = "Medicine Name";

            // -------------------------
            // Time
            // -------------------------
            TextBox tbxTime = new TextBox();

            tbxTime.Width = 100;
            tbxTime.Height = 30;
            tbxTime.Location = new Point(305, 7);
            tbxTime.PlaceholderText = "Time";

            // -------------------------
            // Days
            // -------------------------
            TextBox tbxDays = new TextBox();

            tbxDays.Width = 80;
            tbxDays.Height = 30;
            tbxDays.Location = new Point(415, 7);
            tbxDays.PlaceholderText = "Days";

            // Add controls to row
            row.Controls.Add(tbxDisease);
            row.Controls.Add(tbxMedicine);
            row.Controls.Add(tbxTime);
            row.Controls.Add(tbxDays);

            // Add row to panel
            itemPanel.Controls.Add(row);

            // Remember this row
            firstRow = row;

            rowCount++;
        }

        // =====================================================
        // ADDITIONAL ROW
        // Medicine + Time + Days ONLY
        // =====================================================
        private void AddMedicineRow()
        {
            Panel row = new Panel();

            row.Width = itemPanel.ClientSize.Width - 10;
            row.Height = 45;

            row.Location = new Point(
                5,
                rowCount * 45
            );

            // -------------------------
            // Medicine
            // -------------------------
            TextBox tbxMedicine = new TextBox();

            tbxMedicine.Width = 150;
            tbxMedicine.Height = 30;
            tbxMedicine.Location = new Point(145, 7);
            tbxMedicine.PlaceholderText = "Medicine Name";

            // -------------------------
            // Time
            // -------------------------
            TextBox tbxTime = new TextBox();

            tbxTime.Width = 100;
            tbxTime.Height = 30;
            tbxTime.Location = new Point(305, 7);
            tbxTime.PlaceholderText = "Time";

            // -------------------------
            // Days
            // -------------------------
            TextBox tbxDays = new TextBox();

            tbxDays.Width = 80;
            tbxDays.Height = 30;
            tbxDays.Location = new Point(415, 7);
            tbxDays.PlaceholderText = "Days";

            // Add controls
            row.Controls.Add(tbxMedicine);
            row.Controls.Add(tbxTime);
            row.Controls.Add(tbxDays);

            // Add row to panel
            itemPanel.Controls.Add(row);

            rowCount++;
        }

        // =====================================================
        // + BUTTON
        // =====================================================
        private void btnAddP_Click(object sender, EventArgs e)
        {
            AddMedicineRow();
        }

        // =====================================================
        // PRESCRIBE BUTTON
        // =====================================================
        private void btnPrescribe_Click(object sender, EventArgs e)
        {
            if (patientID <= 0)
            {
                MessageBox.Show(
                    "Patient information is missing.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (firstRow == null)
            {
                MessageBox.Show(
                    "Prescription row was not created.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // =================================================
            // GET FIRST ROW DATA
            // =================================================

            TextBox firstDisease =
                firstRow.Controls[0] as TextBox;

            TextBox firstMedicine =
                firstRow.Controls[1] as TextBox;

            TextBox firstTime =
                firstRow.Controls[2] as TextBox;

            TextBox firstDays =
                firstRow.Controls[3] as TextBox;

            string disease =
                firstDisease.Text.Trim();

            // =================================================
            // VALIDATE DISEASE
            // =================================================

            if (string.IsNullOrWhiteSpace(disease))
            {
                MessageBox.Show(
                    "Please enter the disease.",
                    "Missing Disease",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // =================================================
            // MEDICINE LIST
            // =================================================

            List<string> medicines =
                new List<string>();

            // First medicine
            if (!AddMedicineToList(
                    medicines,
                    firstMedicine.Text.Trim(),
                    firstTime.Text.Trim(),
                    firstDays.Text.Trim()))
            {
                return;
            }

            // =================================================
            // ADDITIONAL MEDICINE ROWS
            // =================================================

            foreach (Control control in itemPanel.Controls)
            {
                // Only process dynamically created Panel rows
                if (control is Panel row && row != firstRow)
                {
                    TextBox medicine =
                        row.Controls[0] as TextBox;

                    TextBox time =
                        row.Controls[1] as TextBox;

                    TextBox days =
                        row.Controls[2] as TextBox;

                    string medicineName =
                        medicine.Text.Trim();

                    string medicineTime =
                        time.Text.Trim();

                    string medicineDays =
                        days.Text.Trim();

                    // Ignore completely empty rows
                    if (string.IsNullOrWhiteSpace(medicineName) &&
                        string.IsNullOrWhiteSpace(medicineTime) &&
                        string.IsNullOrWhiteSpace(medicineDays))
                    {
                        continue;
                    }

                    if (!AddMedicineToList(
                            medicines,
                            medicineName,
                            medicineTime,
                            medicineDays))
                    {
                        return;
                    }
                }
            }

            // =================================================
            // CREATE HISTORY TEXT
            // =================================================

            string prescriptionText =
                "Prescription - " +
                DateTime.Now.ToString("dd/MM/yyyy") +
                Environment.NewLine +
                "Disease: " +
                disease +
                Environment.NewLine;

            foreach (string medicine in medicines)
            {
                prescriptionText +=
                    medicine +
                    Environment.NewLine;
            }

            // =================================================
            // SAVE TO DATABASE
            // =================================================

            try
            {
                bool success =
                    DatabaseHelper.AddPrescriptionToHistory(
                        patientID,
                        prescriptionText);

                if (success)
                {
                    MessageBox.Show(
                        "Prescription added to patient history successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Prescription could not be saved.",
                        "Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving prescription:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // VALIDATE MEDICINE
        // =====================================================
        private bool AddMedicineToList(
            List<string> medicines,
            string medicine,
            string time,
            string days)
        {
            if (string.IsNullOrWhiteSpace(medicine))
            {
                MessageBox.Show(
                    "Please enter the medicine name.",
                    "Missing Medicine",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (string.IsNullOrWhiteSpace(time))
            {
                MessageBox.Show(
                    "Please enter the medicine time.",
                    "Missing Time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (!int.TryParse(
                    days,
                    out int numberOfDays) ||
                numberOfDays <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid number of days.",
                    "Invalid Days",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            medicines.Add(
                "Medicine: " + medicine +
                " | Time: " + time +
                " | Days: " + numberOfDays);

            return true;
        }
    }
}