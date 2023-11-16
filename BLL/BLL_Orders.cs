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
    public class BLL_Orders
    {
        DAL_Orders orders = new DAL_Orders();
        public DataTable getDataTableOrder()
        {
            return orders.load();
        }

        public DataTable SearchByDateOrder(string search)
        {
            return orders.searchDayOrder(search);
        }

        public bool DeteleOrder(int id)
        {
            return orders.deleteOrderById(id);
        }
        public DataTable loadListBill(DateTime ngaydau, DateTime ngaycuoi)
        {
            return orders.loadListBill(ngaydau,ngaycuoi);
        }
        public List<tbl_order> LoadListBillList(DateTime ngaydau, DateTime ngaycuoi)
        {
            return orders.LoadListBillList(ngaydau, ngaycuoi);
        }
    }
}
