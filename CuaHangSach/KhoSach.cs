using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangSach
{
    public class KhoSach
    {
        string maSach, tenSach, nhaXB, maTheLoai, maGiamGia, tinhTrang;
        int maNCC, slTrongKho, slDatHang;
        double donGiaBan;

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
        public string NhaXB
        {
            get { return nhaXB; }
            set { nhaXB = value; }
        }
        public string MaTheLoai
        {
            get { return maTheLoai; }
            set { maTheLoai = value; }
        }
        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public string MaGiamGia
        {
            get { return maGiamGia; }
            set { maGiamGia = value; }
        }
        public double DonGiaBan
        {
            get { return donGiaBan; }
            set { donGiaBan = value; }
        }
        public int SLTrongKho
        {
            get { return slTrongKho; }
            set { slTrongKho = value; }
        }
        public int SLDatHang
        {
            get { return slDatHang; }
            set { slDatHang = value; }
        }
        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        public KhoSach() { }
        public KhoSach(string maSach, string tenSach, string nhaXB, string maTheLoai, int maNCC, string maGiamGia, double donGiaBan, int slTrongKho, int slDatHang, string tinhTrang)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.nhaXB = nhaXB;
            this.maTheLoai = maTheLoai;
            this.maNCC = maNCC;
            this.maGiamGia = maGiamGia;
            this.donGiaBan = donGiaBan;
            this.slTrongKho = slTrongKho;
            this.slDatHang = slDatHang;
            this.tinhTrang = tinhTrang;
        }
    }
}
