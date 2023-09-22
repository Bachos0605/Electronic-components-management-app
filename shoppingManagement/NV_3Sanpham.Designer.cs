
namespace shoppingManagement
{
    partial class NV_3Sanpham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NV_3Sanpham));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLsanpham = new JMaterialTextbox.JMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new JMaterialTextbox.JMaterialTextbox();
            this.txtuser = new JMaterialTextbox.JMaterialTextbox();
            this.txtpass = new JMaterialTextbox.JMaterialTextbox();
            this.MaHD = new JMaterialTextbox.JMaterialTextbox();
            this.quayve = new ePOSOne.btnProduct.Button_WOC();
            this.lammoi = new ePOSOne.btnProduct.Button_WOC();
            this.themkm = new ePOSOne.btnProduct.Button_WOC();
            this.tieptuc = new ePOSOne.btnProduct.Button_WOC();
            this.themsp = new ePOSOne.btnProduct.Button_WOC();
            this.timkiem = new ePOSOne.btnProduct.Button_WOC();
            this.TraCuu = new JMaterialTextbox.JMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.LoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            //this.DVT,
            this.DonGia,
            this.TongCong,
            this.ThanhTien});
            this.dataGridView2.Location = new System.Drawing.Point(358, 344);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(647, 203);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "TenSP";
            this.TenSP.Name = "TenSP";
            // 
            // DVT
            //// 
            //this.DVT.HeaderText = "DVT";
            //this.DVT.Name = "DVT";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.Name = "DonGia";
            // 
            // TongCong
            // 
            this.TongCong.HeaderText = "TongCong";
            this.TongCong.Name = "TongCong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // SLsanpham
            // 
            this.SLsanpham.BackColor = System.Drawing.Color.Transparent;
            this.SLsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SLsanpham.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SLsanpham.ForeColors = System.Drawing.Color.Black;
            this.SLsanpham.HintText = null;
            this.SLsanpham.IsPassword = false;
            this.SLsanpham.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SLsanpham.LineThickness = 2;
            this.SLsanpham.Location = new System.Drawing.Point(774, 285);
            this.SLsanpham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SLsanpham.MaxLength = 32767;
            this.SLsanpham.Name = "SLsanpham";
            this.SLsanpham.OnFocusedColor = System.Drawing.Color.Black;
            this.SLsanpham.OnFocusedTextColor = System.Drawing.Color.Black;
            this.SLsanpham.ReadOnly = false;
            this.SLsanpham.Size = new System.Drawing.Size(79, 23);
            this.SLsanpham.TabIndex = 58;
            this.SLsanpham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SLsanpham.TextName = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(654, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(628, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "TỔNG CỘNG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(802, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "0 vnđ";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 85);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(268, 169);
            this.dataGridView3.TabIndex = 72;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKM,
            this.TenKM,
            this.TienKM});
            this.dataGridView4.Location = new System.Drawing.Point(12, 344);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(340, 203);
            this.dataGridView4.TabIndex = 73;
            // 
            // MaKM
            // 
            this.MaKM.HeaderText = "MaKM";
            this.MaKM.Name = "MaKM";
            // 
            // TenKM
            // 
            this.TenKM.HeaderText = "TenKM";
            this.TenKM.Name = "TenKM";
            // 
            // TienKM
            // 
            this.TienKM.HeaderText = "TienKM";
            this.TienKM.Name = "TienKM";
            // 
            // MaKH
            // 
            this.MaKH.BackColor = System.Drawing.Color.Transparent;
            this.MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MaKH.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MaKH.ForeColors = System.Drawing.Color.Transparent;
            this.MaKH.HintText = null;
            this.MaKH.IsPassword = false;
            this.MaKH.LineBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaKH.LineThickness = 2;
            this.MaKH.Location = new System.Drawing.Point(13, 590);
            this.MaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaKH.MaxLength = 32767;
            this.MaKH.Name = "MaKH";
            this.MaKH.OnFocusedColor = System.Drawing.Color.Black;
            this.MaKH.OnFocusedTextColor = System.Drawing.Color.Black;
            this.MaKH.ReadOnly = false;
            this.MaKH.Size = new System.Drawing.Size(10, 10);
            this.MaKH.TabIndex = 181;
            this.MaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaKH.TextName = "";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.Transparent;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtuser.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtuser.ForeColors = System.Drawing.Color.Transparent;
            this.txtuser.HintText = null;
            this.txtuser.IsPassword = false;
            this.txtuser.LineBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtuser.LineThickness = 2;
            this.txtuser.Location = new System.Drawing.Point(31, 590);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtuser.MaxLength = 32767;
            this.txtuser.Name = "txtuser";
            this.txtuser.OnFocusedColor = System.Drawing.Color.Black;
            this.txtuser.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtuser.ReadOnly = false;
            this.txtuser.Size = new System.Drawing.Size(10, 10);
            this.txtuser.TabIndex = 182;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtuser.TextName = "";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Transparent;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtpass.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtpass.ForeColors = System.Drawing.Color.Transparent;
            this.txtpass.HintText = null;
            this.txtpass.IsPassword = false;
            this.txtpass.LineBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtpass.LineThickness = 2;
            this.txtpass.Location = new System.Drawing.Point(31, 599);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.MaxLength = 32767;
            this.txtpass.Name = "txtpass";
            this.txtpass.OnFocusedColor = System.Drawing.Color.Black;
            this.txtpass.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtpass.ReadOnly = false;
            this.txtpass.Size = new System.Drawing.Size(10, 10);
            this.txtpass.TabIndex = 183;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpass.TextName = "";
            // 
            // MaHD
            // 
            this.MaHD.BackColor = System.Drawing.Color.Transparent;
            this.MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MaHD.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MaHD.ForeColors = System.Drawing.Color.Transparent;
            this.MaHD.HintText = null;
            this.MaHD.IsPassword = false;
            this.MaHD.LineBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaHD.LineThickness = 2;
            this.MaHD.Location = new System.Drawing.Point(31, 609);
            this.MaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaHD.MaxLength = 32767;
            this.MaHD.Name = "MaHD";
            this.MaHD.OnFocusedColor = System.Drawing.Color.Black;
            this.MaHD.OnFocusedTextColor = System.Drawing.Color.Black;
            this.MaHD.ReadOnly = false;
            this.MaHD.Size = new System.Drawing.Size(10, 10);
            this.MaHD.TabIndex = 184;
            this.MaHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaHD.TextName = "";
            // 
            // quayve
            // 
            this.quayve.BorderColor = System.Drawing.Color.Black;
            this.quayve.ButtonColor = System.Drawing.Color.White;
            this.quayve.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.quayve.FlatAppearance.BorderSize = 0;
            this.quayve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.quayve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quayve.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayve.Location = new System.Drawing.Point(12, 20);
            this.quayve.Name = "quayve";
            this.quayve.OnHoverBorderColor = System.Drawing.Color.Black;
            this.quayve.OnHoverButtonColor = System.Drawing.Color.Black;
            this.quayve.OnHoverTextColor = System.Drawing.Color.White;
            this.quayve.Size = new System.Drawing.Size(76, 36);
            this.quayve.TabIndex = 185;
            this.quayve.Text = "<<";
            this.quayve.TextColor = System.Drawing.Color.Black;
            this.quayve.UseVisualStyleBackColor = true;
            this.quayve.Click += new System.EventHandler(this.quayve_Click);
            // 
            // lammoi
            // 
            this.lammoi.BorderColor = System.Drawing.Color.Black;
            this.lammoi.ButtonColor = System.Drawing.Color.White;
            this.lammoi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lammoi.FlatAppearance.BorderSize = 0;
            this.lammoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lammoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lammoi.Location = new System.Drawing.Point(838, 11);
            this.lammoi.Name = "lammoi";
            this.lammoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lammoi.OnHoverButtonColor = System.Drawing.Color.Black;
            this.lammoi.OnHoverTextColor = System.Drawing.Color.White;
            this.lammoi.Size = new System.Drawing.Size(58, 38);
            this.lammoi.TabIndex = 75;
            this.lammoi.TextColor = System.Drawing.Color.Black;
            this.lammoi.UseVisualStyleBackColor = true;
            this.lammoi.Click += new System.EventHandler(this.lammoi_Click);
            // 
            // themkm
            // 
            this.themkm.BorderColor = System.Drawing.Color.Black;
            this.themkm.ButtonColor = System.Drawing.Color.White;
            this.themkm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.themkm.FlatAppearance.BorderSize = 0;
            this.themkm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.themkm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themkm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themkm.Location = new System.Drawing.Point(149, 275);
            this.themkm.Name = "themkm";
            this.themkm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.themkm.OnHoverButtonColor = System.Drawing.Color.Black;
            this.themkm.OnHoverTextColor = System.Drawing.Color.White;
            this.themkm.Size = new System.Drawing.Size(131, 39);
            this.themkm.TabIndex = 74;
            this.themkm.Text = "Thêm khuyến mãi";
            this.themkm.TextColor = System.Drawing.Color.Black;
            this.themkm.UseVisualStyleBackColor = true;
            this.themkm.Click += new System.EventHandler(this.themkm_Click);
            // 
            // tieptuc
            // 
            this.tieptuc.BackColor = System.Drawing.Color.White;
            this.tieptuc.BorderColor = System.Drawing.Color.Black;
            this.tieptuc.ButtonColor = System.Drawing.Color.Black;
            this.tieptuc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tieptuc.FlatAppearance.BorderSize = 0;
            this.tieptuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.tieptuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tieptuc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieptuc.Location = new System.Drawing.Point(877, 555);
            this.tieptuc.Name = "tieptuc";
            this.tieptuc.OnHoverBorderColor = System.Drawing.Color.Black;
            this.tieptuc.OnHoverButtonColor = System.Drawing.Color.White;
            this.tieptuc.OnHoverTextColor = System.Drawing.Color.Black;
            this.tieptuc.Size = new System.Drawing.Size(119, 36);
            this.tieptuc.TabIndex = 71;
            this.tieptuc.Text = "Tạo Hóa Đơn";
            this.tieptuc.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tieptuc.UseVisualStyleBackColor = false;
            this.tieptuc.Click += new System.EventHandler(this.tieptuc_Click);
            // 
            // themsp
            // 
            this.themsp.BorderColor = System.Drawing.Color.Black;
            this.themsp.ButtonColor = System.Drawing.Color.White;
            this.themsp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.themsp.FlatAppearance.BorderSize = 0;
            this.themsp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.themsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themsp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themsp.Location = new System.Drawing.Point(873, 275);
            this.themsp.Name = "themsp";
            this.themsp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.themsp.OnHoverButtonColor = System.Drawing.Color.Black;
            this.themsp.OnHoverTextColor = System.Drawing.Color.White;
            this.themsp.Size = new System.Drawing.Size(123, 39);
            this.themsp.TabIndex = 52;
            this.themsp.Text = "Thêm sản phẩm";
            this.themsp.TextColor = System.Drawing.Color.Black;
            this.themsp.UseVisualStyleBackColor = true;
            this.themsp.Click += new System.EventHandler(this.themsp_Click);
            // 
            // timkiem
            // 
            this.timkiem.BackColor = System.Drawing.Color.White;
            this.timkiem.BorderColor = System.Drawing.Color.Black;
            this.timkiem.ButtonColor = System.Drawing.Color.White;
            this.timkiem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.timkiem.FlatAppearance.BorderSize = 0;
            this.timkiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timkiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.Location = new System.Drawing.Point(774, 11);
            this.timkiem.Name = "timkiem";
            this.timkiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.timkiem.OnHoverButtonColor = System.Drawing.Color.White;
            this.timkiem.OnHoverTextColor = System.Drawing.Color.Black;
            this.timkiem.Size = new System.Drawing.Size(58, 38);
            this.timkiem.TabIndex = 190;
            this.timkiem.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timkiem.UseVisualStyleBackColor = false;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // TraCuu
            // 
            this.TraCuu.BackColor = System.Drawing.Color.Transparent;
            this.TraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TraCuu.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TraCuu.ForeColors = System.Drawing.Color.Black;
            this.TraCuu.HintText = null;
            this.TraCuu.IsPassword = false;
            this.TraCuu.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TraCuu.LineThickness = 2;
            this.TraCuu.Location = new System.Drawing.Point(486, 22);
            this.TraCuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TraCuu.MaxLength = 32767;
            this.TraCuu.Name = "TraCuu";
            this.TraCuu.OnFocusedColor = System.Drawing.Color.Black;
            this.TraCuu.OnFocusedTextColor = System.Drawing.Color.Black;
            this.TraCuu.ReadOnly = false;
            this.TraCuu.Size = new System.Drawing.Size(255, 23);
            this.TraCuu.TabIndex = 189;
            this.TraCuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TraCuu.TextName = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(359, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 19);
            this.label11.TabIndex = 188;
            this.label11.Text = "Nhập từ khóa:";
            // 
            // LoaiTimKiem
            // 
            this.LoaiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoaiTimKiem.FormattingEnabled = true;
            this.LoaiTimKiem.Items.AddRange(new object[] {
            "MaSP",
            "TenSP"});
            this.LoaiTimKiem.Location = new System.Drawing.Point(244, 21);
            this.LoaiTimKiem.Name = "LoaiTimKiem";
            this.LoaiTimKiem.Size = new System.Drawing.Size(92, 21);
            this.LoaiTimKiem.TabIndex = 187;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 186;
            this.label6.Text = "Tìm kiếm theo:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(857, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 192;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(794, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 191;
            this.pictureBox1.TabStop = false;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Black;
            this.button_WOC1.ButtonColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(908, 11);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(97, 38);
            this.button_WOC1.TabIndex = 193;
            this.button_WOC1.Text = "Nhập hàng";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // NV_3Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1017, 632);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.TraCuu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LoaiTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quayve);
            this.Controls.Add(this.MaHD);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.MaKH);
            this.Controls.Add(this.lammoi);
            this.Controls.Add(this.themkm);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.tieptuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SLsanpham);
            this.Controls.Add(this.themsp);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NV_3Sanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Sản Phẩm";
            this.Load += new System.EventHandler(this.NV_Sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ePOSOne.btnProduct.Button_WOC themsp;
        private JMaterialTextbox.JMaterialTextbox SLsanpham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private ePOSOne.btnProduct.Button_WOC tieptuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVL;
        //private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        //private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private ePOSOne.btnProduct.Button_WOC themkm;
        private ePOSOne.btnProduct.Button_WOC lammoi;
        private JMaterialTextbox.JMaterialTextbox MaKH;
        private JMaterialTextbox.JMaterialTextbox txtuser;
        private JMaterialTextbox.JMaterialTextbox txtpass;
        private JMaterialTextbox.JMaterialTextbox MaHD;
        private ePOSOne.btnProduct.Button_WOC quayve;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienKM;
        private ePOSOne.btnProduct.Button_WOC timkiem;
        private JMaterialTextbox.JMaterialTextbox TraCuu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox LoaiTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}