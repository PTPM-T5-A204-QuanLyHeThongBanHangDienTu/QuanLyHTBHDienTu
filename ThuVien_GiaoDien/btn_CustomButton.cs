using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien_GiaoDien
{
    public class btn_CustomButton : Button
    {
        public btn_CustomButton() {
            this.MouseHover += Btn_CustomButton_MouseHover;
        }

        private void Btn_CustomButton_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightPink;
        }
    }
}
