using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ThuVien_GiaoDien
{
    public class txt_MailTextBox : Guna2TextBox
    {
        public txt_MailTextBox()
        {
            this.TextChanged += Txt_MailTextBox_TextChanged
                ;
        }
        ErrorProvider ErrorProvider = new ErrorProvider();
        private void Txt_MailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!this.Text.Contains("@"))
            {
                ErrorProvider.SetError(this, "Thiếu ký tự @");
            }
            else if ( !this.Text.Contains(".Com"))
            {
                ErrorProvider.SetError(this, "Thiếu .Com");
            }
            else
            {
                ErrorProvider.Clear();
            }
        }

    }
}
