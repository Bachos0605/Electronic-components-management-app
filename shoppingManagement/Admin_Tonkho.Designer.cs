
namespace shoppingManagement
{
    partial class Admin_Tonkho
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bangtonkho1 = new shoppingManagement.bangtonkho();
            this.label3 = new System.Windows.Forms.Label();
            this.cthang = new System.Windows.Forms.ComboBox();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.quayve = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(207, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(798, 608);
            this.crystalReportViewer1.TabIndex = 102;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 101;
            this.label3.Text = "Chọn tháng báo cáo:";
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
            this.cthang.Location = new System.Drawing.Point(22, 156);
            this.cthang.Name = "cthang";
            this.cthang.Size = new System.Drawing.Size(159, 21);
            this.cthang.TabIndex = 100;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Black;
            this.button_WOC1.ButtonColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(37, 201);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(118, 38);
            this.button_WOC1.TabIndex = 103;
            this.button_WOC1.Text = "Xem báo cáo";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // quayve
            // 
            this.quayve.BorderColor = System.Drawing.Color.Black;
            this.quayve.ButtonColor = System.Drawing.Color.White;
            this.quayve.FlatAppearance.BorderSize = 0;
            this.quayve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.quayve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quayve.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayve.Location = new System.Drawing.Point(12, 12);
            this.quayve.Name = "quayve";
            this.quayve.OnHoverBorderColor = System.Drawing.Color.Black;
            this.quayve.OnHoverButtonColor = System.Drawing.Color.Black;
            this.quayve.OnHoverTextColor = System.Drawing.Color.White;
            this.quayve.Size = new System.Drawing.Size(80, 35);
            this.quayve.TabIndex = 104;
            this.quayve.Text = "<<";
            this.quayve.TextColor = System.Drawing.Color.Black;
            this.quayve.UseVisualStyleBackColor = true;
            this.quayve.Click += new System.EventHandler(this.quayve_Click);
            // 
            // Admin_Tonkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1017, 632);
            this.Controls.Add(this.quayve);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cthang);
            this.Name = "Admin_Tonkho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Tồn Kho";
            this.Load += new System.EventHandler(this.Admin_Tonkho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cthang;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC quayve;
        private bangtonkho bangtonkho1;
    }
}