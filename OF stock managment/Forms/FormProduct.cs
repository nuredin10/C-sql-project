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
    public partial class FormProducts : Form
    {
        Item i;
        int id;
        public FormProducts()
        {
            InitializeComponent();
            i = new Item();
            dataGridViewProduct.DataSource = i.viewProduct();
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSearchCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item i = new Item();
            dataGridViewProduct.DataSource = i.searchCatagory(cmbSearchCatagory.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormAddProduct().Show();
        }

        private void dataGridViewProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void dataGridViewProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //FormExit fx = new FormExit();
            //fx.Show();
            
            FormEditProduct p = new FormEditProduct();
            p.Show();
            p.ID = int.Parse(dataGridViewProduct.CurrentRow.Cells[0].Value.ToString());
            p.ItemCode = dataGridViewProduct.CurrentRow.Cells[1].Value.ToString();
            p.Description = dataGridViewProduct.CurrentRow.Cells[2].Value.ToString();
            p.Quantity = double.Parse(dataGridViewProduct.CurrentRow.Cells[3].Value.ToString());
            p.Category = dataGridViewProduct.CurrentRow.Cells[4].Value.ToString();
            p.SubCategory = dataGridViewProduct.CurrentRow.Cells[5].Value.ToString();
            p.Uom = dataGridViewProduct.CurrentRow.Cells[6].Value.ToString();
            p.UnitPrice = double.Parse(dataGridViewProduct.CurrentRow.Cells[7].Value.ToString());
            p.BrandName = dataGridViewProduct.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            i = new Item();
          dataGridViewProduct.DataSource =  i.searchItemDescribtion(txtSearchItem.Text);
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            i = new Item();
            dataGridViewProduct.DataSource = i.searchItemDescribtion(txtSearchItem.Text);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Deleting the following information will also affect the information in  transaction ", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                i = new Item();
                id = int.Parse(dataGridViewProduct.CurrentRow.Cells[0].Value.ToString());
                i.deleteProduct(id);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
