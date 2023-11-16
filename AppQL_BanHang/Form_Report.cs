using BLL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;

namespace AppQL_BanHang
{
    public partial class Form_Report : Form
    {
        BLL_Orders orders = new BLL_Orders();
        DataTable thongke = new DataTable("ThongKe");
        public Form_Report()
        {
            InitializeComponent();
            
        }

        private void dp_ngaydau_ValueChanged(object sender, EventArgs e)
        {

        }
       public void load(DateTime ngaydau, DateTime ngaycuoi)
        {
            DataTable dt = new DataTable();
             dt =  orders.loadListBill(ngaydau, ngaycuoi);
            dtgv_thongke.DataSource = dt;
            dtgv_thongke.Columns[7].Visible = false;
            this.dtgv_thongke.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgv_thongke.DefaultCellStyle.BackColor = Color.White;


        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
            load(dp_ngaydau.Value,dp_ngaycuoi.Value);
        }

        private void Form_Report_Load(object sender, EventArgs e)
        {
        }

        private void btn_inthongke_Click(object sender, EventArgs e)
        {


            ExcelExport exp = new ExcelExport();
            List<tbl_order> bill = orders.LoadListBillList(dp_ngaydau.Value, dp_ngaycuoi.Value);
            string name = "Report";
            exp.ExportReport(bill, ref name, true);
        }
    }
}
