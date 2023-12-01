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
    public class DAL_Warehouse
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_ware = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySQL mySQL = new MySQL();
        public DAL_Warehouse() 
        { 
            conn.Open();
        }
        public bool TestConnect()
        {
            mySQL.TestConnect();
            return true;
        }
        public int Check_Connect(int id_warehouse)
        {
            try
            {

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string CauLenh = "select Count(*) from tbl_warehouse where id_warehouse = '" + id_warehouse + "'";
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
            string caulenh = "select * from tbl_warehouse ";
            da = new MySqlDataAdapter(caulenh, conn);
            da.Fill(da_ware, "tbl_warehouse");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_ware.Tables["tbl_warehouse"].Columns[0];
            da_ware.Tables["tbl_warehouse"].PrimaryKey = keys;
            return da_ware.Tables["tbl_warehouse"];
        }
        public bool Insert_ware(tbl_warehouse wa)
        {
            try
            {
                DataRow dong = da_ware.Tables["tbl_warehouse"].NewRow();

                dong[0] = wa.id_warehouse;
                dong[1] = wa.sanpham;
                dong[2] = wa.sl_nhap;
                dong[3] = wa.sl_ngaynhap;
                da_ware.Tables["tbl_warehouse"].Rows.Add(dong);
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_ware, "tbl_warehouse");
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Detele_ware(int id_warehouse)
        {
            try
            {
                DataRow dong = da_ware.Tables["tbl_warehouse"].Rows.Find(id_warehouse);

                if (dong != null)
                {
                    dong.Delete();
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_ware, "tbl_warehouse");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update_ware(tbl_warehouse wa)
        {
            try
            {
                DataRow dong = da_ware.Tables["tbl_warehouse"].Rows.Find(wa.id_warehouse);

                if (dong != null)
                {
                    dong[0] = wa.id_warehouse;
                    dong[1] = wa.sanpham;
                    dong[2] = wa.sl_nhap;
                    dong[3] = wa.sl_ngaynhap;
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_ware, "tbl_warehouse");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable searchDayOrder(string search)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM `tbl_warehouse` WHERE DATE(sl_ngaynhap) = '" + search + "'";
                da = new MySqlDataAdapter(query, conn);
                da.Fill(da_ware, "tbl_warehouse");
                return da_ware.Tables["tbl_warehouse"];
            }
            catch { return null; }
        }
        public int TimMaWare()
        {
            int maxBrandId = 0;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectMaxBrandId = "SELECT MAX(id_warehouse) FROM tbl_warehouse;";
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
    }
}
