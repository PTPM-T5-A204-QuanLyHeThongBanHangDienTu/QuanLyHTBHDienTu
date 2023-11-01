using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_Orders
    {
        int id;
        int productId;
        string productName;
        int customerId;
        int quantity;
        float price;
        string img;
        int status;
        DateTime date_order;

        public tbl_Orders ()
        {

        }

        public tbl_Orders(int pid, int pProId, string pProName, int pCusId, int pQuantity, float pPrice, string pImg, int pStt, DateTime pDateOrder)
        {
            this.id = pid;
            this.price = pPrice;
            this.productName = pProName;
            this.customerId = pCusId;
            this.quantity = pQuantity;
            this.status = pStt;
            this.date_order = pDateOrder;
            this.img = pImg;
            this.productId = pProId;
        }

        public tbl_Orders (tbl_Orders orders)
        {
            this.id = orders.Id;
            this.price = orders.Price;
            this.productName = orders.ProductName;
            this.customerId = orders.CustomerId;
            this.quantity = orders.Quantity;
            this.status = orders.Status;
            this.date_order = orders.Date_order;
            this.img = orders.Img;
            this.productId = orders.ProductId;
        }



        public string ProductName { get => productName; set => productName = value; }
        public int Id { get => id; set => id = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }
        public string Img { get => img; set => img = value; }
        public int Status { get => status; set => status = value; }
        public DateTime Date_order { get => date_order; set => date_order = value; }
    }
}
