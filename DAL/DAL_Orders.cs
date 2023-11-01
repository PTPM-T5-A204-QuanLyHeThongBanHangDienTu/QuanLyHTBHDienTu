using AppQL_BanHang;
using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Orders
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_Orders = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySQL mySQL = new MySQL();
        public DAL_Orders()
        {
            conn.Open();
        }
        public bool TestConnect()
        {
            mySQL.TestConnect();
            return true;
        }
        public DataTable load()
        {
            string caulenh = "SELECT * FROM `tbl_order`";
            da = new MySqlDataAdapter(caulenh, conn);
            da.Fill(da_Orders, "tbl_order");
            return da_Orders.Tables["tbl_order"];
        }
       
        
        public DataTable searchDayOrder(string search)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM `tbl_order` WHERE DATE(date_order) = '"+ search + "'";
                da = new MySqlDataAdapter(query, conn);
                da.Fill(da_Orders, "tbl_order");
                DataColumn[] keys = new DataColumn[1];
                keys[0] = da_Orders.Tables["tbl_order"].Columns[0];
                da_Orders.Tables["tbl_order"].PrimaryKey = keys;
                return da_Orders.Tables["tbl_order"];
            }
            catch { return null; }
        }

        public bool deleteOrderById(int id)
        {
            try
            {
                string deleteQuery = "DELETE FROM tbl_order WHERE id = @id";

                using (MySqlCommand command = new MySqlCommand(deleteQuery, conn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }



    }
}

