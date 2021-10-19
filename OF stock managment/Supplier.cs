using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OF_stock_managment
{
    class Supplier
    {
        int tinnumber;
        string supplierName;
        string date;
        SupplierDBLayer s;

        public Supplier() { }
        public Supplier(int tinnumber, string supplierName, string date)
        {
            this.tinnumber = 3456345;
            this.supplierName = supplierName;
            this.date = date;
        }
        public int Tinnumber
        {
            set { tinnumber = value; }
            get { return tinnumber; }
        }


        public string SupplierName
        {
            set { supplierName = value; }
            get { return supplierName; }
        }

        public string Date
        {
            set { date = value; }
            get { return date; }
        }

        public void INsertSupplier()
        {
            s = new SupplierDBLayer();
            s.InsertSupplierDB(this);
        }

    }
}
