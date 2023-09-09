using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChucNang_1
{
    public partial class UserControl_MySql : UserControl
    {
        Load l = new Load();
        public UserControl_MySql()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            DataTable dt = l.load();
            dataGridView1.DataSource = dt;
        }
    }
}
