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
        public void load()
        {
            DataTable dt = products.load();
            dtg_DataGridView1.DataSource = dt;
            dtg_DataGridView1.Columns[0].Visible = false;
            dtg_DataGridView1.Columns[2].Visible = false;
            dtg_DataGridView1.Columns[3].Visible = false;
            dtg_DataGridView1.Columns[4].Visible = false;
            dtg_DataGridView1.Columns[5].Visible = false;
            dtg_DataGridView1.Columns[9].Visible = false;
            databingding(dt);
            

        }

        private void Form_Product_Load(object sender, EventArgs e)
        {
            load();
            load_Combobox();

        }
        public void load_Combobox()
        {
            cbb_Brand.DataSource = brand.load();
            cbb_Brand.DisplayMember = "brandName";
            cbb_Brand.ValueMember = "brandId";

            cbb_Category.DataSource = category.load();
            cbb_Category.DisplayMember = "catName";
            cbb_Category.ValueMember = "catId";
        }
        public void databingding(DataTable dtd)
        {
            txt_id.DataBindings.Clear();
            txt_name.DataBindings.Clear();
            txt_Price.DataBindings.Clear();
            txt_Description.DataBindings.Clear();
            cbb_Category.DataBindings.Clear();
            cbb_Brand.DataBindings.Clear();
            txt_HinhAnh.DataBindings.Clear();

            txt_id.DataBindings.Add("text", dtd, "productId");
            txt_name.DataBindings.Add("text", dtd, "productName");
            txt_Price.DataBindings.Add("text", dtd, "price");
            txt_Description.DataBindings.Add("text", dtd, "product_desc");
            cbb_Category.DataBindings.Add("text", dtd, "catId");
            cbb_Brand.DataBindings.Add("text", dtd, "brandId");
            txt_HinhAnh.DataBindings.Add("text", dtd, "image");


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
                fileSavePath = saveDirectory + @"\Images\" + fileName;
                txt_HinhAnh.Text = fileName;
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
            //txt_id.Text = dtg_DataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txt_name.Text = dtg_DataGridView1.CurrentRow.Cells[1].Value.ToString();
            //txt_Price.Text = dtg_DataGridView1.CurrentRow.Cells[2].Value.ToString();

            //checkFileName = dtg_DataGridView1.CurrentRow.Cells[3].Value.ToString();
            //txt_HinhAnh.Text = checkFileName;
            //Bitmap bm = new Bitmap(Application.StartupPath + @"\img\" + checkFileName);
            //pcb_SanPham.Image = bm;
            ////txt_ghichu.Text = dtgv_DSSP.CurrentRow.Cells[6].Value.ToString();
            ////cbo_loaiSP.SelectedValue = dtgv_DSSP.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
