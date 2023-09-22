using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void quanly_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Admin f2 = new Login_Admin();
            f2.ShowDialog();
        }

        private void nhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_NV f3 = new Login_NV();
            f3.ShowDialog();
        }
    }
}
