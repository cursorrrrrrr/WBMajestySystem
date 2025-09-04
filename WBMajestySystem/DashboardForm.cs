namespace WBMajestySystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            btnLogout.Click += btnLogout_Click;
            btnQuickAddProduct.Click += btnQuickAddProduct_Click;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(this, "Are you sure you want to log out?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            // Optional: clear any session/role state here

            this.Hide();
            using (var login = new LoginForm())
            {
                login.StartPosition = FormStartPosition.CenterScreen;
                login.ShowDialog(this); // show login on top
            }
            this.Close(); // close dashboard after login closes
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Dashboard button clicked
            MessageBox.Show("Dashboard clicked!");
        }

        // ADD THIS NEW METHOD FOR NEW TRANSACTION
        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            NewTransactionForm newTransactionForm = new NewTransactionForm();
            newTransactionForm.ShowDialog(); // Opens as modal dialog
        }

        // ADD THIS METHOD FOR PRODUCTS BUTTON
        private void btnProducts_Click(object sender, EventArgs e)
        {
            using (var f = new ProductsForm())
            {
                f.ShowDialog();
            }
        }
        // ADD THIS METHOD FOR INVENTORY BUTTON
        private void btnInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inventory section will be implemented next!");
        }

        // ADD THIS METHOD FOR REPORTS BUTTON
        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports section will be implemented next!");
        }

        // ADD THIS METHOD FOR USERS BUTTON
        private void btnUsers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Users section will be implemented next!");
        }

        private void lblMainTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelMainContent_Paint(object sender, EventArgs e)
        {

        }

        private void lblTodaySalesValue_Click(object sender, EventArgs e)
        {

        }

        private void lblLowStockTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lblItemsSoldValue_Click(object sender, EventArgs e)
        {

        }

        private void panelChart_Paint(object sender, EventArgs e)
        {

        }

        private void btnQuickAddProduct_Click(object sender, EventArgs e)
        {
            using (var products = new ProductsForm()) // or whatever your form class is named
            {
                products.StartPosition = FormStartPosition.CenterParent;
                products.ShowDialog(this); // if this is a Form; otherwise use ShowDialog()
            }
        }
    }
}