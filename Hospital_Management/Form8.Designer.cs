namespace Hospital_Management
{
    partial class PrescriptionForm
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
            itemPanel = new Panel();
            btnAddP = new Button();
            btnPrescribe = new Button();
            lblDetails = new Label();
            itemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // itemPanel
            // 
            itemPanel.Controls.Add(btnAddP);
            itemPanel.Location = new Point(326, 167);
            itemPanel.Margin = new Padding(3, 4, 3, 4);
            itemPanel.Name = "itemPanel";
            itemPanel.Size = new Size(585, 357);
            itemPanel.TabIndex = 1;
            // 
            // btnAddP
            // 
            btnAddP.Location = new Point(510, 4);
            btnAddP.Margin = new Padding(3, 4, 3, 4);
            btnAddP.Name = "btnAddP";
            btnAddP.Size = new Size(62, 32);
            btnAddP.TabIndex = 0;
            btnAddP.Text = "+";
            btnAddP.UseVisualStyleBackColor = true;
            // 
            // btnPrescribe
            // 
            btnPrescribe.Location = new Point(405, 548);
            btnPrescribe.Margin = new Padding(3, 4, 3, 4);
            btnPrescribe.Name = "btnPrescribe";
            btnPrescribe.Size = new Size(105, 43);
            btnPrescribe.TabIndex = 0;
            btnPrescribe.Text = "Prescribe";
            btnPrescribe.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            lblDetails.BackColor = SystemColors.Control;
            lblDetails.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetails.ForeColor = Color.Black;
            lblDetails.Location = new Point(3, -5);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(899, 105);
            lblDetails.TabIndex = 2;
            lblDetails.Text = "Details";
            lblDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PrescriptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.doctorprescribers;
            ClientSize = new Size(914, 600);
            Controls.Add(lblDetails);
            Controls.Add(btnPrescribe);
            Controls.Add(itemPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrescriptionForm";
            Text = "Form8";
            itemPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel itemPanel;
        private Button btnAddP;
        private Button btnPrescribe;
        private Label lblDetails;
    }
}