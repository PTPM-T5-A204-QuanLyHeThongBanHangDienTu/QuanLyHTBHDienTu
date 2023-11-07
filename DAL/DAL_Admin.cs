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
    public class DAL_Admin
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_admin = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySQL mySQL = new MySQL();
        public DAL_Admin()
        {
            conn.Open();
        }
        public bool TestConnect()
        {
            mySQL.TestConnect();
            return true;
        }
        public int Check_Connect(int idadmin)
        {
            try
            {

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string CauLenh = "select Count(*) from tbl_admin where adminId = '" + idadmin + "'";
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
            string caulenh = "select * from tbl_admin ";
            da = new MySqlDataAdapter(caulenh, conn);
            da.Fill(da_admin, "tbl_admin");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_admin.Tables["tbl_admin"].Columns[0];
            da_admin.Tables["tbl_admin"].PrimaryKey = keys;
            return da_admin.Tables["tbl_admin"];
        }

        public bool Insert_Admin(tbl_admin admin)
        {
            try
            {
                DataRow dong = da_admin.Tables["tbl_admin"].NewRow();

                dong[0] = admin.adminID;
                dong[1] = admin.adminName;
                dong[2] = admin.adminEmail;
                dong[3] = admin.adminUser;
                dong[4] = admin.adminPassword;
                dong[5] = admin.level;
                da_admin.Tables["tbl_admin"].Rows.Add(dong);
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_admin, "tbl_admin");
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Detele_Admin(int Id)
        {
            try
            {
                DataRow dong = da_admin.Tables["tbl_admin"].Rows.Find(Id);

                if (dong != null)
                {
                    dong.Delete();
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_admin, "tbl_admin");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update_Admin(tbl_admin admin)
        {
            try
            {
                DataRow dong = da_admin.Tables["tbl_admin"].Rows.Find(admin.adminID);

                if (dong != null)
                {
                    dong[1] = admin.adminName;
                    dong[2] = admin.adminEmail;
                    dong[3] = admin.adminUser;
                    dong[4] = admin.adminPassword;

                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_admin, "tbl_admin");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int TimMaAdmin()
        {
            int maxBrandId = 0;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectMaxBrandId = "SELECT MAX(adminId) FROM tbl_admin;";
                MySqlCommand cmd = new MySqlCommand(selectMaxBrandId, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    maxBrandId = Convert.ToInt32(result) + 1;
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

            return maxBrandId;
        }
        public MySqlDataAdapter TimKiemAdmin(string searchkey)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectbrand = "SELECT * FROM tbl_admin WHERE adminName LIKE '%" + searchkey + "%'; ";
                MySqlDataAdapter da = new MySqlDataAdapter(selectbrand, conn);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return da;
            }
            catch { return null; }
        }

    }
}
