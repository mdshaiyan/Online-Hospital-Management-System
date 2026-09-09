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
    public partial class DoctorList : Form
    {
        public DoctorList()
        {
            InitializeComponent();

            flpSpecialist.FlowDirection = FlowDirection.TopDown;
            flpSpecialist.WrapContents = false;
            flpSpecialist.AutoScroll = true;

            LoadSpecializations();
        }

        private void LoadSpecializations()
        {
            DataTable table = DatabaseHelper.GetSpecializationCounts();

            flpSpecialist.Controls.Clear();

            foreach (DataRow row in table.Rows)
            {
                string specialization = row["Specialization"].ToString();
                int count = Convert.ToInt32(row["DoctorCount"]);

                Button btn = new Button();

                btn.Text = specialization + " (" + count + "   doctors)";
                btn.Width = flpSpecialist.ClientSize.Width - 25;
                btn.Height = 45;

                btn.Tag = specialization;
                btn.Click += Specialization_Click;

                flpSpecialist.Controls.Add(btn);
            }
        }

        private void Specialization_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string specialization = btn.Tag.ToString();

            ShowDoctors(specialization);
        }

        private void ShowDoctors(string specialization)
        {
            DataTable table =
                DatabaseHelper.GetDoctorsBySpecialization(specialization);

            flpSpecialist.Controls.Clear();

            foreach (DataRow row in table.Rows)
            {
                Label doctor = new Label();

                doctor.Text =
                    "Doctor:   " + row["DoctorName"] +
                    "\nSpecialization:   " + row["Specialization"] +
                    "\nAge: " + row["Age"];

                doctor.Width = flpSpecialist.ClientSize.Width - 25;
                doctor.Height = 70;
                doctor.Padding = new Padding(10);
                doctor.Margin = new Padding(5);

                flpSpecialist.Controls.Add(doctor);
            }
        }
    }
}
