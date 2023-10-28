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
        private void button1_Click(object sender, EventArgs e)
        {
            Form_Main fm = new Form_Main();
            fm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form_ResgisterUser fm = new Form_ResgisterUser();
            fm.ShowDialog();
        }

        private void Form_Control_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Category fr = new Form_Category();
            fr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Form_Product fr = new Form_Product();
            //fr.ShowDialog();

            OpenChildForm(new Form_Product());
            //Button_BanHang.BackColor = Color.Indigo;
            //Button_DonHang.BackColor = Color.Indigo;

            button5.BackColor = Color.FromArgb(102, 102, 255);
            //Button_kh.BackColor = Color.Indigo;
            //Button_Nhansu.BackColor = Color.Indigo;
            //Button_BaoCao.BackColor = Color.Indigo;
        }
    }
}
