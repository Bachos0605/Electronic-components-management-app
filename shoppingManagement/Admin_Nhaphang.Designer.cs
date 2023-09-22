
namespace shoppingManagement
{
    partial class Admin_Nhaphang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Nhaphang));
            this.timkiem = new ePOSOne.btnProduct.Button_WOC();
            this.TraCuu = new JMaterialTextbox.JMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.LoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dNhap = new JMaterialTextbox.JMaterialTextbox();
            this.MaNV = new JMaterialTextbox.JMaterialTextbox();
            this.MaPH = new JMaterialTextbox.JMaterialTextbox();
            this.lammoi = new ePOSOne.btnProduct.Button_WOC();
            this.capnhat = new ePOSOne.btnProduct.Button_WOC();
            this.xoa = new ePOSOne.btnProduct.Button_WOC();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quayve = new ePOSOne.btnProduct.Button_WOC();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TongNhap = new JMaterialTextbox.JMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.timkiem.Location = new System.Drawing.Point(683, 56);
            this.timkiem.Name = "timkiem";
            this.timkiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.timkiem.OnHoverButtonColor = System.Drawing.Color.White;
            this.timkiem.OnHoverTextColor = System.Drawing.Color.Black;
            this.timkiem.Size = new System.Drawing.Size(58, 38);
            this.timkiem.TabIndex = 116;
            this.timkiem.Text = " ";
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
            this.TraCuu.Location = new System.Drawing.Point(395, 64);
            this.TraCuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TraCuu.MaxLength = 32767;
            this.TraCuu.Name = "TraCuu";
            this.TraCuu.OnFocusedColor = System.Drawing.Color.Black;
            this.TraCuu.OnFocusedTextColor = System.Drawing.Color.Black;
            this.TraCuu.ReadOnly = false;
            this.TraCuu.Size = new System.Drawing.Size(255, 23);
            this.TraCuu.TabIndex = 115;
            this.TraCuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TraCuu.TextName = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(268, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 19);
            this.label11.TabIndex = 114;
            this.label11.Text = "Nhập từ khóa:";
            // 
            // LoaiTimKiem
            // 
            this.LoaiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoaiTimKiem.FormattingEnabled = true;
            this.LoaiTimKiem.Items.AddRange(new object[] {
            "MaPH",
            "MaNV"});
            this.LoaiTimKiem.Location = new System.Drawing.Point(518, 17);
            this.LoaiTimKiem.Name = "LoaiTimKiem";
            this.LoaiTimKiem.Size = new System.Drawing.Size(92, 21);
            this.LoaiTimKiem.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(391, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 112;
            this.label6.Text = "Tìm kiếm theo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 19);
            this.label5.TabIndex = 111;
            this.label5.Text = "Bảng phiếu nhập hàng:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dNhap
            // 
            this.dNhap.BackColor = System.Drawing.Color.Transparent;
            this.dNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dNhap.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dNhap.ForeColors = System.Drawing.Color.Black;
            this.dNhap.HintText = null;
            this.dNhap.IsPassword = false;
            this.dNhap.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dNhap.LineThickness = 2;
            this.dNhap.Location = new System.Drawing.Point(822, 167);
            this.dNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dNhap.MaxLength = 32767;
            this.dNhap.Name = "dNhap";
            this.dNhap.OnFocusedColor = System.Drawing.Color.Black;
            this.dNhap.OnFocusedTextColor = System.Drawing.Color.Black;
            this.dNhap.ReadOnly = false;
            this.dNhap.Size = new System.Drawing.Size(96, 18);
            this.dNhap.TabIndex = 110;
            this.dNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dNhap.TextName = "";
            this.dNhap.Load += new System.EventHandler(this.dNhap_Load);
            // 
            // MaNV
            // 
            this.MaNV.BackColor = System.Drawing.Color.Transparent;
            this.MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MaNV.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MaNV.ForeColors = System.Drawing.Color.Black;
            this.MaNV.HintText = null;
            this.MaNV.IsPassword = false;
            this.MaNV.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaNV.LineThickness = 2;
            this.MaNV.Location = new System.Drawing.Point(822, 118);
            this.MaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaNV.MaxLength = 32767;
            this.MaNV.Name = "MaNV";
            this.MaNV.OnFocusedColor = System.Drawing.Color.Black;
            this.MaNV.OnFocusedTextColor = System.Drawing.Color.Black;
            this.MaNV.ReadOnly = false;
            this.MaNV.Size = new System.Drawing.Size(96, 18);
            this.MaNV.TabIndex = 109;
            this.MaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaNV.TextName = "";
            // 
            // MaPH
            // 
            this.MaPH.BackColor = System.Drawing.Color.Transparent;
            this.MaPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MaPH.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MaPH.ForeColors = System.Drawing.Color.Black;
            this.MaPH.HintText = null;
            this.MaPH.IsPassword = false;
            this.MaPH.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaPH.LineThickness = 2;
            this.MaPH.Location = new System.Drawing.Point(470, 113);
            this.MaPH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaPH.MaxLength = 32767;
            this.MaPH.Name = "MaPH";
            this.MaPH.OnFocusedColor = System.Drawing.Color.Black;
            this.MaPH.OnFocusedTextColor = System.Drawing.Color.Black;
            this.MaPH.ReadOnly = false;
            this.MaPH.Size = new System.Drawing.Size(96, 23);
            this.MaPH.TabIndex = 108;
            this.MaPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaPH.TextName = "";
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
            this.lammoi.Location = new System.Drawing.Point(768, 56);
            this.lammoi.Name = "lammoi";
            this.lammoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lammoi.OnHoverButtonColor = System.Drawing.Color.Black;
            this.lammoi.OnHoverTextColor = System.Drawing.Color.White;
            this.lammoi.Size = new System.Drawing.Size(58, 38);
            this.lammoi.TabIndex = 107;
            this.lammoi.Text = " ";
            this.lammoi.TextColor = System.Drawing.Color.Black;
            this.lammoi.UseVisualStyleBackColor = true;
            this.lammoi.Click += new System.EventHandler(this.lammoi_Click);
            // 
            // capnhat
            // 
            this.capnhat.BorderColor = System.Drawing.Color.Black;
            this.capnhat.ButtonColor = System.Drawing.Color.White;
            this.capnhat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.capnhat.FlatAppearance.BorderSize = 0;
            this.capnhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capnhat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capnhat.Location = new System.Drawing.Point(768, 205);
            this.capnhat.Name = "capnhat";
            this.capnhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.capnhat.OnHoverButtonColor = System.Drawing.Color.White;
            this.capnhat.OnHoverTextColor = System.Drawing.Color.Black;
            this.capnhat.Size = new System.Drawing.Size(58, 38);
            this.capnhat.TabIndex = 106;
            this.capnhat.Text = " ";
            this.capnhat.TextColor = System.Drawing.Color.White;
            this.capnhat.UseVisualStyleBackColor = true;
            this.capnhat.Click += new System.EventHandler(this.capnhat_Click);
            // 
            // xoa
            // 
            this.xoa.BorderColor = System.Drawing.Color.Black;
            this.xoa.ButtonColor = System.Drawing.Color.White;
            this.xoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.xoa.FlatAppearance.BorderSize = 0;
            this.xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(855, 205);
            this.xoa.Name = "xoa";
            this.xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.xoa.OnHoverButtonColor = System.Drawing.Color.White;
            this.xoa.OnHoverTextColor = System.Drawing.Color.Black;
            this.xoa.Size = new System.Drawing.Size(58, 38);
            this.xoa.TabIndex = 105;
            this.xoa.Text = " ";
            this.xoa.TextColor = System.Drawing.Color.White;
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(620, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 19);
            this.label9.TabIndex = 103;
            this.label9.Text = "Ngày nhập sản phẩm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(620, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 102;
            this.label8.Text = "Mã nhân viên:";
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
            this.quayve.Location = new System.Drawing.Point(272, 6);
            this.quayve.Name = "quayve";
            this.quayve.OnHoverBorderColor = System.Drawing.Color.Black;
            this.quayve.OnHoverButtonColor = System.Drawing.Color.Black;
            this.quayve.OnHoverTextColor = System.Drawing.Color.White;
            this.quayve.Size = new System.Drawing.Size(76, 36);
            this.quayve.TabIndex = 101;
            this.quayve.Text = "<<";
            this.quayve.TextColor = System.Drawing.Color.Black;
            this.quayve.UseVisualStyleBackColor = true;
            this.quayve.Click += new System.EventHandler(this.quayve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "Mã phiếu:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(322, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(563, 316);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // TongNhap
            // 
            this.TongNhap.BackColor = System.Drawing.Color.Transparent;
            this.TongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TongNhap.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TongNhap.ForeColors = System.Drawing.Color.Black;
            this.TongNhap.HintText = null;
            this.TongNhap.IsPassword = false;
            this.TongNhap.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TongNhap.LineThickness = 2;
            this.TongNhap.Location = new System.Drawing.Point(470, 164);
            this.TongNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TongNhap.MaxLength = 32767;
            this.TongNhap.Name = "TongNhap";
            this.TongNhap.OnFocusedColor = System.Drawing.Color.Black;
            this.TongNhap.OnFocusedTextColor = System.Drawing.Color.Black;
            this.TongNhap.ReadOnly = false;
            this.TongNhap.Size = new System.Drawing.Size(96, 23);
            this.TongNhap.TabIndex = 118;
            this.TongNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TongNhap.TextName = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 117;
            this.label1.Text = "Tổng sản phẩm nhập:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(786, 64);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 137;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(786, 213);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 136;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(875, 213);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 135;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(702, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 391);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 138;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Admin_Nhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1017, 632);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TongNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.TraCuu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LoaiTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dNhap);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.MaPH);
            this.Controls.Add(this.lammoi);
            this.Controls.Add(this.capnhat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quayve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_Nhaphang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhập Hàng";
            this.Load += new System.EventHandler(this.Admin_Nhaphang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC timkiem;
        private JMaterialTextbox.JMaterialTextbox TraCuu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox LoaiTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private JMaterialTextbox.JMaterialTextbox dNhap;
        private JMaterialTextbox.JMaterialTextbox MaNV;
        private JMaterialTextbox.JMaterialTextbox MaPH;
        private ePOSOne.btnProduct.Button_WOC lammoi;
        private ePOSOne.btnProduct.Button_WOC capnhat;
        private ePOSOne.btnProduct.Button_WOC xoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private ePOSOne.btnProduct.Button_WOC quayve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JMaterialTextbox.JMaterialTextbox TongNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}