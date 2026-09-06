namespace Hospital_Management
{
    partial class adminForm
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
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            btnDoctor = new Button();
            btnCashier = new Button();
            dgvStaff = new DataGridView();
            btnCalculate = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Times New Roman", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 66);
            label1.Name = "label1";
            label1.Size = new Size(112, 37);
            label1.TabIndex = 1;
            label1.Text = "Admin";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(803, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // btnDoctor
            // 
            btnDoctor.BackColor = Color.MediumPurple;
            btnDoctor.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoctor.ForeColor = Color.Black;
            btnDoctor.Location = new Point(254, 125);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(65, 40);
            btnDoctor.TabIndex = 4;
            btnDoctor.Text = "Doctor";
            btnDoctor.UseVisualStyleBackColor = false;
            btnDoctor.Click += btnDoctor_Click;
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.MediumSpringGreen;
            btnCashier.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.ForeColor = Color.Black;
            btnCashier.Location = new Point(450, 125);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(66, 40);
            btnCashier.TabIndex = 5;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // dgvStaff
            // 
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.AllowUserToDeleteRows = false;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(44, 171);
            dgvStaff.MultiSelect = false;
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new Size(709, 232);
            dgvStaff.TabIndex = 6;
            dgvStaff.CellDoubleClick += dgvStaff_CellDoubleClick;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.MistyRose;
            btnCalculate.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.Blue;
            btnCalculate.Location = new Point(678, 415);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Create";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.white_modern_medical_wallpaper_geometric_hexagon_medical_icons_technology_background_vector;
            ClientSize = new Size(803, 449);
            Controls.Add(btnCalculate);
            Controls.Add(dgvStaff);
            Controls.Add(btnCashier);
            Controls.Add(btnDoctor);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "adminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += adminForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private Button btnDoctor;
        private Button btnCashier;
        private ToolStripMenuItem backToolStripMenuItem;
        private DataGridView dgvStaff;
        private Button btnCalculate;
    }
}