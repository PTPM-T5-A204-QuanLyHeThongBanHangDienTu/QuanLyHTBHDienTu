using BLL;
using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQL_BanHang
{
    public partial class Form_LoginAdmin : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        public Form_LoginAdmin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Email.Text;
            string password = txt_Pass.Text;

            connection.Open();

            string query = "SELECT * FROM tbl_admin WHERE adminUser = @username AND adminPass = @password";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Form_Control fr = new Form_Control();
                fr.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin đăng nhập.");
            }

            reader.Close();
            connection.Close();
        }

        private void HidePass_Click(object sender, EventArgs e)
        {
            txt_Pass.PasswordChar = '*';
            
            ShowPass.Visible = true;
            HidePass.Visible = false;
            
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            txt_Pass.PasswordChar = '\0';
            HidePass.Visible = true;
            ShowPass.Visible = false;
        }

        private void Form_LoginAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txt_Email.Clear();
            txt_Pass.Clear();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void btn_Resgister_Click(object sender, EventArgs e)
        {
            Form_ResgisterAdmin fr = new Form_ResgisterAdmin();
            fr.ShowDialog();
            this.Close();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Form_ResetPass fr = new Form_ResetPass();
            fr.ShowDialog();

        }
    }
}
