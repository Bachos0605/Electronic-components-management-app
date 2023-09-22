using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace shoppingManagement
{
    public partial class Login_NV : Form
    {
        public Login_NV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=(DESCRIPTION=" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = orcl)" + ")" +
            "); User Id=ttp; Password=123456Az";

            try
            {
                OracleConnection con = new OracleConnection(connstr);
                OracleDataAdapter adapter = new OracleDataAdapter("Select count(*) from TAIKHOAN where TENTK='" + txtUsername.TextName + "' and MATKHAU='" + txtPassword.TextName + "' ", connstr);
                DataTable data = new DataTable();
                adapter.Fill(data);

                if (data.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    NV_Menu f4 = new NV_Menu(txtUsername.TextName, txtPassword.TextName);
                    f4.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Xin hãy kiểm tra lại tên đăng nhập và mật khẩu!");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có vấn đề về kết nối: "+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
