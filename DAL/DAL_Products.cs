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
    public class DAL_Products
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_products = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySQL mySQL = new MySQL();
        public DAL_Products()
        {
            conn.Open();
        }
        public bool TestConnect()
        {
            mySQL.TestConnect();
            return true;
        }
        public int Check_Connect(int productId)
        {
            try
            {

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string CauLenh = "select Count(*) from tbl_product where productId = '" + productId + "'";
                MySqlCommand cmd = new MySqlCommand(CauLenh, conn);
                int Kq = (int)(long)cmd.ExecuteScalar();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                return Kq;
            }
            catch
            {
                return -1;
            }
        }
        public DataTable load()
        {
            string caulenh = "select * from tbl_product ";
            da = new MySqlDataAdapter(caulenh, conn);
            da.Fill(da_products, "tbl_product");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_products.Tables["tbl_product"].Columns[0];
            da_products.Tables["tbl_product"].PrimaryKey = keys;
            return da_products.Tables["tbl_product"];
        }
        public bool Insert_Proucts(tbl_product product)
        {
            try
            {
                DataRow dong = da_products.Tables["tbl_product"].NewRow();

                dong[0] = product.productId;
                dong[1] = product.productName;
                dong[2] = product.productQuantity;
                dong[7] = product.catId;
                dong[8] = product.brandId;
                dong[9] = product.product_desc;
                dong[10] = product.price;
                dong[11] = product.image;
                da_products.Tables["tbl_product"].Rows.Add(dong);
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_products, "tbl_product");
                return true;
            }
            catch
            {
                return false;
            }

        }

    }
}
