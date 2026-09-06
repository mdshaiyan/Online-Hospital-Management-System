using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Patient : Form
    {
        private int selectedDoctorID = -1;

        private TimeSpan selectedStartTime;
        private TimeSpan selectedEndTime;
        private int patientId;

        public Patient(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;

            LoadPatientDetails();
            LoadDoctors();

            dtpAppointmentDate.ValueChanged += dtpAppointmentDate_ValueChanged;
            cmbDoctor.SelectedIndexChanged += cmbDoctor_SelectedIndexChanged;
            btnBookAppointment.Click += btnBookAppointment_Click;
            btnPUpdate.Click += btnPUpdate_Click;
        }

        private void LoadPatientDetails()
        {
            try
            {
                string query = @"
            SELECT
                PatientName,
                Age,
                Gender,
                BloodGroup,
                MedicalHistory
            FROM Patients
            WHERE PatientID = @patientID";

                DataTable patient =
                    DatabaseHelper.ExecuteQuery(
                        query,
                        new Microsoft.Data.SqlClient.SqlParameter(
                            "@patientID",
                            patientId));

                if (patient.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Patient details not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                DataRow row = patient.Rows[0];

                tbxPName.Text =
                    row["PatientName"] == DBNull.Value
                    ? ""
                    : row["PatientName"].ToString();

                tbxPAge.Text =
                    row["Age"] == DBNull.Value
                    ? ""
                    : row["Age"].ToString();

                tbxGender.Text =
                    row["Gender"] == DBNull.Value
                    ? ""
                    : row["Gender"].ToString();

                tbxBloodGrp.Text =
                    row["BloodGroup"] == DBNull.Value
                    ? ""
                    : row["BloodGroup"].ToString();

                tbxMedHis.Text =
                    row["MedicalHistory"] == DBNull.Value
                    ? ""
                    : row["MedicalHistory"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading patient details:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            if (patientId <= 0)
            {
                MessageBox.Show(
                    "Patient information is missing.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (!int.TryParse(tbxPAge.Text.Trim(), out int age))
            {
                MessageBox.Show(
                    "Please enter a valid age.",
                    "Invalid Age",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(tbxPName.Text))
            {
                MessageBox.Show(
                    "Please enter your name.",
                    "Missing Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                bool success =
                    DatabaseHelper.UpdatePatient(
                        patientId,
                        tbxPName.Text.Trim(),
                        age,
                        tbxGender.Text.Trim(),
                        tbxBloodGrp.Text.Trim(),
                        tbxMedHis.Text.Trim());

                if (success)
                {
                    MessageBox.Show(
                        "Patient details updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Patient details could not be updated.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating patient details:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadDoctors()
        {
            try
            {
                DataTable doctors =
                    DatabaseHelper.GetDoctorsForAppointment();

                cmbDoctor.DataSource = doctors;
                cmbDoctor.DisplayMember = "DoctorName";
                cmbDoctor.ValueMember = "DoctorID";

                if (doctors.Rows.Count > 0)
                {
                    cmbDoctor.SelectedIndex = 0;
                    LoadTimeSlots();
                }
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



        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetSelectedTime();
            LoadTimeSlots();
        }


        private void dtpAppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            ResetSelectedTime();
            LoadTimeSlots();
        }



        private void LoadTimeSlots()
        {
            if (cmbDoctor.SelectedItem == null)
                return;

            DataRowView row = cmbDoctor.SelectedItem as DataRowView;

            if (row == null)
                return;

            int doctorID = Convert.ToInt32(row["DoctorID"]);

            selectedDoctorID = doctorID;

            flpTimeSlot.Controls.Clear();

            // 9 AM to 5 PM
            for (int hour = 9; hour < 17; hour++)
            {
                TimeSpan startTime =
                    new TimeSpan(hour, 0, 0);

                TimeSpan endTime =
                    new TimeSpan(hour + 1, 0, 0);

                Button slotButton = new Button();

                slotButton.Width = 110;
                slotButton.Height = 45;

                slotButton.Text =
                    FormatTime(startTime) +
                    " - " +
                    FormatTime(endTime);

                slotButton.Tag = new TimeSlot
                {
                    StartTime = startTime,
                    EndTime = endTime
                };

                bool booked =
                    DatabaseHelper.IsTimeSlotBooked(
                        doctorID,
                        dtpAppointmentDate.Value.Date,
                        startTime,
                        endTime);

                if (booked)
                {
                    slotButton.BackColor = Color.Red;
                    slotButton.ForeColor = Color.White;
                    slotButton.Enabled = false;

                    slotButton.Text += "\nBooked";
                }
                else
                {
                    slotButton.BackColor = Color.LightGreen;
                    slotButton.ForeColor = Color.Black;

                    slotButton.Click += TimeSlotButton_Click;
                }

                flpTimeSlot.Controls.Add(slotButton);
            }
        }


        private void TimeSlotButton_Click(
            object sender,
            EventArgs e)
        {
            Button clickedButton =
                sender as Button;

            if (clickedButton == null)
                return;

            TimeSlot slot =
                clickedButton.Tag as TimeSlot;

            if (slot == null)
                return;

            // Reset other available slots
            foreach (Control control in flpTimeSlot.Controls)
            {
                if (control is Button button &&
                    button.Enabled)
                {
                    button.BackColor =
                        Color.LightGreen;

                    button.ForeColor =
                        Color.Black;
                }
            }

            // Select this slot
            clickedButton.BackColor = Color.DodgerBlue;

            clickedButton.ForeColor = Color.White;

            selectedStartTime = slot.StartTime;

            selectedEndTime = slot.EndTime;
        }




        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            if (patientId <= 0)
            {
                MessageBox.Show(
                    "Patient information is missing.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (selectedDoctorID <= 0)
            {
                MessageBox.Show(
                    "Please select a doctor.",
                    "Missing Doctor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (selectedStartTime == TimeSpan.Zero && selectedEndTime == TimeSpan.Zero)
            {
                MessageBox.Show(
                    "Please select a time slot.",
                    "Missing Time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // Check again before booking
                bool alreadyBooked = DatabaseHelper.IsTimeSlotBooked(
                        selectedDoctorID,
                        dtpAppointmentDate.Value.Date,
                        selectedStartTime,
                        selectedEndTime);

                if (alreadyBooked)
                {
                    MessageBox.Show("This time slot has already been booked.", "Slot Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LoadTimeSlots();
                    ResetSelectedTime();

                    return;
                }

                bool success = DatabaseHelper.BookAppointment(patientId, selectedDoctorID, dtpAppointmentDate.Value.Date, selectedStartTime, selectedEndTime);

                if (success)
                {
                    MessageBox.Show("Appointment booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetSelectedTime();

                    LoadTimeSlots();
                }
                else
                {
                    MessageBox.Show(
                        "Appointment booking failed.",
                        "Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error booking appointment:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ResetSelectedTime()
        {
            selectedStartTime = TimeSpan.Zero;
            selectedEndTime = TimeSpan.Zero;
        }


        private string FormatTime(TimeSpan time)
        {
            return DateTime.Today.Add(time).ToString("h:mm tt");
        }


        private class TimeSlot
        {
            public TimeSpan StartTime { get; set; }

            public TimeSpan EndTime { get; set; }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm mForm = new mainForm();
            mForm.Show();
            this.Hide();
        }
    }
}