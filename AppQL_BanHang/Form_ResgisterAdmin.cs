using BLL;
using DAL;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form_ResgisterAdmin : Form
    {
        BLL_Admin ad = new BLL_Admin();
        tbl_admin admin = new tbl_admin();
        public Form_ResgisterAdmin()
        {
            InitializeComponent();
        }
        public void load()
        {
            DataTable dt = ad.load();
            dtg_Admin.DataSource = dt;
            dtg_Admin.Columns[5].Visible = false;
        }
        public void LoadStart()
        {
            btn_Luu.Enabled = true;
            btn_them.Enabled = true;
            btn_Sua.Enabled = true;

            txt_Id.Enabled = false;
            txt_Name.Enabled = false;
            txt_Email.Enabled = false;
            txt_adminUser.Enabled = false;
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
            txt_Email.Enabled = false;
            txt_adminUser.Enabled = false;
            txt_Pass.Enabled = false;
            txt_CheckPass.Enabled = true;

            txt_Id.Text = null;
            txt_Name.Text = null;
            txt_Email.Text = null;
            txt_adminUser.Text = null;
            txt_Pass.Text = null;
            txt_CheckPass.Text = null;
        }

        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form_ResgisterAdmin_Load(object sender, EventArgs e)
        {
            LoadStart();

            load();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_LamMoi_Click(sender, e);
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            txt_Id.Text = ad.TimMaAdmin().ToString();
            txt_Name.Enabled = true;
            txt_Email.Enabled = true;
            txt_adminUser.Enabled = true;
            txt_Pass.Enabled = true;
            txt_Id.Enabled = false;
            txt_CheckPass.Enabled = true;

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int Id = int.Parse(txt_Id.Text);
                ad.Detele_Admin(Id);
                MessageBox.Show("Đã Xóa");
                load();
                btn_LamMoi_Click(sender, e);
            }
        }

        private void dtg_Admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Admin.Rows.Count > 0)
            {
                btn_Luu.Enabled = true;
                btn_them.Enabled = true;
                btn_Sua.Enabled = true;

                txt_Id.Enabled = false;
                txt_Name.Enabled = false;
                txt_adminUser.Enabled = false;
                txt_Email.Enabled = false;
                txt_adminUser.Enabled = false;
                txt_Pass.Enabled = false;


                txt_Id.Text = dtg_Admin.CurrentRow.Cells[0].Value.ToString();
                txt_Name.Text = dtg_Admin.CurrentRow.Cells[1].Value.ToString();
                txt_Email.Text = dtg_Admin.CurrentRow.Cells[2].Value.ToString();
                txt_adminUser.Text = dtg_Admin.CurrentRow.Cells[3].Value.ToString();
                txt_Pass.Text = dtg_Admin.CurrentRow.Cells[4].Value.ToString();
                txt_CheckPass.Text = dtg_Admin.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (btn_them.Enabled == true)
            {
                admin.adminID = int.Parse(txt_Id.Text);
                admin.adminName = txt_Name.Text;
                admin.adminEmail = txt_Email.Text;
                admin.adminUser = txt_adminUser.Text;
                admin.adminPassword = txt_Pass.Text;

                int kq = ad.CheckConnect(int.Parse(txt_Id.Text));
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
                    if (ad.Insert_Admin(admin))
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
                admin.adminID = int.Parse(txt_Id.Text);
                admin.adminName = txt_Name.Text;
                admin.adminEmail = txt_Email.Text;
                admin.adminUser = txt_adminUser.Text;
                admin.adminPassword = txt_Pass.Text;;

                if (ad.Update_Admin(admin))
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
            txt_Email.Enabled = true;
            txt_adminUser.Enabled = true;
            txt_Pass.Enabled = true;
            txt_CheckPass.Enabled = true;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            load();
            LoadStart();
            txt_Id.Text = null;
            txt_Name.Text = null;
            txt_Email.Text = null;
            txt_adminUser.Text = null;
            txt_CheckPass.Text = null;
            txt_Pass.Text = null;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_them.Enabled = true;
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string name = txt_timkiem.Text.Trim();
            if (name == "")
            {
                Form_ResgisterAdmin_Load(sender, e);
            }
            else
            {
                string timkiem = txt_timkiem.Text.Trim();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da = ad.TimKiemAdmin(timkiem);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg_Admin.DataSource = dt;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        ErrorProvider error = new ErrorProvider();

        private void txt_CheckPass_TextChanged(object sender, EventArgs e)
        {
            if ( txt_CheckPass.Text != txt_Pass.Text)
            {
                error.SetError(this, "Mật khẩu không trùng khớp! Mời nhập lại ");
                btn_Luu.Enabled = false;
            }
            else
            {
                btn_Luu.Enabled=true;
            }
        }
    }
}
