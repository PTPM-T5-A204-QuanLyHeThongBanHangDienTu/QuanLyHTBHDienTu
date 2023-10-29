using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_category
    {
        public int catId {  get; set; }
        public string catName { get; set; }
        public tbl_category() { }
        public tbl_category(int catId, string catName)
        {
            this.catId = catId;
            this.catName = catName;
        }
        public tbl_category(tbl_category cat)
        {
            this.catId = cat.catId;
            this.catName = cat.catName;
        }
    }
}
