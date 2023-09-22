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
    public partial class NV_3Sanpham : Form
    {
        private double grandTotal = 0;
        private double grandTotalGoc = 0;
        private double itemTotal = 0;
        public NV_3Sanpham(string user, string pass, string makh, string mahd)
        {
            InitializeComponent();
            txtuser.TextName = user;
            txtpass.TextName = pass;
            MaKH.TextName = makh;
            MaHD.TextName = mahd;
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

                string sql = "Select * from SANPHAM  order by MaSP";
                string sql1 = "select * from KHUYENMAI order by MaKM";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);
                OracleDataAdapter adapter1 = new OracleDataAdapter(sql1, con);


                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                dataGridView3.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NV_Sanpham_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void themsp_Click(object sender, EventArgs e)
        {
            String MaSP = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            //String MaVL = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            //String MaDT = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            String TenSP = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //String DVT = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            String SLTon = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            String DonGia = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            String quantity = SLsanpham.TextName;

            

            if ( double.Parse(quantity) <= double.Parse(SLTon))
            {
                double total = (Double.Parse(DonGia) * Double.Parse(quantity));

                grandTotal = grandTotal + total;
                grandTotalGoc += total;

                dataGridView2.Rows.Add(MaSP, TenSP, DonGia, quantity, total.ToString());

                label4.Text = grandTotal.ToString();

                string connstr = "Data Source=(DESCRIPTION=" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = orcl)" + ")" +
                "); User Id=ttp; Password=123456Az";

                OracleConnection con = new OracleConnection(connstr);

                try
                {
                    con.Open();
                    OracleTransaction transaction = con.BeginTransaction(IsolationLevel.Serializable);
                    OracleCommand command = con.CreateCommand();
                    command.Transaction = transaction;

                    command.CommandText = "insert into cthd (MaSP, MaHD, SoLuongSP, TienSP) values ('"
                        + MaSP + "', '" + MaHD.TextName + "', " + quantity + ", " + total + ")";
                    itemTotal += double.Parse(quantity);

                    command.ExecuteNonQuery();

                    command.CommandText = "update HOADON SET SoLuongSP=" + itemTotal + ", TienChuaTru=" + grandTotalGoc + ", TongTien=" + grandTotal +
                        " where MaHD= '" + MaHD.TextName + "'";

                    command.ExecuteNonQuery();

                    double slht = double.Parse(SLTon) - double.Parse(quantity);

                    command.CommandText = "update SANPHAM SET SLTon=" + slht +
                        " where MaSP= '" + MaSP + "'";

                    command.ExecuteNonQuery();

                    transaction.Commit();



                    /*
                    OracleCommand cmd = new OracleCommand(sql, con);
                    OracleCommand cmd1 = new OracleCommand(sql1, con);
                    OracleCommand cmd2 = new OracleCommand(sql2, con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery(); */
                    //MessageBox.Show("Đã thêm sản phẩm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            else
            {
                MessageBox.Show("Số lượng hàng không đủ!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void lammoi_Click(object sender, EventArgs e)
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
                string sql = "DELETE (MaKM) FROM HOADON Where MaHD=" + "'" + MaHD.TextName + "'";
                string sql1 = "DELETE FROM cthd Where MaHD=" + "'" + MaHD.TextName + "'";
                string sql2 = "update HOADON SET SoLuongSP=" + 0 + ", TienChuaTru=" + 0 + ", TongTien=" + 0 +
                    " where MaHD= '" + MaHD.TextName + "'";

                OracleCommand cmd = new OracleCommand(sql, con);
                OracleCommand cmd1 = new OracleCommand(sql1, con);
                OracleCommand cmd2 = new OracleCommand(sql2, con);

                con.Open();

                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                //MessageBox.Show("Xóa sản phẩm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
            this.Hide();
            NV_3Sanpham f2 = new NV_3Sanpham(txtuser.TextName, txtpass.TextName, MaKH.TextName, MaHD.TextName);
            f2.ShowDialog();
        }

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV_2Mahoadon f2 = new NV_2Mahoadon(txtuser.TextName, txtpass.TextName, MaKH.TextName);
            f2.ShowDialog();
        }

        private void themkm_Click(object sender, EventArgs e)
        {
            String MaKM = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();

            String TenKM = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();

            String TienKM = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();

            //double total = Double.Parse(TienKM);

            grandTotal = grandTotal - Int32.Parse(TienKM);

            dataGridView4.Rows.Add(MaKM, TenKM, TienKM);

            label4.Text = grandTotal.ToString();

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

                string sql = "update HOADON set  MaKM='" + MaKM + "', TienKM=" + TienKM + ", TongTien=" + grandTotal + " where MaHD='" + MaHD.TextName + "'";

                OracleCommand cmd = new OracleCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();
                //MessageBox.Show("Đã thêm sản phẩm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void timkiem_Click(object sender, EventArgs e)
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

                string sql = "Select * from SANPHAM where MaSP=UPPER('" + TraCuu.TextName + "') order by MaSP";
                string sql1 = "Select * from SANPHAM where TenSP=UPPER('" + TraCuu.TextName + "') order by MaSP";
                //string sql2 = "Select * from DOITAC where MaDT=UPPER('" + TraCuu.TextName + "') order by MaDT";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);
                OracleDataAdapter adapter1 = new OracleDataAdapter(sql1, con);
                //OracleDataAdapter adapter2 = new OracleDataAdapter(sql2, con);

                if (LoaiTimKiem.Text == "MaSP")
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    if (LoaiTimKiem.Text == "TenSP")
                    {
                        DataTable dt1 = new DataTable();
                        adapter1.Fill(dt1);
                        dataGridView2.DataSource = dt1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tieptuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV_3 f2 = new NV_3(txtuser.TextName, txtpass.TextName, MaKH.TextName, MaHD.TextName);
            f2.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// nhập hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Nhaphang f4 = new Admin_Nhaphang();
            f4.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
