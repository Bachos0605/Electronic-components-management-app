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
    public partial class Login_Admin : Form
    {
        public Login_Admin()
        {
            InitializeComponent();
        }

        private void Login_Admin_Load(object sender, EventArgs e)
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
                OracleDataAdapter adapter = new OracleDataAdapter("Select count(*) from TAIKHOAN join NHANVIEN using (MaNV) where TENTK='" + txtUsername.TextName + "' and MATKHAU='" + txtPassword.TextName + "' and MaQL='QL'", connstr);
                DataTable data = new DataTable();
                adapter.Fill(data);

                if (data.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Admin_Menu f4 = new Admin_Menu();
                    f4.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Xin hãy kiểm tra lại tên đăng nhập và mật khẩu!");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có vấn đề về kết nối: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
