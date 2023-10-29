using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_brand
    {
        public int brandId { get; set; }
        public string brandName { get; set; }
        public tbl_brand() { }
        public tbl_brand(int brandId, string brandName)
        {
            this.brandId = brandId;
            this.brandName = brandName;
        }
        public tbl_brand(tbl_brand brand)
        {
            this.brandId = brand.brandId;
            this.brandName=brand.brandName;
        }
    }
}
