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
            backToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbxCId
            // 
            tbxCId.Location = new Point(252, 88);
            tbxCId.Name = "tbxCId";
            tbxCId.Size = new Size(274, 23);
            tbxCId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 91);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // tbxCPass
            // 
            tbxCPass.Location = new Point(252, 133);
            tbxCPass.Name = "tbxCPass";
            tbxCPass.Size = new Size(274, 23);
            tbxCPass.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 136);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 185);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 1;
            label3.Text = "Role";
            // 
            // cbCRole
            // 
            cbCRole.FormattingEnabled = true;
            cbCRole.Items.AddRange(new object[] { "Doctor", "Cashier" });
            cbCRole.Location = new Point(263, 182);
            cbCRole.Name = "cbCRole";
            cbCRole.Size = new Size(121, 23);
            cbCRole.TabIndex = 2;
            // 
            // btnCCreate
            // 
            btnCCreate.Location = new Point(349, 259);
            btnCCreate.Name = "btnCCreate";
            btnCCreate.Size = new Size(75, 23);
            btnCCreate.TabIndex = 3;
            btnCCreate.Text = "create";
            btnCCreate.UseVisualStyleBackColor = true;
            btnCCreate.Click += btnCreate_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // createForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCCreate);
            Controls.Add(cbCRole);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxCPass);
            Controls.Add(tbxCId);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem backToolStripMenuItem;
    }
}