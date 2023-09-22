using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.IO;
using System.Threading;

namespace shoppingManagement
{
    public partial class Admin_Khuyenmai : Form
    {
        public Admin_Khuyenmai()
        {
            InitializeComponent();
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

                string sql = "Select * from KHUYENMAI  order by MaKM";

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

        private void Admin_Khuyenmai_Load(object sender, EventArgs e)
        {
            connection();
        }

        public void RunOracleTransaction(string connectionString)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                OracleCommand command = connection.CreateCommand();
                OracleTransaction transaction;

                // Start a local transaction
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                // Assign transaction object for a pending local transaction
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "INSERT INTO Dept (DeptNo, Dname, Loc) values (50, 'TECHNOLOGY', 'DENVER')";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "INSERT INTO Dept (DeptNo, Dname, Loc) values (60, 'ENGINEERING', 'KANSAS CITY')";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("Neither record was written to database.");
                }
            }
        }

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Menu f4 = new Admin_Menu();
            f4.ShowDialog();
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

                string sql = "INSERT INTO KHUYENMAI (MaKM, TenKM, TienKM) values " +
                    "('" + MaKM.TextName + "','" + TenKM.TextName + "'," + TienKM.TextName + ")";
                OracleCommand cmd = new OracleCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm khuyến mãi thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from KHUYENMAI order by MaKM", con);
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
                    string sql = "DELETE FROM KHUYENMAI Where MaKM=" + "'" + MaKM.TextName + "'";
                    OracleCommand cmd = new OracleCommand(sql, con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa khuyến mãi thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OracleDataAdapter adapter = new OracleDataAdapter("select * from KHUYENMAI order by MaKM", con);
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
                     con.Open();
                     OracleTransaction transaction = con.BeginTransaction(IsolationLevel.Serializable);
                     OracleCommand command = con.CreateCommand();
                     command.Transaction = transaction;

                    /*string sql = "update KHUYENMAI" +
                         " SET " + "TenKM= '" + TenKM.TextName + "', TienKM=" + TienKM.TextName + 
                        " where MaKM ='" + MaKM.TextName + "'";*/

                    command.CommandText = "update KHUYENMAI" +
                         " SET " + "TenKM= '" + TenKM.TextName + "', TienKM=" + TienKM.TextName +
                        " where MaKM ='" + MaKM.TextName + "'";

                    command.ExecuteNonQuery();

                    OracleDataAdapter adapter = new OracleDataAdapter(command.CommandText, con);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    Thread.Sleep(10000);

                    transaction.Commit();

                    command.CommandText = "update KHUYENMAI" +
                         " SET " + "TenKM= '" + TenKM.TextName + "', TienKM=" + TienKM.TextName +
                        " where MaKM ='" + MaKM.TextName + "'";
                    command.ExecuteNonQuery();
                    /*OracleCommand cmd = new OracleCommand(sql, con);*/

                    /*con.Open();*/


                    MessageBox.Show("Cập nhật khuyến mãi thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /*OracleDataAdapter adapter = new OracleDataAdapter("select * from KHUYENMAI order by MaKM", con);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);


                    dataGridView1.DataSource = dt;*/
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

        private void lammoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Khuyenmai f8 = new Admin_Khuyenmai();
            f8.ShowDialog();
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

                string sql = "Select * from KHUYENMAI where MaKM='" + TraCuu.TextName + "' order by MaKM";
                string sql1 = "Select * from KHUYENMAI where TenKM='" + TraCuu.TextName + "' order by MaKM";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);
                OracleDataAdapter adapter1 = new OracleDataAdapter(sql1, con);

                if (LoaiTimKiem.Text == "MaKM")
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    if (LoaiTimKiem.Text == "TenKM")
                    {
                        DataTable dt1 = new DataTable();
                        adapter1.Fill(dt1);
                        dataGridView1.DataSource = dt1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            MaKM.TextName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            TenKM.TextName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            TienKM.TextName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
