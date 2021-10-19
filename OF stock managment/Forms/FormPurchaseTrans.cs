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
    public partial class FormPurchaseTrans : Form
    {
        int id;
        public FormPurchaseTrans()
        {
            InitializeComponent();
            id = 0;
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            DataGrideSupplier.DataSource = t.SearchSupplierByname(txtSupplierName.Text);
        }

        private void txtTinNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Transaction t = new Transaction();
                DataGrideSupplier.DataSource = t.SearchSupplierByTinnumber(int.Parse(txtTinNumber.Text));
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            datagridItem.DataSource = t.searchItem(txtItemCode.Text);

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            datagridItem.DataSource = t.searchItem(txtDescription.Text);

        }

       


       

        private void FormPurchaseTrans_Load(object sender, EventArgs e)
        {

        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Transaction t = new Transaction(Convert.ToDouble(txtQuantity.Text), 0, Convert.ToInt32(txtInvoiceNo.Text), txtDate.Text, Convert.ToInt32(txtTinNumber.Text), txtSupplierName.Text, txtItemCode.Text, txtDescription.Text, Convert.ToDouble(txtUPrice.Text));
            txtAvgPrice.Text = t.insertTransaction();
            //txtAvgPrice.Text = Convert.ToString(t.averagePrice(Convert.ToDouble(txtUPrice.Text), Convert.ToDouble(txtQuantity.Text), id));
        }

        private void DataGrideSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datagridItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(datagridItem.CurrentRow.Cells[0].Value.ToString());
            txtItemCode.Text = datagridItem.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = datagridItem.CurrentRow.Cells[2].Value.ToString();
            if (datagridItem.CurrentRow.Cells[3].Value.ToString() == null)
                cmbUOM.Text = "";
            else
                cmbUOM.Text = datagridItem.CurrentRow.Cells[3].Value.ToString();
        }

        private void DataGrideSupplier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtTinNumber.Text = DataGrideSupplier.CurrentRow.Cells[0].Value.ToString();
            txtSupplierName.Text = DataGrideSupplier.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
