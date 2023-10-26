using MySqlX.XDevAPI;
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

namespace AppQL_BanHang
{
    public partial class From_ResgisterUser : Form
    {
        DAL_User user = new DAL_User();
        public From_ResgisterUser()
        {
            InitializeComponent();
        }
        public void load()
        {
            DataTable dt = user.load();
            dtg_DataGridView1.DataSource = dt;
            dtg_DataGridView1.Columns[0].Visible = false;
            databingding(dt);
        }

        private void From_ResgisterUser_Load(object sender, EventArgs e)
        {
            load();
            
        }
        public void databingding(DataTable dtd)
        {
            txt_id.DataBindings.Clear();
            txt_name.DataBindings.Clear();
            txt_DiaChi.DataBindings.Clear();
            txt_City.DataBindings.Clear();
            txt_Country.DataBindings.Clear();
            txt_City.DataBindings.Clear();
            txt_Zipcode.DataBindings.Clear();
            txt_Phone.DataBindings.Clear();
            txt_adminEmail.DataBindings.Clear();
            txt_adminPass.DataBindings.Clear();

            txt_id.DataBindings.Add("text",dtd, "id");
            txt_name.DataBindings.Add("text", dtd, "name");
            txt_DiaChi.DataBindings.Add("text", dtd, "address");
            txt_City.DataBindings.Add("text", dtd, "city");
            txt_Country.DataBindings.Add("text", dtd, "country");
            txt_Zipcode.DataBindings.Add("text", dtd, "zipcode");
            txt_Phone.DataBindings.Add("text", dtd, "phone");
            txt_adminEmail.DataBindings.Add("text", dtd, "email");
            txt_adminPass.DataBindings.Add("text", dtd, "password");
        }
        private void btn_CustomButton1_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string name = txt_name.Text;
            string address = txt_DiaChi.Text;
            string city = txt_City.Text;
            string country = txt_Country.Text;
            string zipcode = txt_Zipcode.Text;
            string phone = txt_Phone.Text;
            string email = txt_adminEmail.Text.Trim();
            string pass = txt_adminPass.Text;
            int kq = user.Check_Connect(txt_id.Text);
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
                if (user.Insert_User(id,name,address,city,country,zipcode,phone,email,pass))
                {
                    MessageBox.Show("Thêm Thành Công");
                    txt_id.Clear();
                    txt_name.Clear();
                    txt_DiaChi.Clear();
                    txt_City.Clear();
                    txt_Country.Clear();
                    txt_Zipcode.Clear();
                    txt_Phone.Clear();
                    txt_adminEmail.Clear();
                    txt_adminPass.Clear();
                }

                else
                {
                    MessageBox.Show("Lỗi");
                }


            }
        }
    }
}
