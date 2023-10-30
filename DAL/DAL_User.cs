using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using DTO;
using DAL;

namespace AppQL_BanHang
{
    public class DAL_User
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_Customer = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySQL mySQL = new MySQL();
        public DAL_User()
        {
            conn.Open();
        }
        public bool TestConnect()
        {
            mySQL.TestConnect();
            return true;
        }
        public int Check_Connect(int id)
        {
            try
            {

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string CauLenh = "select Count(*) from tbl_customer where id = '" +id + "'";
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
            string caulenh = "select * from tbl_customer ";
            da = new MySqlDataAdapter(caulenh, conn);
            da.Fill(da_Customer, "tbl_customer");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_Customer.Tables["tbl_customer"].Columns[0];
            da_Customer.Tables["tbl_customer"].PrimaryKey = keys;
            return da_Customer.Tables["tbl_customer"];
        }
        public bool Insert_User(tbl_customer cus)
        {
            try
            {
                DataRow dong = da_Customer.Tables["tbl_customer"].NewRow();
                dong[0] = cus.id;
                dong[1] = cus.name;
                dong[2] = cus.address;
                dong[3] = cus.city;
                dong[4] = cus.country;
                dong[5] = cus.zipcode;
                dong[6] = cus.phone;
                dong[7] = cus.email;
                dong[8] = cus.password;
                da_Customer.Tables["tbl_customer"].Rows.Add(dong);
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_Customer, "tbl_customer");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Detele_User(int Id)
        {
            try
            {
                DataRow dong = da_Customer.Tables["tbl_customer"].Rows.Find(Id);

                if (dong != null)
                {
                    dong.Delete();
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_Customer, "tbl_customer");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update_User(tbl_customer customer)
        {
            try
            {
                DataRow dong = da_Customer.Tables["tbl_customer"].Rows.Find(customer.id);

                if (dong != null)
                {
                    dong[1] = customer.name;
                    dong[2] = customer.address;
                    dong[3] = customer.city;
                    dong[4] = customer.country;
                    dong[5] = customer.zipcode;
                    dong[6] = customer.phone;
                    dong[7] = customer.email;
                    dong[8] = customer.password;
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_Customer,"tbl_customer");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int TimMaCus()
        {
            int maxCusId = 0;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectMaxCatId = "SELECT MAX(id) FROM tbl_customer;";
                MySqlCommand cmd = new MySqlCommand(selectMaxCatId, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    maxCusId = Convert.ToInt32(result) + 1;
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

            return maxCusId;
        }
        public MySqlDataAdapter TimKiemCustomer(string searchkey)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string selectbrand = "SELECT * FROM tbl_customer WHERE name LIKE '%" + searchkey + "%'; ";
                MySqlDataAdapter da = new MySqlDataAdapter(selectbrand, conn);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return da;
            }
            catch { return null; }
        }
    }
}
