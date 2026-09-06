namespace Hospital_Management
{
    partial class signUpForm
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
            tbxSName = new TextBox();
            tbxSPass = new TextBox();
            label3 = new Label();
            btnSignup = new Button();
            cbSignUp = new ComboBox();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(264, 154);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(249, 198);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // tbxSName
            // 
            tbxSName.Location = new Point(343, 152);
            tbxSName.Name = "tbxSName";
            tbxSName.Size = new Size(210, 23);
            tbxSName.TabIndex = 1;
            // 
            // tbxSPass
            // 
            tbxSPass.Location = new Point(343, 198);
            tbxSPass.Name = "tbxSPass";
            tbxSPass.Size = new Size(210, 23);
            tbxSPass.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(275, 245);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 0;
            label3.Text = "Role:";
            // 
            // btnSignup
            // 
            btnSignup.Font = new Font("Segoe UI", 12F);
            btnSignup.Location = new Point(393, 296);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(80, 37);
            btnSignup.TabIndex = 2;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // cbSignUp
            // 
            cbSignUp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSignUp.FormattingEnabled = true;
            cbSignUp.Items.AddRange(new object[] { "Patient", "Admin" });
            cbSignUp.Location = new Point(343, 247);
            cbSignUp.Name = "cbSignUp";
            cbSignUp.Size = new Size(161, 23);
            cbSignUp.TabIndex = 3;
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
            // signUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSignUp);
            Controls.Add(btnSignup);
            Controls.Add(tbxSPass);
            Controls.Add(tbxSName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "signUpForm";
            Text = "Form5";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxSName;
        private TextBox tbxSPass;
        private Label label3;
        private Button btnSignup;
        private ComboBox cbSignUp;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}