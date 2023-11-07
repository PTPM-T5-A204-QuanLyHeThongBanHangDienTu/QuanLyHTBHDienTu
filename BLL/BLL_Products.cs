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
    public class BLL_Products
    {
        DAL_Products da_Products = new DAL_Products(); 
        public BLL_Products() { }
        public bool TestConnect()
        {
            return da_Products.TestConnect();
        }
        public int CheckConnect(int productId)
        {
            return da_Products.Check_Connect(productId);
        }
        public DataTable load()
        {
            return da_Products.load();
        }
        public bool Inser_Products(tbl_product products)
        {
            return da_Products.Insert_Proucts(products);
        }
        public bool Detele_Product(int productID)
        {
            return da_Products.Detele_Product(productID);
        }
        public bool Update_Product(tbl_product products)
        {
            return da_Products.Update_Product(products);
        }
        public int TimMaPro()
        {
            return da_Products.TimMaPro();
        }
            public MySqlDataAdapter TimKiemBrand(string searchkey)
        {
            return da_Products.TimKiemProduct(searchkey);
        }
    }
}
