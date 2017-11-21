namespace CuaHangSach
{
    partial class frmKhoSach
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
            this.btClear = new System.Windows.Forms.Button();
            this.txtMaNcc = new System.Windows.Forms.ComboBox();
            this.txtMaGiam = new System.Windows.Forms.ComboBox();
            this.txtMaLoai = new System.Windows.Forms.ComboBox();
            this.dataGrV1 = new System.Windows.Forms.DataGridView();
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtSLDat = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtSLKho = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrV1)).BeginInit();
            this.SuspendLayout();
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClear.ForeColor = System.Drawing.Color.Teal;
            this.btClear.Location = new System.Drawing.Point(655, 217);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(77, 33);
            this.btClear.TabIndex = 84;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // txtMaNcc
            // 
            this.txtMaNcc.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaNcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaNcc.FormattingEnabled = true;
            this.txtMaNcc.Location = new System.Drawing.Point(119, 233);
            this.txtMaNcc.Name = "txtMaNcc";
            this.txtMaNcc.Size = new System.Drawing.Size(162, 21);
            this.txtMaNcc.TabIndex = 83;
            // 
            // txtMaGiam
            // 
            this.txtMaGiam.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaGiam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaGiam.FormattingEnabled = true;
            this.txtMaGiam.Location = new System.Drawing.Point(459, 96);
            this.txtMaGiam.Name = "txtMaGiam";
            this.txtMaGiam.Size = new System.Drawing.Size(162, 21);
            this.txtMaGiam.TabIndex = 82;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaLoai.FormattingEnabled = true;
            this.txtMaLoai.Location = new System.Drawing.Point(119, 198);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(162, 21);
            this.txtMaLoai.TabIndex = 81;
            // 
            // dataGrV1
            // 
            this.dataGrV1.AllowUserToAddRows = false;
            this.dataGrV1.AllowUserToDeleteRows = false;
            this.dataGrV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrV1.Location = new System.Drawing.Point(36, 295);
            this.dataGrV1.Name = "dataGrV1";
            this.dataGrV1.ReadOnly = true;
            this.dataGrV1.Size = new System.Drawing.Size(696, 195);
            this.dataGrV1.TabIndex = 80;
            this.dataGrV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrV1_CellContentClick);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExit.ForeColor = System.Drawing.Color.Teal;
            this.btExit.Location = new System.Drawing.Point(655, 256);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(77, 33);
            this.btExit.TabIndex = 79;
            this.btExit.Text = "Quay lại";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btEdit.ForeColor = System.Drawing.Color.Teal;
            this.btEdit.Location = new System.Drawing.Point(655, 178);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(77, 33);
            this.btEdit.TabIndex = 78;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDelete.ForeColor = System.Drawing.Color.Teal;
            this.btDelete.Location = new System.Drawing.Point(655, 139);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(77, 33);
            this.btDelete.TabIndex = 77;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAdd.ForeColor = System.Drawing.Color.Teal;
            this.btAdd.Location = new System.Drawing.Point(655, 100);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(77, 33);
            this.btAdd.TabIndex = 76;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearch.ForeColor = System.Drawing.Color.Teal;
            this.btSearch.Location = new System.Drawing.Point(655, 57);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(77, 33);
            this.btSearch.TabIndex = 75;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackColor = System.Drawing.SystemColors.Info;
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTinhTrang.Location = new System.Drawing.Point(459, 234);
            this.txtTinhTrang.Multiline = true;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(162, 20);
            this.txtTinhTrang.TabIndex = 74;
            // 
            // txtSLDat
            // 
            this.txtSLDat.BackColor = System.Drawing.SystemColors.Info;
            this.txtSLDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSLDat.Location = new System.Drawing.Point(459, 200);
            this.txtSLDat.Multiline = true;
            this.txtSLDat.Name = "txtSLDat";
            this.txtSLDat.ShortcutsEnabled = false;
            this.txtSLDat.Size = new System.Drawing.Size(162, 20);
            this.txtSLDat.TabIndex = 73;
            this.txtSLDat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLDat_KeyPress);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.SystemColors.Info;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaBan.Location = new System.Drawing.Point(459, 131);
            this.txtGiaBan.Multiline = true;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ShortcutsEnabled = false;
            this.txtGiaBan.Size = new System.Drawing.Size(162, 20);
            this.txtGiaBan.TabIndex = 72;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtSLKho
            // 
            this.txtSLKho.BackColor = System.Drawing.SystemColors.Info;
            this.txtSLKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSLKho.Location = new System.Drawing.Point(459, 165);
            this.txtSLKho.Multiline = true;
            this.txtSLKho.Name = "txtSLKho";
            this.txtSLKho.ShortcutsEnabled = false;
            this.txtSLKho.Size = new System.Drawing.Size(162, 20);
            this.txtSLKho.TabIndex = 71;
            this.txtSLKho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLKho_KeyPress);
            // 
            // txtNXB
            // 
            this.txtNXB.BackColor = System.Drawing.SystemColors.Info;
            this.txtNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNXB.Location = new System.Drawing.Point(119, 165);
            this.txtNXB.Multiline = true;
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(162, 20);
            this.txtNXB.TabIndex = 70;
            // 
            // txtTenSach
            // 
            this.txtTenSach.BackColor = System.Drawing.SystemColors.Info;
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSach.Location = new System.Drawing.Point(119, 131);
            this.txtTenSach.Multiline = true;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(162, 20);
            this.txtTenSach.TabIndex = 69;
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSach.Location = new System.Drawing.Point(119, 98);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(162, 20);
            this.txtMaSach.TabIndex = 68;
            this.txtMaSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSach_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(324, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 67;
            this.label10.Text = "Tình trạng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(324, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 18);
            this.label11.TabIndex = 65;
            this.label11.Text = "Đơn giá bán";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(324, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 18);
            this.label9.TabIndex = 66;
            this.label9.Text = "Số lượng đặt hàng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(324, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 64;
            this.label8.Text = "Số lượng trong kho";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(324, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Mã giảm giá";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 62;
            this.label6.Text = "Mã NCC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Mã thể loại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 60;
            this.label4.Text = "NXB";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tên sách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Mã sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 44);
            this.label1.TabIndex = 57;
            this.label1.Text = "KHO SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmKhoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 500);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.txtMaNcc);
            this.Controls.Add(this.txtMaGiam);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.dataGrV1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtSLDat);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtSLKho);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmKhoSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhoSach";
            this.Load += new System.EventHandler(this.frmKhoSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ComboBox txtMaNcc;
        private System.Windows.Forms.ComboBox txtMaGiam;
        private System.Windows.Forms.ComboBox txtMaLoai;
        private System.Windows.Forms.DataGridView dataGrV1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtSLDat;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSLKho;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}