namespace WBMajestySystem
{
    partial class ProductsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtSearch = new TextBox();
            cboCategory = new ComboBox();
            cboStatus = new ComboBox();
            btnAddProduct = new Button();
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colBarcode = new DataGridViewTextBoxColumn();
            colExpiry = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colView = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Calisto MT", 11.25F, FontStyle.Bold);
            txtSearch.Location = new Point(20, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search products by name, barcode, or supplier...";
            txtSearch.Size = new Size(708, 25);
            txtSearch.TabIndex = 0;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Calisto MT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(776, 20);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(140, 26);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Calisto MT", 11.25F, FontStyle.Bold);
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(936, 20);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(140, 26);
            cboStatus.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.MediumPurple;
            btnAddProduct.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(1171, 66);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(180, 36);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "+ Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click_1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calisto MT", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colDescription, colCategory, colStock, colPrice, colBarcode, colExpiry, colStatus, colEdit, colView, colDelete });
            dgvProducts.Location = new Point(20, 120);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1468, 647);
            dgvProducts.TabIndex = 5;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colId.DefaultCellStyle = dataGridViewCellStyle3;
            colId.FillWeight = 14.9740353F;
            colId.HeaderText = "PRODUCT ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Resizable = DataGridViewTriState.False;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colName.DataPropertyName = "Name";
            colName.FillWeight = 14.9740353F;
            colName.HeaderText = "PRODUCT NAME";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Resizable = DataGridViewTriState.True;
            colName.Width = 151;
            // 
            // colDescription
            // 
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDescription.DataPropertyName = "Description";
            colDescription.FillWeight = 14.9740353F;
            colDescription.HeaderText = "DESCRIPTION";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.Width = 143;
            // 
            // colCategory
            // 
            colCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCategory.DataPropertyName = "Category";
            colCategory.FillWeight = 14.9740353F;
            colCategory.HeaderText = "CATEGORY";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Width = 125;
            // 
            // colStock
            // 
            colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colStock.DataPropertyName = "Stock";
            colStock.FillWeight = 14.9740353F;
            colStock.HeaderText = "STOCK";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Width = 88;
            // 
            // colPrice
            // 
            colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrice.DataPropertyName = "Price";
            colPrice.FillWeight = 14.9740353F;
            colPrice.HeaderText = "PRICE";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 81;
            // 
            // colBarcode
            // 
            colBarcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colBarcode.DataPropertyName = "Barcode";
            colBarcode.FillWeight = 14.9740353F;
            colBarcode.HeaderText = "BARCODE";
            colBarcode.Name = "colBarcode";
            colBarcode.ReadOnly = true;
            colBarcode.Width = 112;
            // 
            // colExpiry
            // 
            colExpiry.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colExpiry.DataPropertyName = "Expiry";
            colExpiry.FillWeight = 14.9740353F;
            colExpiry.HeaderText = "EXPIRY DATE";
            colExpiry.Name = "colExpiry";
            colExpiry.ReadOnly = true;
            colExpiry.Width = 129;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colStatus.DataPropertyName = "Status";
            colStatus.FillWeight = 14.9740353F;
            colStatus.HeaderText = "STATUS";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 95;
            // 
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colEdit.FillWeight = 108.49955F;
            colEdit.HeaderText = "EDIT";
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Resizable = DataGridViewTriState.True;
            colEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            colEdit.Text = "✏️ Edit";
            colEdit.Width = 72;
            // 
            // colView
            // 
            colView.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colView.FillWeight = 131.2787F;
            colView.HeaderText = "VIEW";
            colView.Name = "colView";
            colView.ReadOnly = true;
            colView.Resizable = DataGridViewTriState.True;
            colView.SortMode = DataGridViewColumnSortMode.Automatic;
            colView.Text = "👁️ View";
            colView.Width = 76;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDelete.FillWeight = 164.034119F;
            colDelete.HeaderText = "DELETE";
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Resizable = DataGridViewTriState.True;
            colDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            colDelete.Text = "❌ Delete";
            colDelete.Width = 96;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 232, 255);
            ClientSize = new Size(1511, 793);
            Controls.Add(dgvProducts);
            Controls.Add(btnAddProduct);
            Controls.Add(cboStatus);
            Controls.Add(cboCategory);
            Controls.Add(txtSearch);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products – WB Majesty";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private ComboBox cboCategory;
        private ComboBox cboStatus;
        private Button btnAddProduct;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colBarcode;
        private DataGridViewTextBoxColumn colExpiry;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colView;
        private DataGridViewButtonColumn colDelete;
    }
}