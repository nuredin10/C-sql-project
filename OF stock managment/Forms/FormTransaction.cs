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
    public partial class FormTransaction : Form
    {
        public FormTransaction()
        {
            InitializeComponent();
            Transaction t = new Transaction();
            dataGridViewTransaction.DataSource = t.viewTransaction();
        }

        private void dataGridViewTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // new FormAddTransaction().Show();
        }

        private void cmbSearchCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            dataGridViewTransaction.DataSource = t.searchByCatagory(cmbSearchCatagory.Text);
        }

        private void txtItemDescribtion_TextChanged(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            dataGridViewTransaction.DataSource = t.searchByItemCodeorDes(txtItemDescribtion.Text);
        }

        private void btnSet_Click_1(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            dataGridViewTransaction.DataSource = t.searchByDateInterval(dateOne.Text, dateTwo.Text);
        }
    }
}
