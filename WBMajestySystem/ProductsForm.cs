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
    public partial class ProductsForm : Form
    {
        private readonly List<ProductRow> _all = new List<ProductRow>();

        public ProductsForm()
        {
            InitializeComponent();

            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToOrderColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            Load += ProductsForm_Load;
            txtSearch.TextChanged += (s, e) => RenderGrid();
            cboCategory.SelectedIndexChanged += (s, e) => RenderGrid();
            cboStatus.SelectedIndexChanged += (s, e) => RenderGrid();
            btnAddProduct.Click += btnAddProduct_Click;

            // ONLY THIS ONE EVENT HANDLER FOR BUTTON COLUMNS:
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;

            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // Filters
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[] { "All Products", "Canned Goods", "Snacks", "Frozen Foods", "Condiments & Sauces", "Fresh Produce", "Beverages", "Dry Goods" });
            cboCategory.SelectedIndex = 0;

            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[] { "All Status", "Active", "Inactive" });
            cboStatus.SelectedIndex = 0;

            // Column formats (names must match Designer column Names)
            SecureFixedColumnWidths();

            if (dgvProducts.Columns["colPrice"] != null)
                dgvProducts.Columns["colPrice"].DefaultCellStyle.Format = "₱#,0.00";
            if (dgvProducts.Columns["colExpiry"] != null)
                dgvProducts.Columns["colExpiry"].DefaultCellStyle.Format = "yyyy-MM-dd";
            if (dgvProducts.Columns["colStock"] != null)
                dgvProducts.Columns["colStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Start with no rows (DB will populate _all later)
            _all.Clear();

            RenderGrid();
        }

        // Locks widths so columns don't expand/contract
        private void SecureFixedColumnWidths()
        {
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            SetCol("colId", 70);
            SetCol("colName", 230);
            SetCol("colDescription", 180);
            SetCol("colCategory", 120);
            SetCol("colStock", 80);
            SetCol("colPrice", 90);
            SetCol("colBarcode", 160);
            SetCol("colExpiry", 110);
            SetCol("colStatus", 90);
            SetCol("colEdit", 60);
            SetCol("colView", 60);
            SetCol("colDelete", 60);
        }

        private void SetCol(string name, int width)
        {
            if (dgvProducts.Columns[name] == null) return;
            var c = dgvProducts.Columns[name];
            c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            c.Width = width;
            c.MinimumWidth = width;
            c.Resizable = DataGridViewTriState.False;
            c.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void RenderGrid()
        {
            var query = (txtSearch.Text ?? "").Trim().ToLowerInvariant();
            var selectedCategory = cboCategory.SelectedItem?.ToString() ?? "All Products";
            var selectedStatus = cboStatus.SelectedItem?.ToString() ?? "All Status";

            var view = _all
                // Category filter
                .Where(p => selectedCategory == "All Products" || string.Equals(p.Category, selectedCategory, StringComparison.OrdinalIgnoreCase))
                // Status filter
                .Where(p => selectedStatus == "All Status" || string.Equals(p.Status, selectedStatus, StringComparison.OrdinalIgnoreCase))
                // Search filter (name/description/barcode)
                .Where(p =>
                    string.IsNullOrEmpty(query) ||
                    (p.Name ?? "").ToLowerInvariant().Contains(query) ||
                    (p.Description ?? "").ToLowerInvariant().Contains(query) ||
                    (p.Barcode ?? "").Contains(query)
                )
                .ToList();

            dgvProducts.DataSource = new BindingList<ProductRow>(view);
            SecureFixedColumnWidths();
        }

        private void dgvProducts_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks or invalid indices
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var grid = dgvProducts;

            // Column must exist
            var col = grid.Columns[e.ColumnIndex];
            if (col == null) return;
            var columnName = col.Name;

            // Helper to safely read a cell by column name
            string GetCellText(string columnNameSafe)
            {
                var c = grid.Columns[columnNameSafe];
                if (c == null) return "";
                if (e.RowIndex >= grid.Rows.Count) return "";
                return grid.Rows[e.RowIndex].Cells[c.Index].Value?.ToString() ?? "";
            }

            var id = GetCellText("colId");
            var productName = GetCellText("colName");
            if (string.IsNullOrWhiteSpace(id)) return;

            switch (columnName)
            {
                case "colEdit":
                    EditProduct(id, productName);
                    return;

                case "colView":
                    ViewProduct(id, productName);
                    return;

                case "colDelete":
                    var confirm = MessageBox.Show(this,
                        $"Are you sure you want to delete '{productName}'?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm != DialogResult.Yes) return;

                    // Remove and immediately rebind; then EXIT handler to avoid using stale row index
                    _all.RemoveAll(p => p.Id == id);
                    RenderGrid();
                    return;
            }
        }

        private void EditProduct(string id, string productName)
        {
            var product = _all.FirstOrDefault(p => p.Id == id);
            if (product == null) return;

            bool updated = false;

            using (var editForm = new EditProductForm())
            {
                editForm.txtProductName.Text = product.Name;
                editForm.txtDescription.Text = product.Description;
                editForm.nudStock.Value = product.Stock;
                editForm.nudPrice.Value = product.Price;
                editForm.cboStatus.Text = product.Status;

                editForm.TopMost = true;
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    product.Name = editForm.txtProductName.Text;
                    product.Description = editForm.txtDescription.Text;
                    product.Stock = (int)editForm.nudStock.Value;
                    product.Price = editForm.nudPrice.Value;
                    product.Status = editForm.cboStatus.Text;

                    RenderGrid();
                    updated = true;
                }
            } // dialog is closed/disposed here

            if (updated)
            {
                this.Activate();
                this.BringToFront();
                MessageBox.Show(this, "Product updated successfully!", "Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // View Product Method
        private void ViewProduct(string id, string productName)
        {
            var product = _all.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                var viewForm = new Form
                {
                    Text = $"View Product: {productName}",
                    Size = new Size(500, 400),
                    StartPosition = FormStartPosition.CenterParent,
                    TopMost = true,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                var details = $"Product Details:\n\n" +
                             $"ID: {product.Id}\n" +
                             $"Name: {product.Name}\n" +
                             $"Description: {product.Description}\n" +
                             $"Category: {product.Category}\n" +
                             $"Stock: {product.Stock}\n" +
                             $"Price: ₱{product.Price:N2}\n" +
                             $"Barcode: {product.Barcode}\n" +
                             $"Expiry: {product.Expiry:yyyy-MM-dd}\n" +
                             $"Status: {product.Status}";

                var label = new Label
                {
                    Text = details,
                    AutoSize = true,
                    Location = new Point(20, 20),
                    Font = new Font("Consolas", 10)
                };

                var okButton = new Button
                {
                    Text = "OK",
                    DialogResult = DialogResult.OK,
                    Location = new Point(200, 300),
                    Size = new Size(80, 30)
                };

                viewForm.Controls.Add(label);
                viewForm.Controls.Add(okButton);
                viewForm.ShowDialog(this);
            }
        }

        // Delete Product Method
        private void DeleteProduct(string id, string productName)
        {
            var confirm = MessageBox.Show(this,
                $"Are you sure you want to delete '{productName}'?\n\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _all.RemoveAll(p => p.Id == id);
                RenderGrid();

                // Success message
                MessageBox.Show(this, $"Product '{productName}' has been deleted successfully!", "Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvProducts.Rows[e.RowIndex];
            if (row.DataBoundItem is not ProductRow item) return;

            row.DefaultCellStyle.BackColor = Color.White;

            if (item.Stock > 0 && item.Stock <= 10)
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);

            var daysLeft = (item.Expiry.Date - DateTime.Today).TotalDays;
            if (daysLeft >= 0 && daysLeft <= 14)
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (var f = new AddProductForm())
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    // Read values from the AddProductForm
                    var nextId = (_all.Count + 1).ToString("D2");
                    var newProduct = new ProductRow(
                    nextId,                          // id
                    f.txtProductName.Text,           // name
                    f.txtDescription.Text,           // description
                    f.cboCategory.Text,              // category
                    (int)f.nudStockQty.Value,        // stock
                    f.nudSellingPrice.Value,         // price
                    f.txtBarcode.Text,               // barcode
                    f.dtpExpiry.ShowCheckBox && !f.dtpExpiry.Checked ? DateTime.MinValue : f.dtpExpiry.Value.Date, // expiry
                    f.cboStatus.Text                 // status
);

                    _all.Add(newProduct);
                    RenderGrid();

                    // Success message
                    MessageBox.Show(this, $"Product '{newProduct.Name}' added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {

        }
    }

    public class ProductRow
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public DateTime Expiry { get; set; }
        public string Status { get; set; }

        public ProductRow(string id, string name, string description, string category, int stock, decimal price, string barcode, DateTime expiry, string status)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            Stock = stock;
            Price = price;
            Barcode = barcode;
            Expiry = expiry;
            Status = status;
        }
    }
}