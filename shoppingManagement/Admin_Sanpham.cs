using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.IO;
using System.Threading;

namespace shoppingManagement
{


    public partial class Admin_Sanpham : Form
    {

        public Admin_Sanpham()
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

                string sql = "Select * from SANPHAM  order by MaSP";
                string sql1 = "Select * from NGUYENVATLIEU  order by MaVL";
                string sql2 = "Select * from DOITAC  order by MaDT";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);
                OracleDataAdapter adapter1 = new OracleDataAdapter(sql1, con);
                OracleDataAdapter adapter2 = new OracleDataAdapter(sql2, con);


                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                //DataTable dt1 = new DataTable();
                //adapter1.Fill(dt1);
                //dataGridView2.DataSource = dt1;

                //DataTable dt2 = new DataTable();
                //adapter2.Fill(dt2);
                //dataGridView3.DataSource = dt2;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
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


        public void capnhatsanpham_Click(object sender, EventArgs e)
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

                    try
                    {
                        con.Open();
                        OracleTransaction transaction = con.BeginTransaction(IsolationLevel.Serializable);
                        OracleCommand command = con.CreateCommand();

                        // Start a local transaction
                        // Assign transaction object for a pending local transaction
                        command.Transaction = transaction;
                        
                        command.CommandText ="update SANPHAM" +
                             " SET "  +" TenSP='" + TenSP.TextName + "', SLTon=" + SLTon.TextName + ", DonGia=" + DonGia.TextName + "" +
                            " where MaSP ='" + MaSP.TextName + "'"; 
                        command.ExecuteNonQuery();

                        OracleDataAdapter adapter = new OracleDataAdapter(command.CommandText, con);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                        Thread.Sleep(10000);
                        transaction.Commit();

                        command.CommandText = "update SANPHAM" +
                             " SET " + " TenSP='" + TenSP.TextName + "', SLTon=" + SLTon.TextName + ", DonGia=" + DonGia.TextName + "" +
                            " where MaSP ='" + MaSP.TextName + "'";
                        command.ExecuteNonQuery();



                        
                        /*
                        string sql = "update SANPHAM" +
                             " SET " + "MaVL= '" + MaVL.Text + "', TenSP='" + TenSP.TextName + "', SLTon=" + SLTon.TextName + ", DonGia=" + DonGia.TextName + ", MaDT='" + MaDT.TextName + "', DVT='" + DVT.Text + "'" +
                            " where MaSP ='" + MaSP.TextName + "'";
                        OracleCommand cmd = new OracleCommand(sql, con);

                        con.Open();

                        cmd.ExecuteNonQuery();
                        */



                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       /* OracleDataAdapter adapter = new OracleDataAdapter("select * from SANPHAM order by MaSP", con);
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);


                        dataGridView1.DataSource = dt;
                        */
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

        


        private void commit_Click(object sender, EventArgs e)
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

                try
                {
                    con.Open();
                    OracleTransaction transaction = con.BeginTransaction(IsolationLevel.Serializable);
                    
                    OracleCommand command = con.CreateCommand();

                    // Start a local transaction
                    // Assign transaction object for a pending local transaction

                    command.Transaction = transaction;

                    command.CommandText = "update SANPHAM" +
                             " SET " +" TenSP='" + TenSP.TextName + "', SLTon='" + SLTon.TextName + "', DonGia='" + DonGia.TextName+"'"  +
                            " where MaSP ='" + MaSP.TextName + "'";
                    command.ExecuteNonQuery();

                    Thread.Sleep(10000);

                    transaction.Commit();

                    MessageBox.Show("Committed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OracleDataAdapter adapter = new OracleDataAdapter("select * from SANPHAM order by MaSP", con);
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //con.Close();
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
            MaSP.TextName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //MaVL.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            TenSP.TextName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //DVT.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            SLTon.TextName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            DonGia.TextName = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void themsanpham_Click(object sender, EventArgs e)
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

                //string sql = "INSERT INTO SANPHAM (MaSP, TenSP, DonGia, SLTon) values " +
                //    "(" + "'" +MaSP.TextName   + "'," + "'" + TenSP.TextName + "','" + Int32.Parse(DonGia.TextName) + "','" + Int32.Parse(SLTon.TextName) + "'"+ ")";
           
                string sql2 = "begin INSERTSP(" + "'" + MaSP.TextName + "','" + TenSP.TextName + "', " + Int32.Parse(DonGia.TextName) + ", " + Int32.Parse(SLTon.TextName) + "); end;";

                OracleCommand cmd = new OracleCommand(sql2, con);

                con.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm sản phẩm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from SANPHAM order by MaSP", con);
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

        

        private void xoasanpham_Click(object sender, EventArgs e)
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
                    string sql = "DELETE FROM SANPHAM Where MaSP=" + "'" + MaSP.TextName + "'";
                    OracleCommand cmd = new OracleCommand(sql, con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa sản phẩm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OracleDataAdapter adapter = new OracleDataAdapter("select * from SANPHAM order by MaSP", con);
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
            Admin_Sanpham f2 = new Admin_Sanpham();
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

                string sql = "Select * from SANPHAM where MaSP=UPPER('" + TraCuu.TextName + "') order by MaSP";
                string sql1 = "Select * from SANPHAM WHERE TenSP LIKE '%" + TraCuu.TextName + "%' order by TenSP";
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
                        dataGridView1.DataSource = dt1;
                    }
                    //if (LoaiTimKiem.Text == "MaVL")
                    //{
                    //    DataTable dt1 = new DataTable();
                    //    adapter1.Fill(dt1);
                    //    dataGridView2.DataSource = dt1;
                    //}
                    //else
                    //{
                    //    if (LoaiTimKiem.Text == "MaDT")
                    //    {
                    //        DataTable dt2 = new DataTable();
                    //        adapter2.Fill(dt2);
                    //        dataGridView3.DataSource = dt2;
                    //    }
                    //}
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

        private void refresh_Click(object sender, EventArgs e)
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

                try
                {
                    con.Open();
                    OracleTransaction transaction = con.BeginTransaction(IsolationLevel.Serializable);

                    OracleCommand command = con.CreateCommand();

                    // Start a local transaction
                    // Assign transaction object for a pending local transaction

                    command.Transaction = transaction;

                    command.CommandText ="Select * from SANPHAM  order by MaSP";

                    command.ExecuteNonQuery();

                    OracleDataAdapter adapter = new OracleDataAdapter(command.CommandText, con);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    Thread.Sleep(10000);

                    command.CommandText = "Select * from SANPHAM  order by MaSP";

                    command.ExecuteNonQuery();

                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;


                    MessageBox.Show("refresh", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //con.Close();
            }
        }

        private void MaVL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
