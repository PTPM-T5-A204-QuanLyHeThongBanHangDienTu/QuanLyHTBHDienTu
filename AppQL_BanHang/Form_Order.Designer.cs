namespace AppQL_BanHang
{
    partial class Form_Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_Order = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_Report = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Reset = new Guna.UI2.WinForms.Guna2Button();
            this.txt_IdOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_dayOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_NameProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QuantityProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_PriceProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_NameCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_EmailCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_q = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_AddressCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.aa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.pickerday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Order
            // 
            this.dtg_Order.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtg_Order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Order.ColumnHeadersHeight = 25;
            this.dtg_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Order.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Order.EnableHeadersVisualStyles = true;
            this.dtg_Order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_Order.Location = new System.Drawing.Point(12, 12);
            this.dtg_Order.Name = "dtg_Order";
            this.dtg_Order.RowHeadersVisible = false;
            this.dtg_Order.RowHeadersWidth = 51;
            this.dtg_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dtg_Order.Size = new System.Drawing.Size(579, 478);
            this.dtg_Order.TabIndex = 71;
            this.dtg_Order.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_Order.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtg_Order.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtg_Order.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtg_Order.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtg_Order.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtg_Order.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_Order.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg_Order.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_Order.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtg_Order.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_Order.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg_Order.ThemeStyle.HeaderStyle.Height = 25;
            this.dtg_Order.ThemeStyle.ReadOnly = false;
            this.dtg_Order.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_Order.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_Order.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtg_Order.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_Order.ThemeStyle.RowsStyle.Height = 22;
            this.dtg_Order.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_Order.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_Report
            // 
            this.btn_Report.Animated = true;
            this.btn_Report.BorderRadius = 20;
            this.btn_Report.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Report.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Report.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Report.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Report.FillColor = System.Drawing.Color.Lime;
            this.btn_Report.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Location = new System.Drawing.Point(950, 445);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(116, 45);
            this.btn_Report.TabIndex = 72;
            this.btn_Report.Text = "Report";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Animated = true;
            this.btn_Reset.BorderRadius = 20;
            this.btn_Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(1084, 445);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(116, 45);
            this.btn_Reset.TabIndex = 73;
            this.btn_Reset.Text = "Reset";
            // 
            // txt_IdOrder
            // 
            this.txt_IdOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IdOrder.DefaultText = "";
            this.txt_IdOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IdOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IdOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IdOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IdOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IdOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_IdOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IdOrder.Location = new System.Drawing.Point(610, 30);
            this.txt_IdOrder.Name = "txt_IdOrder";
            this.txt_IdOrder.PasswordChar = '\0';
            this.txt_IdOrder.PlaceholderText = "";
            this.txt_IdOrder.SelectedText = "";
            this.txt_IdOrder.Size = new System.Drawing.Size(200, 36);
            this.txt_IdOrder.TabIndex = 74;
            // 
            // txt_dayOrder
            // 
            this.txt_dayOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dayOrder.DefaultText = "";
            this.txt_dayOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dayOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dayOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dayOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dayOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dayOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dayOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dayOrder.Location = new System.Drawing.Point(828, 30);
            this.txt_dayOrder.Name = "txt_dayOrder";
            this.txt_dayOrder.PasswordChar = '\0';
            this.txt_dayOrder.PlaceholderText = "";
            this.txt_dayOrder.SelectedText = "";
            this.txt_dayOrder.Size = new System.Drawing.Size(200, 36);
            this.txt_dayOrder.TabIndex = 75;
            // 
            // txt_NameProduct
            // 
            this.txt_NameProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NameProduct.DefaultText = "";
            this.txt_NameProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NameProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NameProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NameProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameProduct.Location = new System.Drawing.Point(610, 95);
            this.txt_NameProduct.Name = "txt_NameProduct";
            this.txt_NameProduct.PasswordChar = '\0';
            this.txt_NameProduct.PlaceholderText = "";
            this.txt_NameProduct.SelectedText = "";
            this.txt_NameProduct.Size = new System.Drawing.Size(200, 36);
            this.txt_NameProduct.TabIndex = 76;
            // 
            // txt_QuantityProduct
            // 
            this.txt_QuantityProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QuantityProduct.DefaultText = "";
            this.txt_QuantityProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QuantityProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QuantityProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QuantityProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QuantityProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QuantityProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_QuantityProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QuantityProduct.Location = new System.Drawing.Point(828, 95);
            this.txt_QuantityProduct.Name = "txt_QuantityProduct";
            this.txt_QuantityProduct.PasswordChar = '\0';
            this.txt_QuantityProduct.PlaceholderText = "";
            this.txt_QuantityProduct.SelectedText = "";
            this.txt_QuantityProduct.Size = new System.Drawing.Size(200, 36);
            this.txt_QuantityProduct.TabIndex = 78;
            // 
            // txt_PriceProduct
            // 
            this.txt_PriceProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PriceProduct.DefaultText = "";
            this.txt_PriceProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PriceProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PriceProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PriceProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PriceProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PriceProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PriceProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PriceProduct.Location = new System.Drawing.Point(1047, 95);
            this.txt_PriceProduct.Name = "txt_PriceProduct";
            this.txt_PriceProduct.PasswordChar = '\0';
            this.txt_PriceProduct.PlaceholderText = "";
            this.txt_PriceProduct.SelectedText = "";
            this.txt_PriceProduct.Size = new System.Drawing.Size(184, 36);
            this.txt_PriceProduct.TabIndex = 79;
            // 
            // txt_NameCustomer
            // 
            this.txt_NameCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NameCustomer.DefaultText = "";
            this.txt_NameCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NameCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NameCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NameCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameCustomer.Location = new System.Drawing.Point(610, 164);
            this.txt_NameCustomer.Name = "txt_NameCustomer";
            this.txt_NameCustomer.PasswordChar = '\0';
            this.txt_NameCustomer.PlaceholderText = "";
            this.txt_NameCustomer.SelectedText = "";
            this.txt_NameCustomer.Size = new System.Drawing.Size(200, 36);
            this.txt_NameCustomer.TabIndex = 80;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.DefaultText = "";
            this.txt_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Location = new System.Drawing.Point(828, 164);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.PlaceholderText = "";
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.Size = new System.Drawing.Size(200, 36);
            this.txt_Phone.TabIndex = 81;
            // 
            // txt_EmailCustomer
            // 
            this.txt_EmailCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EmailCustomer.DefaultText = "";
            this.txt_EmailCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_EmailCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_EmailCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmailCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmailCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EmailCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_EmailCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EmailCustomer.Location = new System.Drawing.Point(1047, 164);
            this.txt_EmailCustomer.Name = "txt_EmailCustomer";
            this.txt_EmailCustomer.PasswordChar = '\0';
            this.txt_EmailCustomer.PlaceholderText = "";
            this.txt_EmailCustomer.SelectedText = "";
            this.txt_EmailCustomer.Size = new System.Drawing.Size(184, 36);
            this.txt_EmailCustomer.TabIndex = 82;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(610, 9);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(64, 15);
            this.guna2HtmlLabel1.TabIndex = 84;
            this.guna2HtmlLabel1.Text = "Mã Hóa Đơn";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(828, 9);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(47, 15);
            this.guna2HtmlLabel2.TabIndex = 85;
            this.guna2HtmlLabel2.Text = "Ngày đặt ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(610, 74);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(71, 15);
            this.guna2HtmlLabel3.TabIndex = 86;
            this.guna2HtmlLabel3.Text = "Tên sản phẩm";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(828, 74);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel4.TabIndex = 87;
            this.guna2HtmlLabel4.Text = "Số lượng";
            // 
            // lb_q
            // 
            this.lb_q.BackColor = System.Drawing.Color.Transparent;
            this.lb_q.Location = new System.Drawing.Point(1047, 74);
            this.lb_q.Name = "lb_q";
            this.lb_q.Size = new System.Drawing.Size(19, 15);
            this.lb_q.TabIndex = 88;
            this.lb_q.Text = "Giá";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(610, 143);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(82, 15);
            this.guna2HtmlLabel6.TabIndex = 89;
            this.guna2HtmlLabel6.Text = "Tên khách hàng";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(828, 143);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(66, 15);
            this.guna2HtmlLabel7.TabIndex = 90;
            this.guna2HtmlLabel7.Text = "Số điện thoại";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(1047, 143);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(28, 15);
            this.guna2HtmlLabel8.TabIndex = 91;
            this.guna2HtmlLabel8.Text = "Email";
            // 
            // txt_AddressCustomer
            // 
            this.txt_AddressCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AddressCustomer.DefaultText = "";
            this.txt_AddressCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AddressCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AddressCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddressCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddressCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddressCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_AddressCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddressCustomer.Location = new System.Drawing.Point(610, 233);
            this.txt_AddressCustomer.Name = "txt_AddressCustomer";
            this.txt_AddressCustomer.PasswordChar = '\0';
            this.txt_AddressCustomer.PlaceholderText = "";
            this.txt_AddressCustomer.SelectedText = "";
            this.txt_AddressCustomer.Size = new System.Drawing.Size(621, 36);
            this.txt_AddressCustomer.TabIndex = 92;
            // 
            // aa
            // 
            this.aa.BackColor = System.Drawing.Color.Transparent;
            this.aa.Location = new System.Drawing.Point(610, 212);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(36, 15);
            this.aa.TabIndex = 93;
            this.aa.Text = "Địa chỉ";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Animated = true;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BorderRadius = 20;
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.FillColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(950, 394);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(116, 45);
            this.btn_Delete.TabIndex = 94;
            this.btn_Delete.Text = "Xóa";
            // 
            // btn_Search
            // 
            this.btn_Search.Animated = true;
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BorderRadius = 20;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.Gold;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1084, 394);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(116, 45);
            this.btn_Search.TabIndex = 95;
            this.btn_Search.Text = "Tìm";
            // 
            // pickerday
            // 
            this.pickerday.Animated = true;
            this.pickerday.BorderRadius = 20;
            this.pickerday.Checked = true;
            this.pickerday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pickerday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pickerday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.pickerday.Location = new System.Drawing.Point(950, 340);
            this.pickerday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.pickerday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.pickerday.Name = "pickerday";
            this.pickerday.Size = new System.Drawing.Size(250, 36);
            this.pickerday.TabIndex = 96;
            this.pickerday.Value = new System.DateTime(2023, 10, 31, 15, 1, 33, 191);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(610, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 203);
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form_Order";
            this.Text = "Form_Order";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtg_Order;
        private Guna.UI2.WinForms.Guna2Button btn_Report;
        private Guna.UI2.WinForms.Guna2Button btn_Reset;
        private Guna.UI2.WinForms.Guna2TextBox txt_IdOrder;
        private Guna.UI2.WinForms.Guna2TextBox txt_dayOrder;
        private Guna.UI2.WinForms.Guna2TextBox txt_NameProduct;
        private Guna.UI2.WinForms.Guna2TextBox txt_QuantityProduct;
        private Guna.UI2.WinForms.Guna2TextBox txt_PriceProduct;
        private Guna.UI2.WinForms.Guna2TextBox txt_NameCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_EmailCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_q;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txt_AddressCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel aa;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2DateTimePicker pickerday;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}