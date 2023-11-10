using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_admin
    {
        public int adminID { get; set; }
        public string adminName { get; set; }
        public string adminEmail { get; set; }
        public string adminUser { get; set; }
        public string adminPassword { get; set; }
        public int level { get; set; }
        public tbl_admin(string v) { }
        public tbl_admin (tbl_admin admin)
        {
            adminID = admin.adminID;
            adminName = admin.adminName;
            adminEmail = admin.adminEmail;
            adminUser = admin.adminUser;  
            adminPassword = admin.adminPassword;
        }

        public tbl_admin()
        {
        }
    }
}
