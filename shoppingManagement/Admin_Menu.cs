using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingManagement
{
    public partial class Admin_Menu : Form
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void qlsanpham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Sanpham f2 = new Admin_Sanpham();
            f2.ShowDialog();
        }

        

        private void qldichvu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dichvu f5 = new Admin_Dichvu();
            f5.ShowDialog();
        }

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Admin f5 = new Login_Admin();
            f5.ShowDialog();
        }

        private void qlkhuyenmai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Khuyenmai f8 = new Admin_Khuyenmai();
            f8.ShowDialog();
        }

        private void qlnhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Nhanvien f1 = new Admin_Nhanvien();
            f1.ShowDialog();
        }

       

        private void qlkhachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Khachhang f4 = new Admin_Khachhang();
            f4.ShowDialog();
        }

        private void tkdoanhthu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Thongkedoanhthu f4 = new Admin_Thongkedoanhthu();
            f4.ShowDialog();
        }

        private void qlnhaphang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Nhaphang f4 = new Admin_Nhaphang();
            f4.ShowDialog();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Re_hoadon f4 = new Re_hoadon();
            f4.ShowDialog();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            
        }

        private void qlhoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Hoadon f4 = new Admin_Hoadon();
            f4.ShowDialog();
        }

        private void qlphieudv_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Phieudichvu f4 = new Admin_Phieudichvu();
            f4.ShowDialog();
        }

        private void qltonkho_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Tonkho f4 = new Admin_Tonkho();
            f4.ShowDialog();
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Tonkho f4 = new Admin_Tonkho();
            f4.ShowDialog();
        }

        private void button_WOC1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Tonkho f4 = new Admin_Tonkho();
            f4.ShowDialog();
        }

        private void button_WOC1_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Tonkho f4 = new Admin_Tonkho();
            f4.ShowDialog();
        }

        private void button_WOC1_Click_4(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Tonkho f4 = new Admin_Tonkho();
            f4.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
