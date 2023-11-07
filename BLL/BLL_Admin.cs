using AppQL_BanHang;
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
    public class BLL_Admin
    {
        DAL_Admin dal_admin = new DAL_Admin();
        public BLL_Admin() { }
        public bool TestConnect()
        {
            return dal_admin.TestConnect();
        }
        public int CheckConnect(int productId)
        {
            return dal_admin.Check_Connect(productId);
        }
        public DataTable load()
        {
            return dal_admin.load();
        }
        public bool Insert_Admin(tbl_admin admin)
        {
            return dal_admin.Insert_Admin(admin);
        }
        public bool Detele_Admin(int id)
        {
            return dal_admin.Detele_Admin(id);
        }
        public bool Update_Admin(tbl_admin admin)
        {
            return dal_admin.Update_Admin(admin);
        }
        public int TimMaAdmin()
        {
            return dal_admin.TimMaAdmin();
        }
        public MySqlDataAdapter TimKiemAdmin(string searchkey)
        {
            return dal_admin.TimKiemAdmin(searchkey);
        }
    }
}
