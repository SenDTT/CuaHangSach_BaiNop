using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangSach
{
    public class TestKhachHang
    {
        string MaKH, HoKH, TenKH, diachi, quequan, ngaysinh;
        int DiemTichLuy;


        public string Ma
        {
            get { return MaKH; }
            set { MaKH = value; }

        }
        public string Ho
        {
            get { return HoKH; }
            set { HoKH = value; }

        }
        public string Ten
        {
            get { return TenKH; }
            set { TenKH = value; }

        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string QueQuan
        {
            get { return quequan; }
            set { quequan = value; }
        }
        public string NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public int DiemTL
        {
            get { return DiemTichLuy; }
            set { DiemTichLuy = value; }
        }
        public TestKhachHang() { }
        public TestKhachHang(string MaKH, string HoKH, string TenKH, string diachi, string quequan, string ngaysinh, int Diem)
        {
            this.MaKH = MaKH;
            this.Ho = HoKH;
            this.Ten = TenKH;
            this.quequan = quequan;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
            this.DiemTichLuy = Diem;
        }

    }
}
