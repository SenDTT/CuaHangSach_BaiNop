using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangSach
{
    public class HoaDonBan
    {
        string maHDB, ngayBan, maNV;
        int maKH, thue;

        public string MaHDB
        {
            get { return maHDB; }
            set { maHDB = value; }
        }

        public string NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }

        public int MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public int Thue
        {
            get { return thue; }
            set { thue = value; }
        }

        public HoaDonBan() { }
        public HoaDonBan(string maHDB, string ngayBan, int maKH, string maNV, int thue)
        {
            this.maHDB = maHDB;
            this.ngayBan = ngayBan;
            this.maKH = maKH;
            this.maNV = maNV;
            this.thue = thue;
        }
    }
}
