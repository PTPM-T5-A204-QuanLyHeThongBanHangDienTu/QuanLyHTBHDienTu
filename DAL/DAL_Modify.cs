using AppQL_BanHang;
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
using System.Collections;

namespace DAL
{
    public class DAL_Modify
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_modify = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySQL mySQL = new MySQL();
        public DAL_Modify()
        {
            
        }
        public List<tbl_TaiKhoan> TaiKhoans(string email)
        {
            List<tbl_TaiKhoan> tk = new List<tbl_TaiKhoan>();
            conn.Open();

            //string query = "SELECT adminEmail,adminPass FROM tbl_admin WHERE adminEmail = '" + email + "' ";
            MySqlCommand command = new MySqlCommand(email, conn);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tk.Add(new tbl_TaiKhoan(reader.GetString(0), reader.GetString(1)));
            }
            conn.Close(); ;

            return tk;
        }
    }
}
