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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Doctors :  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 0;
            label2.Text = "Date:";
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(78, 30);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(324, 23);
            cmbDoctor.TabIndex = 1;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Location = new Point(78, 67);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(207, 23);
            dtpAppointmentDate.TabIndex = 2;
            // 
            // flpTimeSlot
            // 
            flpTimeSlot.Location = new Point(25, 105);
            flpTimeSlot.Name = "flpTimeSlot";
            flpTimeSlot.Size = new Size(402, 140);
            flpTimeSlot.TabIndex = 3;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.Font = new Font("Segoe UI", 15F);
            btnBookAppointment.Location = new Point(442, 159);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(75, 38);
            btnBookAppointment.TabIndex = 4;
            btnBookAppointment.Text = "Book";
            btnBookAppointment.UseVisualStyleBackColor = true;
            // 
            // btnPUpdate
            // 
            btnPUpdate.Font = new Font("Segoe UI", 15F);
            btnPUpdate.Location = new Point(352, 387);
            btnPUpdate.Name = "btnPUpdate";
            btnPUpdate.Size = new Size(87, 41);
            btnPUpdate.TabIndex = 5;
            btnPUpdate.Text = "Update";
            btnPUpdate.UseVisualStyleBackColor = true;
            // 
            // tbxPAge
            // 
            tbxPAge.Location = new Point(78, 316);
            tbxPAge.Name = "tbxPAge";
            tbxPAge.Size = new Size(272, 23);
            tbxPAge.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 319);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 7;
            label3.Text = "Age :";
            // 
            // tbxGender
            // 
            tbxGender.Location = new Point(78, 345);
            tbxGender.Name = "tbxGender";
            tbxGender.Size = new Size(272, 23);
            tbxGender.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 345);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Gender :";
            // 
            // tbxBloodGrp
            // 
            tbxBloodGrp.Location = new Point(495, 316);
            tbxBloodGrp.Name = "tbxBloodGrp";
            tbxBloodGrp.Size = new Size(272, 23);
            tbxBloodGrp.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 319);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 8;
            label5.Text = "Blood Group :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 348);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 8;
            label6.Text = "Med. History :";
            // 
            // tbxMedHis
            // 
            tbxMedHis.Location = new Point(495, 345);
            tbxMedHis.Name = "tbxMedHis";
            tbxMedHis.Size = new Size(272, 23);
            tbxMedHis.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 272);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 9;
            label7.Text = "Name :";
            // 
            // tbxPName
            // 
            tbxPName.Location = new Point(304, 269);
            tbxPName.Name = "tbxPName";
            tbxPName.Size = new Size(272, 23);
            tbxPName.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Patient";
            Text = "Patient";
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
    }
}