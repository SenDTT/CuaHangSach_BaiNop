namespace CuaHangSach
{
    partial class frmNhapSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapSach));
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSLSachMua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoaSach = new System.Windows.Forms.Button();
            this.btThemSach = new System.Windows.Forms.Button();
            this.btLapMoi = new System.Windows.Forms.Button();
            this.btXemPhieu = new System.Windows.Forms.Button();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btIn = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClear.ForeColor = System.Drawing.Color.DarkCyan;
            this.btClear.Location = new System.Drawing.Point(33, 437);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(97, 26);
            this.btClear.TabIndex = 82;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtThue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNgayNhap);
            this.groupBox2.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMaNCC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 60);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phiếu Nhập";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(813, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 23);
            this.label3.TabIndex = 51;
            this.label3.Text = "%";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtThue
            // 
            this.txtThue.BackColor = System.Drawing.SystemColors.Info;
            this.txtThue.Location = new System.Drawing.Point(720, 24);
            this.txtThue.Name = "txtThue";
            this.txtThue.ShortcutsEnabled = false;
            this.txtThue.Size = new System.Drawing.Size(87, 20);
            this.txtThue.TabIndex = 12;
            this.txtThue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThue_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã phiếu nhập:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(670, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Thuế:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayNhap.Location = new System.Drawing.Point(336, 26);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(135, 20);
            this.txtNgayNhap.TabIndex = 50;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(129, 24);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.ShortcutsEnabled = false;
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(116, 20);
            this.txtMaPhieuNhap.TabIndex = 1;
            this.txtMaPhieuNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaPhieuNhap_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(243, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ngày nhập:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaNCC.Location = new System.Drawing.Point(541, 24);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ShortcutsEnabled = false;
            this.txtMaNCC.Size = new System.Drawing.Size(123, 20);
            this.txtMaNCC.TabIndex = 36;
            this.txtMaNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNCC_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(468, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mã NCC:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 48);
            this.label1.TabIndex = 68;
            this.label1.Text = "NHẬP SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSLSachMua);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGiaMua);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(7, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 67);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách:";
            // 
            // txtSLSachMua
            // 
            this.txtSLSachMua.BackColor = System.Drawing.SystemColors.Info;
            this.txtSLSachMua.Location = new System.Drawing.Point(541, 26);
            this.txtSLSachMua.Name = "txtSLSachMua";
            this.txtSLSachMua.ShortcutsEnabled = false;
            this.txtSLSachMua.Size = new System.Drawing.Size(141, 22);
            this.txtSLSachMua.TabIndex = 8;
            this.txtSLSachMua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLSachMua_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(453, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số lượng:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.BackColor = System.Drawing.SystemColors.Info;
            this.txtGiaMua.Location = new System.Drawing.Point(312, 23);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.ShortcutsEnabled = false;
            this.txtGiaMua.Size = new System.Drawing.Size(135, 22);
            this.txtGiaMua.TabIndex = 6;
            this.txtGiaMua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaMua_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(232, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giá mua:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaSach.Location = new System.Drawing.Point(76, 23);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(150, 22);
            this.txtMaSach.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã sách:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.ForeColor = System.Drawing.Color.DarkCyan;
            this.btThoat.Location = new System.Drawing.Point(704, 275);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(110, 26);
            this.btThoat.TabIndex = 80;
            this.btThoat.Text = "Quay lại";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(51, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 23);
            this.label11.TabIndex = 70;
            this.label11.Text = "Chi tiết phiếu nhập: ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(54, 307);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(760, 124);
            this.dataGridView2.TabIndex = 71;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.ForeColor = System.Drawing.Color.DarkCyan;
            this.btSua.Location = new System.Drawing.Point(704, 211);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(110, 26);
            this.btSua.TabIndex = 78;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoaSach
            // 
            this.btXoaSach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoaSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoaSach.ForeColor = System.Drawing.Color.DarkCyan;
            this.btXoaSach.Location = new System.Drawing.Point(592, 243);
            this.btXoaSach.Name = "btXoaSach";
            this.btXoaSach.Size = new System.Drawing.Size(97, 26);
            this.btXoaSach.TabIndex = 77;
            this.btXoaSach.Text = "Xóa sách";
            this.btXoaSach.UseVisualStyleBackColor = false;
            this.btXoaSach.Click += new System.EventHandler(this.btXoaSach_Click);
            // 
            // btThemSach
            // 
            this.btThemSach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThemSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThemSach.ForeColor = System.Drawing.Color.DarkCyan;
            this.btThemSach.Location = new System.Drawing.Point(489, 243);
            this.btThemSach.Name = "btThemSach";
            this.btThemSach.Size = new System.Drawing.Size(97, 26);
            this.btThemSach.TabIndex = 76;
            this.btThemSach.Text = "Thêm sách";
            this.btThemSach.UseVisualStyleBackColor = false;
            this.btThemSach.Click += new System.EventHandler(this.btThemSach_Click);
            // 
            // btLapMoi
            // 
            this.btLapMoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLapMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLapMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLapMoi.ForeColor = System.Drawing.Color.DarkCyan;
            this.btLapMoi.Location = new System.Drawing.Point(704, 179);
            this.btLapMoi.Name = "btLapMoi";
            this.btLapMoi.Size = new System.Drawing.Size(110, 26);
            this.btLapMoi.TabIndex = 75;
            this.btLapMoi.Text = "Lập phiếu mới";
            this.btLapMoi.UseVisualStyleBackColor = false;
            this.btLapMoi.Click += new System.EventHandler(this.btLapMoi_Click);
            // 
            // btXemPhieu
            // 
            this.btXemPhieu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXemPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXemPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXemPhieu.ForeColor = System.Drawing.Color.DarkCyan;
            this.btXemPhieu.Location = new System.Drawing.Point(704, 147);
            this.btXemPhieu.Name = "btXemPhieu";
            this.btXemPhieu.Size = new System.Drawing.Size(110, 26);
            this.btXemPhieu.TabIndex = 74;
            this.btXemPhieu.Text = "Xem phiếu";
            this.btXemPhieu.UseVisualStyleBackColor = false;
            this.btXemPhieu.Click += new System.EventHandler(this.btXemPhieu_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.BackColor = System.Drawing.SystemColors.Info;
            this.lbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTongTien.Location = new System.Drawing.Point(599, 434);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(215, 23);
            this.lbTongTien.TabIndex = 73;
            this.lbTongTien.Text = "0";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(502, 434);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 23);
            this.label12.TabIndex = 72;
            this.label12.Text = "Tổng tiền:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btIn
            // 
            this.btIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btIn.ForeColor = System.Drawing.Color.DarkCyan;
            this.btIn.Location = new System.Drawing.Point(704, 243);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(110, 26);
            this.btIn.TabIndex = 79;
            this.btIn.Text = "In phiếu";
            this.btIn.UseVisualStyleBackColor = false;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 474);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoaSach);
            this.Controls.Add(this.btThemSach);
            this.Controls.Add(this.btLapMoi);
            this.Controls.Add(this.btXemPhieu);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btIn);
            this.MaximizeBox = false;
            this.Name = "frmNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhapSach";
            this.Load += new System.EventHandler(this.frmNhapSach_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtNgayNhap;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSLSachMua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoaSach;
        private System.Windows.Forms.Button btThemSach;
        private System.Windows.Forms.Button btLapMoi;
        private System.Windows.Forms.Button btXemPhieu;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}