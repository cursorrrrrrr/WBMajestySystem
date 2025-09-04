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
 
        }

        private void btnCompleteTransaction_Click(object sender, EventArgs e)
        {
            // Show receipt form
            TransactionReceiptForm receiptForm = new TransactionReceiptForm();
            receiptForm.ShowDialog();

            // Close the transaction form
            this.Close();
        }
        private void panelApplyDiscount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewTransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }


        private void btnCompleteTransaction_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
