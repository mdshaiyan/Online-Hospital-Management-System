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
            itemPanel = new Panel();
            btnAdd = new Button();
            lblPrice = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            btnCalculate = new Button();
            label2 = new Label();
            itemPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // itemPanel
            // 
            itemPanel.AutoScroll = true;
            itemPanel.BackColor = Color.Gainsboro;
            itemPanel.Controls.Add(btnAdd);
            itemPanel.Location = new Point(243, 198);
            itemPanel.Margin = new Padding(3, 4, 3, 4);
            itemPanel.Name = "itemPanel";
            itemPanel.Size = new Size(575, 279);
            itemPanel.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(499, 16);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(53, 60);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Azure;
            lblPrice.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(243, 492);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(85, 29);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 159);
            label1.Name = "label1";
            label1.Size = new Size(165, 35);
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
            btnCalculate.BackColor = Color.LightCyan;
            btnCalculate.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = SystemColors.InactiveCaptionText;
            btnCalculate.Location = new Point(684, 492);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(134, 41);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(358, 79);
            label2.Name = "label2";
            label2.Size = new Size(384, 51);
            label2.TabIndex = 6;
            label2.Text = "Cashier Dashboard";
            label2.Click += label2_Click;
            // 
            // cashierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.updateboy;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(btnCalculate);
            Controls.Add(lblPrice);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(itemPanel);
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
        private Label lblCName;
        private Panel itemPanel;
        private Label label1;
        private Label lblPrice;
        private Button btnAdd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private Button btnCalculate;
        private Label label2;
    }
}