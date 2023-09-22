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
    public partial class Admin_Hoadon : Form
    {
        public Admin_Hoadon()
        {
            InitializeComponent();
        }

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Menu f4 = new Admin_Menu();
            f4.ShowDialog();
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

                string sql = "Select * from HOADON  order by MaHD";

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

        private void Admin_Hoadon_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtmahd.TextName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtmakm.TextName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtmanv.TextName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtmakh.TextName = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dLap.TextName = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtslsp.TextName = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txttongtien.TextName = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txttienkm.TextName = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtconlai.TextName = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtghichu.TextName = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    string sql = "DELETE FROM HOADON Where MaHD=" + "'" + txtmahd.TextName + "'";
                    OracleCommand cmd = new OracleCommand(sql, con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa hóa đơn thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OracleDataAdapter adapter = new OracleDataAdapter("select * from HOADON order by MaHD", con);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);


                    dataGridView1.DataSource = dt;
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
                MessageBox.Show("Dữ liệu chưa được xóa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void capnhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn cập nhật?", "Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    string sql = "update HOADON" +
                         " SET " + "MaNV= '" + txtmanv.TextName + "', MaKH='" + txtmakh.TextName + "', SoLuongSP=" + txtslsp.TextName + ", ThoiGianLap=" + "TO_DATE('" + dLap.TextName + "', 'dd/mm/yyyy hh:mi:ss AM')" + ", TienChuaTru=" + txttongtien.TextName + ", TienKM=" + txttienkm.TextName + ", TongTien=" + txtconlai.TextName + ", GhiChu= '" + txtghichu.TextName + "', MaKM='" + txtmakm.TextName + "' " +
                        " where MaHD ='" + txtmahd.TextName + "'";

                    /* string sql = "update NHANVIEN SET NgaySinh=" + "TO_DATE('" + dSinh.TextName + "','dd-mm-yyy')" + "where MaNV='" + MaNV.TextName + "'"; */
                    OracleCommand cmd = new OracleCommand(sql, con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật hóa đơn thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OracleDataAdapter adapter = new OracleDataAdapter("select * from HOADON order by MaHD", con);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);


                    dataGridView1.DataSource = dt;
                }

                catch (Exception ex)
                {
                    if (ex.Message.Contains("ORA-06512") && ex.Message.Contains("ORA-20000") && ex.Message.Contains("ORA-04088"))
                    {
                        MessageBox.Show("Ngày lập hóa đơn phải sau ngày vào làm của nhân viên!", "Ngày lập hóa đơn không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Lỗi #", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

                finally
                {
                    con.Close();
                }
            }

            else
            {
                MessageBox.Show("Dữ liệu chưa được cập nhật", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Hoadon f2 = new Admin_Hoadon();
            f2.ShowDialog();
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

                string sql = "Select * from HOADON where MaHD='" + TraCuu.TextName + "' order by MaHD";
                string sql1 = "Select * from HOADON where MaNV='" + TraCuu.TextName + "' order by MaHD";
                string sql2 = "Select * from HOADON where MaKH='" + TraCuu.TextName + "' order by MaHD";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);
                OracleDataAdapter adapter1 = new OracleDataAdapter(sql1, con);
                OracleDataAdapter adapter2 = new OracleDataAdapter(sql2, con);

                if (LoaiTimKiem.Text == "MaHD")
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    if (LoaiTimKiem.Text == "MaNV")
                    {
                        DataTable dt1 = new DataTable();
                        adapter1.Fill(dt1);
                        dataGridView1.DataSource = dt1;
                    }
                    else
                    {
                        if (LoaiTimKiem.Text == "MaKH")
                        {
                            DataTable dt2 = new DataTable();
                            adapter2.Fill(dt2);
                            dataGridView1.DataSource = dt2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoaiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
