using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppQL_BanHang
{
    public class MySQL
    {
        MySqlConnection conn = new MySqlConnection("server=Msi; Database =web_mvcphu; Uid=ThanhDat");
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
        public DataTable load_Admin()
        {
            string caulenh = "select * from tbl_admin ";
            da = new MySqlDataAdapter(caulenh, conn);
            da.Fill(da_SinhVien, "tbl_admin");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_SinhVien.Tables["tbl_admin"].Columns[0];
            da_SinhVien.Tables["tbl_admin"].PrimaryKey = keys;
            return da_SinhVien.Tables["tbl_admin"];
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
        public bool Insert_Admin(string padminID,string padminName, string padminEmail, string adminUser, string padminPass)
        {
            try
            {
                DataRow dong = da_SinhVien.Tables["tbl_admin"].NewRow();

                dong[0] = padminID;
                dong[1] = padminName;
                dong[2] = padminEmail;
                dong[3] = adminUser;
                dong[4] = padminPass;
                da_SinhVien.Tables["tbl_admin"].Rows.Add(dong);
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_SinhVien, "tbl_admin");

                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
