using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangSach
{
    public partial class PhanQuyenDanhChoQL : Form
    {
        public PhanQuyenDanhChoQL()
        {
            InitializeComponent();
        }

        
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmDangNhap frmdn = new frmDangNhap();
            //frmdn.ShowDialog();
        }
        

        private void btfrmKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.ShowDialog();
        }

        private void PhanQuyenDanhChoQL_Load(object sender, EventArgs e)
        {

        }

        private void btfrmKS_Click(object sender, EventArgs e)
        {
            frmKhoSach khosach = new frmKhoSach();
            khosach.ShowDialog();
        }

        private void btfrmNV_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanVien = new frmNhanVien();
            nhanVien.ShowDialog();
        }

        private void btfrmNS_Click(object sender, EventArgs e)
        {
            frmNhapSach nhapsach = new frmNhapSach();
            nhapsach.ShowDialog();
        }

        private void btfrmHD_Click(object sender, EventArgs e)
        {
            new frmHDB().ShowDialog();
        }

        private void btfrmBC_Click(object sender, EventArgs e)
        {
            new frmrptBaoCaoHDBTheoNgay().ShowDialog();
        }
    }
}
