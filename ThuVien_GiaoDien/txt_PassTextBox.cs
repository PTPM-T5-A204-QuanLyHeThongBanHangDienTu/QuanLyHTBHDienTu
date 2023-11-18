using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien_GiaoDien
{
    public class txt_PassTextBox : Guna2TextBox
    {
        public txt_PassTextBox() {
            this.TextChanged += Txt_PassTextBox_TextChanged;
        }
        ErrorProvider ErrorProvider = new ErrorProvider();
        private void Txt_PassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.All(a => char.IsLetterOrDigit(a)) || this.Text.Length - 1 < 6)
            {
                ErrorProvider.SetError(this, "Chỉ chấp nhận khi có ký tự đặc biệt và lớn hơn 6 ký");
            }
            else
            {
                ErrorProvider.Clear();
            }
        }
        public bool CheckWord()
        {
            return !this.Text.Any((x) => !char.IsLetterOrDigit(x));
        }
    }
}
