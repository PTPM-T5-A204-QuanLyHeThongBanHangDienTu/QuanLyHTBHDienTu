using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien_GiaoDien
{
    public class txt_NameTextBox : TextBox
    {
        public txt_NameTextBox() {
            this.KeyPress += Txt_NameTextBox_KeyPress;
        }

        private void Txt_NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
