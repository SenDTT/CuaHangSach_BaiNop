using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangSach
{
    public class NhapSach
    {
        int maHDM, thue, soLuong;
        string ngayNhap, maSach, maNCC;
        double giaMua;

        public int MaHDM
        {
            get { return maHDM; }
            set { maHDM = value; }
        }
        public string NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public int Thue
        {
            get { return thue; }
            set { thue = value; }
        }
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public double GiaMua
        {
            get { return giaMua; }
            set { giaMua = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public NhapSach() { }
        public NhapSach(int maHDM, string ngayNhap, string maNCC, int thue, string maSach, double giaMua, int soLuong)
        {
            this.maHDM = maHDM;
            this.ngayNhap = ngayNhap;
            this.maNCC = maNCC;
            this.thue = thue;
            this.maSach = maSach;
            this.giaMua = giaMua;
            this.soLuong = soLuong;
        }
    }
}
