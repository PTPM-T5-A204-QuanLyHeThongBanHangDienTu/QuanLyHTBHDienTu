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
    public partial class Form_Control : Form
    {
        public Form_Control()
        {
            InitializeComponent();
            btn_Orders.Click += Btn_Orders_Click;
    
        }

        private void Btn_Orders_Click(object sender, EventArgs e)
        {
            Form_Order form_Order = new Form_Order();
            OpenChildForm(form_Order);

        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Panel_body.Controls.Add(childForm);
            Panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show()
;
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            Form_Category fr = new Form_Category();
            OpenChildForm(fr);
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            Form_Product fr = new Form_Product();
            OpenChildForm(fr);
   
        }
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
             OpenChildForm(new Form_Product());
             btn_dangxuat.BackColor = Color.FromArgb(102, 102, 255);
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            Form_ResgisterUser fr = new Form_ResgisterUser();
            OpenChildForm(fr);
        }

        private void btn_Brands_Click(object sender, EventArgs e)
        {
            Form_Main fr = new Form_Main();
            OpenChildForm(fr);
        }

        private void btn_Orders_Click_1(object sender, EventArgs e)
        {
            Form_Order fr = new Form_Order();
            OpenChildForm(fr);
        }
    }
}
