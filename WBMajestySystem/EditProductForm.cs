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
    public partial class EditProductForm : Form
    {
        public EditProductForm()
        {
            InitializeComponent();

            // Fill status dropdown
            cboStatus.Items.AddRange(new object[] { "Active", "Inactive" });

            // Wire events

            btnSave.Click += (s, e) => this.DialogResult = DialogResult.OK;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            // This method is called when the form loads
            // You can add any initialization code here if needed
        }


    }
}