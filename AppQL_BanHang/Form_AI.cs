using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace AppQL_BanHang
{
    public partial class Form_AI : Form
    {
        BLL_Category cat = new BLL_Category();
        BLL_AI ai = new BLL_AI();
        public Form_AI()
        {
            InitializeComponent();
        }


        public void LoadCat()
        {
            string[] cat = { "smartPhone", "laptop", "loudspeaker"};
            cbb_Category.DataSource = cat;
        }
        public void LoadPrice()
        {
            string[] price = { "100 - 200 trieu", "300 - 400 trieu", "400 - 500 trieu", "500 tro len" };
            cbb_price.DataSource = price;
        }
        public void LoadAmount()
        {
            string[] amount = { "1 - 20", "10 - 50", "50 - 100"};
            cbb_amount.DataSource = amount;
        }
        public void Loadrank()
        {
            string[] rank = { "A", "B", "C","D","E" };
            cbb_rank.DataSource = rank;
        }

        private void Form_AI_Load(object sender, EventArgs e)
        {
            LoadCat();
            LoadPrice();
            LoadAmount();
            Loadrank();
            cbb_Category.Text = null;
            cbb_price.Text = null;
            cbb_rank.Text = null;
            cbb_amount.Text = null;   
            guna2HtmlLabel4.Visible = false;
        }

        private void btn_khan_Click(object sender, EventArgs e)
        {
            if ( cbb_Category.SelectedValue == null || cbb_price.SelectedValue == null || cbb_rank.SelectedValue == null || cbb_amount.SelectedValue == null)
            {
                MessageBox.Show("Chọn đầy đủ dữ liệu");
                return;
            }
            else
            {
                guna2HtmlLabel5.Text = ai.LoadAI(cbb_Category.SelectedItem.ToString(), cbb_price.SelectedItem.ToString(), cbb_amount.SelectedItem.ToString(), cbb_rank.SelectedItem.ToString());
                guna2HtmlLabel4.Visible = true;
            }
           
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel4.Visible = false;
            guna2HtmlLabel5.Text = "";
            cbb_Category.Text = null;
            cbb_price.Text = null;
            cbb_rank.Text = null;
            cbb_amount.Text = null;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
