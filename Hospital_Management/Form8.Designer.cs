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
            label1 = new Label();
            itemPanel = new Panel();
            btnAddP = new Button();
            btnPrescribe = new Button();
            itemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(168, 72);
            label1.Name = "label1";
            label1.Size = new Size(124, 37);
            label1.TabIndex = 0;
            label1.Text = "Prescribe";
            // 
            // itemPanel
            // 
            itemPanel.Controls.Add(btnAddP);
            itemPanel.Location = new Point(125, 130);
            itemPanel.Name = "itemPanel";
            itemPanel.Size = new Size(571, 249);
            itemPanel.TabIndex = 1;
            // 
            // btnAddP
            // 
            btnAddP.Location = new Point(528, 3);
            btnAddP.Name = "btnAddP";
            btnAddP.Size = new Size(40, 23);
            btnAddP.TabIndex = 0;
            btnAddP.Text = "+";
            btnAddP.UseVisualStyleBackColor = true;
            // 
            // btnPrescribe
            // 
            btnPrescribe.Location = new Point(371, 398);
            btnPrescribe.Name = "btnPrescribe";
            btnPrescribe.Size = new Size(75, 23);
            btnPrescribe.TabIndex = 0;
            btnPrescribe.Text = "Prescribe";
            btnPrescribe.UseVisualStyleBackColor = true;
            // 
            // PrescriptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrescribe);
            Controls.Add(itemPanel);
            Controls.Add(label1);
            Name = "PrescriptionForm";
            Text = "Form8";
            itemPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel itemPanel;
        private Button btnAddP;
        private Button btnPrescribe;
    }
}