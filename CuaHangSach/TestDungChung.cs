using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CuaHangSach
{
    public class TestDungChung
    {
        SqlConnection con = new SqlConnection(@" Server = .; Database = Cua_Hang_Sach; Integrated Security = true");
        public bool kiemtrarong(string kt)
        {
            if (kt == "")
                return true;
            return false;
        }
        public bool kiemtratontai(string kiemtra)
        {

            bool kt = false;
            con.Open();
            SqlDataAdapter da_kt = new SqlDataAdapter("Select * from Khach_Hang where MaKH='" + Convert.ToInt16(kiemtra) + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kt.Fill(dt_kiemtra);
            if (dt_kiemtra.Rows.Count > 0)
            {
                kt = true;

            }
            da_kt.Dispose();
            con.Close();

            return kt;
        }
        string chuoidung = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasd fghjklzxcvbnm áàảạã ăắằẳẵặ âấầẩẫậ êềễểếệ ùúủũụ ưứừửựữ ìíỉịĩ òóỏõọ ôốồỗộổ ờởớỡợơ yýỳỷỹỵ éèẻẹẽ";//Các kí tự đang nhập
        public bool kiemtrakitu(string chuoiCanKiemTra)
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

        public bool kiemtrSDTtontai(string kiemtra)
        {
            bool kt = false;
            con.Open();
            SqlDataAdapter da_kt = new SqlDataAdapter("Select * from Khach_Hang where SDT='" + kiemtra + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kt.Fill(dt_kiemtra);
            if (dt_kiemtra.Rows.Count > 0)
            {
                kt = true;

            }
            da_kt.Dispose();
            con.Close();

            return kt;
        }

        public bool kiemtrCMNDtontai(string kiemtra)
        {
            bool kt = false;
            con.Open();
            SqlDataAdapter da_kt = new SqlDataAdapter("Select * from Nhan_Vien where CMND='" + kiemtra + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kt.Fill(dt_kiemtra);
            if (dt_kiemtra.Rows.Count > 0)
            {
                kt = true;

            }
            da_kt.Dispose();
            con.Close();

            return kt;
        }

        public bool DodaiSDT(string kt)
        {
            if (kt.Count() >= 10 && kt.Count() <= 11)
                return true;
            return false;
        }
        public bool DodaiCMND(string kt)
        {
            if (kt.Count() == 9 || kt.Count() == 12)
                return true;
            return false;
        }

    }
}
