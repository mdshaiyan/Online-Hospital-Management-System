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
            lblCashier.Font = new Font("Segoe UI", 25F);
            lblCashier.Location = new Point(363, 80);
            lblCashier.Name = "lblCashier";
            lblCashier.Size = new Size(161, 57);
            lblCashier.TabIndex = 0;
            lblCashier.Text = "Cashier";
            // 
            // itemPanel
            // 
            itemPanel.AutoScroll = true;
            itemPanel.Controls.Add(btnAdd);
            itemPanel.Location = new Point(113, 209);
            itemPanel.Margin = new Padding(3, 4, 3, 4);
            itemPanel.Name = "itemPanel";
            itemPanel.Size = new Size(589, 293);
            itemPanel.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(457, 29);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(52, 60);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 15F);
            lblPrice.Location = new Point(363, 536);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(76, 35);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(113, 180);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "Item Name:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 24);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 15F);
            btnCalculate.Location = new Point(724, 443);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(167, 59);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // cashierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cashhier;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCalculate);
            Controls.Add(lblPrice);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(itemPanel);
            Controls.Add(lblCashier);
            Margin = new Padding(3, 4, 3, 4);
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