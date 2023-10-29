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

namespace AppQL_BanHang
{
    public partial class Form_Product : Form
    {
        DAL_Products products = new DAL_Products();
        DAL_Brand brand = new DAL_Brand();
        DAL_Category category = new DAL_Category();
        private string fileAddress;
        private string fileName;
        private string fileSavePath;
        private string checkFileName;
        public Form_Product()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            DataTable dt = products.load();
            dtgv_DSSP.DataSource = dt;
            dtgv_DSSP.Columns[2].Visible = false;
            dtgv_DSSP.Columns[4].Visible = false;
            dtgv_DSSP.Columns[5].Visible = false;
            dtgv_DSSP.Columns[9].Visible = false;
            databingding(dt);



        }
        public void LoadStart()
        {
            btn_luu.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
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
            loadData();
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
        public void databingding(DataTable dtd)
        {
            //txt_id.DataBindings.Clear();
            //txt_name.DataBindings.Clear();
            //txt_Price.DataBindings.Clear();
            //txt_Description.DataBindings.Clear();
            //cbb_Category.DataBindings.Clear();
            //cbb_Brand.DataBindings.Clear();
            //txt_HinhAnh.DataBindings.Clear();

            //txt_id.DataBindings.Add("text", dtd, "productId");
            //txt_name.DataBindings.Add("text", dtd, "productName");
            //txt_Price.DataBindings.Add("text", dtd, "price");
            //txt_Description.DataBindings.Add("text", dtd, "product_desc");
            //cbb_Category.DataBindings.Add("text", dtd, "catId");
            //cbb_Brand.DataBindings.Add("text", dtd, "brandId");
            //txt_HinhAnh.DataBindings.Add("text", dtd, "image");


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
        //    txt_id.Text = dtg_DataGridView1.CurrentRow.Cells[0].Value.ToString();
        //    txt_name.Text = dtg_DataGridView1.CurrentRow.Cells[1].Value.ToString();
        //    txt_Price.Text = dtg_DataGridView1.CurrentRow.Cells[2].Value.ToString();

        //    checkFileName = dtg_DataGridView1.CurrentRow.Cells[3].Value.ToString();
        //    txt_HinhAnh.Text = checkFileName;
        //    Bitmap bm = new Bitmap(Application.StartupPath + @"\img\" + checkFileName);
        //    pcb_SanPham.Image = bm;
        //    //txt_ghichu.Text = dtgv_DSSP.CurrentRow.Cells[6].Value.ToString();
        //    //cbo_loaiSP.SelectedValue = dtgv_DSSP.CurrentRow.Cells[7].Value.ToString();
        }

        private void dtg_DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_id.Text = dtg_DataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txt_name.Text = dtg_DataGridView1.CurrentRow.Cells[1].Value.ToString();
            //txt_Price.Text = dtg_DataGridView1.CurrentRow.Cells[10].Value.ToString();

            //checkFileName = dtg_DataGridView1.CurrentRow.Cells[11].Value.ToString();
            //txt_HinhAnh.Text = checkFileName;
            ////Bitmap bm = new Bitmap(Application.StartupPath + @"\img\" + checkFileName);
            ////pcb_SanPham.Image = bm;

            //string imagePath = Path.Combine(Application.StartupPath + @"\img\" + checkFileName);

            //if (File.Exists(imagePath))
            //{
            //    Bitmap bm = new Bitmap(imagePath);
            //    //Image image = Image.FromFile(imagePath);
            //    pcb_SanPham.Image = bm;
            //}
            //else
            //{
            //    // Xử lý tệp không tồn tại, ví dụ: hiển thị hình ảnh mặc định
            //    pcb_SanPham.Image = null;
            //}
        }

        private void dtgv_DSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_DSSP.Rows.Count > 0)
            {
                btn_luu.Enabled = true;
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
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
                //txt_dongianhap.Text = dtgv_DSSP.CurrentRow.Cells[3].Value.ToString();
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

        }
    }
}
