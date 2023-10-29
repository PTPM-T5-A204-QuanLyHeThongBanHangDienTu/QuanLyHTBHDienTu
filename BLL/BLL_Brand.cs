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
    public class BLL_Brand
    {
        DAL_Brand dal_brand = new DAL_Brand();
        public BLL_Brand() { }
        public bool TestConnect()
        {
            return dal_brand.TestConnect();
        }
        public int Check_Connect(int brandid)
        {
            return dal_brand.Check_Connect(brandid);
        }
        public DataTable load()
        {
            return dal_brand.load();
        }
        public bool Insert_Brand(tbl_brand brand)
        {
        return dal_brand.Insert_Brand(brand);

        }
        public bool Detele_Brand(int brandid)
        {
            return dal_brand.Detele_Brand(brandid);
        }
        public int TimMaBrand()
        {
            return dal_brand.TimMaBrand();
        }

    }
}
