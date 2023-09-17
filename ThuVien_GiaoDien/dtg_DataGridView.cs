using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien_GiaoDien
{
    public class dtg_DataGridView : DataGridView
    {
        public dtg_DataGridView ()
        {
            this.RowPostPaint += Dtg_DataGridView_RowPostPaint;
        }

        private void Dtg_DataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            this.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightCyan;
        }
    }
}
