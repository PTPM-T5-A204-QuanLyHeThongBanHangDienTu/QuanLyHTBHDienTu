using BLL;
using DAL;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQL_BanHang
{
    public partial class Form_Order : Form
    {
        private bool isLoaded = false;
        BLL_Orders orders = new BLL_Orders();
        BLL_Customer customer = new BLL_Customer();
        tbe_Customer tbe_Customer = new tbe_Customer();
        public Form_Order()
        {
            InitializeComponent();
            this.Load += Form_Order_Load;
            dtg_Order.CellClick += Dtg_Order_CellClick;
            btn_Search.Click += Btn_Search_Click;
            btn_Reset.Click += Btn_Reset_Click;
            dtg_Order.ReadOnly = true;
            dtg_Order.SelectionChanged += Dtg_Order_SelectionChanged;
            load();
            btn_Delete.Click += Btn_Delete_Click;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_IdOrder.Text.ToString());
            string message = "Bạn chắc chắn muốn xóa";
            string title = "Xóa hóa đơn";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);
            if (result == DialogResult.Yes)
            {
                if (orders.DeteleOrder(id))
                {
                    MessageBox.Show("Xóa thành công!");

                }
            }
            dtg_Order.Refresh();
        }

        private void Dtg_Order_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            txt_AddressCustomer.Text = string.Empty;
            txt_dayOrder.Text = string.Empty;
            txt_EmailCustomer.Text = string.Empty;
            txt_IdOrder.Text = string.Empty;
            txt_NameCustomer.Text = string.Empty;   
            txt_NameProduct.Text = string.Empty;    
            txt_Phone.Text = string.Empty;
            txt_PriceProduct.Text = string.Empty;
            txt_QuantityProduct.Text = string.Empty;

            DataTable dt = orders.getDataTableOrder();

            dt.Clear();

            // Cập nhật DataSource mới
            dt.Merge(orders.getDataTableOrder());

            // Refresh DataGridView để hiển thị dữ liệu mới
            dtg_Order.Refresh();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            string pSearch = pickerday.Value.ToString("yyyy-MM-dd");
            DataTable dt = orders.SearchByDateOrder(pSearch);

            // Xóa dữ liệu từ DataSource trước khi cập nhật
            dt.Clear();

            // Cập nhật DataSource mới
            dt.Merge(orders.SearchByDateOrder(pSearch));

            // Refresh DataGridView để hiển thị dữ liệu mới
            dtg_Order.Refresh();
        }

    

        private void Dtg_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CustomerId = 0;
         
            if (dtg_Order.Rows.Count > 0)
            {
                txt_IdOrder.Text = dtg_Order.CurrentRow.Cells[0].Value.ToString();
                txt_dayOrder.Text = dtg_Order.CurrentRow.Cells[8].Value.ToString();
                CustomerId = int.Parse(dtg_Order.CurrentRow.Cells[3].Value.ToString());
                tbe_Customer = customer.SearchByIdCustomer(CustomerId);
                txt_AddressCustomer.Text = tbe_Customer != null ? tbe_Customer.Address : "Không tìm thấy khách hàng";
                txt_EmailCustomer.Text = tbe_Customer != null ? tbe_Customer.Email : "Không tìm thấy khách hàng";
                txt_NameCustomer.Text = tbe_Customer != null ? tbe_Customer.Name : "Không tìm thấy khách hàng";
                txt_Phone.Text = tbe_Customer != null ? tbe_Customer.Phone.ToString() : "Không tìm thất khách hàng";
                txt_NameProduct.Text = dtg_Order.CurrentRow.Cells[2].Value.ToString();
                txt_PriceProduct.Text = dtg_Order.CurrentRow.Cells[5].Value.ToString();
                txt_QuantityProduct.Text = dtg_Order.CurrentRow.Cells[4].Value.ToString();
                string path = dtg_Order.CurrentRow.Cells[6].Value.ToString();
                string imagePath = path != null ? "C:\\Users\\omogo\\Desktop\\ImgForBeautyBox\\blob (1).jfif" : "C:\\Users\\omogo\\Desktop\\img\\" + path;
                long fileSize = new FileInfo(imagePath).Length; // Get the file size in bytes
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                // Convert the file size to a human-readable format
                string sizeInKB = (fileSize / 1024).ToString("N0") + " KB";
                string sizeInMB = (fileSize / (1024 * 1024)).ToString("N2") + " MB";
                pictureBox1.Image = Image.FromFile(imagePath); 


            }
        }

        private void Form_Order_Load(object sender, EventArgs e)
        {
           
        }

        public void load()
        {
            DataTable dt = orders.getDataTableOrder();

            // Nếu DataGridView đã được tải dữ liệu lần đầu tiên, xóa dữ liệu hiện tại
            if (isLoaded)
            {
                dtg_Order.DataSource = null;
                dtg_Order.Rows.Clear();
            }

            // Cập nhật DataSource mới
            dtg_Order.DataSource = dt;

            // Đánh dấu rằng DataGridView đã được tải dữ liệu lần đầu tiên
            isLoaded = true;
        }
    }
}
