namespace WBMajestySystem
{
    partial class NewTransactionForm
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblTransactionID = new Label();
            lblDateTime = new Label();
            lblScannerTitle = new Label();
            lblScannerInstruction = new Label();
            lblBarcode = new Label();
            txtBarcode = new TextBox();
            btnSearch = new Button();
            btnAddItem = new Button();
            lblItemsTitle = new Label();
            lblItemsInstruction = new Label();
            lblItemsCount = new Label();
            lblSummaryTitle = new Label();
            panelSummary = new Panel();
            lblPercent = new Label();
            cboPaymentMethod = new ComboBox();
            lblChangeValue = new Label();
            lblDiscountSubtitle = new Label();
            lblChange = new Label();
            lblTotalValue = new Label();
            txtAmountReceived = new TextBox();
            btnCompleteTransaction = new Button();
            lblAmountReceived = new Label();
            lblApplyDiscount = new Label();
            lblTotal = new Label();
            lblDiscountValue = new Label();
            lblDiscount = new Label();
            lblPaymentMethod = new Label();
            lblVATValue = new Label();
            lblVAT = new Label();
            lblSubtotalValue = new Label();
            lblSubtotal = new Label();
            txtDiscount = new TextBox();
            panelProductScanner = new Panel();
            panelTransactionItems = new Panel();
            dgvItems = new DataGridView();
            colProductNo = new DataGridViewTextBoxColumn();
            colBarcode = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewTextBoxColumn();
            panelSummary.SuspendLayout();
            panelProductScanner.SuspendLayout();
            panelTransactionItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Californian FB", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Purple;
            lblTitle.Location = new Point(20, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(341, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "➕ New Transaction";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(79, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(272, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Scan or search products to add to cart";
            // 
            // lblTransactionID
            // 
            lblTransactionID.AutoSize = true;
            lblTransactionID.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblTransactionID.ForeColor = Color.FromArgb(74, 46, 110);
            lblTransactionID.Location = new Point(1211, 9);
            lblTransactionID.Name = "lblTransactionID";
            lblTransactionID.Size = new Size(282, 24);
            lblTransactionID.TabIndex = 2;
            lblTransactionID.Text = "Transaction ID: #TXN-2024-0001";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblDateTime.ForeColor = Color.FromArgb(125, 91, 166);
            lblDateTime.Location = new Point(1150, 37);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(343, 24);
            lblDateTime.TabIndex = 3;
            lblDateTime.Text = "Date and Time: Jan 15, 2025 - 10:30 AM";
            // 
            // lblScannerTitle
            // 
            lblScannerTitle.AutoSize = true;
            lblScannerTitle.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScannerTitle.ForeColor = Color.Purple;
            lblScannerTitle.Location = new Point(24, 14);
            lblScannerTitle.Name = "lblScannerTitle";
            lblScannerTitle.Size = new Size(181, 24);
            lblScannerTitle.TabIndex = 4;
            lblScannerTitle.Text = "Product Scanner";
            // 
            // lblScannerInstruction
            // 
            lblScannerInstruction.AutoSize = true;
            lblScannerInstruction.BackColor = Color.Transparent;
            lblScannerInstruction.Font = new Font("Arial", 9F);
            lblScannerInstruction.ForeColor = Color.Gray;
            lblScannerInstruction.Location = new Point(30, 38);
            lblScannerInstruction.Name = "lblScannerInstruction";
            lblScannerInstruction.Size = new Size(255, 15);
            lblScannerInstruction.TabIndex = 5;
            lblScannerInstruction.Text = "Scan barcode or enter product code manually";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.BackColor = Color.Transparent;
            lblBarcode.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarcode.ForeColor = Color.Black;
            lblBarcode.Location = new Point(30, 71);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(162, 16);
            lblBarcode.TabIndex = 6;
            lblBarcode.Text = "Barcode / Product Code:";
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Arial", 12F);
            txtBarcode.Location = new Point(30, 90);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.PlaceholderText = "Scan or type barcode...";
            txtBarcode.Size = new Size(531, 26);
            txtBarcode.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Purple;
            btnSearch.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(567, 88);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(40, 40, 50);
            btnAddItem.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(673, 87);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(100, 30);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "➕ Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            // 
            // lblItemsTitle
            // 
            lblItemsTitle.AutoSize = true;
            lblItemsTitle.Font = new Font("Arial Rounded MT Bold", 15.75F);
            lblItemsTitle.ForeColor = Color.Purple;
            lblItemsTitle.Location = new Point(23, 15);
            lblItemsTitle.Name = "lblItemsTitle";
            lblItemsTitle.Size = new Size(192, 24);
            lblItemsTitle.TabIndex = 9;
            lblItemsTitle.Text = "Transaction Items";
            // 
            // lblItemsInstruction
            // 
            lblItemsInstruction.AutoSize = true;
            lblItemsInstruction.Font = new Font("Arial", 9F);
            lblItemsInstruction.ForeColor = Color.Gray;
            lblItemsInstruction.Location = new Point(35, 43);
            lblItemsInstruction.Name = "lblItemsInstruction";
            lblItemsInstruction.Size = new Size(368, 15);
            lblItemsInstruction.TabIndex = 10;
            lblItemsInstruction.Text = "Press DEL to remove selected item, or double-click to edit quantity";
            // 
            // lblItemsCount
            // 
            lblItemsCount.AutoSize = true;
            lblItemsCount.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemsCount.ForeColor = Color.Purple;
            lblItemsCount.Location = new Point(885, 42);
            lblItemsCount.Name = "lblItemsCount";
            lblItemsCount.Size = new Size(96, 16);
            lblItemsCount.TabIndex = 11;
            lblItemsCount.Text = "3 items in cart";
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.AutoSize = true;
            lblSummaryTitle.Font = new Font("Arial Rounded MT Bold", 15.75F);
            lblSummaryTitle.ForeColor = Color.Purple;
            lblSummaryTitle.Location = new Point(19, 14);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(233, 24);
            lblSummaryTitle.TabIndex = 13;
            lblSummaryTitle.Text = "Transaction Summary";
            // 
            // panelSummary
            // 
            panelSummary.BackColor = Color.FromArgb(235, 232, 255);
            panelSummary.BorderStyle = BorderStyle.FixedSingle;
            panelSummary.Controls.Add(lblPercent);
            panelSummary.Controls.Add(cboPaymentMethod);
            panelSummary.Controls.Add(lblChangeValue);
            panelSummary.Controls.Add(lblSummaryTitle);
            panelSummary.Controls.Add(lblDiscountSubtitle);
            panelSummary.Controls.Add(lblChange);
            panelSummary.Controls.Add(lblTotalValue);
            panelSummary.Controls.Add(txtAmountReceived);
            panelSummary.Controls.Add(btnCompleteTransaction);
            panelSummary.Controls.Add(lblAmountReceived);
            panelSummary.Controls.Add(lblApplyDiscount);
            panelSummary.Controls.Add(lblTotal);
            panelSummary.Controls.Add(lblDiscountValue);
            panelSummary.Controls.Add(lblDiscount);
            panelSummary.Controls.Add(lblPaymentMethod);
            panelSummary.Controls.Add(lblVATValue);
            panelSummary.Controls.Add(lblVAT);
            panelSummary.Controls.Add(lblSubtotalValue);
            panelSummary.Controls.Add(lblSubtotal);
            panelSummary.Controls.Add(txtDiscount);
            panelSummary.Location = new Point(1093, 119);
            panelSummary.Name = "panelSummary";
            panelSummary.Size = new Size(381, 540);
            panelSummary.TabIndex = 14;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.BackColor = Color.Transparent;
            lblPercent.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercent.ForeColor = Color.Black;
            lblPercent.Location = new Point(307, 205);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(27, 24);
            lblPercent.TabIndex = 17;
            lblPercent.Text = "%";
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentMethod.Font = new Font("Arial", 12F);
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Items.AddRange(new object[] { "💸 CASH", "💳 GCASH", "📱 CARD" });
            cboPaymentMethod.Location = new Point(247, 268);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(106, 26);
            cboPaymentMethod.TabIndex = 19;
            // 
            // lblChangeValue
            // 
            lblChangeValue.AutoSize = true;
            lblChangeValue.BackColor = SystemColors.Window;
            lblChangeValue.BorderStyle = BorderStyle.FixedSingle;
            lblChangeValue.Font = new Font("Arial", 15.75F);
            lblChangeValue.ForeColor = Color.Black;
            lblChangeValue.Location = new Point(247, 393);
            lblChangeValue.Name = "lblChangeValue";
            lblChangeValue.Size = new Size(68, 26);
            lblChangeValue.TabIndex = 23;
            lblChangeValue.Text = "₱0.00";
            // 
            // lblDiscountSubtitle
            // 
            lblDiscountSubtitle.AutoSize = true;
            lblDiscountSubtitle.BackColor = Color.Transparent;
            lblDiscountSubtitle.Font = new Font("Arial", 9F);
            lblDiscountSubtitle.ForeColor = Color.Gray;
            lblDiscountSubtitle.Location = new Point(88, 225);
            lblDiscountSubtitle.Name = "lblDiscountSubtitle";
            lblDiscountSubtitle.Size = new Size(133, 15);
            lblDiscountSubtitle.TabIndex = 15;
            lblDiscountSubtitle.Text = "Senior, PWD, or Promo";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.BackColor = Color.Transparent;
            lblChange.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(19, 389);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(108, 29);
            lblChange.TabIndex = 22;
            lblChange.Text = "Change:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblTotalValue.ForeColor = Color.FromArgb(192, 0, 192);
            lblTotalValue.Location = new Point(202, 145);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(76, 23);
            lblTotalValue.TabIndex = 7;
            lblTotalValue.Text = "₱156.80";
            lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAmountReceived
            // 
            txtAmountReceived.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmountReceived.Location = new Point(247, 325);
            txtAmountReceived.Name = "txtAmountReceived";
            txtAmountReceived.Size = new Size(58, 32);
            txtAmountReceived.TabIndex = 21;
            txtAmountReceived.Text = "0.00";
            txtAmountReceived.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCompleteTransaction
            // 
            btnCompleteTransaction.BackColor = Color.Purple;
            btnCompleteTransaction.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompleteTransaction.ForeColor = Color.White;
            btnCompleteTransaction.Location = new Point(88, 453);
            btnCompleteTransaction.Name = "btnCompleteTransaction";
            btnCompleteTransaction.Size = new Size(200, 40);
            btnCompleteTransaction.TabIndex = 24;
            btnCompleteTransaction.Text = "Complete Transaction";
            btnCompleteTransaction.UseVisualStyleBackColor = false;
            btnCompleteTransaction.Click += btnCompleteTransaction_Click;
            btnCompleteTransaction.MouseCaptureChanged += btnCompleteTransaction_Click;
            // 
            // lblAmountReceived
            // 
            lblAmountReceived.AutoSize = true;
            lblAmountReceived.BackColor = Color.Transparent;
            lblAmountReceived.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblAmountReceived.ForeColor = Color.Black;
            lblAmountReceived.Location = new Point(19, 327);
            lblAmountReceived.Name = "lblAmountReceived";
            lblAmountReceived.Size = new Size(222, 29);
            lblAmountReceived.TabIndex = 20;
            lblAmountReceived.Text = "Amount Received:";
            // 
            // lblApplyDiscount
            // 
            lblApplyDiscount.AutoSize = true;
            lblApplyDiscount.BackColor = Color.Transparent;
            lblApplyDiscount.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplyDiscount.ForeColor = Color.Black;
            lblApplyDiscount.Location = new Point(19, 196);
            lblApplyDiscount.Name = "lblApplyDiscount";
            lblApplyDiscount.Size = new Size(190, 29);
            lblApplyDiscount.TabIndex = 8;
            lblApplyDiscount.Text = "Apply Discount";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(192, 0, 192);
            lblTotal.Location = new Point(88, 145);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // lblDiscountValue
            // 
            lblDiscountValue.AutoSize = true;
            lblDiscountValue.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblDiscountValue.ForeColor = Color.Green;
            lblDiscountValue.Location = new Point(216, 109);
            lblDiscountValue.Name = "lblDiscountValue";
            lblDiscountValue.Size = new Size(62, 23);
            lblDiscountValue.TabIndex = 5;
            lblDiscountValue.Text = "-₱0.00";
            lblDiscountValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblDiscount.ForeColor = Color.Black;
            lblDiscount.Location = new Point(88, 109);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(85, 23);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "Discount:";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.BackColor = Color.Transparent;
            lblPaymentMethod.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblPaymentMethod.ForeColor = Color.Black;
            lblPaymentMethod.Location = new Point(19, 265);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(213, 29);
            lblPaymentMethod.TabIndex = 18;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblVATValue
            // 
            lblVATValue.AutoSize = true;
            lblVATValue.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblVATValue.ForeColor = Color.Black;
            lblVATValue.Location = new Point(212, 83);
            lblVATValue.Name = "lblVATValue";
            lblVATValue.Size = new Size(66, 23);
            lblVATValue.TabIndex = 3;
            lblVATValue.Text = "₱16.80";
            lblVATValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblVAT.ForeColor = Color.Black;
            lblVAT.Location = new Point(88, 84);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(95, 23);
            lblVAT.TabIndex = 2;
            lblVAT.Text = "VAT (12%):";
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.AutoSize = true;
            lblSubtotalValue.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblSubtotalValue.ForeColor = Color.Black;
            lblSubtotalValue.Location = new Point(202, 55);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(76, 23);
            lblSubtotalValue.TabIndex = 1;
            lblSubtotalValue.Text = "₱140.00";
            lblSubtotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblSubtotal.ForeColor = Color.Black;
            lblSubtotal.Location = new Point(88, 55);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(82, 23);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal:";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(247, 202);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(58, 32);
            txtDiscount.TabIndex = 16;
            txtDiscount.Text = "0";
            txtDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // panelProductScanner
            // 
            panelProductScanner.BackColor = Color.FromArgb(235, 232, 255);
            panelProductScanner.BorderStyle = BorderStyle.FixedSingle;
            panelProductScanner.Controls.Add(btnAddItem);
            panelProductScanner.Controls.Add(lblScannerTitle);
            panelProductScanner.Controls.Add(lblScannerInstruction);
            panelProductScanner.Controls.Add(lblBarcode);
            panelProductScanner.Controls.Add(txtBarcode);
            panelProductScanner.Controls.Add(btnSearch);
            panelProductScanner.Location = new Point(30, 80);
            panelProductScanner.Name = "panelProductScanner";
            panelProductScanner.Size = new Size(837, 134);
            panelProductScanner.TabIndex = 24;
            // 
            // panelTransactionItems
            // 
            panelTransactionItems.BackColor = Color.FromArgb(235, 232, 255);
            panelTransactionItems.BorderStyle = BorderStyle.FixedSingle;
            panelTransactionItems.Controls.Add(dgvItems);
            panelTransactionItems.Controls.Add(lblItemsInstruction);
            panelTransactionItems.Controls.Add(lblItemsTitle);
            panelTransactionItems.Controls.Add(lblItemsCount);
            panelTransactionItems.Location = new Point(30, 233);
            panelTransactionItems.Name = "panelTransactionItems";
            panelTransactionItems.Size = new Size(1030, 493);
            panelTransactionItems.TabIndex = 25;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colProductNo, colBarcode, colProductName, colQuantity, colPrice, colTotal, colAction });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle1;
            dgvItems.Location = new Point(24, 70);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvItems.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(972, 396);
            dgvItems.TabIndex = 12;
            // 
            // colProductNo
            // 
            colProductNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colProductNo.Frozen = true;
            colProductNo.HeaderText = "PRODUCT NO.";
            colProductNo.Name = "colProductNo";
            colProductNo.ReadOnly = true;
            // 
            // colBarcode
            // 
            colBarcode.Frozen = true;
            colBarcode.HeaderText = "BARCODE";
            colBarcode.Name = "colBarcode";
            colBarcode.ReadOnly = true;
            colBarcode.Width = 150;
            // 
            // colProductName
            // 
            colProductName.Frozen = true;
            colProductName.HeaderText = "PRODUCT NAME";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 450;
            // 
            // colQuantity
            // 
            colQuantity.Frozen = true;
            colQuantity.HeaderText = "QUANTITY";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 80;
            // 
            // colPrice
            // 
            colPrice.Frozen = true;
            colPrice.HeaderText = "PRICE";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 50;
            // 
            // colTotal
            // 
            colTotal.Frozen = true;
            colTotal.HeaderText = "TOTAL";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 50;
            // 
            // colAction
            // 
            colAction.Frozen = true;
            colAction.HeaderText = "ACTION";
            colAction.Name = "colAction";
            colAction.ReadOnly = true;
            colAction.Width = 80;
            // 
            // NewTransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1523, 749);
            Controls.Add(lblDateTime);
            Controls.Add(lblTransactionID);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(panelSummary);
            Controls.Add(panelProductScanner);
            Controls.Add(panelTransactionItems);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewTransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Transaction - WB Majesty Groceries Store";
            Load += NewTransactionForm_Load;
            panelSummary.ResumeLayout(false);
            panelSummary.PerformLayout();
            panelProductScanner.ResumeLayout(false);
            panelProductScanner.PerformLayout();
            panelTransactionItems.ResumeLayout(false);
            panelTransactionItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblTransactionID;
        private Label lblDateTime;
        private Panel panelProductScanner;
        private Label lblScannerTitle;
        private Label lblScannerInstruction;
        private Label lblBarcode;
        private TextBox txtBarcode;
        private Button btnSearch;
        private Button btnAddItem;
        private Panel panelTransactionItems;
        private Label lblItemsTitle;
        private Label lblItemsInstruction;
        private Label lblItemsCount;
        private Panel panelSummary;
        private Label lblSummaryTitle;
        private Label lblSubtotalValue;
        private Label lblSubtotal;
        private Label lblTotalValue;
        private Label lblTotal;
        private Label lblDiscountValue;
        private Label lblDiscount;
        private Label lblVATValue;
        private Label lblVAT;        
        private Label lblPaymentMethod;
        private ComboBox cboPaymentMethod;
        private Label lblAmountReceived;
        private TextBox txtAmountReceived;
        private Label lblChange;
        private Label lblChangeValue;
        private Button btnCompleteTransaction;
        private Label lblPercent;
        private TextBox txtDiscount;
        private Label lblDiscountSubtitle;
        private Label lblApplyDiscount;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn colProductNo;
        private DataGridViewTextBoxColumn colBarcode;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colAction;
    }
}