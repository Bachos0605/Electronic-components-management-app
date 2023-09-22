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
    public partial class NV_5Maphieudichvu : Form
    {
        public NV_5Maphieudichvu(string user, string pass, string makh)
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

                string sql = "Select MaPDV from PHIEUDV order by MaPDV desc";

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

        private void NV_5Maphieudichvu_Load(object sender, EventArgs e)
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

                string sql = "INSERT INTO PHIEUDV (MaPDV, MaNV, MaKH, NgayLap, SoLuongDV, TongTien, ThanhToanTruoc, TienConLai, TinhTrang) values " +
                    "('" + MaHD.TextName + "', '" + usertxt.TextName + "', '" + MaKH.TextName + "', TO_DATE('" + date + "', 'dd/mm/yyyy'), 0, 0, 0, 0, 'Da Giao')";
                
                OracleCommand cmd = new OracleCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã tạo phiếu dịch vụ thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from PHIEUDV order by MaPDV", con);
                DataTable dt = new DataTable();

                adapter.Fill(dt);


                dataGridView1.DataSource = dt;

                this.Hide();
                NV_6Dichvu f3 = new NV_6Dichvu(usertxt.TextName, passtxt.TextName, MaKH.TextName, MaHD.TextName);
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
            NV_4Khachhang f3 = new NV_4Khachhang(usertxt.TextName, passtxt.TextName);
            f3.ShowDialog();
        }
    }
}
