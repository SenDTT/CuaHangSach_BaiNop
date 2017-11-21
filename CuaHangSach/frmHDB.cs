using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangSach
{
    public partial class frmHDB : Form
    {
        SqlConnection cn = null;
        private DataTable dt;
        private DataSet ds;
        private SqlDataAdapter da;
        public frmHDB()
        {
            InitializeComponent();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHDB_Load(object sender, EventArgs e)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["Cua_Hang_Sach"].ConnectionString;
            cn = new SqlConnection(cnStr);
            LoadDataGirdView();
        }
        public void Connect()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void DisConnect()
        {
            if (cn != null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        public void LoadDataGirdView()
        {
            string sql = "SELECT Hoa_Don_ban.* FROM Hoa_Don_ban";
            ds = GetDataSet(sql);
            dt = ds.Tables[0];
            dgvHoaDon.DataSource = dt;
        }
        private DataSet GetDataSet(string sql)
        {
            da = new SqlDataAdapter(sql, cn);
            ds = new DataSet();
            int numberOfRows = da.Fill(ds);

            if (numberOfRows <= 0)
                ds = null;
            return ds;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmChiTietHDB cthdb = new frmChiTietHDB();
            cthdb.ShowDialog();
            LoadDataGirdView();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Connect();
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                try
                {

                    SqlDataAdapter da = new SqlDataAdapter();
                    string del = "DELETE FROM [Chi_Tiet_HDB] WHERE Chi_Tiet_HDB.MaHDB=" + dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = del;
                    cmd.ExecuteNonQuery();
                    string del1 = "DELETE FROM [Hoa_Don_Ban] WHERE Hoa_Don_Ban.MaHDB=" + dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = cn;
                    cmd1.CommandText = del1;
                    cmd1.ExecuteNonQuery();
                    foreach (DataGridViewRow row in dgvHoaDon.SelectedRows)
                    {
                        dgvHoaDon.Rows.Remove(row);
                    }
                    MessageBox.Show("Xóa thành công");
                    LoadDataGirdView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            Connect();
            if (IsNumber() == true)
            {
                try
                {
                    string sql = "SELECT * FROM Hoa_Don_Ban WHERE MaHDB = '" + txtTuKhoa.Text + "' ";
                    ds = GetDataSet(sql);
                    dt = ds.Tables[0];
                    dgvHoaDon.DataSource = dt;
                    MessageBox.Show("Tìm thấy hóa đơn");
                    txtTuKhoa.Text = "Nhập mã hóa đơn";
                    txtTuKhoa.ForeColor = Color.Gray;
                }
                catch (Exception)
                {

                    MessageBox.Show("Không tìm thấy hóa đơn");
                    txtTuKhoa.Text = "Nhập mã hóa đơn";
                    txtTuKhoa.ForeColor = Color.Gray;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại mã hóa đơn!");
                txtTuKhoa.Text = "Nhập mã hóa đơn";
                txtTuKhoa.ForeColor = Color.Gray;
            }
        }
        private bool IsNumber()
        {
            foreach (Char c in txtTuKhoa.Text)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                string sql = "SELECT MaHDB, MaSach[Mã sách], DonGiaBan[Đơn giá], SoLuong[Số lượng] FROM Chi_Tiet_HDB WHERE MaHDB ='" + dgvHoaDon.CurrentRow.Cells["MaHDB"].Value.ToString() + "'";
                ds = GetDataSet(sql);
                dt = ds.Tables[0];
                dgvHoaDon.DataSource = dt;
                dgvHoaDon.Columns[0].Width = 127;
                dgvHoaDon.Columns[1].Width = 175;
                dgvHoaDon.Columns[2].Width = 145;
                dgvHoaDon.Columns[3].Width = 145;
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể load thông tin chi tiết!\nVui lòng thử lại!");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaHDB, NgayBan[Ngày bán], MaKH[Mã khách hàng], MaNV[Mã nhân viên] FROM Hoa_Don_ban";
            ds = GetDataSet(sql);
            dt = ds.Tables[0];
            dgvHoaDon.DataSource = dt;
            dgvHoaDon.Columns[0].Width = 127;
            dgvHoaDon.Columns[1].Width = 175;
            dgvHoaDon.Columns[2].Width = 145;
            dgvHoaDon.Columns[3].Width = 145;
        }

        private void txtTuKhoa_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Text = "";
            txtTuKhoa.ForeColor = Color.Black;
        }
    }
}
