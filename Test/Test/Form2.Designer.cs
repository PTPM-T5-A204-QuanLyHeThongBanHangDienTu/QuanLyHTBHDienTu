﻿namespace Test
{
    partial class Form2
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
            this.userControl_MySql1 = new ChucNang_1.UserControl_MySql();
            this.SuspendLayout();
            // 
            // userControl_MySql1
            // 
            this.userControl_MySql1.Location = new System.Drawing.Point(0, 3);
            this.userControl_MySql1.Name = "userControl_MySql1";
            this.userControl_MySql1.Size = new System.Drawing.Size(521, 351);
            this.userControl_MySql1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 354);
            this.Controls.Add(this.userControl_MySql1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private ChucNang_1.UserControl_MySql userControl_MySql1;
    }
}