using DAL;
using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Customer
    {
        DAL_Customer customer = new DAL_Customer();
        tbe_Customer tbe_Customer = new tbe_Customer(); 

        public tbe_Customer SearchByIdCustomer(int pId)
        {
            return customer.searchByIdCustomer(pId);
        }
    }
}
