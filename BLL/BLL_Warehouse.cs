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
    public class BLL_Warehouse
    {
        DAL_Warehouse da = new DAL_Warehouse();
        public BLL_Warehouse() { }

        public bool TestConnect()
        {
            return da.TestConnect();
        }
        public int CheckConnect(int productId)
        {
            return da.Check_Connect(productId);
        }
        public DataTable load()
        {
            return da.load();
        }
        public bool Inser_Ware(tbl_warehouse wa)
        {
            return da.Insert_ware(wa);
        }
        public bool Detele_Ware(int id_warehouse)
        {
            return da.Detele_ware(id_warehouse);
        }
        public bool Update_Ware(tbl_warehouse wa)
        {
            return da.Update_ware(wa);
        }
        public int TimMa()
        {
            return da.TimMaWare();
        }
        public DataTable SearchByDateOrder(string search)
        {
            return da.searchDayOrder(search);
        }
    }
}
