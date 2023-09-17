using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;

namespace AppQL_BanHang
{
    public partial class Form_Admin : Form
    {
        MySQL mySql = new MySQL();
        public Form_Admin()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            DataTable dt = mySql.load_Admin();
            dtg_DataGridView1.DataSource = dt;
        }

        private void btn_CustomButton1_Click(object sender, EventArgs e)
        {
            string adminID = txt_adminID.Text;
            string adminName = txt_adminName.Text;
            string adminEmail = txt_adminEmail.Text;
            string adminUser = txt_adminUser.Text;
            string adminPass = txt_adminPass.Text;
            int kq = mySql.Check_Connect(txt_adminID.Text);
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
                if (mySql.Insert_Admin(adminID, adminName, adminEmail, adminUser, adminPass))
                {
                    MessageBox.Show("Thêm Thành Công");
                    txt_adminID.Clear();
                    txt_adminName.Clear();
                    txt_adminEmail.Clear();
                    txt_adminUser.Clear();
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
