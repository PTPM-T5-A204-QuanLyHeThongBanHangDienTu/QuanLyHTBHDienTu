using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace AppQL_BanHang
{
    public class DAL_Category
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_Cat = new DataSet();
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
        public int Check_Connect(int catId)
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
            da.Fill(da_Cat, "tbl_category");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_Cat.Tables["tbl_category"].Columns[0];
            da_Cat.Tables["tbl_category"].PrimaryKey = keys;
            return da_Cat.Tables["tbl_category"];
        }
        public bool Insert_Category(tbl_category cat)
        {
            try
            {
                DataRow dong = da_Cat.Tables["tbl_category"].NewRow();

                dong[0] = cat.catId;
                dong[1] = cat.catName;
                da_Cat.Tables["tbl_category"].Rows.Add(dong);
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_Cat, "tbl_category");
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Detele_Cat(int catId)
        {
            try
            {
                DataRow dong = da_Cat.Tables["tbl_category"].Rows.Find(catId);

                if (dong != null)
                {
                    dong.Delete();
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_Cat, "tbl_category");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update_Cat(tbl_category Cat)
        {
            try
            {
                DataRow dong = da_Cat.Tables["tbl_category"].Rows.Find(Cat.catId);

                if (dong != null)
                {
                    dong[1] = Cat.catName;
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_Cat, "tbl_category");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int TimMaCat()
        {
            int maxCatId = 0;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectMaxCatId = "SELECT MAX(catId) FROM tbl_category;";
                MySqlCommand cmd = new MySqlCommand(selectMaxCatId, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    maxCatId = Convert.ToInt32(result) + 1;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return maxCatId;
        }
        public MySqlDataAdapter TimKiemCat(string searchkey)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectCat = "SELECT * FROM tbl_category WHERE catName LIKE '%" + searchkey + "%'; ";
                MySqlDataAdapter da = new MySqlDataAdapter(selectCat, conn);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return da;
            }
            catch { return null; }
        }

    }
}
