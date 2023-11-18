
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
using DTO;
using MySql.Data.MySqlClient;

namespace AppQL_BanHang
{
    public partial class Form_ResgisterUser : Form
    {
        DAL_User user = new DAL_User();
        tbl_customer customer = new tbl_customer();
        public Form_ResgisterUser()
        {
            InitializeComponent();
        }
        public void load()
        {
            DataTable dt = user.load();
            dtg_User.DataSource = dt;
        }

        private void From_ResgisterUser_Load(object sender, EventArgs e)
        {
            LoadStart();
            load();
            
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void LoadStart()
        {
            btn_Luu.Enabled = true;
            btn_them.Enabled = true;
            btn_Sua.Enabled = true;

            txt_Id.Enabled = false;
            txt_Name.Enabled = false;
            txt_Diachi.Enabled = false;
            txt_City.Enabled = false;
            txt_Country.Enabled = false;
            txt_Zipcode.Enabled = false;
            txt_Phone.Enabled = false;
            txt_Email.Enabled = false;
            txt_Pass.Enabled = false;
            txt_CheckPass.Enabled = false;

        }
        public void LoadAfterInsert()
        {
            btn_Luu.Enabled = true;
            btn_them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;

            txt_Id.Enabled = false;
            txt_Name.Enabled = false;
            txt_City.Enabled = false;
            txt_Country.Enabled = false;
            txt_Diachi.Enabled = false;
            txt_Zipcode.Enabled = false;
            txt_Phone.Enabled = false;
            txt_Email.Enabled = false;
            txt_Pass.Enabled = false;
            txt_CheckPass.Enabled = false;

            txt_Id.Text = null;
            txt_Name.Text = null;
            txt_City.Text = null;
            txt_Country.Text = null;
            txt_Diachi.Text = null;
            txt_Zipcode.Text = null;
            txt_Phone.Text = null;
            txt_Email.Text = null;
            txt_Pass.Text = null;
            txt_CheckPass.Text = null;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_LamMoi_Click(sender, e);
            btn_Sua.Enabled =   false;
            btn_Xoa.Enabled = false;
            txt_Id.Text = user.TimMaCus().ToString();
            txt_Name.Enabled = true;
            txt_Diachi.Enabled = true;
            txt_City.Enabled = true;
            txt_Country.Enabled = true;
            txt_Zipcode.Enabled = true;
            txt_Phone.Enabled = true;
            txt_Email.Enabled = true;
            txt_CheckPass.Enabled = true;
            txt_Pass.Enabled = true;
            txt_Id.Enabled = false;


        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int Id = int.Parse(txt_Id.Text);
                user.Detele_User(Id);
                MessageBox.Show("Đã Xóa");
                load();
                btn_LamMoi_Click(sender, e);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            load();
            LoadStart();
            txt_Id.Text = null;
            txt_Name.Text = null;
            txt_Diachi.Text = null;
            txt_City.Text = null;
            txt_Country.Text = null;
            txt_Email.Text = null;
            txt_Pass.Text = null;
            txt_Zipcode.Text = null;
            txt_Phone.Text = null;
            txt_CheckPass.Text = null;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_them.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if ( btn_them.Enabled == true) 
            {
                customer.id = int.Parse(txt_Id.Text);
                customer.name = txt_Name.Text;
                customer.address = txt_Diachi.Text;
                customer.city = txt_City.Text;
                customer.country = txt_Country.Text;
                customer.zipcode = txt_Zipcode.Text;
                customer.phone = txt_Phone.Text;
                customer.email = txt_Email.Text.Trim();
                customer.password = txt_Pass.Text;
                int kq = user.Check_Connect(int.Parse(txt_Id.Text));
                if (kq == -1)
                {
                    MessageBox.Show("Câu lệnh không hợp lệ");
                    return;
                }
                if (kq == 1)
                {
                    MessageBox.Show("Mã đã tồn tại");
                    return;
                }
                if (kq == 0)
                {
                    if (user.Insert_User(customer))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        LoadAfterInsert();
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
            }
            else
            {
                customer.id = int.Parse(txt_Id.Text);
                customer.name = txt_Name.Text;
                customer.address = txt_Diachi.Text;
                customer.city = txt_City.Text;
                customer.country = txt_Country.Text;
                customer.zipcode = txt_Zipcode.Text;
                customer.phone = txt_Phone.Text;
                customer.email = txt_Email.Text.Trim();
                customer.password = txt_Pass.Text;

                if (user.Update_User(customer))
                {
                    msgBox("Thông tin thay đổi đã được lưu!");
                    LoadAfterInsert();
                    load();
                }

                else
                    msgBox("Sửa thất bại", true);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {


            btn_them.Enabled = false;
            btn_Xoa.Enabled = false;

            txt_Id.Enabled = false;
            txt_Name.Enabled = true;
            txt_City.Enabled = true;
            txt_Country.Enabled = true;
            txt_Diachi.Enabled = true;
            txt_Zipcode.Enabled = true;
            txt_Phone.Enabled = true;
            txt_Email.Enabled = true;
            txt_Pass.Enabled = true;
            txt_CheckPass.Enabled = true;
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string name = txt_timkiem.Text.Trim();
            if (name == "")
            {
                From_ResgisterUser_Load(sender, e);
            }
            else
            {
                string timkiem = txt_timkiem.Text.Trim();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da = user.TimKiemCustomer(timkiem);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg_User.DataSource = dt;
            }
        }

        private void dtg_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_User.Rows.Count > 0)
            {
                btn_Luu.Enabled = true;
                btn_them.Enabled = true;
                btn_Sua.Enabled = true;

                txt_Id.Enabled = false;
                txt_Name.Enabled = false;
                txt_Phone.Enabled = false;
                txt_Zipcode.Enabled = false;
                txt_City.Enabled = false;
                txt_Country.Enabled = false;
                txt_Diachi.Enabled = false;
                txt_Email.Enabled = false;
                txt_Pass.Enabled = false;


                txt_Id.Text = dtg_User.CurrentRow.Cells[0].Value.ToString();
                txt_Name.Text = dtg_User.CurrentRow.Cells[1].Value.ToString();
                txt_Diachi.Text = dtg_User.CurrentRow.Cells[2].Value.ToString();
                txt_City.Text = dtg_User.CurrentRow.Cells[3].Value.ToString();
                txt_Country.Text = dtg_User.CurrentRow.Cells[4].Value.ToString();
                txt_Zipcode.Text = dtg_User.CurrentRow.Cells[5].Value.ToString();
                txt_Phone.Text = dtg_User.CurrentRow.Cells[6].Value.ToString();
                txt_Email.Text = dtg_User.CurrentRow.Cells[7].Value.ToString();
                txt_Pass.Text = dtg_User.CurrentRow.Cells[8].Value.ToString();
                txt_CheckPass.Text = dtg_User.CurrentRow.Cells[8].Value.ToString();

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        ErrorProvider error = new ErrorProvider();
        private void txt_CheckPass_TextChanged(object sender, EventArgs e)
        {
            if (txt_CheckPass.Text != txt_Pass.Text)
            {
                error.SetError(this, "Mật khẩu không trùng khớp! Mời nhập lại ");
                btn_Luu.Enabled = false;
            }
            else
            {
                btn_Luu.Enabled = true;
            }
        }

    }
}
