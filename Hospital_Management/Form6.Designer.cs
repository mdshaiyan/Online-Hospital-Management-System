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
            SuspendLayout();
            // 
            // tbxPName
            // 
            tbxPName.Location = new Point(317, 185);
            tbxPName.Margin = new Padding(3, 4, 3, 4);
            tbxPName.Name = "tbxPName";
            tbxPName.Size = new Size(270, 27);
            tbxPName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 189);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // tbxPId
            // 
            tbxPId.Location = new Point(317, 247);
            tbxPId.Margin = new Padding(3, 4, 3, 4);
            tbxPId.Name = "tbxPId";
            tbxPId.ReadOnly = true;
            tbxPId.Size = new Size(270, 27);
            tbxPId.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 251);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // tbxPSpeciality
            // 
            tbxPSpeciality.Location = new Point(317, 307);
            tbxPSpeciality.Margin = new Padding(3, 4, 3, 4);
            tbxPSpeciality.Name = "tbxPSpeciality";
            tbxPSpeciality.Size = new Size(270, 27);
            tbxPSpeciality.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 311);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 1;
            label3.Text = "Speciality:";
            // 
            // tbxAge
            // 
            tbxAge.Location = new Point(317, 375);
            tbxAge.Margin = new Padding(3, 4, 3, 4);
            tbxAge.Name = "tbxAge";
            tbxAge.Size = new Size(270, 27);
            tbxAge.TabIndex = 0;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(246, 379);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 20);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(317, 469);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(502, 469);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // profileDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dcotorupdate1;
            ClientSize = new Size(801, 513);
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
    }
}