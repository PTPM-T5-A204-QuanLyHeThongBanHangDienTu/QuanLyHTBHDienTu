
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien_GiaoDien;
using DAL;

namespace AppQL_BanHang
{
    public partial class Form_ResgisterUser : Form
    {
        DAL_User user = new DAL_User();
        public Form_ResgisterUser()
        {
            InitializeComponent();
        }
        public void load()
        {
            DataTable dt = user.load();
            dtg_User.DataSource = dt;
            databingding(dt);
        }

        private void From_ResgisterUser_Load(object sender, EventArgs e)
        {
            load();
            
        }
        public void databingding(DataTable dtd)
        {
            txt_Id.DataBindings.Clear();
            txt_Name.DataBindings.Clear();
            txt_Diachi.DataBindings.Clear();
            txt_City.DataBindings.Clear();
            txt_Country.DataBindings.Clear();
            txt_City.DataBindings.Clear();
            txt_Zipcode.DataBindings.Clear();
            txt_Phone.DataBindings.Clear();
            txt_Email.DataBindings.Clear();
            txt_Pass.DataBindings.Clear();

            txt_Id.DataBindings.Add("text",dtd, "id");
            txt_Name.DataBindings.Add("text", dtd, "name");
            txt_Diachi.DataBindings.Add("text", dtd, "address");
            txt_City.DataBindings.Add("text", dtd, "city");
            txt_Country.DataBindings.Add("text", dtd, "country");
            txt_Zipcode.DataBindings.Add("text", dtd, "zipcode");
            txt_Phone.DataBindings.Add("text", dtd, "phone");
            txt_Email.DataBindings.Add("text", dtd, "email");
            txt_Pass.DataBindings.Add("text", dtd, "password");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string id = txt_Id.Text;
            string name = txt_Name.Text;
            string address = txt_Diachi.Text;
            string city = txt_City.Text;
            string country = txt_Country.Text;
            string zipcode = txt_Zipcode.Text;
            string phone = txt_Phone.Text;
            string email = txt_Email.Text.Trim();
            string pass = txt_Pass.Text;
            int kq = user.Check_Connect(txt_Id.Text);
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
                if (user.Insert_User(id, name, address, city, country, zipcode, phone, email, pass))
                {
                    MessageBox.Show("Thêm Thành Công");
                    txt_Id.Clear();
                    txt_Name.Clear();
                    txt_Diachi.Clear();
                    txt_City.Clear();
                    txt_Country.Clear();
                    txt_Zipcode.Clear();
                    txt_Phone.Clear();
                    txt_Email.Clear();
                    txt_Pass.Clear();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }


            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                user.Detele_User(txt_Id.Text);
                MessageBox.Show("Đã Xóa");
                load();
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
