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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace shoppingManagement
{
    public partial class Re_hoadon : Form
    {
        public Re_hoadon()
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
                // string m = cthang.Text;

                /*
                dichvu sr1 = new dichvu();
                //sr1.SetDataSource(s1.Tables["table1"]);
                sr1.SetDataSource(s1.DataSet);
                crystalReportViewer2.ReportSource = sr1;
                crystalReportViewer2.Refresh(); */


                /*
                ReportDocument report = new ReportDocument();
                report.Load("E:/C#/Computer-Shop-Management-master/shoppingManagement/hoadon.rpt");


                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                crConnectionInfo.ServerName = "localhost";
                crConnectionInfo.DatabaseName = "orcl";
                crConnectionInfo.UserID = "ttp";
                crConnectionInfo.Password = "123456Az";
                TableLogOnInfo crTableLogoninfo = new TableLogOnInfo();

                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in report.Database.Tables)
                {
                    crTableLogoninfo = CrTable.LogOnInfo;
                    crTableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crTableLogoninfo);
                }
                foreach (ReportDocument subreport in report.Subreports)
                {
                    foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in subreport.Database.Tables)
                    {
                        crTableLogoninfo = CrTable.LogOnInfo;
                        crTableLogoninfo.ConnectionInfo = crConnectionInfo;
                        CrTable.ApplyLogOnInfo(crTableLogoninfo);
                    }
                }
                crystalReportViewer2.ReportSource = report;
                */

                string c = MaHD.TextName;

                hoadon sr = new hoadon();

                string sql = "Select * from HOADON where MaHD = '" + c + "'";

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

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Menu f4 = new Admin_Menu();
            f4.ShowDialog();
        }
    }
}
