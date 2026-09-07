namespace Hospital_Management
{
    partial class cashierForm
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
            lblCashier = new Label();
            itemPanel = new Panel();
            btnAdd = new Button();
            lblPrice = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            btnCalculate = new Button();
            itemPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCashier
            // 
            lblCashier.AutoSize = true;
            lblCashier.BackColor = Color.IndianRed;
            lblCashier.Font = new Font("Times New Roman", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashier.Location = new Point(491, 50);
            lblCashier.Name = "lblCashier";
            lblCashier.Size = new Size(127, 37);
            lblCashier.TabIndex = 0;
            lblCashier.Text = "Cashier";
            lblCashier.Click += lblCashier_Click;
            // 
            // itemPanel
            // 
            itemPanel.AutoScroll = true;
            itemPanel.Controls.Add(btnAdd);
            itemPanel.Location = new Point(297, 192);
            itemPanel.Name = "itemPanel";
            itemPanel.Size = new Size(503, 209);
            itemPanel.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Info;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(400, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(46, 45);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.DeepSkyBlue;
            lblPrice.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(297, 404);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(68, 23);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Fuchsia;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 170);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 1;
            label1.Text = "Item Name:";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
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
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = SystemColors.MenuHighlight;
            btnCalculate.Location = new Point(671, 403);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(117, 31);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // cashierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.updateboy;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(lblPrice);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(itemPanel);
            Controls.Add(lblCashier);
            Name = "cashierForm";
            Text = "Form4";
            itemPanel.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCashier;
        private Label lblCName;
        private Panel itemPanel;
        private Label label1;
        private Label lblPrice;
        private Button btnAdd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private Button btnCalculate;
    }
}