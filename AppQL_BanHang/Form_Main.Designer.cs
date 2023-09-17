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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idBrand = new System.Windows.Forms.TextBox();
            this.txt_nameBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dtg_DataGridView1 = new ThuVien_GiaoDien.dtg_DataGridView();
            this.btn_Them = new ThuVien_GiaoDien.btn_CustomButton();
            this.btn_Xoa = new ThuVien_GiaoDien.btn_CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brand_ID";
            // 
            // txt_idBrand
            // 
            this.txt_idBrand.Location = new System.Drawing.Point(70, 55);
            this.txt_idBrand.Name = "txt_idBrand";
            this.txt_idBrand.Size = new System.Drawing.Size(99, 20);
            this.txt_idBrand.TabIndex = 0;
            // 
            // txt_nameBrand
            // 
            this.txt_nameBrand.Location = new System.Drawing.Point(273, 55);
            this.txt_nameBrand.Name = "txt_nameBrand";
            this.txt_nameBrand.Size = new System.Drawing.Size(150, 20);
            this.txt_nameBrand.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(175, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand_Name";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dtg_DataGridView1
            // 
            this.dtg_DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DataGridView1.Location = new System.Drawing.Point(0, 93);
            this.dtg_DataGridView1.Name = "dtg_DataGridView1";
            this.dtg_DataGridView1.Size = new System.Drawing.Size(423, 150);
            this.dtg_DataGridView1.TabIndex = 14;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(7, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 15;
            this.btn_Them.Text = "Insert";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(105, 12);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Detele";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 290);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtg_DataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nameBrand);
            this.Controls.Add(this.txt_idBrand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

