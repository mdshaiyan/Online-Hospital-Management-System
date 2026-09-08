namespace Hospital_Management
{
    partial class createForm
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
            tbxCId = new TextBox();
            label1 = new Label();
            tbxCPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbCRole = new ComboBox();
            btnCCreate = new Button();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripTextBox();
            lblCashier = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbxCId
            // 
            tbxCId.BackColor = Color.Navy;
            tbxCId.ForeColor = SystemColors.Window;
            tbxCId.Location = new Point(425, 213);
            tbxCId.Margin = new Padding(3, 4, 3, 4);
            tbxCId.Name = "tbxCId";
            tbxCId.Size = new Size(352, 27);
            tbxCId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(317, 215);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // tbxCPass
            // 
            tbxCPass.BackColor = Color.Navy;
            tbxCPass.ForeColor = SystemColors.Window;
            tbxCPass.Location = new Point(425, 276);
            tbxCPass.Margin = new Padding(3, 4, 3, 4);
            tbxCPass.Name = "tbxCPass";
            tbxCPass.Size = new Size(352, 27);
            tbxCPass.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(317, 276);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Navy;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(317, 341);
            label3.Name = "label3";
            label3.Size = new Size(42, 22);
            label3.TabIndex = 1;
            label3.Text = "Role";
            // 
            // cbCRole
            // 
            cbCRole.BackColor = Color.Navy;
            cbCRole.ForeColor = SystemColors.Window;
            cbCRole.FormattingEnabled = true;
            cbCRole.Items.AddRange(new object[] { "Doctor", "Cashier" });
            cbCRole.Location = new Point(449, 341);
            cbCRole.Margin = new Padding(3, 4, 3, 4);
            cbCRole.Name = "cbCRole";
            cbCRole.Size = new Size(155, 28);
            cbCRole.TabIndex = 2;
            // 
            // btnCCreate
            // 
            btnCCreate.BackColor = Color.Navy;
            btnCCreate.ForeColor = SystemColors.Control;
            btnCCreate.Location = new Point(425, 433);
            btnCCreate.Margin = new Padding(3, 4, 3, 4);
            btnCCreate.Name = "btnCCreate";
            btnCCreate.Size = new Size(110, 31);
            btnCCreate.TabIndex = 3;
            btnCCreate.Text = "create";
            btnCCreate.UseVisualStyleBackColor = false;
            btnCCreate.Click += btnCreate_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1028, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 27);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // lblCashier
            // 
            lblCashier.AutoSize = true;
            lblCashier.BackColor = Color.Transparent;
            lblCashier.Font = new Font("Times New Roman", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashier.ForeColor = SystemColors.ButtonFace;
            lblCashier.Location = new Point(292, 71);
            lblCashier.Name = "lblCashier";
            lblCashier.Size = new Size(426, 48);
            lblCashier.TabIndex = 5;
            lblCashier.Text = "Create Doctor/Cashier";
            // 
            // createForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.admindashboardrs1;
            ClientSize = new Size(1028, 600);
            Controls.Add(lblCashier);
            Controls.Add(btnCCreate);
            Controls.Add(cbCRole);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxCPass);
            Controls.Add(tbxCId);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "createForm";
            Text = "Form7";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxCId;
        private Label label1;
        private TextBox tbxCPass;
        private Label label2;
        private Label label3;
        private ComboBox cbCRole;
        private Button btnCCreate;
        private MenuStrip menuStrip1;
        private ToolStripTextBox backToolStripMenuItem;
        private Label lblCashier;
    }
}