using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using MySql.Data.MySqlClient;

namespace AppQL_BanHang
{
    public partial class Form_Product : Form
    {
        DAL_Products products = new DAL_Products();
        DAL_Brand brand = new DAL_Brand();
        DAL_Category category = new DAL_Category();
        tbl_product prod = new tbl_product();
        private string fileAddress;
        private string fileName;
        private string fileSavePath;
        private string checkFileName;
        public Form_Product()
        {
            InitializeComponent();
        }
        public void load()
        {
            DataTable dt = products.load();
            dtgv_DSSP.DataSource = dt;
            dtgv_DSSP.Columns[2].Visible = false;
            dtgv_DSSP.Columns[4].Visible = false;
            dtgv_DSSP.Columns[5].Visible = false;
            dtgv_DSSP.Columns[9].Visible = false;

        }
        public void LoadStart()
        {
            btn_luu.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_chonanh.Enabled = false;
            txt_masp.Enabled = false;
            txt_tensp.Enabled = false;
            txt_sl.Enabled = false;
            cbo_loaiSP.Enabled = false;
            txt_dongiaban.Enabled = false;
            txt_hinhanh.Enabled = false;
            cbb_thuonghieu.Enabled = false;
            txt_mota.Enabled = false;
        }
        private void Form_Product_Load(object sender, EventArgs e)
        {
            LoadStart();
            load();
            load_Combobox();

        }
        public void load_Combobox()
        {
            cbb_thuonghieu.DataSource = brand.load();
            cbb_thuonghieu.DisplayMember = "brandName";
            cbb_thuonghieu.ValueMember = "brandId";

            cbo_loaiSP.DataSource = category.load();
            cbo_loaiSP.DisplayMember = "catName";
            cbo_loaiSP.ValueMember = "catId";
        }

        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool checkIsNummber(string text)
        {
            return int.TryParse(text, out int s);
        }
        private Image cloneImage(string path)
        {
            Image result;
            using (Bitmap original = new Bitmap(path))
            {
                result = (Bitmap)original.Clone();

            };

            return result;
        }
        private void moHinh()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(.gif)|*.gif|All files(*.*)|*.*";
            open.FilterIndex = 2;
            open.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileAddress = open.FileName;
                pcb_SanPham.Image = cloneImage(fileAddress);
                pcb_SanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                fileName = Path.GetFileName(fileAddress);
                string saveDirectory = Application.StartupPath;
                fileSavePath = saveDirectory + @"\img\" + fileName;
                txt_hinhanh.Text = fileName;
            }
        }

        private void pcb_SanPham_Click(object sender, EventArgs e)
        {
            //moHinh();
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            moHinh();
        }

        private void dtg_DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_DSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_DSSP.Rows.Count > 0)
            {
                btn_luu.Enabled = true;
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
                btn_chonanh.Enabled = false;

                txt_masp.Enabled = false;
                txt_tensp.Enabled = false;
                txt_sl.Enabled = false;
                cbb_thuonghieu.Enabled = false;
                txt_dongiaban.Enabled = false;
                txt_hinhanh.Enabled = false;
                txt_mota.Enabled = false;

                txt_masp.Text = dtgv_DSSP.CurrentRow.Cells[0].Value.ToString();
                txt_tensp.Text = dtgv_DSSP.CurrentRow.Cells[1].Value.ToString();
                txt_sl.Text = dtgv_DSSP.CurrentRow.Cells[3].Value.ToString();
                cbo_loaiSP.SelectedValue = dtgv_DSSP.CurrentRow.Cells[6].Value.ToString();
                cbb_thuonghieu.SelectedValue = dtgv_DSSP.CurrentRow.Cells[7].Value.ToString();
                txt_mota.Text = dtgv_DSSP.CurrentRow.Cells[8].Value.ToString();
                txt_dongiaban.Text = dtgv_DSSP.CurrentRow.Cells[10].Value.ToString();
                checkFileName = dtgv_DSSP.CurrentRow.Cells[11].Value.ToString();
                txt_hinhanh.Text = checkFileName;
                Bitmap bm = new Bitmap(Application.StartupPath + @"\img\" + checkFileName);
                pcb_SanPham.Image = bm;

            }
        }

        private void Form_Product_SizeChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_lammoi_Click(sender, e);
            txt_masp.Text = products.TimMaPro().ToString();
            txt_tensp.Enabled = true;
            txt_masp.Enabled = false;
            txt_dongiaban.Enabled = true;
            txt_hinhanh.Enabled = true;
            txt_mota.Enabled = true;
            txt_sl.Enabled = true;
            cbb_thuonghieu.Enabled = true;
            cbo_loaiSP.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_chonanh.Enabled = true;
        }
        public void LoadAfterInsert()
        {
            btn_luu.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

            txt_masp.Enabled = false;
            txt_mota.Enabled = false;
            txt_dongiaban.Enabled=false;
            txt_hinhanh.Enabled=false;
            txt_sl.Enabled = false;
            txt_tensp.Enabled = false;
            cbb_thuonghieu.Enabled = false;
            cbo_loaiSP.Enabled=false;

            txt_hinhanh.Text = null;
            txt_dongiaban.Text = null;
            txt_masp.Text = null;
            txt_tensp.Text = null;
            txt_mota.Text = null;
            txt_sl.Text = null;
            cbb_thuonghieu.Text = null;
            cbo_loaiSP.Text = null;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            load();
            LoadStart();
            txt_masp.Text = null;
            txt_tensp.Text = null;
            txt_mota.Text = null;
            txt_dongiaban.Text = null;
            txt_hinhanh.Text = null;
            cbo_loaiSP.Text = null;
            txt_sl.Text = null;
            cbb_thuonghieu.Text = null;
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
        }

        private void btn_chonanh_Click_1(object sender, EventArgs e)
        {
            moHinh();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if ( btn_them.Enabled == true)
            {
                prod.productId = int.Parse(txt_masp.Text);
                prod.productName = txt_tensp.Text;
                prod.productQuantity = int.Parse(txt_sl.Text);
                prod.price = txt_dongiaban.Text;
                prod.catId = int.Parse(cbo_loaiSP.SelectedValue.ToString());
                prod.brandId = int.Parse(cbb_thuonghieu.SelectedValue.ToString());
                prod.product_desc = txt_mota.Text;
                prod.image = txt_hinhanh.Text;

                int kq = products.Check_Connect(int.Parse(txt_masp.Text));
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
                    if (products.Insert_Proucts(prod))
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
                prod.productId = int.Parse(txt_masp.Text);
                prod.productName = txt_tensp.Text;
                prod.productQuantity = int.Parse(txt_sl.Text);
                prod.price = txt_dongiaban.Text;
                prod.catId = int.Parse(cbo_loaiSP.SelectedValue.ToString());
                prod.brandId = int.Parse(cbb_thuonghieu.SelectedValue.ToString());
                prod.product_desc = txt_mota.Text;
                prod.image = txt_hinhanh.Text;
                if (products.Update_Product(prod))
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
            txt_masp.Enabled = false;
            txt_tensp.Enabled = true;
            txt_mota.Enabled = true;
            txt_dongiaban.Enabled = true;
            txt_hinhanh.Enabled = true;
            txt_sl.Enabled = true;
            cbb_thuonghieu.Enabled = true;
            cbo_loaiSP.Enabled = true;

            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int productId = int.Parse(txt_masp.Text);
                products.Detele_Product(productId);
                MessageBox.Show("Đã Xóa");
                load();
                btn_lammoi_Click(sender, e);
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string name = txt_timkiem.Text.Trim();
            if (name == "") 
            {
                Form_Product_Load(sender, e);
            }
            else
            {
                string timkiem = txt_timkiem.Text.Trim();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da = products.TimKiemProduct(timkiem);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgv_DSSP.DataSource = dt;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
