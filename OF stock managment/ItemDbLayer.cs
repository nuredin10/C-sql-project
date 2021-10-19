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
    class ItemDBLayer
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

        public void InsertItemDB(Item i)
        {
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspInsertItem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemCode", i.ItemCode);
                cmd.Parameters.AddWithValue("@itemDescription", i.ItemDescription);
                cmd.Parameters.AddWithValue("@quantity", i.Quantity);
                cmd.Parameters.AddWithValue("@catagory", i.CatagoryName);
                cmd.Parameters.AddWithValue("@subcatagory", i.SubCatagory);
                cmd.Parameters.AddWithValue("@UOM", i.UOM);
                cmd.Parameters.AddWithValue("@unitPrice", i.UnitPrice);
                cmd.Parameters.AddWithValue("@brandName", i.BrandName);

                int row = cmd.ExecuteNonQuery();
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
        }


        public void UpdateItemDB(Item i)
        {
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspUpdateItem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", i.Id);
                cmd.Parameters.AddWithValue("@ItemCode", i.ItemCode);
                cmd.Parameters.AddWithValue("@itemDescription", i.ItemDescription);
                cmd.Parameters.AddWithValue("@quantity", i.Quantity);
                cmd.Parameters.AddWithValue("@catagory", i.CatagoryName);
                cmd.Parameters.AddWithValue("@subcatagory", i.SubCatagory);
                cmd.Parameters.AddWithValue("@UOM", i.UOM);
                cmd.Parameters.AddWithValue("@unitPrice", i.UnitPrice);
                cmd.Parameters.AddWithValue("@brandName", i.BrandName);

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

        public void DeleteItemDB(int id)
        {
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspDeleteItem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                    MessageBox.Show("Deleted succesfully! ");
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

        public DataTable SearchItemByItemCodeDB(string itemcode)
        {

            using (conn = new SqlConnection(conStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("uspSearchItemByItemCode", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@val", itemcode);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtItem");

                    DataTable dt = ds.Tables["dtItem"];
                    return dt;
                }
            }

        }

        public DataTable SearchItemByItemCodeOrItemDescDB(string val)
        {

            using (conn = new SqlConnection(conStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("uspSearchItemByItemCodeAndDescribtion", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@val", val);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtItem");

                    DataTable dt = ds.Tables["dtItem"];
                    return dt;
                }
            }

        }

        public DataTable SearchItemByCatagoryDB(string catagory)
        {

            using (conn = new SqlConnection(conStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("uspSearchItemByCatagory", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@val", catagory);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtItem");

                    DataTable dt = ds.Tables["dtItem"];
                    return dt;
                }
            }
        }

        public DataTable ViewItemDB()
        {

            using (conn = new SqlConnection(conStr))
            {
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspViewItem", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                da.Fill(ds, "dtItem");

                DataTable dt = ds.Tables["dtItem"];
                return dt;
            }
            }

        }



    }
}
