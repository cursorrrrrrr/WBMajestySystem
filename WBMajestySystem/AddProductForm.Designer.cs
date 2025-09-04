namespace WBMajestySystem
{
    partial class AddProductForm
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
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            label5 = new Label();
            nudStockQty = new NumericUpDown();
            label6 = new Label();
            cboUnit = new ComboBox();
            label7 = new Label();
            nudCostPrice = new NumericUpDown();
            label8 = new Label();
            nudSellingPrice = new NumericUpDown();
            label9 = new Label();
            cboSupplier = new ComboBox();
            label10 = new Label();
            nudReorderLevel = new NumericUpDown();
            label11 = new Label();
            dtpExpiry = new DateTimePicker();
            label12 = new Label();
            nudDiscount = new NumericUpDown();
            label13 = new Label();
            cboStatus = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            label14 = new Label();
            cboCategory = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtBarcode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudStockQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCostPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSellingPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudReorderLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 0;
            label1.Text = "Product ID:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(24, 44);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(360, 23);
            txtProductId.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(24, 104);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(360, 23);
            txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label2.Location = new Point(24, 78);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 2;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label3.Location = new Point(24, 138);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 4;
            label3.Text = "Barcode:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(24, 224);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Type the description here...";
            txtDescription.Size = new Size(360, 23);
            txtDescription.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label4.Location = new Point(24, 198);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 6;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label5.Location = new Point(420, 24);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 8;
            label5.Text = "Stock Quantity";
            // 
            // nudStockQty
            // 
            nudStockQty.Location = new Point(420, 44);
            nudStockQty.Name = "nudStockQty";
            nudStockQty.Size = new Size(120, 23);
            nudStockQty.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label6.Location = new Point(590, 24);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 10;
            label6.Text = "Unit of Measure";
            // 
            // cboUnit
            // 
            cboUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnit.FormattingEnabled = true;
            cboUnit.Location = new Point(590, 44);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(121, 23);
            cboUnit.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label7.Location = new Point(420, 84);
            label7.Name = "label7";
            label7.Size = new Size(90, 23);
            label7.TabIndex = 12;
            label7.Text = "Cost Price";
            // 
            // nudCostPrice
            // 
            nudCostPrice.DecimalPlaces = 2;
            nudCostPrice.Location = new Point(420, 104);
            nudCostPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCostPrice.Name = "nudCostPrice";
            nudCostPrice.Size = new Size(120, 23);
            nudCostPrice.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label8.Location = new Point(590, 84);
            label8.Name = "label8";
            label8.Size = new Size(112, 23);
            label8.TabIndex = 14;
            label8.Text = "Selling Price";
            // 
            // nudSellingPrice
            // 
            nudSellingPrice.DecimalPlaces = 2;
            nudSellingPrice.Location = new Point(590, 104);
            nudSellingPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSellingPrice.Name = "nudSellingPrice";
            nudSellingPrice.Size = new Size(120, 23);
            nudSellingPrice.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label9.Location = new Point(420, 144);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 16;
            label9.Text = "Supplier";
            // 
            // cboSupplier
            // 
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(420, 164);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(121, 23);
            cboSupplier.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label10.Location = new Point(420, 204);
            label10.Name = "label10";
            label10.Size = new Size(122, 23);
            label10.TabIndex = 18;
            label10.Text = "Reorder Level";
            // 
            // nudReorderLevel
            // 
            nudReorderLevel.Location = new Point(420, 224);
            nudReorderLevel.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudReorderLevel.Name = "nudReorderLevel";
            nudReorderLevel.Size = new Size(120, 23);
            nudReorderLevel.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label11.Location = new Point(590, 204);
            label11.Name = "label11";
            label11.Size = new Size(137, 23);
            label11.TabIndex = 20;
            label11.Text = "Expiration Date";
            // 
            // dtpExpiry
            // 
            dtpExpiry.Format = DateTimePickerFormat.Short;
            dtpExpiry.Location = new Point(590, 224);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.ShowCheckBox = true;
            dtpExpiry.Size = new Size(200, 23);
            dtpExpiry.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label12.Location = new Point(420, 264);
            label12.Name = "label12";
            label12.Size = new Size(102, 23);
            label12.TabIndex = 22;
            label12.Text = "Discount %";
            // 
            // nudDiscount
            // 
            nudDiscount.Location = new Point(420, 284);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(120, 23);
            nudDiscount.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(590, 264);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 24;
            label13.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(590, 284);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(121, 23);
            cboStatus.TabIndex = 25;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(590, 360);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 34);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumPurple;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(720, 360);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 34);
            btnSave.TabIndex = 27;
            btnSave.Text = " Save Product";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            label14.Location = new Point(590, 144);
            label14.Name = "label14";
            label14.Size = new Size(80, 23);
            label14.TabIndex = 28;
            label14.Text = "Category";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(590, 164);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(121, 23);
            cboCategory.TabIndex = 29;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(24, 164);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(360, 23);
            txtBarcode.TabIndex = 5;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            txtBarcode.KeyPress += txtBarcode_KeyPress;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 232, 255);
            ClientSize = new Size(893, 482);
            Controls.Add(cboCategory);
            Controls.Add(label14);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(cboStatus);
            Controls.Add(label13);
            Controls.Add(nudDiscount);
            Controls.Add(label12);
            Controls.Add(dtpExpiry);
            Controls.Add(label11);
            Controls.Add(nudReorderLevel);
            Controls.Add(label10);
            Controls.Add(cboSupplier);
            Controls.Add(label9);
            Controls.Add(nudSellingPrice);
            Controls.Add(label8);
            Controls.Add(nudCostPrice);
            Controls.Add(label7);
            Controls.Add(cboUnit);
            Controls.Add(label6);
            Controls.Add(nudStockQty);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtBarcode);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Product";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudStockQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCostPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSellingPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudReorderLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public TextBox txtProductId;
        public Label label2;
        public TextBox txtProductName;
        public Label label3;
        public TextBox txtBarcode;
        public Label label4;
        public TextBox txtDescription;
        public Label label14;
        public ComboBox cboCategory;
        public Label label5;
        public NumericUpDown nudStockQty;
        public Label label6;
        public ComboBox cboUnit;
        public Label label7;
        public NumericUpDown nudCostPrice;
        public Label label8;
        public NumericUpDown nudSellingPrice;
        public Label label9;
        public ComboBox cboSupplier;
        public Label label10;
        public NumericUpDown nudReorderLevel;
        public Label label11;
        public DateTimePicker dtpExpiry;
        public Label label12;
        public NumericUpDown nudDiscount;
        public Label label13;
        public ComboBox cboStatus;
        public Button btnCancel;
        public Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}