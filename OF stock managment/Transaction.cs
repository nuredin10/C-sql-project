using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OF_stock_managment
{
    class Transaction : Supplier
    {
        int id;
        double purchased;
        double sells;
        int invoiceNumber;
        string date;
        string month;
        string itemCode;
        string description;
        double newprice;

        public Transaction() { }
        public Transaction(double purchased, double sells, int invoiceNumber, string date, int tinnumber, string suppliername, string itemCode, string description,double newprice)
            : base(tinnumber, suppliername, date)
        {
            this.purchased = purchased;
            this.sells = sells;
            this.date = date;
            this.invoiceNumber = invoiceNumber;
            this.description = description;
            this.itemCode = itemCode;
            this.newprice = newprice;
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public double Purchased
        {
            set { purchased = value; }
            get { return purchased; }
        }

        public double NewPrice
        {
            set { newprice = value; }
            get { return newprice; }
        }

        public double Sells
        {
            set { sells = value; }
            get { return sells; }
        }

        public int InvoiceNumber
        {
            set { invoiceNumber = value; }
            get { return invoiceNumber; }
        }

        public string Date
        {
            set { date = value; }
            get { return date; }
        }

        public string Month
        {
            set { month = value; }
            get { return month; }
        }
        public string ItemCode
        {
            set { itemCode = value; }
            get { return itemCode; }
        }
        public string Description
        {
            set { description = value; }
            get { return description; }
        }

        public string insertTransaction()
        {
            TransactionDBLayer tdb = new TransactionDBLayer();
            string ave = tdb.InsertTranctionDB(this);
            return ave;
        }

        public DataTable searchByItemCodeorDes(string val)
        {
            TransactionDBLayer tdb = new TransactionDBLayer();
           return  tdb.SearchTransactionByItemDescAndCodenDB(val);
        }

        public DataTable searchItem(string val)
        {
            TransactionDBLayer tdb = new TransactionDBLayer();
            return tdb.searchItem(val);
        }

        public DataTable searchByCatagory(string catagory)
        {
            TransactionDBLayer tdb = new TransactionDBLayer();
            return tdb.SearchTransactionByCatagory(catagory);
        }
        public DataTable searchByDateInterval(string dateone, string datetwo)
        {
            TransactionDBLayer tdb = new TransactionDBLayer();
            return tdb.SearchTransactionByyDateInterval(dateone, datetwo);
        }

        public DataTable SearchSupplierByTinnumber(int tinumber)
        {
            TransactionDBLayer tdb = new TransactionDBLayer();
            DataTable dt = tdb.SearchSupplierByTinnumberDB(tinumber);
            return dt;
        }

        public DataTable SearchSupplierByname(string name)
        {
            TransactionDBLayer tdb = new TransactionDBLayer();
            DataTable dt = tdb.SearchSupplierBynameDB(name);
            return dt;
        }
        
        public DataTable viewTransaction()
        {
            TransactionDBLayer tdb = new TransactionDBLayer();
            DataTable dt  = tdb.ViewTransactionDB();
            return dt;
        }

        public double averagePrice(double newprice,double quantity, int id)
        {
            TransactionDBLayer tdb = new TransactionDBLayer();
            return tdb.CalculateAvgSalaryDB(newprice, quantity, id);
        }
    }
}
