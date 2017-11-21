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
    public partial class frmNhanVien : Form
    {
        SqlConnection sqlCon = null;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            string cnstr = ConfigurationManager.ConnectionStrings["Cua_Hang_Sach"].ConnectionString;
            sqlCon = new SqlConnection(cnstr);
            sqlCon.Open();
            string sqlselect = "SELECT *FROM Nhan_Vien";
            SqlCommand command = new SqlCommand(sqlselect, sqlCon);

            SqlDataReader rd = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dtgv1.DataSource = dt;
            sqlCon.Close();
            //string cnstr = " Server = .; Database = BOOKSTORE; Integrated Security = true";
            //sqlCon = new SqlConnection(cnstr);
            //string sql = "Select * From Nhan_Vien";
            //dtgv1.DataSource = GetData(sql);
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
        private List<Object> GetData(string sql)
        {
            //Connect();
            List<Object> list = new List<object>();
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();

            string MaNV;
            string HoNV;
            string TenNV;
            string GioiTinh;
            DateTime NgaySinh;
            string QueQuan;
            string DiaChi;
            string CMND;
            string SDT;
            string MaCV;
            string password;
            string MaLuong;

            while (dr.Read())
            {
                MaNV = dr.GetString(0);
                HoNV = dr.GetString(1);
                TenNV = dr.GetString(2);
                GioiTinh = dr.GetString(3);
                NgaySinh = dr.GetDateTime(4);
                QueQuan = dr.GetString(5);
                DiaChi = dr.GetString(6);
                CMND = dr.GetString(7);
                SDT = dr.GetString(8);
                MaCV = dr.GetString(9);

                password = dr.IsDBNull(10).ToString();
                MaLuong = dr.GetString(11);
                var prod = new
                {
                    MaNV = MaNV,
                    HoNV = HoNV,
                    TenNV = TenNV,
                    GioiTinh = GioiTinh,
                    NgaySinh = NgaySinh,
                    QueQuan = QueQuan,
                    DiaChi = DiaChi,
                    CMND = CMND,
                    SDT = SDT,
                    MaCV = MaCV,
                    password = password,
                    MaLuong = MaLuong
                };
                list.Add(prod);
            };
            dr.Close();
            Disconnect();
            return list;
        }
        private bool kiemtraSutontai(string nhap)
        {
            string kiemtra;
            try
            {
                kiemtra = String.Format(nhap);
            }
            catch (Exception)
            {
                MessageBox.Show(" Nhập sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bool kt = false;
            kiemtra = String.Format(nhap);

            Connect();
            SqlDataAdapter da_kt = new SqlDataAdapter("Select * from Nhan_Vien where MaNV='" + kiemtra + "'", sqlCon);
            DataTable dt_kiemtra = new DataTable();
            da_kt.Fill(dt_kiemtra);
            if (dt_kiemtra.Rows.Count > 0)
            {
                kt = true;

            }
            da_kt.Dispose();
            Disconnect();

            return kt;
        }
        string chuoidung = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasd fghjklzxcvbnm áàảạã ăắằẳẵặ âấầẩẫậ êềễểếệ ùúủũụ ưứừửựữ ìíỉịĩ òóỏõọ ôốồỗộổ ờởớỡợơ yýỳỷỹỵ éèẻẹẽ";//Các kí tự đang nhập
        private bool kiemtrakitu(string chuoiCanKiemTra)
        {
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoidung)
                {
                    if (kiTu == kitu2)
                        dung = true;
                }
                if (dung == false) return false;
            }
            return true;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" && txt6.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên hoặc CMND nhân viên cần tìm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Disconnect();
            }
            else
            {
                Connect();
                SqlCommand kiemtranhanvien = new SqlCommand("select * from Nhan_Vien WHERE MaNV = '" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                SqlDataReader data = kiemtranhanvien.ExecuteReader();
                if (data.Read() != true)
                {
                    MessageBox.Show("Không tìm thấy nhân viên này ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Close();
                    data.Dispose();
                    Disconnect();
                }
                else
                {

                    data.Close();
                    data.Dispose();
                    Disconnect();

                    if (txt1.Text != "" && txt6.Text != "")
                    {
                        MessageBox.Show("Vui lòng chỉ nhập mã nhân viên hoặc CMND nhân viên cần tìm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data.Close();
                        data.Dispose();
                        Disconnect();
                    }

                    else
                    {
                        string sql = "select * FROM Nhan_Vien WHERE MaNV = '" + txt1.Text + "' or CMND='" + txt6.Text + "'";
                        Connect();
                        ///Hiện thông tin lên các nút text box

                        SqlCommand command11 = new SqlCommand("select MaNV from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txt1.Text = (string)command11.ExecuteScalar();
                        SqlCommand command = new SqlCommand("select HoNV from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txt2.Text = (string)command.ExecuteScalar();
                        SqlCommand command1 = new SqlCommand("select TenNV from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txt3.Text = (string)command1.ExecuteScalar();
                        SqlCommand command2 = new SqlCommand("select GioiTinh from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        cbb1.Text = (string)command2.ExecuteScalar();
                        SqlCommand command3 = new SqlCommand("select NgaySinh from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txtNgaySinh.Text = command3.ExecuteScalar().ToString();
                        SqlCommand command4 = new SqlCommand("select QueQuan from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txt4.Text = (string)command4.ExecuteScalar();
                        SqlCommand command5 = new SqlCommand("select DiaChi from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txt5.Text = (string)command5.ExecuteScalar().ToString();
                        SqlCommand command6 = new SqlCommand("select CMND from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txt6.Text = command6.ExecuteScalar().ToString();
                        SqlCommand command7 = new SqlCommand("select SDT from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txt7.Text = command7.ExecuteScalar().ToString();
                        SqlCommand command8 = new SqlCommand("select MaCV from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txt8.Text = command8.ExecuteScalar().ToString();
                        SqlCommand command9 = new SqlCommand("select password from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txt9.Text = (string)command9.ExecuteScalar().ToString();
                        SqlCommand command10 = new SqlCommand("select MaLuong from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txt10.Text = (string)command10.ExecuteScalar().ToString();
                        SqlCommand command12 = new SqlCommand("select TinhTrang from Nhan_Vien where MaNV='" + txt1.Text + "' or CMND='" + txt6.Text + "'", sqlCon);
                        txtTinhTrang.Text = (string)command12.ExecuteScalar().ToString();
                        SqlCommand cmd = new SqlCommand(sql, sqlCon);
                        dtgv1.DataSource = GetData(sql);
                        MessageBox.Show(" Tìm thấy ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Disconnect();
                    }

                }
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (kiemtrakitu(txt2.Text) == false)
            {
                MessageBox.Show(" Có ký tự đặt biệt và số ở họ nhân viên ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt2.Focus();
            }
            else if (kiemtrakitu(txt3.Text) == false)
            {
                MessageBox.Show(" Có ký tự đặt biệt và số ở tên nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt7.Focus();
            }
            else if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "" || cbb1.Text == "" || txtNgaySinh.Text == "" || txt4.Text == "" || txt5.Text == "" || txt6.Text == "" || txt7.Text == "" || txt8.Text == ""  || txt10.Text == "" || txtTinhTrang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên cần thêm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Disconnect();
            }
            else if (kiemtraSutontai(txt1.Text) == true)
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt1.Focus();
            }
            else if (kiemtraSutontai(txt6.Text) == true)
            {
                MessageBox.Show("Số CMND này đã tồn tại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt5.Focus();
            }
            else if (kiemtraSutontai(txt7.Text) == true)
            {
                MessageBox.Show("SDT này đã tồn tại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt5.Focus();
            }
            else
            {
                string sql = "Insert into Nhan_Vien values('" + txt1.Text + "', N'" + txt2.Text + "', N'" + txt3.Text + "', N'" + cbb1.Text + "', N'" + txtNgaySinh.Text + "', N'" + txt4.Text + "', N'" + txt5.Text + "', N'" + txt6.Text + "', N'" + txt7.Text + "', N'" + txt8.Text + "', N'" + txt9.Text + "', N'" + txt10.Text + "', N'" + txtTinhTrang.Text + "')";

                Connect();
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                dtgv1.DataSource = GetData(sql);
                Init();
                MessageBox.Show(" Bạn đã thêm thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disconnect();
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            Connect();
            SqlCommand danhsachcoko = new SqlCommand("select MaNV from Nhan_Vien where MaNV='" + txt1.Text + "'", sqlCon);
            SqlDataReader data = danhsachcoko.ExecuteReader();
            if (data.Read() != true)
            {
                MessageBox.Show("Mã này không có trong danh sách nhân viên ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data.Close();
                data.Dispose();
                Disconnect();
            }
            else
            {
                if (txt1.Text.Trim() == "" || txt2.Text.Trim() == "" || txt3.Text.Trim() == "" || cbb1.Text.Trim() == "" || txtNgaySinh.Text.Trim() == "" || txt4.Text.Trim() == "" || txt5.Text.Trim() == "" || txt6.Text.Trim() == "" || txt7.Text.Trim() == "" || txt8.Text.Trim() == "" || txt10.Text.Trim() == "" || txtTinhTrang.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên và nội dung cần sửa ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Disconnect();
                }
                //else if ( txt6.Text != "txt6.Text")
                //{
                //    MessageBox.Show("Không thể sửa CMND ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    Disconnect();
                //}
                else
                {
                    data.Close();
                    data.Dispose();
                    string sql = "update Nhan_Vien set HoNV=@HoNV,TenNV=@TenNV,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,QueQuan=@QueQuan,DiaChi=@DiaChi,CMND=@CMND,SDT=@SDT,MaCV=@MaCV,password=@password,MaLuong=@MaLuong,TinhTrang=@TinhTrang where MaNV=@MaNV";
                    //string sql = "update Khach_Hang set HoKH= "
                    //string sql = "update Khach_Hang set HoKH=@HoKH,TenKH=@TenKH,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiemTichLuy=@DiemTichLuy where MaKH=@MaKH or SDT=@SDT" ;
                    Connect();
                    SqlCommand cmd = new SqlCommand(sql, sqlCon);
                    cmd.Parameters.AddWithValue("MaNV", txt1.Text);
                    cmd.Parameters.AddWithValue("HoNV", txt2.Text);
                    cmd.Parameters.AddWithValue("TenNV", txt3.Text);
                    cmd.Parameters.AddWithValue("GioiTinh", cbb1.Text);
                    cmd.Parameters.AddWithValue("NgaySinh", txtNgaySinh.Text);
                    cmd.Parameters.AddWithValue("QueQuan", txt4.Text);
                    cmd.Parameters.AddWithValue("DiaChi", txt5.Text);
                    cmd.Parameters.AddWithValue("CMND", txt6.Text);
                    cmd.Parameters.AddWithValue("SDT", txt7.Text);
                    cmd.Parameters.AddWithValue("MaCV", txt8.Text);
                    cmd.Parameters.AddWithValue("password", txt9.Text);
                    cmd.Parameters.AddWithValue("MaLuong", txt10.Text);
                    cmd.Parameters.AddWithValue("TinhTrang", txtTinhTrang.Text);
                    cmd.ExecuteNonQuery();
                    Init();
                    MessageBox.Show(" Bạn đã sửa thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disconnect();
                }
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
            txt4.Text = null;
            txt5.Text = null;
            txt6.Text = null;
            txt7.Text = null;
            txt8.Text = null;
            txt9.Text = null;
            txt10.Text = null;
            cbb1.Text = null;
            txtNgaySinh.Text = null;
            txtTinhTrang.Text = null;
            Init();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt1.Text = dtgv1.CurrentRow.Cells[0].Value.ToString();
            txt2.Text = dtgv1.CurrentRow.Cells[1].Value.ToString();
            txt3.Text = dtgv1.CurrentRow.Cells[2].Value.ToString();
            cbb1.Text = dtgv1.CurrentRow.Cells[3].Value.ToString();
            txtNgaySinh.Text = dtgv1.CurrentRow.Cells[4].Value.ToString();
            txt4.Text = dtgv1.CurrentRow.Cells[5].Value.ToString();
            txt5.Text = dtgv1.CurrentRow.Cells[6].Value.ToString();
            txt6.Text = dtgv1.CurrentRow.Cells[7].Value.ToString();
            txt7.Text = dtgv1.CurrentRow.Cells[8].Value.ToString();
            txt8.Text = dtgv1.CurrentRow.Cells[9].Value.ToString();
            txt9.Text = dtgv1.CurrentRow.Cells[10].Value.ToString();
            txt10.Text = dtgv1.CurrentRow.Cells[11].Value.ToString();
            txtTinhTrang.Text = dtgv1.CurrentRow.Cells[12].Value.ToString();
        }

        private void btQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
