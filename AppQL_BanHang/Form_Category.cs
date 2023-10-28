using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace AppQL_BanHang
{
    public partial class Form_Category : Form
    {
        DAL_Category cat = new DAL_Category();
        public Form_Category()
        {
            InitializeComponent();
        }
        public void load()
        {
            DataTable dt = cat.load();
            dtg_Category.DataSource = dt;
            databingding(dt);

        }
        public void databingding(DataTable dtd)
        {
            txt_CatId.DataBindings.Clear();
            txt_CatName.DataBindings.Clear();
            txt_CatId.DataBindings.Add("text", dtd, "catId");
            txt_CatName.DataBindings.Add("text", dtd, "catName");
        }

        private void Form_Category_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string catId = txt_CatId.Text;
            string catName = txt_CatName.Text;

            int kq = cat.Check_Connect(txt_CatId.Text);
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
                if (cat.Insert_Category(catId, catName))
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
                cat.Detele_Brand(txt_CatId.Text);
                MessageBox.Show("Đã Xóa");
                load();
            }
        }

    }
}
