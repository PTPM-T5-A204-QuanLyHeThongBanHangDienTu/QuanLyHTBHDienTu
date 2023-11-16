using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_order
    {
        public string STT { get; set; }
        public int id { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public int customer_id { get; set; }
        public int quantity { get; set; }
        public string price { get; set; }
        public string image { get; set; }
        public int status { get; set; }
        public DateTime date_order { get; set; }

        public tbl_order() { }
        public tbl_order(string STT, int id, int productId, string productName, int customer_id, int quantity, string price, string image, int status, DateTime date_order)
        {
            this.STT = STT;
            this.id = id;
            this.productId = productId;
            this.productName = productName;
            this.customer_id = customer_id;
            this.quantity = quantity;
            this.price = price;
            this.image = image;
            this.status = status;
            this.date_order = date_order;
        }
        public tbl_order(tbl_order order)
        {
            this.STT = order.STT;
            this.id = order.id;
            this.productId = order.productId;
            this.productName = order.productName;
            this.customer_id = order.customer_id;
            this.quantity = order.quantity;
            this.price = order.price;
            this.image = order.image;
            this.status = order.status;
            this.date_order = order.date_order;
        }
    }
}
