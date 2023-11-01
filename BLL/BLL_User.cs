using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQL_BanHang;
using DAL;
using DTO;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class BLL_User
    {
        DAL_User da_User = new DAL_User();
        public bool TestConnect()
        {
            return da_User.TestConnect();
        }
        public int CheckConnect(int id)
        {
            return da_User.Check_Connect(id);
        }
        public DataTable load()
        {
            return da_User.load();
        }
        public bool Inser_User(tbl_customer cus)
        {
            return da_User.Insert_User(cus);
        }
        public bool Detele_User(int id)
        {
            return da_User.Detele_User(id);
        }
        public bool Update_User(tbl_customer customer)
        {
            return da_User.Update_User(customer);
        }
        public MySqlDataAdapter TimKiemBrand(string searchkey)
        {
            return da_User.TimKiemCustomer(searchkey);
        }
        public int TimMaPro()
        {
            return da_User.TimMaCus();
        }
    }
}
