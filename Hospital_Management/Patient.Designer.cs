namespace Hospital_Management
{
    partial class Patient
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
            label2 = new Label();
            cmbDoctor = new ComboBox();
            dtpAppointmentDate = new DateTimePicker();
            flpTimeSlot = new FlowLayoutPanel();
            btnBookAppointment = new Button();
            btnPUpdate = new Button();
            tbxPAge = new TextBox();
            label3 = new Label();
            tbxGender = new TextBox();
            label4 = new Label();
            tbxBloodGrp = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbxMedHis = new TextBox();
            label7 = new Label();
            tbxPName = new TextBox();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            btnSpecialist = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 43);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Doctors :  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 86);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Date:";
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(162, 40);
            cmbDoctor.Margin = new Padding(3, 4, 3, 4);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(370, 28);
            cmbDoctor.TabIndex = 1;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Location = new Point(162, 81);
            dtpAppointmentDate.Margin = new Padding(3, 4, 3, 4);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(255, 27);
            dtpAppointmentDate.TabIndex = 2;
            // 
            // flpTimeSlot
            // 
            flpTimeSlot.Location = new Point(41, 137);
            flpTimeSlot.Margin = new Padding(3, 4, 3, 4);
            flpTimeSlot.Name = "flpTimeSlot";
            flpTimeSlot.Size = new Size(459, 187);
            flpTimeSlot.TabIndex = 3;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.BackColor = SystemColors.Window;
            btnBookAppointment.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookAppointment.Location = new Point(552, 205);
            btnBookAppointment.Margin = new Padding(3, 4, 3, 4);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(86, 51);
            btnBookAppointment.TabIndex = 4;
            btnBookAppointment.Text = "Book";
            btnBookAppointment.UseVisualStyleBackColor = false;
            // 
            // btnPUpdate
            // 
            btnPUpdate.BackColor = SystemColors.Window;
            btnPUpdate.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPUpdate.Location = new Point(353, 522);
            btnPUpdate.Margin = new Padding(3, 4, 3, 4);
            btnPUpdate.Name = "btnPUpdate";
            btnPUpdate.Size = new Size(179, 55);
            btnPUpdate.TabIndex = 5;
            btnPUpdate.Text = "Update";
            btnPUpdate.UseVisualStyleBackColor = false;
            // 
            // tbxPAge
            // 
            tbxPAge.Location = new Point(89, 421);
            tbxPAge.Margin = new Padding(3, 4, 3, 4);
            tbxPAge.Name = "tbxPAge";
            tbxPAge.Size = new Size(310, 27);
            tbxPAge.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 421);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 7;
            label3.Text = "Age :";
            // 
            // tbxGender
            // 
            tbxGender.Location = new Point(89, 460);
            tbxGender.Margin = new Padding(3, 4, 3, 4);
            tbxGender.Name = "tbxGender";
            tbxGender.Size = new Size(310, 27);
            tbxGender.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 464);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 7;
            label4.Text = "Gender :";
            // 
            // tbxBloodGrp
            // 
            tbxBloodGrp.Location = new Point(566, 421);
            tbxBloodGrp.Margin = new Padding(3, 4, 3, 4);
            tbxBloodGrp.Name = "tbxBloodGrp";
            tbxBloodGrp.Size = new Size(310, 27);
            tbxBloodGrp.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(459, 423);
            label5.Name = "label5";
            label5.Size = new Size(101, 17);
            label5.TabIndex = 8;
            label5.Text = "Blood Group :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Window;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(443, 464);
            label6.Name = "label6";
            label6.Size = new Size(117, 19);
            label6.TabIndex = 8;
            label6.Text = "Med. History :";
            // 
            // tbxMedHis
            // 
            tbxMedHis.Location = new Point(566, 460);
            tbxMedHis.Margin = new Padding(3, 4, 3, 4);
            tbxMedHis.Name = "tbxMedHis";
            tbxMedHis.Size = new Size(310, 27);
            tbxMedHis.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Window;
            label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(213, 363);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 9;
            label7.Text = "Name :";
            // 
            // tbxPName
            // 
            tbxPName.Location = new Point(302, 359);
            tbxPName.Margin = new Padding(3, 4, 3, 4);
            tbxPName.Name = "tbxPName";
            tbxPName.Size = new Size(310, 27);
            tbxPName.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 24);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // btnSpecialist
            // 
            btnSpecialist.BackColor = SystemColors.Window;
            btnSpecialist.Location = new Point(585, 40);
            btnSpecialist.Margin = new Padding(3, 4, 3, 4);
            btnSpecialist.Name = "btnSpecialist";
            btnSpecialist.Size = new Size(181, 39);
            btnSpecialist.TabIndex = 11;
            btnSpecialist.Text = "Specialist List";
            btnSpecialist.UseVisualStyleBackColor = false;
            btnSpecialist.Click += btnSpecialist_Click;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.updated1;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSpecialist);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbxMedHis);
            Controls.Add(tbxPName);
            Controls.Add(tbxBloodGrp);
            Controls.Add(tbxGender);
            Controls.Add(tbxPAge);
            Controls.Add(btnPUpdate);
            Controls.Add(btnBookAppointment);
            Controls.Add(flpTimeSlot);
            Controls.Add(dtpAppointmentDate);
            Controls.Add(cmbDoctor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Patient";
            Text = "Patient";
            Load += Patient_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbDoctor;
        private DateTimePicker dtpAppointmentDate;
        private FlowLayoutPanel flpTimeSlot;
        private Button btnBookAppointment;
        private Button btnPUpdate;
        private TextBox tbxPAge;
        private Label label3;
        private TextBox tbxGender;
        private Label label4;
        private TextBox tbxBloodGrp;
        private Label label5;
        private Label label6;
        private TextBox tbxMedHis;
        private Label label7;
        private TextBox tbxPName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private Button btnSpecialist;
    }
}