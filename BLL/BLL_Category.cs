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
    public class BLL_Category
    {
        DAL_Category dal_Category = new DAL_Category();
        public bool TestConnect()
        {
          return  dal_Category.TestConnect();
        }
        public int Check_Connect(int catId)
        {
          return  dal_Category.Check_Connect(catId);
        }
        public DataTable load()
        {
            return dal_Category.load();
        }
        public bool Insert_Category(tbl_category cat)
        {
           return dal_Category.Insert_Category(cat);

        }
        public bool Detele_Cat(int catId)
        {
            return dal_Category.Detele_Cat(catId);
        }
        public bool Update_Cat(tbl_category Cat)
        {
           return dal_Category.Update_Cat(Cat);
        }
        public int TimMaCat()
        {
            return dal_Category.TimMaCat();
        }
        public MySqlDataAdapter TimKiemCat(string searchkey)
        {
           return dal_Category.TimKiemCat(searchkey);
        }
    }
}
