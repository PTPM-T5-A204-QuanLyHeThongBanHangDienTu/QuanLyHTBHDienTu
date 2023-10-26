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
    public partial class Form_Main : Form
    {
        DAL_Brand brand = new DAL_Brand();
        public Form_Main()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            DataTable dt = brand.load();
            dtg_DataGridView1.DataSource = dt;
            databingding(dt);
            dtg_DataGridView1.Columns[0].Visible = false;
        }
        public void databingding(DataTable dtd)
        {
            txt_idBrand.DataBindings.Clear();
            txt_nameBrand.DataBindings.Clear();
            txt_idBrand.DataBindings.Add("text", dtd, "brandId");
            txt_nameBrand.DataBindings.Add("text", dtd, "brandName");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string MH = txt_idBrand.Text;
            string TH = txt_nameBrand.Text;

            int kq = brand.Check_Connect(txt_idBrand.Text);
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
                if (brand.Insert_Brand(MH, TH))
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
                brand.Detele_Brand(txt_idBrand.Text);
                MessageBox.Show("Đã Xóa");
            }
        }
    }
}
