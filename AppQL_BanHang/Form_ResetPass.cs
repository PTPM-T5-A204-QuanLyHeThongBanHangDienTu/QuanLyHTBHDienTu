using DAL;
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
    public partial class Form_ResetPass : Form
    {
        DAL_Modify modify = new DAL_Modify();   
        public Form_ResetPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtEmaildangky_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string email = txtEmaildangky.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email !");
            }
            else
            {
                string query = "SELECT adminEmail,adminPass FROM tbl_admin WHERE adminEmail = '" + email + "' ";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    lbl_kq.ForeColor = Color.Blue;
                    lbl_kq.Text = modify.TaiKhoans(query)[0].Mk;
                }
                else
                {
                    lbl_kq.ForeColor = Color.Red;
                    lbl_kq.Text = "Email chưa được đăng kí";
                }
            }
        }

        private void Form_ResetPass_Load(object sender, EventArgs e)
        {

        }
    }
}
