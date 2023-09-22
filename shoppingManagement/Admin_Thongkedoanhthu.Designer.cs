
namespace shoppingManagement
{
    partial class Admin_Thongkedoanhthu
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
            this.lapbc = new ePOSOne.btnProduct.Button_WOC();
            this.cthang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quayve = new ePOSOne.btnProduct.Button_WOC();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.baocaodoanhthu1 = new shoppingManagement.baocaodoanhthu();
            this.label1 = new System.Windows.Forms.Label();
            this.cNam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lapbc
            // 
            this.lapbc.BorderColor = System.Drawing.Color.Black;
            this.lapbc.ButtonColor = System.Drawing.Color.White;
            this.lapbc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lapbc.FlatAppearance.BorderSize = 0;
            this.lapbc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lapbc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lapbc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapbc.Location = new System.Drawing.Point(39, 269);
            this.lapbc.Name = "lapbc";
            this.lapbc.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lapbc.OnHoverButtonColor = System.Drawing.Color.Black;
            this.lapbc.OnHoverTextColor = System.Drawing.Color.White;
            this.lapbc.Size = new System.Drawing.Size(166, 39);
            this.lapbc.TabIndex = 84;
            this.lapbc.Text = "Lập báo cáo";
            this.lapbc.TextColor = System.Drawing.Color.Black;
            this.lapbc.UseVisualStyleBackColor = true;
            this.lapbc.Click += new System.EventHandler(this.lapbc_Click);
            // 
            // cthang
            // 
            this.cthang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cthang.FormattingEnabled = true;
            this.cthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cthang.Location = new System.Drawing.Point(39, 215);
            this.cthang.Name = "cthang";
            this.cthang.Size = new System.Drawing.Size(166, 21);
            this.cthang.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 87;
            this.label3.Text = "Chọn tháng báo cáo:";
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
            this.quayve.Location = new System.Drawing.Point(12, 12);
            this.quayve.Name = "quayve";
            this.quayve.OnHoverBorderColor = System.Drawing.Color.Black;
            this.quayve.OnHoverButtonColor = System.Drawing.Color.Black;
            this.quayve.OnHoverTextColor = System.Drawing.Color.White;
            this.quayve.Size = new System.Drawing.Size(76, 36);
            this.quayve.TabIndex = 88;
            this.quayve.Text = "<<";
            this.quayve.TextColor = System.Drawing.Color.Black;
            this.quayve.UseVisualStyleBackColor = true;
            this.quayve.Click += new System.EventHandler(this.quayve_Click);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(225, 12);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(780, 608);
            this.crystalReportViewer2.TabIndex = 85;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 90;
            this.label1.Text = "Chọn năm báo cáo:";
            // 
            // cNam
            // 
            this.cNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cNam.FormattingEnabled = true;
            this.cNam.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cNam.Location = new System.Drawing.Point(39, 137);
            this.cNam.Name = "cNam";
            this.cNam.Size = new System.Drawing.Size(166, 21);
            this.cNam.TabIndex = 89;
            // 
            // Admin_Thongkedoanhthu
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1017, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cNam);
            this.Controls.Add(this.quayve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cthang);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.lapbc);
            this.Name = "Admin_Thongkedoanhthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Doanh Thu";
            this.Load += new System.EventHandler(this.Admin_Thongkedoanhthu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC lapbaocao;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private baocaothang crystalReport11;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.Label label4;
        private ePOSOne.btnProduct.Button_WOC lapbc;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.ComboBox cthang;
        private System.Windows.Forms.Label label3;
        private ePOSOne.btnProduct.Button_WOC quayve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cNam;
        private baocaodoanhthu baocaodoanhthu1;
    }
}