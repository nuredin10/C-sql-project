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
    public partial class FormAddSupplier : Form
    {
        public FormAddSupplier()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier(int.Parse(txtITInNo.Text), txtSupplierName.Text, dateSupplier.Text);
            s.INsertSupplier();
        }
    }
}
