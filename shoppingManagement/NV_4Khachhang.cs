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
    public partial class NV_4Khachhang : Form
    {
        public NV_4Khachhang(string user, string pass)
        {
            InitializeComponent();
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

                string sql = "Select * from KHACHHANG  order by MaKH";

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

        private void NV_4Khachhang_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            MaKH.TextName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            TenKH.TextName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            GioiTinh.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Email.TextName = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            sdt.TextName = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //Diem.TextName = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            //Loai.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            dSinh.TextName = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
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

                string sql2 = "Begin Insertkh(" + "'" + MaKH.TextName + "','" + TenKH.TextName + "','" + GioiTinh.Text + "','" + Email.TextName + "'," + sdt.TextName + "" + "" + "," + " TO_DATE('" + dSinh.TextName + "','dd/mm/yyyy hh:mi:ss AM')" + "); end;";

                //string sql = "INSERT INTO KHACHHANG (MaKH, TenKH, GioiTinh, Email, SDT, NgSinh) values " +
                //    "(" + "'" + MaKH.TextName + "','" + TenKH.TextName + "','" + GioiTinh.Text + "','" + Email.TextName + "'," + sdt.TextName + ",'" + "','"  + "'," + " TO_DATE('" + dSinh.TextName + "','dd/mm/yyyy hh:mi:ss AM')" + ")";
                OracleCommand cmd = new OracleCommand(sql2, con);

                con.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm khách hàng thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from KHACHHANG order by MaKH", con);
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
                    string sql = "update KHACHHANG" +
                         " SET " + "TenKH= '" + TenKH.TextName + "', GioiTinh='" + GioiTinh.Text + "', Email='" + Email.TextName + "', NgSinh=" + "TO_DATE('" + dSinh.TextName + "', 'dd/mm/yyyy hh:mi:ss AM')" + ", SDT=" + sdt.TextName + ""  + "" + "" +
                        " where MaKH ='" + MaKH.TextName + "'";

                    /* string sql = "update NHANVIEN SET NgaySinh=" + "TO_DATE('" + dSinh.TextName + "','dd-mm-yyy')" + "where MaNV='" + MaNV.TextName + "'"; */
                    OracleCommand cmd = new OracleCommand(sql, con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OracleDataAdapter adapter = new OracleDataAdapter("select * from KHACHHANG order by MaKH", con);
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
                MessageBox.Show("Dữ liệu chưa được cập nhật", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    string sql = "DELETE FROM KHACHHANG Where MaKH=" + "'" + MaKH.TextName + "'";
                    OracleCommand cmd = new OracleCommand(sql, con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa khách hàng thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OracleDataAdapter adapter = new OracleDataAdapter("select * from KHACHHANG order by MaKH", con);
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

        private void lammoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV_4Khachhang f2 = new NV_4Khachhang(usertxt.TextName, passtxt.TextName);
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

                string sql = "Select * from KHACHHANG where TenKH='" + TraCuu.TextName + "' order by MaKH";
                string sql1 = "Select * from KHACHHANG where MaKH='" + TraCuu.TextName + "' order by MaKH";
                string sql2 = "Select * from KHACHHANG where SDT='" + TraCuu.TextName + "' order by MaKH";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);
                OracleDataAdapter adapter1 = new OracleDataAdapter(sql1, con);
                OracleDataAdapter adapter2 = new OracleDataAdapter(sql2, con);

                if (LoaiTimKiem.Text == "TenKH")
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    if (LoaiTimKiem.Text == "MaKH")
                    {
                        DataTable dt1 = new DataTable();
                        adapter1.Fill(dt1);
                        dataGridView1.DataSource = dt1;
                    }
                    else
                    {
                        if (LoaiTimKiem.Text == "SDT")
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

        private void tieptuc_Click(object sender, EventArgs e)
        {
            if (MaKH.TextName == null)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Chưa chọn khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            else
            {
                

                this.Hide();
                NV_5Maphieudichvu f3 = new NV_5Maphieudichvu(usertxt.TextName, passtxt.TextName, MaKH.TextName);
                f3.ShowDialog();
            }
        }

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV_Menu f3 = new NV_Menu(usertxt.TextName, passtxt.TextName);
            f3.ShowDialog();
        }
    }
}
