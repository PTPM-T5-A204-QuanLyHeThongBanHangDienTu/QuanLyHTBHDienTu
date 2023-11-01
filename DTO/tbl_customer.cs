using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DTO
{
    public class tbl_customer
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }    
        public string country { get; set; }
        public string zipcode { get; set; }
        public string phone { get; set;}
        public string email { get; set; }
        public string password { get; set; }
        public tbl_customer()
        {

        }
        public tbl_customer ( tbl_customer customer)
        {
            id = customer.id;
            name = customer.name;
            address = customer.address;
            city = customer.city;
            country = customer.country;
            zipcode = customer.zipcode;
            phone = customer.phone;
            email = customer.email;
            password = customer.password;
        }

    }
}
