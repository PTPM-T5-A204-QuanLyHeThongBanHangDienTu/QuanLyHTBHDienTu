namespace AppQL_BanHang
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form_Main
            // 
            this.ClientSize = new System.Drawing.Size(1143, 557);
            this.Name = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idBrand;
        private System.Windows.Forms.TextBox txt_nameBrand;
        private System.Windows.Forms.Label label2;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private ThuVien_GiaoDien.dtg_DataGridView dtg_DataGridView1;
        private ThuVien_GiaoDien.btn_CustomButton btn_Them;
        private ThuVien_GiaoDien.btn_CustomButton btn_Xoa;
    }
}

