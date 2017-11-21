using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CuaHangSach
{
    public partial class frmDangNhap : Form
    {
        ConnectToSQL con = new ConnectToSQL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private bool KiemTraSo(string user)
        {
            try
            {
                int so = Convert.ToInt32(user);
                return true;
            }
            catch
            {
                return false;
            }
        }
        

        private void txtpass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtuser.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!KiemTraSo(txtuser.Text.Trim()))
            {
                MessageBox.Show("Tài khoảng không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btlogin_Click_1(object sender, EventArgs e)
        {
            if (txtuser.Text.Trim() == "" || txtpass.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!KiemTraSo(txtuser.Text.Trim()))
            {
                MessageBox.Show("Tài khoảng không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = new DataTable();
            dt = con.GetData("SELECT * FROM Nhan_Vien WHERE MaNV ='" + txtuser.Text + "' AND password ='" + txtpass.Text + "'");
            
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataRow dr = dt.Rows[0];
                string maCV = dr["MaCV"].ToString().Trim();
                switch (maCV)
                {
                    case "TN004":
                        PhanQuyenNhanVienTN tn = new PhanQuyenNhanVienTN();
                        this.Hide();
                        tn.ShowDialog();
                        this.Show();
                        txtuser.Text = null;
                        txtpass.Text = null;
                        break;
                    case "KK002":
                        PhanQuyenNhanVienKK kk = new PhanQuyenNhanVienKK();
                        this.Hide();
                        kk.ShowDialog();
                        this.Show();
                        txtuser.Text = null;
                        txtpass.Text = null;
                        break;
                    case "QL003":
                        PhanQuyenDanhChoQL ql = new PhanQuyenDanhChoQL();
                        this.Hide();
                        ql.ShowDialog();
                        this.Show();
                        txtuser.Text = null;
                        txtpass.Text = null;
                        break;

                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, Vui lòng thử lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void txtpass_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtuser.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!KiemTraSo(txtuser.Text.Trim()))
            {
                MessageBox.Show("Tài khoảng không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}