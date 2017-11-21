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
    public partial class PhanQuyenNhanVienKK : Form
    {
        public PhanQuyenNhanVienKK()
        {
            InitializeComponent();
        }

        private void PhanQuyenNhanVienKK_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmDangNhap frmdn = new frmDangNhap();
            //frmdn.ShowDialog();
        }

        private void btfrmKS_Click(object sender, EventArgs e)
        {
            frmKhoSach kho = new frmKhoSach();
            kho.ShowDialog();
        }

        private void btfrmNS_Click(object sender, EventArgs e)
        {
            new frmNhapSach().ShowDialog();
        }

        private void PhanQuyenNhanVienKK_Load(object sender, EventArgs e)
        {

        }
    }
}
