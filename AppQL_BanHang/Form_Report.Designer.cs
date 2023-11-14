namespace AppQL_BanHang
{
    partial class Form_Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_inthongke = new Guna.UI2.WinForms.Guna2Button();
            this.btn_thongke = new Guna.UI2.WinForms.Guna2Button();
            this.dp_ngaycuoi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dp_ngaydau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtgv_thongke = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_inthongke);
            this.groupBox1.Controls.Add(this.btn_thongke);
            this.groupBox1.Controls.Add(this.dp_ngaycuoi);
            this.groupBox1.Controls.Add(this.dp_ngaydau);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.groupBox1.Location = new System.Drawing.Point(38, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1279, 220);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // btn_inthongke
            // 
            this.btn_inthongke.BorderRadius = 6;
            this.btn_inthongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_inthongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_inthongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_inthongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_inthongke.FillColor = System.Drawing.Color.SlateBlue;
            this.btn_inthongke.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inthongke.ForeColor = System.Drawing.Color.White;
            this.btn_inthongke.Location = new System.Drawing.Point(559, 135);
            this.btn_inthongke.Name = "btn_inthongke";
            this.btn_inthongke.Size = new System.Drawing.Size(180, 45);
            this.btn_inthongke.TabIndex = 8;
            this.btn_inthongke.Text = "In Thống Kê";
            this.btn_inthongke.Click += new System.EventHandler(this.btn_inthongke_Click);
            // 
            // btn_thongke
            // 
            this.btn_thongke.BorderRadius = 6;
            this.btn_thongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_thongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_thongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_thongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_thongke.FillColor = System.Drawing.Color.SlateBlue;
            this.btn_thongke.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btn_thongke.ForeColor = System.Drawing.Color.White;
            this.btn_thongke.Location = new System.Drawing.Point(559, 39);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(180, 45);
            this.btn_thongke.TabIndex = 7;
            this.btn_thongke.Text = "Thống Kê";
            this.btn_thongke.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dp_ngaycuoi
            // 
            this.dp_ngaycuoi.Checked = true;
            this.dp_ngaycuoi.CustomFormat = "yyyy-MM-dd";
            this.dp_ngaycuoi.FillColor = System.Drawing.Color.White;
            this.dp_ngaycuoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dp_ngaycuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_ngaycuoi.Location = new System.Drawing.Point(234, 135);
            this.dp_ngaycuoi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dp_ngaycuoi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dp_ngaycuoi.Name = "dp_ngaycuoi";
            this.dp_ngaycuoi.Size = new System.Drawing.Size(162, 36);
            this.dp_ngaycuoi.TabIndex = 3;
            this.dp_ngaycuoi.Value = new System.DateTime(2023, 11, 15, 0, 0, 0, 0);
            // 
            // dp_ngaydau
            // 
            this.dp_ngaydau.Checked = true;
            this.dp_ngaydau.CustomFormat = "yyyy-MM-dd";
            this.dp_ngaydau.FillColor = System.Drawing.Color.White;
            this.dp_ngaydau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dp_ngaydau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_ngaydau.Location = new System.Drawing.Point(234, 48);
            this.dp_ngaydau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dp_ngaydau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dp_ngaydau.Name = "dp_ngaydau";
            this.dp_ngaydau.Size = new System.Drawing.Size(162, 36);
            this.dp_ngaydau.TabIndex = 2;
            this.dp_ngaydau.Value = new System.DateTime(2023, 11, 15, 0, 0, 0, 0);
            this.dp_ngaydau.ValueChanged += new System.EventHandler(this.dp_ngaydau_ValueChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(94, 135);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(63, 18);
            this.guna2HtmlLabel4.TabIndex = 1;
            this.guna2HtmlLabel4.Text = "Đến ngày:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(94, 48);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(55, 18);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Từ ngày:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(400, 6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(400, 60);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "THỐNG KÊ DOANH THU";
            // 
            // dtgv_thongke
            // 
            this.dtgv_thongke.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgv_thongke.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_thongke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_thongke.ColumnHeadersHeight = 20;
            this.dtgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_thongke.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_thongke.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_thongke.Location = new System.Drawing.Point(38, 331);
            this.dtgv_thongke.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_thongke.Name = "dtgv_thongke";
            this.dtgv_thongke.RowHeadersVisible = false;
            this.dtgv_thongke.RowHeadersWidth = 51;
            this.dtgv_thongke.Size = new System.Drawing.Size(1279, 394);
            this.dtgv_thongke.TabIndex = 83;
            this.dtgv_thongke.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_thongke.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_thongke.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_thongke.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_thongke.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_thongke.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_thongke.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_thongke.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgv_thongke.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_thongke.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtgv_thongke.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_thongke.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_thongke.ThemeStyle.HeaderStyle.Height = 20;
            this.dtgv_thongke.ThemeStyle.ReadOnly = false;
            this.dtgv_thongke.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_thongke.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_thongke.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtgv_thongke.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgv_thongke.ThemeStyle.RowsStyle.Height = 22;
            this.dtgv_thongke.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_thongke.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1400, 745);
            this.Controls.Add(this.dtgv_thongke);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Name = "Form_Report";
            this.Text = "Form_Report";
            this.Load += new System.EventHandler(this.Form_Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_inthongke;
        private Guna.UI2.WinForms.Guna2Button btn_thongke;
        private Guna.UI2.WinForms.Guna2DateTimePicker dp_ngaycuoi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dp_ngaydau;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_thongke;
    }
}