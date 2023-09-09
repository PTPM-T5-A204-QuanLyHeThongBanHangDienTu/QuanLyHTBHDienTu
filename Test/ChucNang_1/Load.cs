using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ChucNang_1
{
    public class Load
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database = databanhang; Uid=root");
        DataSet da_SinhVien = new DataSet();

        public Load()
        {
            conn.Open();
        }
        public MySqlConnection Connection { get { return conn; } }
        public bool TestConnect()
        {
            string caulenh = conn.ConnectionString;
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                MySqlCommand sqlCommand = new MySqlCommand(caulenh);
                sqlCommand.ExecuteNonQuery();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable load()
        {
            string caulenh = "select * from sanpham ";
            MySqlDataAdapter dataAdapter_Ql_SinhVien = new MySqlDataAdapter(caulenh, conn);
            dataAdapter_Ql_SinhVien.Fill(da_SinhVien, "sanpham");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_SinhVien.Tables["sanpham"].Columns[0];
            da_SinhVien.Tables["sanpham"].PrimaryKey = keys;
            return da_SinhVien.Tables["sanpham"];
        }
    }
}
