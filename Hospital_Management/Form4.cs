using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class cashierForm : Form
    {
        private int itemRowCount = 0;

        public cashierForm()
        {
            InitializeComponent();

            // Create the first row automatically
            AddItemRow();
        }

        private void AddItemRow()
        {
            int rowHeight = 40;

            // Create a row panel
            Panel row = new Panel();

            row.Width = itemPanel.ClientSize.Width - 10;
            row.Height = rowHeight;

            row.Location = new Point(
                5,
                itemRowCount * rowHeight
            );

            // Item Name
            TextBox txtItem = new TextBox();
            txtItem.Width = 180;
            txtItem.Height = 30;
            txtItem.Location = new Point(0, 5);
            txtItem.PlaceholderText = "Item Name";

            // Quantity
            TextBox txtQuantity = new TextBox();
            txtQuantity.Width = 80;
            txtQuantity.Height = 30;
            txtQuantity.Location = new Point(190, 5);
            txtQuantity.PlaceholderText = "Quantity";

            // Price
            TextBox txtPrice = new TextBox();
            txtPrice.Width = 100;
            txtPrice.Height = 30;
            txtPrice.Location = new Point(280, 5);
            txtPrice.PlaceholderText = "Price";

            // Add TextBoxes to row
            row.Controls.Add(txtItem);
            row.Controls.Add(txtQuantity);
            row.Controls.Add(txtPrice);

            // Add row to itemPanel
            itemPanel.Controls.Add(row);

            itemRowCount++;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItemRow();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is mainForm)
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal grandTotal = 0;

            foreach (Control control in itemPanel.Controls)
            {
                // Each control is one row Panel
                if (control is Panel row)
                {
                    TextBox txtItem = row.Controls[0] as TextBox;
                    TextBox txtQuantity = row.Controls[1] as TextBox;
                    TextBox txtPrice = row.Controls[2] as TextBox;

                    // Skip completely empty rows
                    if (string.IsNullOrWhiteSpace(txtItem.Text) &&
                        string.IsNullOrWhiteSpace(txtQuantity.Text) &&
                        string.IsNullOrWhiteSpace(txtPrice.Text))
                    {
                        continue;
                    }

                    // Check quantity
                    if (!decimal.TryParse(txtQuantity.Text, out decimal quantity))
                    {
                        MessageBox.Show(
                            "Please enter a valid quantity for: " + txtItem.Text,
                            "Invalid Quantity",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // Check price
                    if (!decimal.TryParse(txtPrice.Text, out decimal price))
                    {
                        MessageBox.Show(
                            "Please enter a valid price for: " + txtItem.Text,
                            "Invalid Price",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // Quantity × Price
                    decimal itemTotal = quantity * price;

                    grandTotal += itemTotal;
                }
            }

            // Show final total
            lblPrice.Text = grandTotal.ToString("0.00");

        }

        
    }
}