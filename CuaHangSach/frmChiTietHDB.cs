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
using DGVPrinterHelper;

namespace CuaHangSach
{
    public partial class frmChiTietHDB : Form
    {
        SqlConnection cn = null;
        double tongTien;
        ErrorProvider Error = new ErrorProvider();

        public frmChiTietHDB()
        {
            InitializeComponent();
        }

        private void frmChiTietHDB_Load(object sender, EventArgs e)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["Cua_Hang_Sach"].ConnectionString;
            cn = new SqlConnection(cnStr);
            loadItemFromDB();
            btLuuHD.Enabled = false;
            btXoaHD.Enabled = false;
            btThemHD.Enabled = true;
            btInPhieu.Enabled = false;
            loadIdKhachHang();
            loadIdNhanVien();
        }
        private void loadIdKhachHang()
        {
            Connect();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT MaKH FROM Khach_Hang ", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtMaKH.Items.Add(dr["MaKH"].ToString());
            }
            txtMaKH.SelectedIndex = 0;
            DisConnect();
        }
        private void loadIdNhanVien()
        {
            Connect();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT MaNV FROM Nhan_Vien WHERE MaCV = 'QL003' OR MaCV = 'TN004' ", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtMaNV.Items.Add(dr["MaNV"].ToString());
            }
            txtMaNV.SelectedIndex = 0;
            DisConnect();
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

        private void loadItemFromDB()
        {
            Connect();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT MaSach FROM Sach", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbMaSach.Items.Add(dr["MaSach"].ToString());
            }
            DisConnect();
            cbMaSach.SelectedIndexChanged += new EventHandler(cbMaSach_SelectedIndexChanged);
        }
        private void btXoaHD_Click(object sender, EventArgs e)
        {
            Connect();
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {

                try
                {
                    foreach (DataGridViewRow row in dgvMatHang.SelectedRows)
                    {
                        dgvMatHang.Rows.Remove(row);
                    }
                    MessageBox.Show("Xóa thành công!");
                    btLuuHD.Enabled = true;
                    btXoaHD.Enabled = true;
                    btThemHD.Enabled = true;
                    txtMaHD.Enabled = true;
                    txtMaKH.Enabled = true;
                    txtMaNV.Enabled = true;
                    dtpNgayBan.Enabled = true;
                }
                catch (Exception)
                {

                    MessageBox.Show("Không xóa thành công!");
                }
            }
        }

        private void btLuuHD_Click(object sender, EventArgs e)
        {
            dtpNgayBan.Value.ToString("dd-MM-yyyy");
            Connect();
            if (IsCharMaHD() == false)
            {
                MessageBox.Show("Vui lòng nhập lại mã hóa đơn!");
                txtMaHD.Clear();
            }
            else if (KtMaHDB() == true)
            {
                MessageBox.Show("Hóa đơn đã tồn tại.\nVui lòng nhập lại mã hóa đơn khác!");
                txtMaHD.Clear();
            }
            else if(int.Parse(txtMaHD.Text) == 0)
            {
                MessageBox.Show("Hóa đơn đã tồn tại.\nVui lòng nhập lại mã hóa đơn khác!");
                txtMaHD.Clear();
            }
            else if (IsNumber() == false)
            {
                MessageBox.Show("Vui lòng nhập lại số lượng");
                txtSoLuong.Clear();
            }
            else if (txtMaNV.Text != "" && txtMaKH.Text != "" && txtMaHD.Text != "" && txtthue.Text != "")
            {
                try
                {
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO Hoa_Don_Ban(MaHDB,NgayBan,MaKH,MaNV,ThueVAT) VALUES(@MaHDB, @NgayBan,@MaKH,@MaNV,@Thue)", cn);
                    cmd1.Parameters.AddWithValue("@MaHDB", txtMaHD.Text);
                    cmd1.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
                    cmd1.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    cmd1.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    cmd1.Parameters.AddWithValue("@Thue", txtthue.Text);
                    cmd1.ExecuteNonQuery();
                    cmd1.Parameters.Clear();

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Chi_Tiet_HDB(MaHDB,MaSach,DonGiaBan,SoLuong) VALUES(@MaHDB,@MaSach,@DonGiaBan,@SoLuong)", cn);
                    cmd2.Parameters.AddWithValue("@MaHDB", txtMaHD.Text);
                    cmd2.Parameters.AddWithValue("@MaSach", cbMaSach.Text);
                    cmd2.Parameters.AddWithValue("@DonGiaBan", txtDonBan.Text);
                    cmd2.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();
                    MessageBox.Show("Thêm thành công");
                    btInPhieu.Enabled = true;
                    btLuuHD.Enabled = true;
                    btXoaHD.Enabled = true;
                    btThemHD.Enabled = true;
                    txtMaHD.Enabled = false;
                    txtMaKH.Enabled = false;
                    txtMaNV.Enabled = false;
                    dtpNgayBan.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn!");
                }
                else if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng!");
                }
                else if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên!");
                }
                else if (txtthue.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thuê!");
                }
            }
            btQuayLai.Enabled = true;
        }

        private void btThemHD_Click(object sender, EventArgs e)
        {
            if (txtthue.Text == "" || txtMaHD.Text == "" || txtMaNV.Text == "" || txtMaKH.Text == "" || txtDonBan.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }

            else if (txtthue.Text == " " || txtMaHD.Text == " " || txtMaNV.Text == " " || txtMaKH.Text == " " || txtDonBan.Text == " " || txtSoLuong.Text == " ")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else if (IsCharMaHD() == false)
            {
                MessageBox.Show("Vui lòng nhập lại mã hóa đơn!");
                txtMaHD.Clear();
            }
            else if (IsCharSL() == false) 
            {
                MessageBox.Show("Vui lòng nhập lại số lượng!");
                txtSoLuong.Clear();
            }
            else if (IsCharThue() == false)
            {
                MessageBox.Show("Vui lòng nhập lại thuế!");
                txtthue.Clear();
            }
            else if (int.Parse(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 0!");
                txtSoLuong.Clear();
            }
            else if (KtSoLuong() == true)
            {
                MessageBox.Show("Số lượng sách không đủ!");
                txtSoLuong.Clear();
            }
            else
            {
                if (txtGiamGia.Text != "")
                    {
                        string tile = "";
                        double a = double.Parse(txtDonBan.Text);
                        double b = double.Parse(txtSoLuong.Text);
                        Connect();
                        string sql = "select TiLe from Giam_Gia where MaGiamGia = '" + txtGiamGia.Text + "'";
                        SqlCommand kiemtra = new SqlCommand(sql, cn);
                        SqlDataReader dr = kiemtra.ExecuteReader();
                        while(dr.Read())
                        {
                            tile = (string)dr["TiLe"].ToString();
                        }
                        double c = int.Parse(tile) / 100.0;
                        double sotiengiam = a * c;
                        double tongtien = ((a * b) - sotiengiam);
                        txtThanhTien.Text = tongtien.ToString();
                        dgvMatHang.Rows.Add(cbMaSach.Text, txtTenSach.Text, int.Parse(txtSoLuong.Text), float.Parse(txtDonBan.Text), sotiengiam, double.Parse(txtThanhTien.Text));
                        txtTongTien.Text = (TongTien() + TongTien() * (Convert.ToDouble(txtthue.Text) / 100)).ToString();
                        kiemtra.Clone();
                        kiemtra.Dispose();
                        DisConnect();
                    }
                    else
                    {
                        double a = double.Parse(txtDonBan.Text);
                        double b = double.Parse(txtSoLuong.Text);
                        double c = a * b;
                        txtThanhTien.Text = c.ToString();
                        dgvMatHang.Rows.Add(cbMaSach.Text, txtTenSach.Text, int.Parse(txtSoLuong.Text), float.Parse(txtDonBan.Text), "", double.Parse(txtThanhTien.Text));
                        txtTongTien.Text = TongTien().ToString();
                    }
                    btLuuHD.Enabled = true;
                    btXoaHD.Enabled = true;
                    btThemHD.Enabled = true;
                    txtMaHD.Enabled = true;
                    txtMaKH.Enabled = true;
                    txtMaNV.Enabled = true;
                    dtpNgayBan.Enabled = true;
            }
        }

        private void cbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connect();
            SqlCommand cmd = new SqlCommand("SELECT Sach.DonGiaBan, Sach.TenSach, Sach.MaGiamGia FROM Sach WHERE Sach.MaSach = '" + cbMaSach.Text + "'", cn);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string DonGiaBan = (string)dr["DonGiaBan"].ToString();
                txtDonBan.Text = DonGiaBan;

                string TenSach = (string)dr["TenSach"].ToString();
                txtTenSach.Text = TenSach;

                string Giamgia = (string)dr["MaGiamGia"].ToString();
                txtGiamGia.Text = Giamgia;
            }
            cmd.Clone();
            cmd.Dispose();
            DisConnect();
        }
        private double TongTien()
        {
            tongTien = 0;
            for (int i = 0; i < dgvMatHang.Rows.Count - 1; i++)
            {
                tongTien += double.Parse(dgvMatHang.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            return tongTien;
        }

        //private bool KtChucVu()
        //{
        //    bool kt = false;
        //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nhan_Vien WHERE (MaCV like 'TN%' OR MaCV like 'QL%') AND MaNV='" + txtMaNV.Text + "'", cn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //    {
        //        kt = true;
        //    }
        //    return kt;
        //}

        private bool IsNumber()
        {
            foreach (Char c in txtSoLuong.Text)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private bool KtSoLuong()
        {
            bool kt = false;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sach WHERE MaSach ='" + cbMaSach.Text + "'AND SLtrongKho <'" + txtSoLuong.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                kt = true;
            }
            return kt;
        }

        //private bool KtKhachHang()
        //{
        //    bool kt = false;
        //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Khach_Hang WHERE MaKH='" + txtMaKH.Text + "'", cn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //    {
        //        kt = true;
        //    }
        //    return kt;
        //}

        private bool KtMaHDB()
        {
            bool kt = false;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hoa_Don_Ban WHERE MaHDB='" + txtMaHD.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                kt = true;
            }
            return kt;
        }

        private bool IsCharSL()
        {
            foreach (Char c in txtSoLuong.Text)
            {
                if (Char.IsLetter(c))
                    return false;
            }
            return true;
        }


        private bool IsCharMaHD()
        {
            foreach (Char c in txtMaHD.Text)
            {
                if (Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private bool IsCharThue()
        {
            foreach (Char c in txtthue.Text)
            {
                if (Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private bool IsSymbolThue()
        {
            foreach (Char c in txtthue.Text)
            {
                if (Char.IsSymbol(c))
                    return false;
            }
            return true;
        }

        private bool IsSymbolMaHD()
        {
            foreach (Char c in txtMaHD.Text)
            {
                if (Char.IsSymbol(c))
                    return false;
            }
            return true;
        }

        private bool IsSymbolSL()
        {
            foreach (Char c in txtSoLuong.Text)
            {
                if (Char.IsSymbol(c))
                    return false;
            }
            return true;
        }

        //private bool KtNhanVien()
        //{
        //    bool kt = false;
        //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Nhan_Vien WHERE MaNV='" + txtMaNV.Text + "'", cn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //    {
        //        kt = true;
        //    }
        //    return kt;
        //}

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btInPhieu_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "HÓA ĐƠN BÁN SÁCH";
            printer.TitleColor = Color.Red;
            printer.SubTitle = "Ngày bán: " + dtpNgayBan.Value.Date.ToString("dd-MM-yyyy");
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.OwnerDraw += Printer_OwnerDraw;
            printer.PrintPreviewDataGridView(dgvMatHang);
        }
        private void Printer_OwnerDraw(object sender, DGVCellDrawingEventArgs e)
        {
            e.g.DrawString("Tổng tiền: " + txtTongTien.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 630, 250);
            e.g.DrawString("Thuế: " + txtthue.Text + "%", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 630, 280);
        }
        private void btThemKH_Click(object sender, EventArgs e)
        {
            new frmKhachHang().ShowDialog();
        }

        
    }
}
