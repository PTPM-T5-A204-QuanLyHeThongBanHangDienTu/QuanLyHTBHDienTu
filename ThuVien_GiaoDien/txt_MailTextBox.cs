using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien_GiaoDien
{
    public class txt_MailTextBox : TextBox
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
                ErrorProvider.SetError(this, "Thieu Ky Tu @");
            }
            else if ( !this.Text.Contains(".Com"))
            {
                ErrorProvider.SetError(this, "Thieu .Com");
            }
            else
            {
                ErrorProvider.Clear();
            }
        }

    }
}
