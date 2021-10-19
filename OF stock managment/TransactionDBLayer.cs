using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace OF_stock_managment
{
    class TransactionDBLayer
    {
        string conStr = "server=.;database=Stock Managment;uid=lab;pwd=123;";
        SqlConnection conn;
        public void openConnection()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }

        public string InsertTranctionDB(Transaction t)
        {
            string ave = "";
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspinsertTranction", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchase", t.Purchased);
                cmd.Parameters.AddWithValue("@sells", t.Sells);
                cmd.Parameters.AddWithValue("@invoicenumber", t.InvoiceNumber);
                cmd.Parameters.AddWithValue("@date", t.Date);
                cmd.Parameters.AddWithValue("@itemcode", t.ItemCode);
                cmd.Parameters.AddWithValue("@itemdescribtion", t.Description);
                cmd.Parameters.AddWithValue("@tinNumber", t.Tinnumber);
                cmd.Parameters.AddWithValue("@supplierName", t.SupplierName);
                cmd.Parameters.AddWithValue("@uprice", t.NewPrice);

                cmd.Parameters.Add("@output", SqlDbType.Char, 500);
                cmd.Parameters["@output"].Direction = ParameterDirection.Output;
                int row = cmd.ExecuteNonQuery();
                ave = (string)cmd.Parameters["@output"].Value;
                
                if (row > 0)
                    MessageBox.Show("Saved succesfully! ");
                else
                    MessageBox.Show("ERROR! ");
                closeConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ave;
        }

        public void UpdateTranctionDB(Transaction t, string itemcode, string itemdescribtion)
        {
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspupdateTranction", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tranid", t.Id);
                cmd.Parameters.AddWithValue("@purchase", t.Purchased);
                cmd.Parameters.AddWithValue("@sells", t.Sells);
                cmd.Parameters.AddWithValue("@invoicenumber", t.InvoiceNumber);
                cmd.Parameters.AddWithValue("@date", t.Date);
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                cmd.Parameters.AddWithValue("@itemdescribtion", itemdescribtion);
                cmd.Parameters.AddWithValue("@tinNumber", t.Tinnumber);
                cmd.Parameters.AddWithValue("@supplierName", t.SupplierName);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                    MessageBox.Show("Updated succesfully! ");
                else
                    MessageBox.Show("ERROR! ");
                closeConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DeleteTranctionDB(Transaction t, string itemcode, string itemdescribtion)
        {
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspdeleteTransaction", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tranid", t.Id);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                    MessageBox.Show("Updated succesfully! ");
                else
                    MessageBox.Show("ERROR! ");
                closeConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable SearchTransactionByItemCodeDB(string itemcode)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchTransactionByItemCode", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@val", itemcode);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
            }
            closeConnection();

        }

        public DataTable SearchTransactionByItemDescAndCodenDB(string itemcode)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchTransactionByItemDescribtion", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@val", itemcode);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
            }
            closeConnection();

        }

        public DataTable SearchTransactionByCatagory(string catagory)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchTransactionByCatagory", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Catagory", catagory);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
                closeConnection();
            }
        }

        public DataTable searchItem(string val)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchPurchaseItemByItemCodeAndDescribtion", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@val", val);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
            }
        }


        public DataTable SearchSupplierByTinnumberDB(int tinNumber)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchSupplierByTinnumber", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@tinumber", tinNumber);

                DataSet ds = new DataSet();
                da.Fill(ds, "dtSupplier");

                DataTable dt = ds.Tables["dtSupplier"];
                return dt;
            }
            closeConnection();

        }

        public DataTable SearchSupplierBynameDB(string supplierName)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchSupplierByname", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@suppliername", supplierName);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtSupplier");

                DataTable dt = ds.Tables["dtSupplier"];
                return dt;

            }
        }


        public DataTable SearchTransactionByyDateInterval(string dateone, string datetwo)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchTransactionByDateInterval", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@dateOne", dateone);
                da.SelectCommand.Parameters.AddWithValue("@dateTwo", datetwo);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
                closeConnection();
            }
        }
        public DataTable ViewTransactionDB()
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspViewTransaction", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
                closeConnection();
            }
        }

        public double CalculateAvgSalaryDB(double newPrice,double newquantity,int id)
        {
            double avgPrice=0.0;
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("dbo.calculateAvagerSalary", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par = new SqlParameter("@Newunitprice", SqlDbType.Float);
                SqlParameter par2 = new SqlParameter("@newquantity", SqlDbType.Float);
                SqlParameter par3 = new SqlParameter("@id", SqlDbType.Int);
                SqlParameter par4 = new SqlParameter("@avgprice", SqlDbType.Float);

                par.Direction = ParameterDirection.Input;
                par2.Direction = ParameterDirection.Input;
                par3.Direction = ParameterDirection.Input;
                par4.Direction = ParameterDirection.ReturnValue;

                par.Value = newPrice;
                par2.Value = newquantity;
                par3.Value = id;
                    cmd.Parameters.Add(par);
                    cmd.Parameters.Add(par2);
                    cmd.Parameters.Add(par3);


                 cmd.ExecuteNonQuery();
                if(par4.Value != DBNull.Value )
                {
                    avgPrice = Convert.ToDouble(par4.Value);
                }
                return avgPrice;


                //if (row > 0)
                //    MessageBox.Show("Updated succesfully! ");
                //else
                //    MessageBox.Show("ERROR! ");
                //closeConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return avgPrice;

        }


    }
}
