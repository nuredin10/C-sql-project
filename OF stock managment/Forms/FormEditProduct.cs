using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OF_stock_managment.Forms
{
    public partial class FormEditProduct : Form
    {
        public FormEditProduct()
        {
            InitializeComponent();
        }
        public string ItemCode
        {
            get { return txtItemCode.Text;}
            set { txtItemCode.Text = value; }
        }
        public string Description
        {
            get { return txtItemDescription.Text; }
            set { txtItemDescription.Text = value; }
        }
        public string Category
        {
            get { return cmbCatagory.Text; }
            set { cmbCatagory.Text = value; }
        }
        public string SubCategory
        {
            get { return cmbSubcatagory.Text; }
            set { cmbSubcatagory.Text = value; }
        }
        public double Quantity
        {
            set { txtQuantity.Text = Convert.ToString(value); }
            get { return Convert.ToDouble(txtQuantity.Text); }
        }

        public double UnitPrice
        {
            set { txtUnitPrice.Text = Convert.ToString(value); }
            get { return Convert.ToDouble(txtUnitPrice.Text); }
        }
        public string Uom
        {
            get { return cmbUOM.Text; }
            set { cmbUOM.Text = value; }
        }
       
        public string BrandName
        {
            get { return txtBrandName.Text; }
            set { txtBrandName.Text = value; }
        }
        public int ID
        {
            set { txtId.Text = Convert.ToString(value); }
            get { return Convert.ToInt32(txtId.Text); }
        }
        private void FormEditProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to edit the following information", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Item i = new Item(Convert.ToInt32(txtId.Text), txtItemCode.Text, txtItemDescription.Text, Convert.ToDouble(txtQuantity.Text), cmbUOM.Text, txtBrandName.Text, Convert.ToDouble(txtUnitPrice.Text), cmbCatagory.Text, cmbSubcatagory.Text);
                i.updateProduct();
            }

        }
    }
}
