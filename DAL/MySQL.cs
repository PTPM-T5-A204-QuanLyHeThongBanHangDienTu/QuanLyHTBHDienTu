using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DAL;

namespace AppQL_BanHang
{
    public class MySQL
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_SinhVien = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        public MySQL()
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
    }
}
