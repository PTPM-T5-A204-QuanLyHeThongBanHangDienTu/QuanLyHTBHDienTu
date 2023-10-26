using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQL_BanHang
{
    public class DAL_Category
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_SinhVien = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySQL mySQL = new MySQL();
        public DAL_Category()
        {
            conn.Open();
        }
        public bool TestConnect()
        {
            mySQL.TestConnect();
            return true;
        }
        public int Check_Connect(string catId)
        {
            try
            {

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string CauLenh = "select Count(*) from tbl_category where catId = '" + catId + "'";
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
            string caulenh = "select * from tbl_category ";
            da = new MySqlDataAdapter(caulenh, conn);
            da.Fill(da_SinhVien, "tbl_category");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_SinhVien.Tables["tbl_category"].Columns[0];
            da_SinhVien.Tables["tbl_category"].PrimaryKey = keys;
            return da_SinhVien.Tables["tbl_category"];
        }
        public bool Insert_Category(string catId, string catName)
        {
            try
            {
                DataRow dong = da_SinhVien.Tables["tbl_category"].NewRow();

                dong[0] = catId;
                dong[1] = catName;
                da_SinhVien.Tables["tbl_category"].Rows.Add(dong);
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_SinhVien, "tbl_category");
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Detele_Brand(string catId)
        {
            try
            {
                DataRow dong = da_SinhVien.Tables["tbl_category"].Rows.Find(catId);

                if (dong != null)
                {
                    dong.Delete();
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_SinhVien, "tbl_category");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
