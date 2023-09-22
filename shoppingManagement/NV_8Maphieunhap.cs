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
    public partial class NV_8Maphieunhap : Form
    {
        public NV_8Maphieunhap(string user, string pass, string makh)
        {
            InitializeComponent();
            MaKH.TextName = makh;
            usertxt.TextName = user;
            passtxt.TextName = pass;
        }

        public void connection()
        {
            string connstr = "Data Source=(DESCRIPTION=" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = orcl)" + ")" +
            "); User Id=ttp; Password=123456Az";

            OracleConnection con = new OracleConnection(connstr);
            try
            {

                string sql = "Select MaPH from PHIEUNHAP  order by MaPH desc";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);


                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NV_8Maphieunhap_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=(DESCRIPTION=" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = orcl)" + ")" +
            "); User Id=ttp; Password=123456Az";

            OracleConnection con = new OracleConnection(connstr);
            OracleCommand cmdn = con.CreateCommand();
            cmdn.CommandType = CommandType.Text;

            try
            {
                string date = DateTime.UtcNow.ToString("dd-MM-yyyy");

                string sql = "INSERT INTO PHIEUNHAP (MaPH, MaNV, NgNSP, TongNSP) values " +
                    "('" + MaHD.TextName + "', '" + usertxt.TextName + "' " + ", TO_DATE('" + date + "', 'dd/mm/yyyy'), 0)";
                OracleCommand cmd = new OracleCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã tạo phiếu thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from PHIEUNHAP order by MaNV", con);
                DataTable dt = new DataTable();

                adapter.Fill(dt);


                dataGridView1.DataSource = dt;

                this.Hide();
                NV_9Phieunhap f3 = new NV_9Phieunhap(usertxt.TextName, passtxt.TextName, MaKH.TextName, MaHD.TextName);
                f3.ShowDialog();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV_Menu f = new NV_Menu(usertxt.TextName,passtxt.TextName);
            f.ShowDialog();
        }

        //private void quayve_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    NV_7Doitac f3 = new NV_7Doitac(usertxt.TextName, passtxt.TextName);
        //    f3.ShowDialog();
        //}
    }
}
