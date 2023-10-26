namespace AppQL_BanHang
{
    partial class Form_Category
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
            this.btn_Xoa = new ThuVien_GiaoDien.btn_CustomButton();
            this.btn_Them = new ThuVien_GiaoDien.btn_CustomButton();
            this.dtg_DataGridView1 = new ThuVien_GiaoDien.dtg_DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CatName = new System.Windows.Forms.TextBox();
            this.txt_CatId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(110, 12);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Detele";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(12, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Insert";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dtg_DataGridView1
            // 
            this.dtg_DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DataGridView1.Location = new System.Drawing.Point(5, 93);
            this.dtg_DataGridView1.Name = "dtg_DataGridView1";
            this.dtg_DataGridView1.Size = new System.Drawing.Size(423, 150);
            this.dtg_DataGridView1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(207, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cat_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cat_ID";
            // 
            // txt_CatName
            // 
            this.txt_CatName.Location = new System.Drawing.Point(278, 55);
            this.txt_CatName.Name = "txt_CatName";
            this.txt_CatName.Size = new System.Drawing.Size(150, 20);
            this.txt_CatName.TabIndex = 18;
            // 
            // txt_CatId
            // 
            this.txt_CatId.Location = new System.Drawing.Point(61, 55);
            this.txt_CatId.Name = "txt_CatId";
            this.txt_CatId.Size = new System.Drawing.Size(99, 20);
            this.txt_CatId.TabIndex = 17;
            // 
            // Form_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 244);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtg_DataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CatName);
            this.Controls.Add(this.txt_CatId);
            this.Name = "Form_Category";
            this.Text = "Form_Category";
            this.Load += new System.EventHandler(this.Form_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ThuVien_GiaoDien.btn_CustomButton btn_Xoa;
        private ThuVien_GiaoDien.btn_CustomButton btn_Them;
        private ThuVien_GiaoDien.dtg_DataGridView dtg_DataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CatName;
        private System.Windows.Forms.TextBox txt_CatId;
    }
}