using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_warehouse
    {
        public int id_warehouse { get; set; }
        public string sanpham { get; set; }
        public string sl_nhap { get; set; }
        public DateTime sl_ngaynhap {  get; set; }
        public tbl_warehouse() { }
        public tbl_warehouse(tbl_warehouse warehouse)
        {
            sanpham = warehouse.sanpham;
            id_warehouse = warehouse.id_warehouse;
            sl_ngaynhap = warehouse.sl_ngaynhap;
            sl_nhap = warehouse.sl_nhap;
        }

    }
}
