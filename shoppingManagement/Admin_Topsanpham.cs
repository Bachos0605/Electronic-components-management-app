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
using System.IO;

namespace shoppingManagement
{
    public partial class Admin_Topsanpham : Form
    {
        public Admin_Topsanpham()
        {
            InitializeComponent();
        }

        private void lapbc_Click(object sender, EventArgs e)
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


                topsanpham sr = new topsanpham();

                string sql = "select * FROM(select  s.MASP, TenSP, h.ThoiGianLap from CTHD c, SANPHAM s, HOADON h where h.MAHD = c.MAHD and c.MASP = s.MASP and extract(month from thoigianlap) = '07' and extract(year from thoigianlap) = '2021' group by s.MASP, TenSP, h.ThoiGianLap, extract(month from thoigianlap), extract(year from thoigianlap) order by sum(c.SOLUONGSP) DESC) WHERE ROWNUM <= 3";


                DataSet s1 = new DataSet();

                OracleDataAdapter adapter1 = new OracleDataAdapter(sql, con);


                adapter1.Fill(s1, "HOADON");
                DataTable dt = s1.Tables["HOADON"];
                sr.SetDataSource(s1.Tables["HOADON"]);
                crystalReportViewer2.ReportSource = sr;
                crystalReportViewer2.Refresh();
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

        private void Admin_Topsanpham_Load(object sender, EventArgs e)
        {

        }
    }
}
