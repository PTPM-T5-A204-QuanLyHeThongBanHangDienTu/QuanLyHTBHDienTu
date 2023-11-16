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
        public DataTable loadListBill(DateTime ngaydau, DateTime ngaycuoi)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet da_Orders = new DataSet();
            string caulenh = "SELECT * FROM `tbl_order` WHERE date_order BETWEEN '" + ngaydau.ToString("yyyy-MM-dd") + "' AND '" + ngaycuoi.ToString("yyyy-MM-dd") + "'";
            da = new MySqlDataAdapter(caulenh, conn);
            da.Fill(da_Orders, "tbl_order");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_Orders.Tables["tbl_order"].Columns[0];
            da_Orders.Tables["tbl_order"].PrimaryKey = keys;
            return da_Orders.Tables["tbl_order"];

        }
        public List<tbl_order> LoadListBillList(DateTime ngaydau, DateTime ngaycuoi)
        {
            List<tbl_order> orders = new List<tbl_order>();

            using (MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root"))
            {
                conn.Open();

                string query = "SELECT * FROM `tbl_order` WHERE date_order BETWEEN '" + ngaydau.ToString("yyyy-MM-dd") + "' AND '" + ngaycuoi.ToString("yyyy-MM-dd") + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tbl_order order = new tbl_order
                        {
                            //STT = reader.GetString("STT"),
                            id = reader.GetInt32("id"),
                            productId = reader.GetInt32("productId"),
                            productName = reader.GetString("productName"),
                            customer_id = reader.GetInt32("customer_id"),
                            quantity = reader.GetInt32("quantity"),
                            price = reader.GetString("price"),
                            image = reader.GetString("image"),
                            status = reader.GetInt32("status"),
                            date_order = Convert.ToDateTime(reader["date_order"]),
                        };

                        orders.Add(order);
                    }
                }
            }

            return orders;
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

