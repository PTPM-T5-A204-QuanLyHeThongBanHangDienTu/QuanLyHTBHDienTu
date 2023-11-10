using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_TaiKhoan
    {
        public string tenTk;

        public string TenTk
        {
            get { return tenTk; }
            set { tenTk = value; }
        }

        public string mk;

        public string Mk
        {
            get { return mk; }
            set { mk = value; }
        }
        public tbl_TaiKhoan()
        {

        }
        public tbl_TaiKhoan(string tenTk, string mk)
        {
            this.TenTk = tenTk;
            this.Mk = mk;
        }
    }
}
