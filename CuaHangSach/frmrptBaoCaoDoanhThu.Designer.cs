namespace CuaHangSach
{
    partial class frmrptBaoCaoHDBTheoNgay
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
            this.rptDoanhThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btNgay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btLoad = new System.Windows.Forms.Button();
            this.btNam = new System.Windows.Forms.Button();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rptDoanhThu
            // 
            this.rptDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rptDoanhThu.Location = new System.Drawing.Point(4, 81);
            this.rptDoanhThu.Name = "rptDoanhThu";
            this.rptDoanhThu.ServerReport.BearerToken = null;
            this.rptDoanhThu.Size = new System.Drawing.Size(756, 443);
            this.rptDoanhThu.TabIndex = 0;
            // 
            // btNgay
            // 
            this.btNgay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNgay.Location = new System.Drawing.Point(340, 11);
            this.btNgay.Name = "btNgay";
            this.btNgay.Size = new System.Drawing.Size(90, 43);
            this.btNgay.TabIndex = 1;
            this.btNgay.Text = "Ngày";
            this.btNgay.UseVisualStyleBackColor = false;
            this.btNgay.Click += new System.EventHandler(this.btNgay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập Ngày Cần Xem";
            // 
            // dtpNgay
            // 
            this.dtpNgay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(196, 17);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(138, 29);
            this.dtpNgay.TabIndex = 4;
            this.dtpNgay.Value = new System.DateTime(2017, 11, 18, 21, 12, 47, 0);
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.Location = new System.Drawing.Point(436, 11);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(90, 43);
            this.btLoad.TabIndex = 1;
            this.btLoad.Text = "Tháng";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.frmrptBaoCaoHDBTheoNgay_Load);
            // 
            // btNam
            // 
            this.btNam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNam.Location = new System.Drawing.Point(532, 12);
            this.btNam.Name = "btNam";
            this.btNam.Size = new System.Drawing.Size(90, 43);
            this.btNam.TabIndex = 1;
            this.btNam.Text = "Năm";
            this.btNam.UseVisualStyleBackColor = false;
            this.btNam.Click += new System.EventHandler(this.btNam_Click);
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayLai.Location = new System.Drawing.Point(628, 12);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(104, 43);
            this.btQuayLai.TabIndex = 1;
            this.btQuayLai.Text = "Quay Lại";
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // frmrptBaoCaoHDBTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(765, 526);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.btNam);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btNgay);
            this.Controls.Add(this.rptDoanhThu);
            this.MaximizeBox = false;
            this.Name = "frmrptBaoCaoHDBTheoNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmrptBaoCaoHDBTheoNgay";
            this.Load += new System.EventHandler(this.frmrptBaoCaoHDBTheoNgay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptDoanhThu;
        private System.Windows.Forms.Button btNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btNam;
        private System.Windows.Forms.Button btQuayLai;
    }
}