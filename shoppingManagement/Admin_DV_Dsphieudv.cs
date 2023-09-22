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
    public partial class Admin_DV_Dsphieudv : Form
    {
        public Admin_DV_Dsphieudv()
        {
            InitializeComponent();
        }

        private void Admin_DV_Dsphieudv_Load(object sender, EventArgs e)
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
                //string m = cthang.Text;

               danhsachphieudv sr = new danhsachphieudv();

                string sql = "Select * from PHIEUDV";

                DataSet s1 = new DataSet();

                OracleDataAdapter adapter1 = new OracleDataAdapter(sql, con);


                adapter1.Fill(s1, "HOADON");
                DataTable dt = s1.Tables["HOADON"];
                sr.SetDataSource(s1.Tables["HOADON"]);
                crystalReportViewer1.ReportSource = sr;
                crystalReportViewer1.Refresh();


                /*
                dichvu sr1 = new dichvu();
                //sr1.SetDataSource(s1.Tables["table1"]);
                sr1.SetDataSource(s1.DataSet);
                crystalReportViewer2.ReportSource = sr1;
                crystalReportViewer2.Refresh(); */
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
            Admin_Phieudichvu f5 = new Admin_Phieudichvu();
            f5.ShowDialog();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
