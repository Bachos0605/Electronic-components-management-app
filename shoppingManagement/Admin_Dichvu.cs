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
    public partial class Admin_Dichvu : Form
    {
        public Admin_Dichvu()
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

                string sql = "Select * from DICHVU order by MaDV";

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

        private void Admin_Dichvu_Load(object sender, EventArgs e)
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
                transaction = connection.BeginTransaction(isolationLevel: IsolationLevel.ReadCommitted);
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


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            MaDV.TextName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            TenDV.TextName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            DonGia.TextName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
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

                con.Open();
                OracleTransaction transaction = con.BeginTransaction(IsolationLevel.Serializable);
                OracleCommand command = con.CreateCommand();

                command.Transaction = transaction;

                command.CommandText = "INSERT INTO DICHVU (MaDV, TenDV, TienDV) values " +
                    "(" + "'" + MaDV.TextName + "','" + TenDV.TextName + "'," + Int32.Parse(DonGia.TextName) + ")";
                command.ExecuteNonQuery();

                OracleDataAdapter adapter = new OracleDataAdapter(command.CommandText, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                Thread.Sleep(10000);
                transaction.Commit();
                
                command.CommandText = "INSERT INTO DICHVU (MaDV, TenDV, TienDV) values " +
                    "(" + "'" + MaDV.TextName + "','" + TenDV.TextName + "'," + Int32.Parse(DonGia.TextName) + ")";
                command.ExecuteNonQuery();
                MessageBox.Show("Đã thêm dịch vụ thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                    string sql = "DELETE FROM DICHVU Where Madv=" + "'" + MaDV.TextName + "'";
                    OracleCommand cmd = new OracleCommand(sql, con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa dịch vụ thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OracleDataAdapter adapter = new OracleDataAdapter("select * from DICHVU order by MaDV", con);
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
                    command.CommandText = "update DICHVU" +
                         " SET " + "TenDV= '" + TenDV.TextName + "', TienDV=" + Int32.Parse(DonGia.TextName) +
                        " where MaDV ='" + MaDV.TextName + "'";
                    command.ExecuteNonQuery();
                    /*OracleCommand cmd = new OracleCommand(sql, con);

                    con.Open();*/
                    OracleDataAdapter adapter = new OracleDataAdapter(command.CommandText, con);

                    /*cmd.ExecuteNonQuery();*/
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;


                    Thread.Sleep(millisecondsTimeout: 1000000);
                    transaction.Commit();

                    command.CommandText = "update DICHVU" +
                         " SET " + "TenDV= '" + TenDV.TextName + "', TienDV=" + Int32.Parse(DonGia.TextName) +
                        " where MaDV ='" + MaDV.TextName + "'";
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật dịch vụ thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    /*OracleDataAdapter adapter = new OracleDataAdapter("select * from DICHVU order by MaDV", con);
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
            Admin_Dichvu f5 = new Admin_Dichvu();
            f5.ShowDialog();
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

                
                

                if (LoaiTimKiem.Text == "MaDV")
                {
                    string sql = "Select * from DICHVU where MaDV=UPPER('" + TraCuu.TextName + "') order by MaDV";
                    
                    OracleDataAdapter adapter = new OracleDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {

                    string sql1 = "Select * from DICHVU WHERE TenDV LIKE '%"+ TraCuu.TextName + "%' order by TenDV";
                    OracleDataAdapter adapter1 = new OracleDataAdapter(sql1, con);
                    if (LoaiTimKiem.Text == "TenDV")
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
