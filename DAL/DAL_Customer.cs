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
    public class DAL_Customer
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        DataSet da_Customer = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySQL mySQL = new MySQL();

        public DAL_Customer()
        {
            conn.Open();
        }
        public bool TestConnect()
        {
            mySQL.TestConnect();
            return true;
        }


        public tbe_Customer searchByIdCustomer(int pId)
        {
            tbe_Customer customer = null;

            using (MySqlConnection connection = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root"))
            {
                string query = "SELECT * FROM `tbl_customer` WHERE `tbl_customer`.`id` = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", pId);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customer = new tbe_Customer
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Password = reader.GetString("password"),
                            Phone= reader.GetInt32("phone"),
                            Email = reader.GetString("email"),
                            Address = reader.GetString("address"),
                            City = reader.GetString("city"),
                            Country=reader.GetString("country"),
                            Zipcode = reader.GetString("zipcode")
                        };
                    }
                }
            }

            return customer;
        }

    }
}
