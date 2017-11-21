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
    public partial class frmNhapSach : Form
    {
        SqlConnection sqlCon = null;
        ErrorProvider Error = new ErrorProvider();

        public int Thue { get; private set; }

        public frmNhapSach()
        {
            InitializeComponent();
        }

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            KetnoiCSDL();
            btThemSach.Enabled = false;
            btXoaSach.Enabled = false;
            btSua.Enabled = false;
            btIn.Enabled = false;
            txtMaPhieuNhap.Focus();
        }
        
        private void KetnoiCSDL()
        {
            string cnstr = ConfigurationManager.ConnectionStrings["Cua_Hang_Sach"].ConnectionString;
            sqlCon = new SqlConnection(cnstr);
            string sql = "Select Hoa_Don_Mua.*,MaSach,GiaMua,SoLuong From Hoa_Don_Mua, Chi_Tiet_HDM where Hoa_Don_Mua.MaHDM=Chi_Tiet_HDM.MaHDM";
            SqlCommand com = new SqlCommand(sql, sqlCon);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Disconnect();
            dataGridView2.DataSource = dt;
        }
        private void CSDLChi_Tiet_HDM()
        {
            Connect();
            string sql = "Select * From Chi_Tiet_HDM";
            SqlCommand com = new SqlCommand(sql, sqlCon);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Disconnect();
            dataGridView2.DataSource = dt;
        }
        private void Connect()
        {
            try
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(" /n", ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" /n", ex.Message);
            }
        }
        private void Disconnect()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        private void btXemPhieu_Click(object sender, EventArgs e)
        {
            Connect();
            Error.Clear();
            SqlCommand TimSach = new SqlCommand("select * FROM Hoa_Don_Mua, Chi_Tiet_HDM WHERE Hoa_Don_Mua.MaHDM = Chi_Tiet_HDM.MaHDM and Hoa_Don_Mua.MaHDM= '" + txtMaPhieuNhap.Text + "'", sqlCon);
            SqlDataReader data = TimSach.ExecuteReader();
            Error.Clear();
            if (data.Read() != true)
            {
                MessageBox.Show("Không tìm thấy Phiếu nhập này hoặc bạn nhập sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtMaPhieuNhap, "Không tìm thấy phiếu nhập này");
                txtMaPhieuNhap.Focus();
                data.Close();
                data.Dispose();
                Disconnect();

            }
            else
            {
                data.Close();
                data.Dispose();
                Disconnect();
                if (txtMaPhieuNhap.Text == "")
                {
                    MessageBox.Show("Nhập mã phiếu cần tìm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Close();
                    data.Dispose();
                    Disconnect();
                }


                else
                {
                    string sql = "select * FROM Hoa_Don_Mua, Chi_Tiet_HDM WHERE Hoa_Don_Mua.MaHDM = Chi_Tiet_HDM.MaHDM and Hoa_Don_Mua.MaHDM = '" + txtMaPhieuNhap.Text + "'";
                    Connect();

                    SqlCommand command = new SqlCommand("select NgayNhap   FROM Hoa_Don_Mua, Chi_Tiet_HDM WHERE Hoa_Don_Mua.MaHDM = Chi_Tiet_HDM.MaHDM and Hoa_Don_Mua.MaHDM= '" + txtMaPhieuNhap.Text + "'", sqlCon);
                    txtNgayNhap.Text = command.ExecuteScalar().ToString();
                    SqlCommand command1 = new SqlCommand("select MaNCC   FROM Hoa_Don_Mua, Chi_Tiet_HDM WHERE Hoa_Don_Mua.MaHDM = Chi_Tiet_HDM.MaHDM and Hoa_Don_Mua.MaHDM= '" + txtMaPhieuNhap.Text + "'", sqlCon);
                    int Mancc = (int)command1.ExecuteScalar();
                    SqlCommand command2 = new SqlCommand("select MaSach FROM Hoa_Don_Mua, Chi_Tiet_HDM WHERE Hoa_Don_Mua.MaHDM = Chi_Tiet_HDM.MaHDM and Hoa_Don_Mua.MaHDM= '" + txtMaPhieuNhap.Text + "'", sqlCon);
                    txtMaSach.Text = (string)command2.ExecuteScalar();
                    SqlCommand command3 = new SqlCommand("select GiaMua FROM Hoa_Don_Mua, Chi_Tiet_HDM WHERE Hoa_Don_Mua.MaHDM = Chi_Tiet_HDM.MaHDM and Hoa_Don_Mua.MaHDM= '" + txtMaPhieuNhap.Text + "'", sqlCon);
                    int giamua = Convert.ToInt32(command3.ExecuteScalar());
                    SqlCommand command4 = new SqlCommand("select SoLuong FROM Hoa_Don_Mua, Chi_Tiet_HDM WHERE Hoa_Don_Mua.MaHDM = Chi_Tiet_HDM.MaHDM and Hoa_Don_Mua.MaHDM= '" + txtMaPhieuNhap.Text + "'", sqlCon);
                    int SL = (int)command4.ExecuteScalar();

                    SqlCommand command6 = new SqlCommand("select Thue FROM Hoa_Don_Mua, Chi_Tiet_HDM WHERE Hoa_Don_Mua.MaHDM = Chi_Tiet_HDM.MaHDM and Hoa_Don_Mua.MaHDM= '" + txtMaPhieuNhap.Text + "'", sqlCon);
                    if (command6.ExecuteScalar().ToString() == "")
                    {
                        txtThue.Text = "";
                    }
                    else
                        txtThue.Text = command6.ExecuteScalar().ToString();
                    txtMaNCC.Text = Mancc.ToString();

                    //txtMaGiamGia.Text = Magg.ToString();
                    //txtThue.Text = thue.ToString();
                    txtGiaMua.Text = giamua.ToString();
                    txtSLSachMua.Text = SL.ToString();
                    //truy xuất ô tìm kiếm dc trên Sql

                    string S = "select * FROM  Chi_Tiet_HDM WHERE Chi_Tiet_HDM.MaHDM=@MaHDM";
                    SqlCommand command0 = new SqlCommand(S, sqlCon);
                    command0.Parameters.AddWithValue("MaHDM", txtMaPhieuNhap.Text);
                    command0.Parameters.AddWithValue("NgayNhap", txtNgayNhap.Text);
                    command0.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
                    command0.Parameters.AddWithValue("MaSach", txtMaSach.Text);
                    command0.Parameters.AddWithValue("GiaMua", txtGiaMua.Text);
                    command0.Parameters.AddWithValue("SoLuong", txtSLSachMua.Text);
                    command0.Parameters.AddWithValue("Thue", txtThue.Text);
                    command0.ExecuteNonQuery();
                    SqlDataReader dr = command0.ExecuteReader();
                    DataTable dt = new DataTable();
                    //SqlCommand cmd = new SqlCommand(sql, sqlCon);
                    dt.Load(dr);
                    dataGridView2.DataSource = dt;
                    double sum = 0;
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        sum += (Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value));
                    }
                    if (txtThue.Text == "")
                    {
                        Thue = 0;
                        lbTongTien.Text = sum.ToString();
                    }
                    else
                    {
                        Thue = Convert.ToInt16(txtThue.Text);
                        lbTongTien.Text = (sum + sum * (Convert.ToDouble(txtThue.Text) / 100)).ToString();
                    }
                    sqlCon.Close();
                    //MessageBox.Show(" Tìm thấy ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaPhieuNhap.Enabled = false;
                    txtNgayNhap.Enabled = false;
                    txtMaNCC.Enabled = false;
                    txtThue.Enabled = false;
                    btLapMoi.Enabled = false;
                    btThemSach.Enabled = true;
                    btSua.Enabled = true;
                    btXoaSach.Enabled = true;
                    btIn.Enabled = true;
                    Disconnect();
                }
            }
        }

        private void btLapMoi_Click(object sender, EventArgs e)
        {
            Error.Clear();
            if (txtMaPhieuNhap.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Dử Liệu Cho Ô Mã Phiếu Nhập  ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPhieuNhap.Focus();
            }
            else if (txtNgayNhap.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Dử Liệu Cho Ô Ngày Nhập  ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgayNhap.Focus();
            }
            else if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Dử Liệu Cho Ô Mã Cung Câp  ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
            }
            else if (Convert.ToInt32(txtThue.Text) < 0 || Convert.ToInt32(txtThue.Text) > 100)
            {
                MessageBox.Show(" Bạn nhập % không hợp lệ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPhieuNhap.Focus();
            }
            else
            {
                Connect();
                SqlCommand cmdtk = new SqlCommand("select MaHDM from Hoa_Don_Mua where MaHDM='" + txtMaPhieuNhap.Text + "'", sqlCon);
                SqlDataReader data = cmdtk.ExecuteReader();
                if (data.Read() == true)
                {

                    MessageBox.Show(" Mã Hóa Đơn Này Đã có  ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Dispose();
                    data.Close();
                    Disconnect();
                }
                else
                {
                    //doc trên bảng Nha_Cung_Cap 
                    // chưa có thì báo lỗi
                    //có thì thực hiện chưc năng thêm
                    data.Dispose();
                    data.Close();
                    SqlCommand cmdtk1 = new SqlCommand("select MaNCC from Nha_Cung_Cap where MaNCC='" + txtMaNCC.Text + "'", sqlCon);
                    SqlDataReader data1 = cmdtk1.ExecuteReader();
                    if (data1.Read() != true)
                    {
                        MessageBox.Show(" Mã Nhà Cung Cấp  Này không có  ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data1.Dispose();
                        data1.Close();
                        Disconnect();
                    }
                    else
                    {
                        if (txtThue.Text == "")
                        {
                            data1.Dispose();
                            data1.Close();
                            Disconnect();
                            sqlCon.Open();
                            SqlCommand cmd = new SqlCommand("Insert into Hoa_Don_Mua(MaHDM,NgayNhap,MaNCC) Values('" + txtMaPhieuNhap.Text + "',N'" + txtNgayNhap.Text + "',N'" + txtMaNCC.Text + "')", sqlCon);
                            cmd.ExecuteNonQuery();

                            //// Hiển Thị
                            string S = "select * FROM  Chi_Tiet_HDM WHERE Chi_Tiet_HDM.MaHDM=@MaHDM";
                            SqlCommand command0 = new SqlCommand(S, sqlCon);
                            command0.Parameters.AddWithValue("MaHDM", txtMaPhieuNhap.Text);
                            SqlDataReader dr = command0.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dataGridView2.DataSource = dt;
                            //// Tắt chức năng
                            txtMaPhieuNhap.Enabled = false;
                            txtNgayNhap.Enabled = false;
                            txtMaNCC.Enabled = false;
                            txtThue.Enabled = false;
                            btLapMoi.Enabled = false;
                            btThemSach.Enabled = true;
                            btXoaSach.Enabled = true;
                            btSua.Enabled = true;
                            btIn.Enabled = true;
                            btXemPhieu.Enabled = false;
                            ////Gán  DataGridView Rổng
                            dataGridView2.DataSource = null;
                            Disconnect();
                        }
                        else
                        {
                            data1.Dispose();
                            data1.Close();
                            Disconnect();
                            Connect();
                            SqlCommand cmd = new SqlCommand("Insert into Hoa_Don_Mua(MaHDM,NgayNhap,MaNCC,Thue) Values('" + txtMaPhieuNhap.Text + "',N'" + txtNgayNhap.Text + "',N'" + txtMaNCC.Text + "',N'" + txtThue.Text + "')", sqlCon);
                            cmd.ExecuteNonQuery();

                            //// Hiển Thị
                            string S = "select * FROM  Chi_Tiet_HDM WHERE Chi_Tiet_HDM.MaHDM=@MaHDM";
                            SqlCommand command0 = new SqlCommand(S, sqlCon);
                            command0.Parameters.AddWithValue("MaHDM", txtMaPhieuNhap.Text);
                            SqlDataReader dr = command0.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dataGridView2.DataSource = dt;
                            //// đóng mở chức năng
                            txtMaPhieuNhap.Enabled = false;
                            txtNgayNhap.Enabled = false;
                            txtMaNCC.Enabled = false;
                            txtThue.Enabled = false;
                            btLapMoi.Enabled = false;
                            btThemSach.Enabled = true;
                            btXoaSach.Enabled = true;
                            btSua.Enabled = true;
                            btIn.Enabled = true;
                            btXemPhieu.Enabled = false;
                            ////Gán về rỗng
                            dataGridView2.DataSource = null;
                            Disconnect();
                        }
                    }
                }
                Disconnect();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Error.Clear();
            if (txtMaSach.Text == "" || txtGiaMua.Text == "" || txtSLSachMua.Text == "")
            {
                MessageBox.Show(" Dử Liệu Của Bạn Đang Trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtMaSach.Text == "")
                    txtMaSach.Focus();
                if (txtSLSachMua.Text == "")
                    txtSLSachMua.Focus();
                if (txtGiaMua.Text == "")
                    txtGiaMua.Focus();
            }
            else
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("Update Chi_Tiet_HDM Set MaSach=@MaSach,GiaMua=@GiaMua,SoLuong=@SoLuong where MaHDM=@MaHDM and MaSach=@MaSach", sqlCon);
                cmd.Parameters.AddWithValue("MaHDM", txtMaPhieuNhap.Text);
                cmd.Parameters.AddWithValue("MaSach", txtMaSach.Text);
                cmd.Parameters.AddWithValue("GiaMua", txtGiaMua.Text);
                cmd.Parameters.AddWithValue("SoLuong", txtSLSachMua.Text);
                cmd.ExecuteNonQuery();
                //// Hiển Thị
                string S = "select * FROM  Chi_Tiet_HDM WHERE Chi_Tiet_HDM.MaHDM=@MaHDM";
                SqlCommand command0 = new SqlCommand(S, sqlCon);
                command0.Parameters.AddWithValue("MaHDM", txtMaPhieuNhap.Text);
                SqlDataReader dr = command0.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
                //Tong Tiền
                double sum = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    sum += (Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value));
                }
                if (txtThue.Text == "")
                {
                    Thue = 0;
                    lbTongTien.Text = sum.ToString();
                }
                else
                {
                    Thue = Convert.ToInt16(txtThue.Text);
                    lbTongTien.Text = (sum + sum * (Convert.ToDouble(txtThue.Text) / 100)).ToString();
                }
                MessageBox.Show(" Bạn Sửa Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlCon.Close();
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            Error.Clear();
            printPreviewDialog1.Document = printDocument1;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Na_Na;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString(" Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 350, 170);
            e.Graphics.DrawString(" STT", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 25, 210);
            e.Graphics.DrawString(" Mã HDM ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 200, 210);
            e.Graphics.DrawString(" Mã Sách ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 350, 210);
            e.Graphics.DrawString(" Số Lượng Mua ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 500, 210);
            e.Graphics.DrawString(" Giá Mua ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 700, 210);
            int y = 250;
            int STT = 1;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(STT.ToString() + ".", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 40, y);
                e.Graphics.DrawString(Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value).ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 220, y);
                e.Graphics.DrawString(dataGridView2.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 365, y);
                e.Graphics.DrawString(Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value).ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 550, y);
                e.Graphics.DrawString(Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value).ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 720, y);
                y = y + 40;
                STT++;
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 25, y);
            e.Graphics.DrawString(" Tổng Tiền: " + lbTongTien.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 600, y + 80);
            e.Graphics.DrawString(" Thuế     :     " + Thue.ToString() + " %", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 600, y + 40);

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoaSach_Click(object sender, EventArgs e)
        {
            Error.Clear();
            if (txtMaSach.Text == "")
            {
                MessageBox.Show(" Bạn Chưa Nhap Mã Sách ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
            }
            else
            {
                Connect();
                SqlCommand cmdtk = new SqlCommand("select MaHDM from Chi_Tiet_HDM where MaHDM='" + txtMaPhieuNhap.Text + "'", sqlCon);
                SqlDataReader data = cmdtk.ExecuteReader();
                if (data.Read() == true)
                {
                    data.Close();
                    data.Dispose();
                    SqlCommand cmdtk1 = new SqlCommand("select MaSach from Chi_Tiet_HDM where MaSach='" + txtMaSach.Text + "'", sqlCon);
                    SqlDataReader data1 = cmdtk1.ExecuteReader();
                    if (data1.Read() == true)
                    {
                        if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Disconnect();
                            data1.Close();
                            data1.Dispose();
                            Connect();
                            SqlCommand cmd = new SqlCommand("Delete from Chi_Tiet_HDM where MaHDM=@MaHDM and MaSach=@MaSach", sqlCon);
                            cmd.Parameters.AddWithValue("MaHDM", txtMaPhieuNhap.Text);
                            cmd.Parameters.AddWithValue("MaSach", txtMaSach.Text);
                            cmd.ExecuteNonQuery();
                            ////Hiễn Thị
                            string S = "select * FROM  Chi_Tiet_HDM WHERE Chi_Tiet_HDM.MaHDM=@MaHDM";
                            SqlCommand command0 = new SqlCommand(S, sqlCon);
                            command0.Parameters.AddWithValue("MaHDM", txtMaPhieuNhap.Text);
                            SqlDataReader dr = command0.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dataGridView2.DataSource = dt;
                            //Tong Tiền
                            double sum = 0;
                            for (int i = 0; i < dataGridView2.Rows.Count; i++)
                            {
                                sum += (Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value));
                            }
                            if (txtThue.Text == "")
                            {
                                Thue = 0;
                                lbTongTien.Text = sum.ToString();
                            }
                            else
                            {
                                Thue = Convert.ToInt16(txtThue.Text);
                                lbTongTien.Text = (sum + sum * (Convert.ToDouble(txtThue.Text) / 100)).ToString();
                            }
                            MessageBox.Show(" Xóa Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sqlCon.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Không Tìm Thấy Mã Sách Bạn Cần Xóa ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            Disconnect();
        }

        private void btThemSach_Click(object sender, EventArgs e)
        {
            Error.Clear();
            if (txtMaSach.Text == "" || txtSLSachMua.Text == "" || txtGiaMua.Text == "")
            {
                MessageBox.Show(" Bạn Chưa Nhap dử liệu  ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtGiaMua.Text == "")
                {
                    txtGiaMua.Focus();
                }
                if (txtMaSach.Text == "")
                {

                    txtMaSach.Focus();
                }
                if (txtSLSachMua.Text == "")
                {

                    txtSLSachMua.Focus();
                }
            }
            else
            {
                Connect();
                SqlCommand cmdtk = new SqlCommand("select MaHDM,MaSach from Chi_Tiet_HDM where MaHDM='" + txtMaPhieuNhap.Text + "'and MaSach='" + txtMaSach.Text + "'", sqlCon);
                SqlDataReader data = cmdtk.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show(" Đã Tồn Tại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Close();
                    data.Dispose();
                    sqlCon.Close();
                }
                else
                {
                    data.Close();
                    data.Dispose();
                    //    SqlCommand cmdtk1 = new SqlCommand("select MaSach from Sach where MaSach='" + txtMaSach.Text + "'", sqlCon);
                    //    SqlDataReader data1 = cmdtk1.ExecuteReader();
                    //    if (data1.Read() != true)
                    //    {
                    //        MessageBox.Show(" Mã Sách Này Không có ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        data1.Close();
                    //        data1.Dispose();
                    //        Disconnect();
                    //    }
                    //    else
                    ////    {
                    //      Disconnect();
                    Connect();
                    SqlCommand cmd = new SqlCommand("Insert Into Chi_Tiet_HDM(MaHDM,MaSach,GiaMua,SoLuong)" + "Values ('" + Convert.ToInt32(txtMaPhieuNhap.Text) + "',N'" + txtMaSach.Text + "',N'" + Convert.ToInt32(txtGiaMua.Text) + "',N'" + Convert.ToInt32(txtSLSachMua.Text) + "')", sqlCon);
                    cmd.ExecuteNonQuery();
                    // Hiển Thị
                    string S = "select * FROM  Chi_Tiet_HDM WHERE Chi_Tiet_HDM.MaHDM=@MaHDM";
                    SqlCommand command0 = new SqlCommand(S, sqlCon);
                    command0.Parameters.AddWithValue("MaHDM", txtMaPhieuNhap.Text);
                    SqlDataReader dr = command0.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView2.DataSource = dt;
                    //Tong Tiền
                    double sum = 0;
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        sum += (Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value));
                    }
                    if (txtThue.Text == "")
                    {
                        Thue = 0;
                        lbTongTien.Text = sum.ToString();
                    }
                    else
                    {
                        Thue = Convert.ToInt16(txtThue.Text);
                        lbTongTien.Text = (sum + sum * (Convert.ToDouble(txtThue.Text) / 100)).ToString();
                    }
                    MessageBox.Show(" Thêm Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlCon.Close();

                    //}

                }
                Disconnect();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            KetnoiCSDL();
            lbTongTien.Text = "0";
            btThemSach.Enabled = false;
            btXoaSach.Enabled = false;
            btSua.Enabled = false;
            btIn.Enabled = false;
            txtGiaMua.Text = null;
            txtMaNCC.Text = null;
            txtMaPhieuNhap.Text = null;
            txtMaSach.Text = null;
            txtNgayNhap.Text = null;
            txtSLSachMua.Text = null;
            txtThue.Text = null;
            txtMaPhieuNhap.Enabled = true;
            txtNgayNhap.Enabled = true;
            txtMaNCC.Enabled = true;
            txtThue.Enabled = true;
            btLapMoi.Enabled = true;
        }

        private void txtMaPhieuNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtGiaMua.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtSLSachMua.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtGiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSLSachMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
