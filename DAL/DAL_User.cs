using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;

namespace AppQL_BanHang
{
    public class DAL_User
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_SinhVien = new DataSet();
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
        public int Check_Connect(string id)
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
            da.Fill(da_SinhVien, "tbl_customer");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = da_SinhVien.Tables["tbl_customer"].Columns[0];
            da_SinhVien.Tables["tbl_customer"].PrimaryKey = keys;
            return da_SinhVien.Tables["tbl_customer"];
        }
        public bool Insert_User(string id, string name, string address, string city,string country, string zipcode, string phone, string email, string padminPass)
        {
            try
            {
                DataRow dong = da_SinhVien.Tables["tbl_customer"].NewRow();
                dong[0] = id;
                dong[1] = name;
                dong[2] = address;
                dong[3] = city;
                dong[4] = country;
                dong[5] = zipcode;
                dong[6] = phone;
                dong[7] = email;
                dong[8] = padminPass;
                da_SinhVien.Tables["tbl_customer"].Rows.Add(dong);
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_SinhVien, "tbl_customer");
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Detele_User(string Id)
        {
            try
            {
                DataRow dong = da_SinhVien.Tables["tbl_customer"].Rows.Find(Id);

                if (dong != null)
                {
                    dong.Delete();
                }
                MySqlCommandBuilder build = new MySqlCommandBuilder(da);
                da.Update(da_SinhVien, "tbl_customer");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
