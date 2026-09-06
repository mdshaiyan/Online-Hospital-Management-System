namespace Hospital_Management
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxId = new TextBox();
            tbxPass = new TextBox();
            lblId = new Label();
            lblPass = new Label();
            cbRole = new ComboBox();
            lblRole = new Label();
            btnLogin = new Button();
            btnRSignup = new Button();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbxId
            // 
            tbxId.BackColor = SystemColors.Info;
            tbxId.Location = new Point(348, 244);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(211, 22);
            tbxId.TabIndex = 0;
            tbxId.TextChanged += tbxId_TextChanged;
            // 
            // tbxPass
            // 
            tbxPass.BackColor = SystemColors.Info;
            tbxPass.Location = new Point(348, 279);
            tbxPass.Name = "tbxPass";
            tbxPass.PasswordChar = '*';
            tbxPass.Size = new Size(211, 22);
            tbxPass.TabIndex = 1;
            tbxPass.TextChanged += tbxPass_TextChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F);
            lblId.Location = new Point(308, 242);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 21);
            lblId.TabIndex = 2;
            lblId.Text = "ID:";
            lblId.Click += lblId_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F);
            lblPass.Location = new Point(257, 279);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(79, 21);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password:";
            lblPass.Click += lblPass_Click;
            // 
            // cbRole
            // 
            cbRole.BackColor = SystemColors.Control;
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Doctor", "Patient", "Cashier" });
            cbRole.Location = new Point(348, 319);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(121, 23);
            cbRole.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 12F);
            lblRole.Location = new Point(292, 317);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(44, 21);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Aquamarine;
            btnLogin.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(405, 363);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 38);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRSignup
            // 
            btnRSignup.BackColor = Color.MediumSlateBlue;
            btnRSignup.Location = new Point(405, 433);
            btnRSignup.Name = "btnRSignup";
            btnRSignup.Size = new Size(99, 38);
            btnRSignup.TabIndex = 6;
            btnRSignup.Text = "Sign Up";
            btnRSignup.UseVisualStyleBackColor = false;
            btnRSignup.Click += btnRSignup_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(980, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.hospital_logo;
            pictureBox1.Location = new Point(308, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(249, 173);
            label1.Name = "label1";
            label1.Size = new Size(400, 50);
            label1.TabIndex = 10;
            label1.Text = "ONLINE HOSPITAL MANAGEMENT\n SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.ChatGPT_Image_Sep_6__2026__01_03_00_AM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(980, 557);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRSignup);
            Controls.Add(btnLogin);
            Controls.Add(lblRole);
            Controls.Add(cbRole);
            Controls.Add(lblPass);
            Controls.Add(lblId);
            Controls.Add(tbxPass);
            Controls.Add(tbxId);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "B";
            FormClosing += mainForm_FormClosing;
            Load += mainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxId;
        private TextBox tbxPass;
        private Label lblId;
        private Label lblPass;
        private ComboBox cbRole;
        private Label lblRole;
        private Button btnLogin;
        private Button btnRSignup;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
