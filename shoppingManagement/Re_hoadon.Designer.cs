
namespace shoppingManagement
{
    partial class Re_hoadon
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
            this.label3 = new System.Windows.Forms.Label();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lapbc = new ePOSOne.btnProduct.Button_WOC();
            this.MaHD = new JMaterialTextbox.JMaterialTextbox();
            this.quayve = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 91;
            this.label3.Text = "Nhập mã hóa đơn:";
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(213, 12);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(780, 608);
            this.crystalReportViewer2.TabIndex = 89;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.lapbc.Location = new System.Drawing.Point(27, 190);
            this.lapbc.Name = "lapbc";
            this.lapbc.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lapbc.OnHoverButtonColor = System.Drawing.Color.Black;
            this.lapbc.OnHoverTextColor = System.Drawing.Color.White;
            this.lapbc.Size = new System.Drawing.Size(98, 39);
            this.lapbc.TabIndex = 88;
            this.lapbc.Text = "Xem";
            this.lapbc.TextColor = System.Drawing.Color.Black;
            this.lapbc.UseVisualStyleBackColor = true;
            this.lapbc.Click += new System.EventHandler(this.lapbc_Click);
            // 
            // MaHD
            // 
            this.MaHD.BackColor = System.Drawing.Color.Transparent;
            this.MaHD.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MaHD.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MaHD.ForeColors = System.Drawing.Color.Black;
            this.MaHD.HintText = null;
            this.MaHD.IsPassword = false;
            this.MaHD.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaHD.LineThickness = 2;
            this.MaHD.Location = new System.Drawing.Point(27, 138);
            this.MaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaHD.MaxLength = 32767;
            this.MaHD.Name = "MaHD";
            this.MaHD.OnFocusedColor = System.Drawing.Color.Black;
            this.MaHD.OnFocusedTextColor = System.Drawing.Color.Black;
            this.MaHD.ReadOnly = false;
            this.MaHD.Size = new System.Drawing.Size(98, 23);
            this.MaHD.TabIndex = 92;
            this.MaHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaHD.TextName = "";
            // 
            // quayve
            // 
            this.quayve.BorderColor = System.Drawing.Color.Black;
            this.quayve.ButtonColor = System.Drawing.Color.White;
            this.quayve.FlatAppearance.BorderSize = 0;
            this.quayve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.quayve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quayve.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayve.Location = new System.Drawing.Point(27, 12);
            this.quayve.Name = "quayve";
            this.quayve.OnHoverBorderColor = System.Drawing.Color.Black;
            this.quayve.OnHoverButtonColor = System.Drawing.Color.Black;
            this.quayve.OnHoverTextColor = System.Drawing.Color.White;
            this.quayve.Size = new System.Drawing.Size(80, 35);
            this.quayve.TabIndex = 93;
            this.quayve.Text = "<<";
            this.quayve.TextColor = System.Drawing.Color.Black;
            this.quayve.UseVisualStyleBackColor = true;
            this.quayve.Click += new System.EventHandler(this.quayve_Click);
            // 
            // Re_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1017, 632);
            this.Controls.Add(this.quayve);
            this.Controls.Add(this.MaHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.lapbc);
            this.Name = "Re_hoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private ePOSOne.btnProduct.Button_WOC lapbc;
        private JMaterialTextbox.JMaterialTextbox MaHD;
        private ePOSOne.btnProduct.Button_WOC quayve;
    }
}