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
    public partial class FormExit : Form
    {
        public FormExit()
        {
            InitializeComponent();
        }

        private void FormExit_Load(object sender, EventArgs e)
        {

        }

        public string Yes
        {
            set { }
            get { return btnYes.Text; }
        }

        
        public string No
        {
            set { }
            get { return btnNo.Text; }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            FormMain.Exit("Yes");

        }



        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
