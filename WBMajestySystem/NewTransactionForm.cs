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
    public partial class NewTransactionForm : Form
    {
        public NewTransactionForm()
        {
            InitializeComponent();

            btnSearch.Click += btnSearch_Click;
            btnAddItem.Click += btnAddItem_Click;

            // Live totals
            txtAmountReceived.TextChanged += (s, e) => RecalcTotals();
            txtDiscount.TextChanged += (s, e) => RecalcTotals();

            // Enter in barcode box = Search + Add
            txtBarcode.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.PerformClick();
                    btnAddItem.PerformClick();
                    e.SuppressKeyPress = true;
                }
            };
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            var q = txtBarcode.Text.Trim();
            if (q.Length == 0)
            {
                MessageBox.Show("Enter barcode or name.");
                return;
            }

            using var conn = Db.GetConnection();
            conn.Open();

            using var cmd = new MySql.Data.MySqlClient.MySqlCommand(@"
				SELECT id, product_id, barcode, name, price
				FROM products
				WHERE barcode = @q OR name LIKE CONCAT('%', @q, '%')
				ORDER BY barcode=@q DESC, name ASC
				LIMIT 1;", conn);
            cmd.Parameters.AddWithValue("@q", q);

            using var r = cmd.ExecuteReader();
            if (!r.Read())
            {
                MessageBox.Show("No product found.");
                return;
            }

            // Normalize the barcode text to the DB value (visual confirmation)
            txtBarcode.Text = r["barcode"].ToString();
        }

        private void btnAddItem_Click(object? sender, EventArgs e)
        {
            var code = txtBarcode.Text.Trim();
            if (code.Length == 0)
            {
                MessageBox.Show("Search first.");
                return;
            }

            using var conn = Db.GetConnection();
            conn.Open();

            using var cmd = new MySql.Data.MySqlClient.MySqlCommand(@"
				SELECT id, product_id, barcode, name, price
				FROM products
				WHERE barcode = @b OR name LIKE CONCAT('%', @b, '%')
				ORDER BY barcode=@b DESC, name ASC
				LIMIT 1;", conn);
            cmd.Parameters.AddWithValue("@b", code);

            using var r = cmd.ExecuteReader();
            if (!r.Read())
            {
                MessageBox.Show("Product not found.");
                return;
            }

            var productNo = r["product_id"].ToString();              // maps to colProductNo
            var barcode = r["barcode"].ToString();
            var name = r["name"].ToString();
            var price = Convert.ToDecimal(r["price"]);

            // Merge by barcode if already in grid
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if ((row.Cells["colBarcode"].Value as string) == barcode)
                {
                    int qty = Convert.ToInt32(row.Cells["colQuantity"].Value) + 1;
                    row.Cells["colQuantity"].Value = qty;
                    row.Cells["colPrice"].Value = price.ToString("0.00");
                    row.Cells["colTotal"].Value = (qty * price).ToString("0.00");
                    RecalcTotals();
                    txtBarcode.Clear();
                    return;
                }
            }

            // New line: ProductNo | Barcode | Name | Qty | Price | Total | Action
            dgvItems.Rows.Add(
                productNo,
                barcode,
                name,
                1,
                price.ToString("0.00"),
                (1 * price).ToString("0.00"),
                string.Empty
            );

            RecalcTotals();
            txtBarcode.Clear();
        }

        private void RecalcTotals()
        {
            decimal subtotal = 0m;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                var cell = row.Cells["colTotal"].Value;
                if (cell != null && decimal.TryParse(cell.ToString(), out var sub))
                    subtotal += sub;
            }

            // VAT 12% (change if needed)
            decimal vat = Math.Round(subtotal * 0.12m, 2);

            // Discount is a percent in txtDiscount (0–100)
            decimal discountPct = 0m;
            if (decimal.TryParse(txtDiscount.Text, out var d))
            {
                if (d < 0) d = 0;
                if (d > 100) d = 100;
                discountPct = d / 100m;
            }
            decimal discount = Math.Round(subtotal * discountPct, 2);

            decimal total = subtotal + vat - discount;

            lblSubtotalValue.Text = $"PHP {subtotal:0.00}";
            lblVATValue.Text = $"PHP {vat:0.00}";
            lblDiscountValue.Text = $"-PHP {discount:0.00}";
            lblTotalValue.Text = $"PHP {total:0.00}";

            if (decimal.TryParse(txtAmountReceived.Text, out var received))
                lblChangeValue.Text = $"PHP {(received - total):0.00}";
            else
                lblChangeValue.Text = "PHP 0.00";
        }
        private void NewTransactionForm_Load(object? sender, EventArgs e)
        {
            // init if needed
        }

        private void lblTitle_Click(object? sender, EventArgs e)
        {
            // optional: no-op
        }

        private void btnCompleteTransaction_Click(object? sender, EventArgs e)
        {
            using (var receiptForm = new TransactionReceiptForm())
            {
                receiptForm.ShowDialog();
            }
            this.Close();
        }
    }
}