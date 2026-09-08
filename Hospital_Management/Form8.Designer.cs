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
            itemPanel.Location = new Point(285, 125);
            itemPanel.Name = "itemPanel";
            itemPanel.Size = new Size(512, 268);
            itemPanel.TabIndex = 1;
            // 
            // btnAddP
            // 
            btnAddP.Location = new Point(446, 3);
            btnAddP.Name = "btnAddP";
            btnAddP.Size = new Size(54, 24);
            btnAddP.TabIndex = 0;
            btnAddP.Text = "+";
            btnAddP.UseVisualStyleBackColor = true;
            // 
            // btnPrescribe
            // 
            btnPrescribe.Location = new Point(354, 411);
            btnPrescribe.Name = "btnPrescribe";
            btnPrescribe.Size = new Size(92, 32);
            btnPrescribe.TabIndex = 0;
            btnPrescribe.Text = "Prescribe";
            btnPrescribe.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            lblDetails.BackColor = SystemColors.Control;
            lblDetails.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetails.ForeColor = Color.Black;
            lblDetails.Location = new Point(3, -4);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(787, 79);
            lblDetails.TabIndex = 2;
            lblDetails.Text = "Details";
            lblDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PrescriptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.doctorprescribers;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDetails);
            Controls.Add(btnPrescribe);
            Controls.Add(itemPanel);
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