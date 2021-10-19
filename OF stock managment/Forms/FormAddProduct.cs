using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OF_stock_managment
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            Item i = new Item(txtItemCode.Text, txtItemDescription.Text, Convert.ToDouble(txtQuantity.Text), cmbUOM.Text, txtBrandName.Text, Convert.ToDouble(txtUnitPrice.Text), cmbCatagory.Text, cmdSubcatagory.Text);
            i.insertProduct();
            Clear();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txtBrandName.Clear();
            cmbCatagory.Text = "";
            txtItemCode.Clear();
            txtItemDescription.Clear();
            cmdSubcatagory.Text = "";
            txtQuantity.Text = "0.00";
            txtUnitPrice.Text = "0.00";
            cmbUOM.Text = "";

        }

        private void txtCatagory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
