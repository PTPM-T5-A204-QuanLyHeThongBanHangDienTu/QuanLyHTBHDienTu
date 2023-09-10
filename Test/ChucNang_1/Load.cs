using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace ChucNang_1
{
    public class Load
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database = web_mvcphu; Uid=root");
        DataSet da_SinhVien = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();

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
        public int Check_Connect(string pbrandId)
        {
            try
            {

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string CauLenh = "select Count(*) from tbl_brand where brandId = '" + pbrandId + "'";
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
            string caulenh = "select * from tbl_brand ";
            da = new MySqlDataAdapter(caulenh, conn);
            da.Fill(da_SinhVien, "tbl_brand");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_SinhVien.Tables["tbl_brand"].Columns[0];
            da_SinhVien.Tables["tbl_brand"].PrimaryKey = keys;
            return da_SinhVien.Tables["tbl_brand"];
        }
        public bool Insert(string pbrandId, string pbrandName)
        {
            try
            {
                DataRow dong = da_SinhVien.Tables["tbl_brand"].NewRow();

                dong[0] = pbrandId;
                dong[1] = pbrandName;
                da_SinhVien.Tables["tbl_brand"].Rows.Add(dong);
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_SinhVien, "tbl_brand");
                
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Detele(string pbrandId)
        {
            try
            {
                DataRow dong = da_SinhVien.Tables["tbl_brand"].Rows.Find(pbrandId);

                if (dong != null)
                {
                    dong.Delete();
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_SinhVien, "tbl_brand");
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
