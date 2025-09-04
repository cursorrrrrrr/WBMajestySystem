namespace WBMajestySystem
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panelSidebar = new Panel();
            btnNewTransaction = new Button();
            lblSystemStatus = new Label();
            btnUsers = new Button();
            btnReports = new Button();
            btnInventory = new Button();
            btnDashboard = new Button();
            btnProducts = new Button();
            panelUserInfo = new Panel();
            btnLogout = new Button();
            lblUserName = new Label();
            lblUserRole = new Label();
            lblSubtitle = new Label();
            lblLogo = new Label();
            panelMainContent = new Panel();
            btnQuickGenerateReport = new Button();
            btnQuickAddProduct = new Button();
            lblQuickActionsTitle = new Label();
            panelPendingOrders = new Panel();
            pictureBox4 = new PictureBox();
            lblPendingOrdersSubtitle = new Label();
            lblPendingOrdersTitle = new Label();
            lblPendingOrdersValue = new Label();
            panelLowStock = new Panel();
            pictureBox1 = new PictureBox();
            lblLowStockSubtitle = new Label();
            lblLowStockTitle = new Label();
            lblLowStockValue = new Label();
            panelTotalProducts = new Panel();
            pictureBox3 = new PictureBox();
            lblTotalProductsSubtitle = new Label();
            lblTotalProductsTitle = new Label();
            lblTotalProductsValue = new Label();
            panelTodaySales = new Panel();
            pictureBox2 = new PictureBox();
            lblTodaySalesLabel = new Label();
            lblTodaySalesValue = new Label();
            lblMainSubtitle = new Label();
            lblMainTitle = new Label();
            panelSidebar.SuspendLayout();
            panelUserInfo.SuspendLayout();
            panelMainContent.SuspendLayout();
            panelPendingOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTotalProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelTodaySales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 30, 46);
            panelSidebar.Controls.Add(btnNewTransaction);
            panelSidebar.Controls.Add(lblSystemStatus);
            panelSidebar.Controls.Add(btnUsers);
            panelSidebar.Controls.Add(btnReports);
            panelSidebar.Controls.Add(btnInventory);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(btnProducts);
            panelSidebar.Controls.Add(panelUserInfo);
            panelSidebar.Controls.Add(lblSubtitle);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(300, 903);
            panelSidebar.TabIndex = 0;
            // 
            // btnNewTransaction
            // 
            btnNewTransaction.BackColor = Color.FromArgb(125, 91, 166);
            btnNewTransaction.FlatStyle = FlatStyle.Flat;
            btnNewTransaction.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewTransaction.ForeColor = Color.White;
            btnNewTransaction.Location = new Point(25, 182);
            btnNewTransaction.Name = "btnNewTransaction";
            btnNewTransaction.Size = new Size(249, 60);
            btnNewTransaction.TabIndex = 9;
            btnNewTransaction.Text = "➕ New Transaction";
            btnNewTransaction.UseVisualStyleBackColor = false;
            btnNewTransaction.Click += btnNewTransaction_Click;
            // 
            // lblSystemStatus
            // 
            lblSystemStatus.BackColor = Color.FromArgb(40, 167, 69);
            lblSystemStatus.Font = new Font("Segoe UI", 10F);
            lblSystemStatus.Location = new Point(3, 879);
            lblSystemStatus.Name = "lblSystemStatus";
            lblSystemStatus.Size = new Size(291, 20);
            lblSystemStatus.TabIndex = 8;
            lblSystemStatus.Text = "System Online";
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(58, 58, 82);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(20, 481);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(261, 50);
            btnUsers.TabIndex = 7;
            btnUsers.Text = "👥 Users";
            btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(58, 58, 82);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(20, 425);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(261, 50);
            btnReports.TabIndex = 6;
            btnReports.Text = "📑 Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(58, 58, 82);
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(20, 369);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(261, 50);
            btnInventory.TabIndex = 5;
            btnInventory.Text = "🏷️ Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(58, 58, 82);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(20, 257);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(261, 50);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "📊 Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(58, 58, 82);
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(20, 313);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(261, 50);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "📦 Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // panelUserInfo
            // 
            panelUserInfo.BackColor = Color.FromArgb(40, 40, 50);
            panelUserInfo.Controls.Add(btnLogout);
            panelUserInfo.Controls.Add(lblUserName);
            panelUserInfo.Controls.Add(lblUserRole);
            panelUserInfo.Location = new Point(20, 120);
            panelUserInfo.Name = "panelUserInfo";
            panelUserInfo.Size = new Size(261, 43);
            panelUserInfo.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(235, 232, 255);
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(171, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(50, 3);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(99, 21);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Admin User";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserRole.ForeColor = Color.FromArgb(204, 204, 204);
            lblUserRole.Location = new Point(44, 21);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(115, 20);
            lblUserRole.TabIndex = 1;
            lblUserRole.Text = "Administrator";
            lblUserRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(204, 204, 204);
            lblSubtitle.Location = new Point(26, 62);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(240, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Groceries Store";
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Sparkling Bright", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(20, 19);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(333, 80);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "WB Majesty";
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(245, 247, 250);
            panelMainContent.Controls.Add(btnQuickGenerateReport);
            panelMainContent.Controls.Add(btnQuickAddProduct);
            panelMainContent.Controls.Add(lblQuickActionsTitle);
            panelMainContent.Controls.Add(panelPendingOrders);
            panelMainContent.Controls.Add(panelLowStock);
            panelMainContent.Controls.Add(panelTotalProducts);
            panelMainContent.Controls.Add(panelTodaySales);
            panelMainContent.Controls.Add(lblMainSubtitle);
            panelMainContent.Controls.Add(lblMainTitle);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(300, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1260, 903);
            panelMainContent.TabIndex = 1;
            panelMainContent.Paint += panelMainContent_Paint;
            // 
            // btnQuickGenerateReport
            // 
            btnQuickGenerateReport.BackColor = Color.FromArgb(108, 117, 125);
            btnQuickGenerateReport.FlatStyle = FlatStyle.Flat;
            btnQuickGenerateReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuickGenerateReport.ForeColor = Color.White;
            btnQuickGenerateReport.Location = new Point(761, 337);
            btnQuickGenerateReport.Name = "btnQuickGenerateReport";
            btnQuickGenerateReport.Size = new Size(241, 60);
            btnQuickGenerateReport.TabIndex = 9;
            btnQuickGenerateReport.Text = "📝 Generate Report";
            btnQuickGenerateReport.UseVisualStyleBackColor = false;
            // 
            // btnQuickAddProduct
            // 
            btnQuickAddProduct.BackColor = Color.FromArgb(92, 84, 112);
            btnQuickAddProduct.FlatStyle = FlatStyle.Flat;
            btnQuickAddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuickAddProduct.ForeColor = Color.White;
            btnQuickAddProduct.Location = new Point(498, 337);
            btnQuickAddProduct.Name = "btnQuickAddProduct";
            btnQuickAddProduct.Size = new Size(241, 60);
            btnQuickAddProduct.TabIndex = 8;
            btnQuickAddProduct.Text = "➕ Add Product";
            btnQuickAddProduct.UseVisualStyleBackColor = false;
            btnQuickAddProduct.Click += btnQuickAddProduct_Click;
            // 
            // lblQuickActionsTitle
            // 
            lblQuickActionsTitle.Font = new Font("Sparkling Bright", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickActionsTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblQuickActionsTitle.Location = new Point(30, 280);
            lblQuickActionsTitle.Name = "lblQuickActionsTitle";
            lblQuickActionsTitle.Size = new Size(200, 38);
            lblQuickActionsTitle.TabIndex = 6;
            lblQuickActionsTitle.Text = "Quick Actions";
            // 
            // panelPendingOrders
            // 
            panelPendingOrders.BackColor = Color.FromArgb(235, 232, 255);
            panelPendingOrders.BorderStyle = BorderStyle.FixedSingle;
            panelPendingOrders.Controls.Add(pictureBox4);
            panelPendingOrders.Controls.Add(lblPendingOrdersSubtitle);
            panelPendingOrders.Controls.Add(lblPendingOrdersTitle);
            panelPendingOrders.Controls.Add(lblPendingOrdersValue);
            panelPendingOrders.Location = new Point(873, 130);
            panelPendingOrders.Name = "panelPendingOrders";
            panelPendingOrders.Size = new Size(250, 120);
            panelPendingOrders.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(7, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // lblPendingOrdersSubtitle
            // 
            lblPendingOrdersSubtitle.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingOrdersSubtitle.ForeColor = Color.FromArgb(102, 102, 102);
            lblPendingOrdersSubtitle.Location = new Point(3, 92);
            lblPendingOrdersSubtitle.Name = "lblPendingOrdersSubtitle";
            lblPendingOrdersSubtitle.Size = new Size(244, 20);
            lblPendingOrdersSubtitle.TabIndex = 2;
            lblPendingOrdersSubtitle.Text = "₱4,250.00 value";
            lblPendingOrdersSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendingOrdersTitle
            // 
            lblPendingOrdersTitle.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            lblPendingOrdersTitle.ForeColor = Color.FromArgb(127, 140, 141);
            lblPendingOrdersTitle.Location = new Point(50, 14);
            lblPendingOrdersTitle.Name = "lblPendingOrdersTitle";
            lblPendingOrdersTitle.Size = new Size(183, 25);
            lblPendingOrdersTitle.TabIndex = 0;
            lblPendingOrdersTitle.Text = "PENDING ORDERS";
            // 
            // lblPendingOrdersValue
            // 
            lblPendingOrdersValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingOrdersValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblPendingOrdersValue.Location = new Point(3, 27);
            lblPendingOrdersValue.Name = "lblPendingOrdersValue";
            lblPendingOrdersValue.Size = new Size(244, 75);
            lblPendingOrdersValue.TabIndex = 1;
            lblPendingOrdersValue.Text = "8";
            lblPendingOrdersValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLowStock
            // 
            panelLowStock.BackColor = Color.FromArgb(255, 244, 244);
            panelLowStock.BorderStyle = BorderStyle.FixedSingle;
            panelLowStock.Controls.Add(pictureBox1);
            panelLowStock.Controls.Add(lblLowStockSubtitle);
            panelLowStock.Controls.Add(lblLowStockTitle);
            panelLowStock.Controls.Add(lblLowStockValue);
            panelLowStock.Location = new Point(589, 130);
            panelLowStock.Name = "panelLowStock";
            panelLowStock.Size = new Size(250, 120);
            panelLowStock.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblLowStockSubtitle
            // 
            lblLowStockSubtitle.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockSubtitle.ForeColor = Color.Firebrick;
            lblLowStockSubtitle.Location = new Point(3, 93);
            lblLowStockSubtitle.Name = "lblLowStockSubtitle";
            lblLowStockSubtitle.Size = new Size(244, 25);
            lblLowStockSubtitle.TabIndex = 2;
            lblLowStockSubtitle.Text = "Needs attention❗❗";
            lblLowStockSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            lblLowStockTitle.ForeColor = Color.Firebrick;
            lblLowStockTitle.Location = new Point(39, 9);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(201, 25);
            lblLowStockTitle.TabIndex = 0;
            lblLowStockTitle.Text = "LOW STOCK ITEMS";
            lblLowStockTitle.Click += lblLowStockTitle_Click;
            // 
            // lblLowStockValue
            // 
            lblLowStockValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockValue.ForeColor = Color.Red;
            lblLowStockValue.Location = new Point(3, 24);
            lblLowStockValue.Name = "lblLowStockValue";
            lblLowStockValue.Size = new Size(244, 75);
            lblLowStockValue.TabIndex = 1;
            lblLowStockValue.Text = "23";
            lblLowStockValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTotalProducts
            // 
            panelTotalProducts.BackColor = Color.FromArgb(235, 232, 255);
            panelTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            panelTotalProducts.Controls.Add(pictureBox3);
            panelTotalProducts.Controls.Add(lblTotalProductsSubtitle);
            panelTotalProducts.Controls.Add(lblTotalProductsTitle);
            panelTotalProducts.Controls.Add(lblTotalProductsValue);
            panelTotalProducts.Location = new Point(309, 130);
            panelTotalProducts.Name = "panelTotalProducts";
            panelTotalProducts.Size = new Size(250, 120);
            panelTotalProducts.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(5, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // lblTotalProductsSubtitle
            // 
            lblTotalProductsSubtitle.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProductsSubtitle.ForeColor = Color.FromArgb(102, 102, 102);
            lblTotalProductsSubtitle.Location = new Point(3, 90);
            lblTotalProductsSubtitle.Name = "lblTotalProductsSubtitle";
            lblTotalProductsSubtitle.Size = new Size(244, 28);
            lblTotalProductsSubtitle.TabIndex = 2;
            lblTotalProductsSubtitle.Text = "1,199 in stock";
            lblTotalProductsSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalProductsTitle
            // 
            lblTotalProductsTitle.BackColor = Color.Transparent;
            lblTotalProductsTitle.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            lblTotalProductsTitle.ForeColor = Color.FromArgb(127, 140, 141);
            lblTotalProductsTitle.Location = new Point(51, 11);
            lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            lblTotalProductsTitle.Size = new Size(178, 24);
            lblTotalProductsTitle.TabIndex = 0;
            lblTotalProductsTitle.Text = "TOTAL PRODUCTS";
            // 
            // lblTotalProductsValue
            // 
            lblTotalProductsValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProductsValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalProductsValue.Location = new Point(-1, 25);
            lblTotalProductsValue.Name = "lblTotalProductsValue";
            lblTotalProductsValue.Size = new Size(248, 75);
            lblTotalProductsValue.TabIndex = 1;
            lblTotalProductsValue.Text = "1,247";
            lblTotalProductsValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTodaySales
            // 
            panelTodaySales.BackColor = Color.FromArgb(235, 232, 255);
            panelTodaySales.BorderStyle = BorderStyle.FixedSingle;
            panelTodaySales.Controls.Add(pictureBox2);
            panelTodaySales.Controls.Add(lblTodaySalesLabel);
            panelTodaySales.Controls.Add(lblTodaySalesValue);
            panelTodaySales.Location = new Point(30, 130);
            panelTodaySales.Name = "panelTodaySales";
            panelTodaySales.Size = new Size(250, 120);
            panelTodaySales.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lblTodaySalesLabel
            // 
            lblTodaySalesLabel.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodaySalesLabel.ForeColor = Color.FromArgb(127, 140, 141);
            lblTodaySalesLabel.Location = new Point(48, 10);
            lblTodaySalesLabel.Name = "lblTodaySalesLabel";
            lblTodaySalesLabel.Size = new Size(185, 32);
            lblTodaySalesLabel.TabIndex = 1;
            lblTodaySalesLabel.Text = "TODAY'S SALES";
            // 
            // lblTodaySalesValue
            // 
            lblTodaySalesValue.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodaySalesValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblTodaySalesValue.Location = new Point(-1, 46);
            lblTodaySalesValue.Name = "lblTodaySalesValue";
            lblTodaySalesValue.Size = new Size(250, 55);
            lblTodaySalesValue.TabIndex = 0;
            lblTodaySalesValue.Text = "₱15,847.50";
            lblTodaySalesValue.TextAlign = ContentAlignment.MiddleCenter;
            lblTodaySalesValue.Click += lblTodaySalesValue_Click;
            // 
            // lblMainSubtitle
            // 
            lblMainSubtitle.Font = new Font("Rockwell Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainSubtitle.ForeColor = Color.FromArgb(127, 140, 141);
            lblMainSubtitle.Location = new Point(30, 75);
            lblMainSubtitle.Name = "lblMainSubtitle";
            lblMainSubtitle.Size = new Size(400, 35);
            lblMainSubtitle.TabIndex = 1;
            lblMainSubtitle.Text = "Manage your store operations efficiently.";
            // 
            // lblMainTitle
            // 
            lblMainTitle.Font = new Font("Californian FB", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMainTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblMainTitle.Location = new Point(6, 9);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(968, 78);
            lblMainTitle.TabIndex = 0;
            lblMainTitle.Text = "Sales and Inventory Dashboard";
            lblMainTitle.Click += lblMainTitle_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(1560, 903);
            Controls.Add(panelMainContent);
            Controls.Add(panelSidebar);
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WB Majesty Groceries Store Sales and Inventory System";
            Load += Form1_Load;
            panelSidebar.ResumeLayout(false);
            panelUserInfo.ResumeLayout(false);
            panelMainContent.ResumeLayout(false);
            panelPendingOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTotalProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelTodaySales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label lblLogo;
        private Label lblSubtitle;
        private Panel panelUserInfo;
        private Label lblUserName;
        private Label lblUserRole;
        private Button btnProducts;
        private Button btnDashboard;
        private Button btnReports;
        private Button btnInventory;
        private Button btnUsers;
        private Label lblSystemStatus;
        private Panel panelMainContent;
        private Label lblMainSubtitle;
        private Label lblMainTitle;
        private Panel panelTodaySales;
        private Button btnNewTransaction;
        private Label lblTodaySalesLabel;
        private Label lblTodaySalesValue;
        private Panel panelLowStock;
        private Label lblLowStockTitle;
        private Panel panelTotalProducts;
        private Label lblTotalProductsSubtitle;
        private Label lblTotalProductsValue;
        private Label lblTotalProductsTitle;
        private Panel panelPendingOrders;
        private Label lblPendingOrdersTitle;
        private Label lblLowStockSubtitle;
        private Label lblLowStockValue;
        private Label lblPendingOrdersSubtitle;
        private Label lblPendingOrdersValue;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label lblQuickActionsTitle;
        private Button btnQuickGenerateReport;
        private Button btnQuickAddProduct;
        private Button btnLogout;
    }
}
