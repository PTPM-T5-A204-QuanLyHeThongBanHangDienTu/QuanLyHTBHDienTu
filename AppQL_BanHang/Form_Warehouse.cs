using DAL;
using DTO;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQL_BanHang
{
    public partial class Form_Warehouse : Form
    {
        DAL_Warehouse ware = new DAL_Warehouse();
        DAL_Products pro = new DAL_Products();
        tbl_warehouse we = new tbl_warehouse();
        public Form_Warehouse()
        {
            InitializeComponent();
        }
        public void load()
        {
            DataTable dt = ware.load();
            dtgv_DSSP.DataSource = dt;

        }
        public void LoadStart()
        {
            btn_luu.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;

            txt_ID.Enabled = false;
            txt_SoLuong.Enabled = false;
            dp_ngaynhap.Enabled = false;
            cbb_TenSp.Enabled = false;
        }
        private void Form_Product_Load(object sender, EventArgs e)
        {


        }
        public void load_Combobox()
        {
            cbb_TenSp.DataSource = pro.load();
            cbb_TenSp.DisplayMember = "productName";
            cbb_TenSp.ValueMember = "productId";

        }
        public void LoadAfterInsert()
        {
            btn_luu.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

            txt_ID.Enabled = false;
            txt_SoLuong.Enabled = false;
            cbb_TenSp.Enabled = false;
            dp_ngaynhap.Enabled = false;

            txt_ID.Text = null;
            txt_SoLuong.Text = null;
            cbb_TenSp.Text = null;
            dp_ngaynhap.Text = null;
        }


        private void Form_Warehouse_Load(object sender, EventArgs e)
        {
            LoadStart();
            load();
            load_Combobox();
        }
        private void dtgv_DSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_DSSP.Rows.Count > 0)
            {
                btn_luu.Enabled = true;
                btn_them.Enabled = true;
                btn_sua.Enabled = true;

                txt_ID.Enabled = false;
                txt_SoLuong.Enabled = false;
                dp_ngaynhap.Enabled = false;
                cbb_TenSp.Enabled = false;

                txt_ID.Text = dtgv_DSSP.CurrentRow.Cells[0].Value.ToString();
                cbb_TenSp.SelectedValue = dtgv_DSSP.CurrentRow.Cells[1].Value.ToString();
                txt_SoLuong.Text = dtgv_DSSP.CurrentRow.Cells[2].Value.ToString();
                dp_ngaynhap.Text = dtgv_DSSP.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_LamMoi_Click(sender, e);
            txt_ID.Text = ware.TimMaWare().ToString();
            txt_SoLuong.Enabled = true;
            cbb_TenSp.Enabled = true;
            dp_ngaynhap.Enabled = true;

            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            load();
            LoadStart();
            txt_ID.Text = null;
            txt_SoLuong.Text = null;
            cbb_TenSp.Text = null;
            dp_ngaynhap.Text = null;
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (btn_them.Enabled == true)
            {
                we.id_warehouse = int.Parse(txt_ID.Text);
                we.sanpham = cbb_TenSp.SelectedValue.ToString();
                we.sl_nhap = txt_SoLuong.Text;
                we.sl_ngaynhap = (dp_ngaynhap.Value);

                int kq = ware.Check_Connect(int.Parse(txt_ID.Text));
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
                    if (ware.Insert_ware(we))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        LoadAfterInsert();
                        load();
                    }

                    else
                        MessageBox.Show("Lỗi");
                }
            }
            else
            {
                we.id_warehouse = int.Parse(txt_ID.Text);
                we.sanpham = cbb_TenSp.SelectedValue.ToString();
                we.sl_nhap = txt_SoLuong.Text;
                we.sl_ngaynhap = (dp_ngaynhap.Value);
                if (ware.Update_ware(we))
                {
                    msgBox("Thông tin thay đổi đã được lưu!");
                    LoadAfterInsert();
                    load();
                }

                else
                    msgBox("Sửa thất bại", true);

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_ID.Enabled = false;
            txt_SoLuong.Enabled = true;
            dp_ngaynhap.Enabled = true;
            cbb_TenSp.Enabled = true;

            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int idware = int.Parse(txt_ID.Text);
                ware.Detele_ware(idware);
                MessageBox.Show("Đã Xóa");
                load();
                btn_LamMoi_Click(sender, e);   
            }
        }

        private void guna2DateTimePicker1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string pSearch = guna2DateTimePicker1.Value.ToString("yyyy-MM-dd");
            DataTable dt = ware.searchDayOrder(pSearch);

            // Xóa dữ liệu từ DataSource trước khi cập nhật
            dt.Clear();

            // Cập nhật DataSource mới
            dt.Merge(ware.searchDayOrder(pSearch));

            // Refresh DataGridView để hiển thị dữ liệu mới
            dtgv_DSSP.Refresh();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
