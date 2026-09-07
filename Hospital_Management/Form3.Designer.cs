namespace Hospital_Management
{
    partial class doctorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbxDPatient = new TextBox();
            label2 = new Label();
            btnDSearch = new Button();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            dgvPatient = new DataGridView();
            PatientID = new DataGridViewTextBoxColumn();
            ViewHistory = new DataGridViewButtonColumn();
            Prescription = new DataGridViewButtonColumn();
            Blood_Group = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 50);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 0;
            label1.Text = "Doctor";
            label1.Click += label1_Click;
            // 
            // tbxDPatient
            // 
            tbxDPatient.Location = new Point(253, 107);
            tbxDPatient.Name = "tbxDPatient";
            tbxDPatient.Size = new Size(231, 23);
            tbxDPatient.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Aquamarine;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(187, 109);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 4;
            label2.Text = "Patient:";
            label2.Click += label2_Click;
            // 
            // btnDSearch
            // 
            btnDSearch.BackColor = SystemColors.Info;
            btnDSearch.Location = new Point(507, 107);
            btnDSearch.Name = "btnDSearch";
            btnDSearch.Size = new Size(75, 23);
            btnDSearch.TabIndex = 5;
            btnDSearch.Text = "Search";
            btnDSearch.UseVisualStyleBackColor = false;
            btnDSearch.Click += btnSearch_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // dgvPatient
            // 
            dgvPatient.AllowUserToAddRows = false;
            dgvPatient.AllowUserToDeleteRows = false;
            dgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatient.Columns.AddRange(new DataGridViewColumn[] { PatientID, ViewHistory, Prescription, Blood_Group, PatientName, Age, Gender });
            dgvPatient.Location = new Point(12, 154);
            dgvPatient.MultiSelect = false;
            dgvPatient.Name = "dgvPatient";
            dgvPatient.ReadOnly = true;
            dgvPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatient.Size = new Size(776, 267);
            dgvPatient.TabIndex = 8;
            // 
            // PatientID
            // 
            PatientID.DataPropertyName = "PatientID";
            PatientID.HeaderText = "Patient ID";
            PatientID.Name = "PatientID";
            PatientID.ReadOnly = true;
            // 
            // ViewHistory
            // 
            ViewHistory.HeaderText = "History";
            ViewHistory.Name = "ViewHistory";
            ViewHistory.ReadOnly = true;
            ViewHistory.Text = "History";
            ViewHistory.UseColumnTextForButtonValue = true;
            // 
            // Prescription
            // 
            Prescription.HeaderText = "Prescription";
            Prescription.Name = "Prescription";
            Prescription.ReadOnly = true;
            Prescription.Text = "Prescribe";
            Prescription.UseColumnTextForButtonValue = true;
            // 
            // Blood_Group
            // 
            Blood_Group.DataPropertyName = "BloodGroup";
            Blood_Group.HeaderText = "BloodGroup";
            Blood_Group.Name = "Blood_Group";
            Blood_Group.ReadOnly = true;
            // 
            // PatientName
            // 
            PatientName.DataPropertyName = "PatientName";
            PatientName.HeaderText = "Patient Name";
            PatientName.Name = "PatientName";
            PatientName.ReadOnly = true;
            // 
            // Age
            // 
            Age.DataPropertyName = "PatientID";
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // doctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_abstract_blur_hospital_clinic_counter_interior_defocused_medical_background_image_15646915;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPatient);
            Controls.Add(menuStrip1);
            Controls.Add(btnDSearch);
            Controls.Add(label2);
            Controls.Add(tbxDPatient);
            Controls.Add(label1);
            Name = "doctorForm";
            Text = "Form3";
            Load += doctorForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxDPatient;
        private Label label2;
        private Button btnDSearch;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private DataGridView dgvPatient;
        private DataGridViewTextBoxColumn PatientID;
        private DataGridViewButtonColumn ViewHistory;
        private DataGridViewButtonColumn Prescription;
        private DataGridViewTextBoxColumn Blood_Group;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
    }
}