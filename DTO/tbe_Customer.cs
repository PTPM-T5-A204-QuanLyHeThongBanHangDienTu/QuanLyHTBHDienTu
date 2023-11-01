using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbe_Customer
    {
        private DataRowCollection rows;
        int id;
        string name;
        string address;
        string city;
        string country;
        string zipcode;
        string phone;
        string email;
        string password;

        public tbe_Customer() { }

        public tbe_Customer(int id, string name, string address, string city, string country, string zipcode, string phone, string email, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.Country = country;
            this.Zipcode = zipcode;
            this.Phone = phone;
            this.Email = email;
            this.Password = password;
        }

        public tbe_Customer (tbe_Customer customer)
        {
            this.Id = customer.Id; 
            this.Name = customer.Name;
            this.Address = customer.Address;
            this.City = customer.City;
            this.Country = customer.Country;
            this.Zipcode = customer.Zipcode;
            this.Phone = customer.Phone;
            this.Email = customer.Email;
            this.Password = customer.Password;
        }
        public tbe_Customer(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = row["name"].ToString();
            this.Phone = (string)row["phone"];
            this.Email= row["email"].ToString();
            this.Password = row["password"].ToString();
            this.City = row["city"].ToString();
            this.address = row["address"].ToString();
        }
        public tbe_Customer(DataRowCollection rows)
        {
            this.rows = rows;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string Zipcode { get => zipcode; set => zipcode = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
