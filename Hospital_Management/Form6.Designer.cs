namespace Hospital_Management
{
    partial class profileDetailsForm
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
            tbxPName = new TextBox();
            label1 = new Label();
            tbxPId = new TextBox();
            label2 = new Label();
            tbxPSpeciality = new TextBox();
            label3 = new Label();
            tbxAge = new TextBox();
            lblAge = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblCashier = new Label();
            SuspendLayout();
            // 
            // tbxPName
            // 
            tbxPName.BackColor = SystemColors.Info;
            tbxPName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPName.Location = new Point(364, 201);
            tbxPName.Margin = new Padding(3, 4, 3, 4);
            tbxPName.Name = "tbxPName";
            tbxPName.Size = new Size(274, 31);
            tbxPName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(271, 201);
            label1.Name = "label1";
            label1.Size = new Size(65, 27);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // tbxPId
            // 
            tbxPId.BackColor = SystemColors.Info;
            tbxPId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPId.Location = new Point(364, 260);
            tbxPId.Margin = new Padding(3, 4, 3, 4);
            tbxPId.Name = "tbxPId";
            tbxPId.ReadOnly = true;
            tbxPId.Size = new Size(270, 31);
            tbxPId.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 260);
            label2.Name = "label2";
            label2.Size = new Size(36, 27);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // tbxPSpeciality
            // 
            tbxPSpeciality.BackColor = SystemColors.Info;
            tbxPSpeciality.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPSpeciality.Location = new Point(364, 316);
            tbxPSpeciality.Margin = new Padding(3, 4, 3, 4);
            tbxPSpeciality.Name = "tbxPSpeciality";
            tbxPSpeciality.Size = new Size(270, 31);
            tbxPSpeciality.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(256, 315);
            label3.Name = "label3";
            label3.Size = new Size(92, 27);
            label3.TabIndex = 1;
            label3.Text = "Speciality:";
            // 
            // tbxAge
            // 
            tbxAge.BackColor = SystemColors.Info;
            tbxAge.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxAge.Location = new Point(364, 385);
            tbxAge.Margin = new Padding(3, 4, 3, 4);
            tbxAge.Name = "tbxAge";
            tbxAge.Size = new Size(270, 31);
            tbxAge.TabIndex = 0;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = SystemColors.ButtonFace;
            lblAge.BorderStyle = BorderStyle.Fixed3D;
            lblAge.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(271, 388);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(50, 27);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(271, 462);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Info;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(459, 462);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblCashier
            // 
            lblCashier.AutoSize = true;
            lblCashier.BackColor = Color.Transparent;
            lblCashier.Font = new Font("Times New Roman", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashier.Location = new Point(265, 126);
            lblCashier.Name = "lblCashier";
            lblCashier.Size = new Size(373, 48);
            lblCashier.TabIndex = 4;
            lblCashier.Text = "Update information";
            lblCashier.Click += lblCashier_Click;
            // 
            // profileDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.doctorthreers;
            ClientSize = new Size(942, 657);
            Controls.Add(lblCashier);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblAge);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxAge);
            Controls.Add(tbxPSpeciality);
            Controls.Add(tbxPId);
            Controls.Add(tbxPName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "profileDetailsForm";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxPName;
        private Label label1;
        private TextBox tbxPId;
        private Label label2;
        private TextBox tbxPSpeciality;
        private Label label3;
        private TextBox tbxAge;
        private Label lblAge;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblCashier;
    }
}