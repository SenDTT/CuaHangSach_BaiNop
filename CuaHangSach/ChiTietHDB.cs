using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangSach
{
    public class ChiTietHDB
    {
        string maHDB, maSach;
        double donGiaBan;
        int soLuong;

        public string MaHDB
        {
            get { return maHDB; }
            set { maHDB = value; }
        }

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public double DonGiaBan
        {
            get { return donGiaBan; }
            set { donGiaBan = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public ChiTietHDB() { }
        public ChiTietHDB(string maHDB, string maSach, double donGiaBan, int soLuong)
        {
            this.maHDB = maHDB;
            this.maSach = maSach;
            this.donGiaBan = donGiaBan;
            this.soLuong = soLuong;
        }
    }
}