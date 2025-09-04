namespace WBMajestySystem
{
    partial class TransactionReceiptForm
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
            lblStoreTitle = new Label();
            lblStoreAddress = new Label();
            lblReceiptTitle = new Label();
            lblReceiptTransactionID = new Label();
            lblReceiptDateTime = new Label();
            lblReceiptTime = new Label();
            lblReceiptCashier = new Label();
            lblSeparator1 = new Label();
            lstReceiptItems = new ListBox();
            lblSeparator2 = new Label();
            lblReceiptPaymentMethod = new Label();
            lblThankYou = new Label();
            lblContactNumber = new Label();
            lblSeparator3 = new Label();
            lblSubtotalValue = new Label();
            lblReceiptSubtotal = new Label();
            lblVATValue = new Label();
            lblReceiptVAT = new Label();
            this.lblTotalValue = new Label();
            lblReceiptTotal = new Label();
            SuspendLayout();
            // 
            // lblStoreTitle
            // 
            lblStoreTitle.AutoSize = true;
            lblStoreTitle.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStoreTitle.ForeColor = Color.Purple;
            lblStoreTitle.Location = new Point(12, 7);
            lblStoreTitle.Name = "lblStoreTitle";
            lblStoreTitle.Size = new Size(358, 24);
            lblStoreTitle.TabIndex = 0;
            lblStoreTitle.Text = "WB MAJESTY GROCERIES STORE";
            lblStoreTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStoreAddress
            // 
            lblStoreAddress.AutoSize = true;
            lblStoreAddress.Font = new Font("Arial", 10F);
            lblStoreAddress.ForeColor = Color.Gray;
            lblStoreAddress.Location = new Point(32, 31);
            lblStoreAddress.Name = "lblStoreAddress";
            lblStoreAddress.Size = new Size(330, 16);
            lblStoreAddress.TabIndex = 1;
            lblStoreAddress.Text = "23 Pag-asa St. Katuparan North Signal, Taguig City";
            // 
            // lblReceiptTitle
            // 
            lblReceiptTitle.AutoSize = true;
            lblReceiptTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptTitle.ForeColor = Color.Black;
            lblReceiptTitle.Location = new Point(121, 75);
            lblReceiptTitle.Name = "lblReceiptTitle";
            lblReceiptTitle.Size = new Size(138, 19);
            lblReceiptTitle.TabIndex = 2;
            lblReceiptTitle.Text = "SALES RECEIPT";
            // 
            // lblReceiptTransactionID
            // 
            lblReceiptTransactionID.AutoSize = true;
            lblReceiptTransactionID.Font = new Font("Arial", 10F);
            lblReceiptTransactionID.ForeColor = Color.Black;
            lblReceiptTransactionID.Location = new Point(29, 119);
            lblReceiptTransactionID.Name = "lblReceiptTransactionID";
            lblReceiptTransactionID.Size = new Size(214, 16);
            lblReceiptTransactionID.TabIndex = 3;
            lblReceiptTransactionID.Text = "Transaction ID: #TXN-2024-0001";
            // 
            // lblReceiptDateTime
            // 
            lblReceiptDateTime.AutoSize = true;
            lblReceiptDateTime.Font = new Font("Arial", 10F);
            lblReceiptDateTime.ForeColor = Color.Black;
            lblReceiptDateTime.Location = new Point(29, 136);
            lblReceiptDateTime.Name = "lblReceiptDateTime";
            lblReceiptDateTime.Size = new Size(190, 16);
            lblReceiptDateTime.TabIndex = 4;
            lblReceiptDateTime.Text = "Date: Jan 15, 2025 10:30 AM";
            // 
            // lblReceiptTime
            // 
            lblReceiptTime.AutoSize = true;
            lblReceiptTime.Font = new Font("Arial", 10F);
            lblReceiptTime.ForeColor = Color.Black;
            lblReceiptTime.Location = new Point(29, 153);
            lblReceiptTime.Name = "lblReceiptTime";
            lblReceiptTime.Size = new Size(62, 16);
            lblReceiptTime.TabIndex = 5;
            lblReceiptTime.Text = "WALK-IN";
            // 
            // lblReceiptCashier
            // 
            lblReceiptCashier.AutoSize = true;
            lblReceiptCashier.Font = new Font("Arial", 10F);
            lblReceiptCashier.ForeColor = Color.Black;
            lblReceiptCashier.Location = new Point(29, 169);
            lblReceiptCashier.Name = "lblReceiptCashier";
            lblReceiptCashier.Size = new Size(135, 16);
            lblReceiptCashier.TabIndex = 6;
            lblReceiptCashier.Text = "Cashier: Admin User";
            // 
            // lblSeparator1
            // 
            lblSeparator1.AutoSize = true;
            lblSeparator1.Font = new Font("Arial", 10F);
            lblSeparator1.ForeColor = Color.Black;
            lblSeparator1.Location = new Point(20, 185);
            lblSeparator1.Name = "lblSeparator1";
            lblSeparator1.Size = new Size(342, 16);
            lblSeparator1.TabIndex = 7;
            lblSeparator1.Text = "-------------------------------------------------------------------";
            // 
            // lstReceiptItems
            // 
            lstReceiptItems.BackColor = Color.FromArgb(250, 247, 255);
            lstReceiptItems.Font = new Font("Arial", 9F);
            lstReceiptItems.FormattingEnabled = true;
            lstReceiptItems.ItemHeight = 15;
            lstReceiptItems.Location = new Point(12, 204);
            lstReceiptItems.Name = "lstReceiptItems";
            lstReceiptItems.Size = new Size(360, 199);
            lstReceiptItems.TabIndex = 8;
            // 
            // lblSeparator2
            // 
            lblSeparator2.AutoSize = true;
            lblSeparator2.Font = new Font("Arial", 10F);
            lblSeparator2.ForeColor = Color.Black;
            lblSeparator2.Location = new Point(20, 406);
            lblSeparator2.Name = "lblSeparator2";
            lblSeparator2.Size = new Size(342, 16);
            lblSeparator2.TabIndex = 9;
            lblSeparator2.Text = "-------------------------------------------------------------------";
            // 
            // lblReceiptPaymentMethod
            // 
            lblReceiptPaymentMethod.AutoSize = true;
            lblReceiptPaymentMethod.Font = new Font("Arial", 10F);
            lblReceiptPaymentMethod.ForeColor = Color.Black;
            lblReceiptPaymentMethod.Location = new Point(20, 491);
            lblReceiptPaymentMethod.Name = "lblReceiptPaymentMethod";
            lblReceiptPaymentMethod.Size = new Size(154, 16);
            lblReceiptPaymentMethod.TabIndex = 13;
            lblReceiptPaymentMethod.Text = "Payment Method: Cash";
            // 
            // lblThankYou
            // 
            lblThankYou.AutoSize = true;
            lblThankYou.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThankYou.ForeColor = Color.Purple;
            lblThankYou.Location = new Point(77, 534);
            lblThankYou.Name = "lblThankYou";
            lblThankYou.Size = new Size(212, 16);
            lblThankYou.TabIndex = 14;
            lblThankYou.Text = "Thank you for Shopping with us!";
            lblThankYou.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new Font("Arial", 10F);
            lblContactNumber.ForeColor = Color.Gray;
            lblContactNumber.Location = new Point(132, 47);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(95, 16);
            lblContactNumber.TabIndex = 15;
            lblContactNumber.Text = "09731915204";
            // 
            // lblSeparator3
            // 
            lblSeparator3.AutoSize = true;
            lblSeparator3.Font = new Font("Arial", 10F);
            lblSeparator3.ForeColor = Color.Black;
            lblSeparator3.Location = new Point(20, 450);
            lblSeparator3.Name = "lblSeparator3";
            lblSeparator3.Size = new Size(342, 16);
            lblSeparator3.TabIndex = 16;
            lblSeparator3.Text = "-------------------------------------------------------------------";
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.AutoSize = true;
            lblSubtotalValue.BackColor = Color.Transparent;
            lblSubtotalValue.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotalValue.ForeColor = Color.Black;
            lblSubtotalValue.Location = new Point(304, 421);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(50, 18);
            lblSubtotalValue.TabIndex = 25;
            lblSubtotalValue.Text = "₱0.00";
            // 
            // lblReceiptSubtotal
            // 
            lblReceiptSubtotal.AutoSize = true;
            lblReceiptSubtotal.BackColor = Color.Transparent;
            lblReceiptSubtotal.Font = new Font("Arial", 10F);
            lblReceiptSubtotal.ForeColor = Color.Black;
            lblReceiptSubtotal.Location = new Point(20, 422);
            lblReceiptSubtotal.Name = "lblReceiptSubtotal";
            lblReceiptSubtotal.Size = new Size(63, 16);
            lblReceiptSubtotal.TabIndex = 24;
            lblReceiptSubtotal.Text = "Subtotal:";
            // 
            // lblVATValue
            // 
            lblVATValue.AutoSize = true;
            lblVATValue.BackColor = Color.Transparent;
            lblVATValue.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVATValue.ForeColor = Color.Black;
            lblVATValue.Location = new Point(295, 439);
            lblVATValue.Name = "lblVATValue";
            lblVATValue.Size = new Size(59, 18);
            lblVATValue.TabIndex = 27;
            lblVATValue.Text = "₱16.80";
            // 
            // lblReceiptVAT
            // 
            lblReceiptVAT.AutoSize = true;
            lblReceiptVAT.BackColor = Color.Transparent;
            lblReceiptVAT.Font = new Font("Arial", 10F);
            lblReceiptVAT.ForeColor = Color.Black;
            lblReceiptVAT.Location = new Point(20, 438);
            lblReceiptVAT.Name = "lblReceiptVAT";
            lblReceiptVAT.Size = new Size(82, 16);
            lblReceiptVAT.TabIndex = 26;
            lblReceiptVAT.Text = "VAT (12%): ";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.BackColor = Color.Transparent;
            this.lblTotalValue.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblTotalValue.ForeColor = Color.Black;
            this.lblTotalValue.Location = new Point(285, 463);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new Size(69, 19);
            this.lblTotalValue.TabIndex = 29;
            this.lblTotalValue.Text = "₱156.80";
            // 
            // lblReceiptTotal
            // 
            lblReceiptTotal.AutoSize = true;
            lblReceiptTotal.BackColor = Color.Transparent;
            lblReceiptTotal.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblReceiptTotal.ForeColor = Color.Black;
            lblReceiptTotal.Location = new Point(20, 463);
            lblReceiptTotal.Name = "lblReceiptTotal";
            lblReceiptTotal.Size = new Size(71, 19);
            lblReceiptTotal.TabIndex = 28;
            lblReceiptTotal.Text = "TOTAL: ";
            // 
            // TransactionReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 255);
            ClientSize = new Size(384, 561);
            Controls.Add(this.lblTotalValue);
            Controls.Add(lblReceiptTotal);
            Controls.Add(lblVATValue);
            Controls.Add(lblReceiptVAT);
            Controls.Add(lblSubtotalValue);
            Controls.Add(lblReceiptSubtotal);
            Controls.Add(lblSeparator3);
            Controls.Add(lblContactNumber);
            Controls.Add(lblThankYou);
            Controls.Add(lblReceiptPaymentMethod);
            Controls.Add(lblSeparator2);
            Controls.Add(lstReceiptItems);
            Controls.Add(lblSeparator1);
            Controls.Add(lblReceiptCashier);
            Controls.Add(lblReceiptTime);
            Controls.Add(lblReceiptDateTime);
            Controls.Add(lblReceiptTransactionID);
            Controls.Add(lblReceiptTitle);
            Controls.Add(lblStoreAddress);
            Controls.Add(lblStoreTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TransactionReceiptForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaction Receipt - WB Majesty Groceries Store";
            Load += TransactionReceiptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        

        private Label lblStoreTitle;
        private Label lblStoreAddress;
        private Label lblContactNumber;
        private Label lblReceiptTitle;
        private Label lblReceiptTransactionID;
        private Label lblReceiptDateTime;
        private Label lblReceiptTime;
        private Label lblReceiptCashier;
        private Label lblSeparator1;
        private ListBox lstReceiptItems;
        private Label lblSeparator2;
        private Label lblReceiptSubtotal;
        private Label lblSubtotalValue;
        private Label lblReceiptVAT;
        private Label lblVATValue;
        private Label lblSeparator3;
        private Label lblReceiptTotal;
        private Label lblTotalValue;
        private Label lblReceiptPaymentMethod;
        private Label lblThankYou;

    }
}