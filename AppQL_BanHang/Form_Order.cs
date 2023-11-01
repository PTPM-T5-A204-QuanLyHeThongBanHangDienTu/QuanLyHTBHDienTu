﻿using BLL;
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
            guna2DataGridView1.CellClick += Dtg_Order_CellClick;
            btn_Search.Click += btn_LamMoi_Click;
            btn_Reset.Click += btn_LamMoi_Click;
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.SelectionChanged += Dtg_Order_SelectionChanged;
            load();
            btn_Delete.Click += btn_Xoa_Click;
        }



        private void Dtg_Order_SelectionChanged(object sender, EventArgs e)
        {
            
        }




    

        private void Dtg_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CustomerId = 0;
         
            if (guna2DataGridView1.Rows.Count > 0)
            {
                txt_Id.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_NgayDat.Text = guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();
                CustomerId = int.Parse(guna2DataGridView1.CurrentRow.Cells[3].Value.ToString());
                tbe_Customer = customer.SearchByIdCustomer(CustomerId);
                txt_Diachi.Text = tbe_Customer != null ? tbe_Customer.Address : "Không tìm thấy khách hàng";
                txt_Emails.Text = tbe_Customer != null ? tbe_Customer.Email : "Không tìm thấy khách hàng";
                txt_TenKhach.Text = tbe_Customer != null ? tbe_Customer.Name : "Không tìm thấy khách hàng";
                txt_SDT.Text = tbe_Customer != null ? tbe_Customer.Phone.ToString() : "Không tìm thất khách hàng";
                txt_TenSP.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_Gia.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_Soluong.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                string path = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
                string imagePath = path != null ? "C:\\Users\\dat03\\OneDrive\\Máy tính\\img\\1bef665118.jpg" : "C:\\Users\\dat03\\OneDrive\\Máy tính\\img" + path;
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
                guna2DataGridView1.DataSource = null;
                guna2DataGridView1.Rows.Clear();
               
            }

            // Cập nhật DataSource mới
            guna2DataGridView1.DataSource = dt;

            // Đánh dấu rằng DataGridView đã được tải dữ liệu lần đầu tiên
            isLoaded = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
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
            guna2DataGridView1.Refresh();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_Diachi.Text = string.Empty;
            txt_NgayDat.Text = string.Empty;
            txt_Emails.Text = string.Empty;
            txt_Id.Text = string.Empty;
            txt_TenKhach.Text = string.Empty;
            txt_TenSP.Text = string.Empty;
            txt_SDT.Text = string.Empty;
            txt_Gia.Text = string.Empty;
            txt_Soluong.Text = string.Empty;

            DataTable dt = orders.getDataTableOrder();

            dt.Clear();

            // Cập nhật DataSource mới
            dt.Merge(orders.getDataTableOrder());

            // Refresh DataGridView để hiển thị dữ liệu mới
            guna2DataGridView1.Refresh();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string pSearch = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            DataTable dt = orders.SearchByDateOrder(pSearch);

            // Xóa dữ liệu từ DataSource trước khi cập nhật
            dt.Clear();

            // Cập nhật DataSource mới
            dt.Merge(orders.SearchByDateOrder(pSearch));

            // Refresh DataGridView để hiển thị dữ liệu mới
            guna2DataGridView1.Refresh();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int CustomerId = 0;

            if (guna2DataGridView1.Rows.Count > 0)
            {
                txt_Id.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_NgayDat.Text = guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();
                CustomerId = int.Parse(guna2DataGridView1.CurrentRow.Cells[3].Value.ToString());
                tbe_Customer = customer.SearchByIdCustomer(CustomerId);
                txt_Diachi.Text = tbe_Customer != null ? tbe_Customer.Address : "Không tìm thấy khách hàng";
                txt_Emails.Text = tbe_Customer != null ? tbe_Customer.Email : "Không tìm thấy khách hàng";
                txt_TenKhach.Text = tbe_Customer != null ? tbe_Customer.Name : "Không tìm thấy khách hàng";
                txt_SDT.Text = tbe_Customer != null ? tbe_Customer.Phone.ToString() : "Không tìm thất khách hàng";
                txt_TenSP.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_Gia.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_Soluong.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                string path = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
                string imagePath = path != null ? "C:\\Users\\dat03\\OneDrive\\Máy tính\\img\\1bef665118.jpg" : "C:\\Users\\dat03\\OneDrive\\Máy tính\\img\\" + path;
                long fileSize = new FileInfo(imagePath).Length; // Get the file size in bytes
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                // Convert the file size to a human-readable format
                string sizeInKB = (fileSize / 1024).ToString("N0") + " KB";
                string sizeInMB = (fileSize / (1024 * 1024)).ToString("N2") + " MB";
                pictureBox1.Image = Image.FromFile(imagePath);


            }
        }
    }
}
