using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBMajestySystem
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            cboUnit.Items.AddRange(new object[] { "Piece", "Box", "Pack", "Kg", "Liter" });
            cboSupplier.Items.AddRange(new object[] { "Supplier A", "Supplier B", "Supplier C" });
            cboStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cboCategory.Items.AddRange(new object[] { "Canned Goods", "Snacks", "Frozen Foods", "Condiments & Sauces", "Fresh Produce", "Beverages", "Dry Goods" });
            if (cboCategory.Items.Count > 0 && cboCategory.SelectedIndex < 0)
                cboCategory.SelectedIndex = 0;
            cboUnit.SelectedIndex = 0; cboStatus.SelectedIndex = 0;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
            btnSave.Click += btnSave_Click;
        }
        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show(this, "Product Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                MessageBox.Show(this, "Barcode is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarcode.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBarcode_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // allow control keys (Backspace, Delete, arrows)
            if (char.IsControl(e.KeyChar)) return;

            // allow digits only
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtBarcode_TextChanged(object? sender, EventArgs e)
        {
            // clean pasted text, keep digits only
            var tb = (TextBox)sender!;
            int sel = tb.SelectionStart;
            string digits = new string(tb.Text.Where(char.IsDigit).ToArray());
            if (tb.Text != digits)
            {
                tb.Text = digits;
                tb.SelectionStart = Math.Min(sel, digits.Length);
            }
        }
    }
}
