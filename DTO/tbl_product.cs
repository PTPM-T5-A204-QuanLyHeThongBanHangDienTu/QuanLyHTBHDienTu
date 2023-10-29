using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string product_code { get; set; }
        public int productQuantity { get; set;}
        public string product_soldout { get; set;}
        public string product_remain { get; set;}
        public int catId { get; set;}
        public int brandId { get; set; }
        public string product_desc { get; set;}
        public int type { get; set;}
        public string price { get; set;}
        public string image { get; set;}

        public tbl_product() { }
        public tbl_product(tbl_product pro) 
        { 
            productId = pro.productId;
            productName = pro.productName;
            product_code = pro.product_code;
            productQuantity = pro.productQuantity;
            product_soldout = pro.product_soldout;
            product_remain = pro.product_remain;
            catId = pro.catId;
            brandId = pro.brandId;
            product_desc = pro.product_desc;
            type = pro.type;
            price = pro.price;
            image = pro.image;
        }
    }
}
