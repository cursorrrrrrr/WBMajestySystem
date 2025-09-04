namespace WBMajestySystem
{
    partial class EditProductForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProductName = new TextBox();
            txtDescription = new TextBox();
            nudStock = new NumericUpDown();
            nudPrice = new NumericUpDown();
            cboStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Stock Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 140);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 180);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Status:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(130, 20);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(300, 23);
            txtProductName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(130, 60);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 23);
            txtDescription.TabIndex = 6;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(130, 100);
            nudStock.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(100, 23);
            nudStock.TabIndex = 7;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(130, 140);
            nudPrice.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(100, 23);
            nudPrice.TabIndex = 8;
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(130, 180);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(100, 23);
            cboStatus.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(320, 250);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboStatus);
            Controls.Add(nudPrice);
            Controls.Add(nudStock);
            Controls.Add(txtDescription);
            Controls.Add(txtProductName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Product";
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public TextBox txtProductName;
        public TextBox txtDescription;
        public NumericUpDown nudStock;
        public NumericUpDown nudPrice;
        public ComboBox cboStatus;
        public Button btnSave;
        public Button btnCancel;
    }
}