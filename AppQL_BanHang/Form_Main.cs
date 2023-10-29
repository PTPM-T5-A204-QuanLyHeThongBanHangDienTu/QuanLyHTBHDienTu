﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
//using BL
namespace AppQL_BanHang
{
    public partial class Form_Main : Form
    {
        BLL_Brand brand = new BLL_Brand();
        tbl_brand brand2 = new tbl_brand();
        public Form_Main()
        {
            InitializeComponent();

        }
        public void load()
        {
            DataTable dt = brand.load();
            dtg_Brands.DataSource = dt;
            //databingding(dt);
        }
        public void databingding(DataTable dtd)
        {
            txt_BrandId.DataBindings.Clear();
            txt_BrandName.DataBindings.Clear();

            txt_BrandId.DataBindings.Add("text", dtd, "brandId");
            txt_BrandName.DataBindings.Add("text", dtd, "brandName");
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            brand2.brandId = int.Parse( txt_BrandId.Text);
            brand2.brandName = txt_BrandName.Text;

            int _brandid = int.Parse(txt_BrandId.Text);
            int kq = brand.Check_Connect(_brandid);
            if (kq == -1)
            {
                MessageBox.Show("Câu lệnh không hợp lệ");
                return;
            }
            if (kq == 1)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại");
                return;
            }
            if (kq == 0)
            {
                if (brand.Insert_Brand(brand2))
                    MessageBox.Show("Thêm Thành Công");
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int brandid = int.Parse(txt_BrandId.Text);
                brand.Detele_Brand(brandid);
                MessageBox.Show("Đã Xóa");
                load();
                btn_LamMoi_Click(sender, e);
            }
            
        }

        public void LoadStart()
        {
            btn_luu.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            txt_BrandId.Enabled = false;
            txt_BrandName.Enabled = false;
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            load();
            LoadStart();
            txt_BrandId.Text = null;
            txt_BrandName.Text = null;
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (btn_them.Enabled == true)
            {

                brand2.brandId = int.Parse(txt_BrandId.Text);
                brand2.brandName = txt_BrandName.Text;

                int _brandid = int.Parse(txt_BrandId.Text);
                int kq = brand.Check_Connect(_brandid);
                if (kq == -1)
                {
                    MessageBox.Show("Câu lệnh không hợp lệ");
                    return;
                }
                if (kq == 1)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại");
                    return;
                }
                if (kq == 0)
                {
                    if (brand.Insert_Brand(brand2))
                        msgBox("Thêm brand thành công!");
                    else
                        msgBox("Thêm brand thất bại", true);
                }

            }
            else
            {

                //sp.Tensp = txt_tensp.Text;
                //sp.Soluong = int.Parse(txt_sl.Text);
                //sp.Dongiaban = float.Parse(txt_dongiaban.Text);
                //sp.Dongianhap = float.Parse(txt_dongianhap.Text);
                //sp.Ghichu = txt_ghichu.Text;
                //sp.Hinhanh = txt_hinhanh.Text;
                //sp.Masp = int.Parse(txt_masp.Text);
                //sp.Maloai = int.Parse(cbo_loaiSP.SelectedValue.ToString());
                //if (SanPhamDAO.Instance.updateSP(sp))
                //{
                //    showSP();
                msgBox("Sửa sản phẩm thành công!");
                //}
                //else
                //{
                //    msgBox("Sửa sản phẩm không được", true);
                //}
            }
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            btn_LamMoi_Click(sender, e);
            //txt_BrandId.Enabled = true;
            txt_BrandId.Text =  brand.TimMaBrand().ToString();
            txt_BrandName.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            txt_BrandId.Enabled = false;
            txt_BrandName.Enabled = true;      
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            load();
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = false;
        }

        private void dtg_Brands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Brands.Rows.Count > 0)
            {
                txt_BrandId.Text = dtg_Brands.CurrentRow.Cells[0].Value.ToString();
                txt_BrandName.Text = dtg_Brands.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
