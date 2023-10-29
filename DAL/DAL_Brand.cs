using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace AppQL_BanHang
{
    public class DAL_Brand
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_brand = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySQL mySQL = new MySQL();

        //tbl_brand brand = new tbl_brand();
        public DAL_Brand()
        {
            conn.Open();
        }
        public bool TestConnect()
        {
            mySQL.TestConnect();
            return true;
        }
        public int Check_Connect(int brandid)
        {
            try
            {

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string CauLenh = "select Count(*) from tbl_brand where brandId = '" + brandid + "'";
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
            da.Fill(da_brand, "tbl_brand");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_brand.Tables["tbl_brand"].Columns[0];
            da_brand.Tables["tbl_brand"].PrimaryKey = keys;
            return da_brand.Tables["tbl_brand"];
        }
        public bool Insert_Brand(tbl_brand brand)
        {
            try
            {
                DataRow dong = da_brand.Tables["tbl_brand"].NewRow();

                dong[0] = brand.brandId;
                dong[1] = brand.brandName;
                da_brand.Tables["tbl_brand"].Rows.Add(dong);
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_brand, "tbl_brand");
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Detele_Brand(int brandid)
        {
            try
            {
                DataRow dong = da_brand.Tables["tbl_brand"].Rows.Find(brandid);

                if (dong != null)
                {
                    dong.Delete();
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_brand, "tbl_brand");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update_Brand(tbl_brand brand)
        {
            try
            {
                DataRow dong = da_brand.Tables["tbl_brand"].Rows.Find(brand.brandId);

                if (dong != null)
                {
                    dong[1] = brand.brandName;
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_brand, "tbl_brand");
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public MySqlDataAdapter TimMaBrand()
        //{
        //    try
        //    {
        //        if (conn.State == ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }
        //        string selectKhachHang = "SELECT brandId FROM tbl_brand ORDER BY brandId DESC LIMIT 1; ";
        //        MySqlDataAdapter da = new MySqlDataAdapter(selectKhachHang, conn);
        //        if (conn.State == ConnectionState.Open)
        //            conn.Close();
        //        return da;
        //    }
        //    catch { return null; }
        //}
        public int TimMaBrand()
        {
            int maxBrandId = 0;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectMaxBrandId = "SELECT MAX(brandId) FROM tbl_brand;";
                MySqlCommand cmd = new MySqlCommand(selectMaxBrandId, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    maxBrandId = Convert.ToInt32(result)+1;
                }
            }
            catch(Exception ex) 
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
