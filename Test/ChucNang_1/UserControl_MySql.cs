using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChucNang_1
{
    public partial class UserControl_MySql : UserControl
    {
        Load l = new Load();
        public UserControl_MySql()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            DataTable kq = l.load();
            dtg_DataGridView1.DataSource = kq;
            databingding(kq);
        }
        public void databingding(DataTable dt)
        {
            txt_idBrand.DataBindings.Clear();
            txt_nameBrand.DataBindings.Clear();
            txt_idBrand.DataBindings.Add("text", dt, "brandId");
            txt_nameBrand.DataBindings.Add("text", dt, "brandName");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string MH = txt_idBrand.Text;
            string TH = txt_nameBrand.Text;

            int kq = l.Check_Connect(txt_idBrand.Text);
            if (kq == -1)
            {
                MessageBox.Show("Loi cau lenh");
                return;
            }
            if (kq == 1)
            {
                MessageBox.Show("Trung khoa chinh");
                return;
            }
            if (kq == 0)
            {
                if (l.Insert(MH, TH))
                    MessageBox.Show("Them thanh cong");
                else
                    MessageBox.Show("Khong them duoc");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            l.Detele(txt_idBrand.Text);
            MessageBox.Show("Da xoa");
        }


    }
}
