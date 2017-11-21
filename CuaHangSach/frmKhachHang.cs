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
    public partial class frmKhachHang : Form
    {
        SqlConnection sqlCon = null;
        //int numberOfRows = 0;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            string cnstr = ConfigurationManager.ConnectionStrings["Cua_Hang_Sach"].ConnectionString;
            sqlCon = new SqlConnection(cnstr);
            string sql = "Select * From Khach_Hang";
            dtgv1.DataSource = GetData(sql);

        }

        private List<Object> GetData(string sql)
        {
            Connect();
            //sql = "Select * From Khach_Hang";
            List<Object> list = new List<object>();
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            SqlDataReader dr = cmd.ExecuteReader();

            int MaKH;
            string HoKH;
            string TenKH;
            string GioiTinh;
            DateTime NgaySinh;
            string SDT;
            int DiemTichLuy;
            while (dr.Read())
            {
                MaKH = dr.GetInt32(0);
                HoKH = dr.GetString(1);
                TenKH = dr.GetString(2);
                GioiTinh = dr.GetString(3);
                NgaySinh = dr.GetDateTime(4);
                SDT = dr.GetString(5);
                DiemTichLuy = dr.GetInt32(6);
                var prod = new
                {
                    MaKH = MaKH,
                    HoKH = HoKH,
                    TenKH = TenKH,
                    GioiTinh = GioiTinh,
                    NgaySinh = NgaySinh,
                    SDT = SDT,
                    DiemTichLuy = DiemTichLuy
                };
                list.Add(prod);
            };
            dr.Close();
            Disconnect();
            return list;
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
        private void bt1_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" && txt5.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng hoặc SDT khách hàng cần tìm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Connect();
                SqlCommand kiemtrakhachhang = new SqlCommand("select * FROM Khach_Hang WHERE MaKH = '" + txt1.Text + "' or SDT='" + txt5.Text + "'", sqlCon);
                SqlDataReader data = kiemtrakhachhang.ExecuteReader();

                if (data.Read() != true)
                {
                    MessageBox.Show("Không tìm thấy khách hàng này ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Close();
                    data.Dispose();
                    Disconnect();

                }
                else
                {

                    data.Close();
                    data.Dispose();
                    Disconnect();
                    if (txt1.Text != "" && txt5.Text != "")
                    {
                        MessageBox.Show("Vui lòng chỉ nhập mã khách hàng hoặc SDT khách hàng cần tìm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data.Close();
                        data.Dispose();
                        Disconnect();
                    }

                    else
                    {
                        string sql = "select * FROM Khach_Hang WHERE MaKH = '" + txt1.Text + "' or SDT='" + txt5.Text + "'";
                        Connect();
                        ///Hiện thông tin lên các nút text box

                        SqlCommand command6 = new SqlCommand("select MaKH from Khach_Hang where MaKH='" + txt1.Text + "' or SDT='" + txt5.Text + "'", sqlCon);
                        txt1.Text = command6.ExecuteScalar().ToString();
                        SqlCommand command = new SqlCommand("select HoKH from Khach_Hang where MaKH='" + txt1.Text + "' or SDT='" + txt5.Text + "'", sqlCon);
                        txt2.Text = (string)command.ExecuteScalar();
                        SqlCommand command1 = new SqlCommand("select TenKH from Khach_Hang where MaKH='" + txt1.Text + "' or SDT='" + txt5.Text + "'", sqlCon);
                        txt7.Text = (string)command1.ExecuteScalar();
                        SqlCommand command2 = new SqlCommand("select GioiTinh from Khach_Hang where MaKH='" + txt1.Text + "' or SDT='" + txt5.Text + "'", sqlCon);
                        cbb1.Text = (string)command2.ExecuteScalar();
                        SqlCommand command3 = new SqlCommand("select NgaySinh from Khach_Hang where MaKH='" + txt1.Text + "' or SDT='" + txt5.Text + "'", sqlCon);
                        txtNgaySinh.Text = command3.ExecuteScalar().ToString();
                        SqlCommand command4 = new SqlCommand("select SDT from Khach_Hang where MaKH='" + txt1.Text + "' or SDT='" + txt5.Text + "'", sqlCon);
                        txt5.Text = (string)command4.ExecuteScalar();
                        SqlCommand command5 = new SqlCommand("select DiemTichLuy from Khach_Hang where MaKH='" + txt1.Text + "' or SDT='" + txt5.Text + "'", sqlCon);
                        txt6.Text = command5.ExecuteScalar().ToString();

                        SqlCommand cmd = new SqlCommand(sql, sqlCon);
                        dtgv1.DataSource = GetData(sql);
                        MessageBox.Show(" Tìm thấy ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Disconnect();
                    }

                }
            }
        }

        private void bt2_Them_Click(object sender, EventArgs e)
        {
            if (kiemtrakitu(txt2.Text) == false)
            {
                MessageBox.Show(" Có ký tự đặt biệt và số ở họ khách hàng ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt2.Focus();
            }
            else if (kiemtrakitu(txt7.Text) == false)
            {
                MessageBox.Show(" Có ký tự đặt biệt và số ở tên khách hàng ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt7.Focus();
            }
            else if (txt1.Text == "" || txt2.Text == "" || txt7.Text == "" || cbb1.Text == "" || txtNgaySinh.Text == "" || txt5.Text == "" || txt6.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng cần thêm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Disconnect();
            }
            else if (kiemtraSutontai(txt1.Text) == true)
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt1.Focus();
            }
            else if (kiemtraSutontai(txt5.Text) == true)
            {
                MessageBox.Show("SDT này đã tồn tại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt5.Focus();
            }
            else
            {
                string sql = "Insert into Khach_Hang values('" + txt1.Text + "', N'" + txt2.Text + "', N'" + txt7.Text + "', N'" + cbb1.Text + "', N'" + txtNgaySinh.Text + "', N'" + txt5.Text + "', N'" + txt6.Text + "')";

                Connect();
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                dtgv1.DataSource = GetData(sql);
                Init();
                MessageBox.Show(" Bạn đã thêm thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disconnect();
            }
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

        private void bt3_Sua_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "" || txt7.Text == "" || cbb1.Text == "" || txtNgaySinh.Text == "" || txt5.Text == "" || txt6.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng và nội dung cần sửa ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Connect();
                SqlCommand danhsachcoko = new SqlCommand("select MaKH from Khach_Hang where MaKH='" + txt1.Text + "'", sqlCon);
                SqlDataReader data = danhsachcoko.ExecuteReader();
                if (data.Read() != true)
                {
                    MessageBox.Show("Mã này không có trong danh sách khách hàng ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Close();
                    data.Dispose();
                    Disconnect();
                }
                else
                {
                    if (txt1.Text == "" || txt2.Text == "" || txt7.Text == "" || cbb1.Text == "" || txtNgaySinh.Text == "" || txt5.Text == "" || txt6.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng và nội dung cần sửa ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Disconnect();
                    }
                    //else if (txt1.Text != "txt1.Text" && txt5.Text != "txt5.Text")
                    //{
                    //    MessageBox.Show("Không thể sửa MaKH và SDT ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //    Disconnect();
                    //}
                    else
                    {
                        data.Close();
                        data.Dispose();
                        string sql = "update Khach_Hang set HoKH=@HoKH,TenKH=@TenKH,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,SDT=@SDT,DiemTichLuy=@DiemTichLuy where MaKH=@MaKH";
                        //string sql = "update Khach_Hang set HoKH= "
                        //string sql = "update Khach_Hang set HoKH=@HoKH,TenKH=@TenKH,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiemTichLuy=@DiemTichLuy where MaKH=@MaKH or SDT=@SDT" ;
                        Connect();
                        SqlCommand cmd = new SqlCommand(sql, sqlCon);
                        cmd.Parameters.AddWithValue("MaKH", txt1.Text);
                        cmd.Parameters.AddWithValue("HoKH", txt2.Text);
                        cmd.Parameters.AddWithValue("TenKH", txt7.Text);
                        cmd.Parameters.AddWithValue("GioiTinh", cbb1.Text);
                        cmd.Parameters.AddWithValue("NgaySinh", txtNgaySinh.Text);
                        cmd.Parameters.AddWithValue("SDT", txt5.Text);
                        cmd.Parameters.AddWithValue("DiemTichLuy", txt6.Text);
                        cmd.ExecuteNonQuery();
                        Init();
                        MessageBox.Show(" Bạn đã sửa thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Disconnect();
                    }
                }
            }
        }

        private void bt4_clear_Click(object sender, EventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            txt5.Text = null;
            txt6.Text = null;
            txt7.Text = null;
            cbb1.Text = null;
            txtNgaySinh.Text = null;

            Init();
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
            SqlDataAdapter da_kt = new SqlDataAdapter("Select * from Khach_Hang where MaKH='" + kiemtra + "'", sqlCon);
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

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}