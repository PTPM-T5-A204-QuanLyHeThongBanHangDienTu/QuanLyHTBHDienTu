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
using BLL;
using DTO;
using MySql.Data.MySqlClient;

namespace AppQL_BanHang
{
    public partial class Form_Category : Form
    {
        BLL_Category cat = new BLL_Category();
        tbl_category cate = new tbl_category();
        public Form_Category()
        {
            InitializeComponent();
        }
        public void load()
        {   
            DataTable dt = cat.load();
            dtg_Category.DataSource = dt;

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
            txt_CatId.Enabled = false;
            txt_CatName.Enabled = false;
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_LamMoi_Click(sender, e);
            txt_CatId.Text = cat.TimMaCat().ToString();
            txt_CatName.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;


        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int catid = int.Parse(txt_CatId.Text);
                cat.Detele_Cat(catid);
                MessageBox.Show("Đã Xóa");
                load();
                btn_LamMoi_Click(sender,e);
            }
        }
        public void LoadStart()
        {
            btn_luu.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            txt_CatId.Enabled = false;
            txt_CatName.Enabled = false;
        }
        public void LoadAfterInsert()
        {
            btn_luu.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled=true;
            txt_CatId.Enabled = false;
            txt_CatName.Enabled = false;
            txt_CatId.Text = null;
            txt_CatName.Text = null;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (btn_them.Enabled == true)
            {

                cate.catId = int.Parse(txt_CatId.Text);
                cate.catName = txt_CatName.Text;

                int _catid = int.Parse(txt_CatId.Text);
                int kq = cat.Check_Connect(_catid);
                if (kq == -1)
                {
                    MessageBox.Show("Câu lệnh không hợp lệ");
                    return;
                }
                if (kq == 1)
                {
                    MessageBox.Show("Mã loại sản phẩm đã tồn tại");
                    return;
                }
                if (kq == 0)
                {
                    if (cat.Insert_Category(cate))
                    {
                        msgBox("Thêm loại sản phẩm thành công!");
                        LoadAfterInsert();
                        load();
                    }
                        
                    else
                        msgBox("Thêm loại sản phẩm thất bại", true);
                }

            }
            else
            {
                cate.catId = int.Parse(txt_CatId.Text);
                cate.catName = txt_CatName.Text;
                if (cat.Update_Cat(cate))
                {
                    msgBox("Sửa loại sản phẩm thành công!");
                    LoadAfterInsert();
                    load();
                }

                else
                    msgBox("Sửa loại sản phẩm thất bại", true);

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            txt_CatId.Enabled = false;
            txt_CatName.Enabled = true;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            load();
            LoadStart();
            txt_CatId.Text = null;
            txt_CatName.Text = null;
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
        }

        private void dtg_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Category.Rows.Count > 0)
            {
                txt_CatId.Text = dtg_Category.CurrentRow.Cells[0].Value.ToString();
                txt_CatName.Text = dtg_Category.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string name = txt_timkiem.Text.Trim();
            if (name == "")
            {
                Form_Category_Load(sender, e);
            }
            else
            {
                string timkiem = txt_timkiem.Text.Trim();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da = cat.TimKiemCat(timkiem);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg_Category.DataSource = dt;
            }
        }
    }
}
