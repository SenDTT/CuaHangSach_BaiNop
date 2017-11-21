using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CuaHangSach;

namespace UnitTest
{
    [TestClass]
    public class KhachHangTest
    {
        private TestKhachHang KH;
        [TestInitialize]
        public void SetUp()
        {
            //string MaKH,HoKH, TenKH, diachi, quequan, ngaysinh;
            //int DiemTichLuy;
            this.KH = new TestKhachHang("17710", "Mai", "Hieu", "LamDong", "DaLat", "1/1/1990", 10);
        }
        [TestMethod]
        public void Ma()
        {
            Assert.AreEqual(KH.Ma, "17710");
        }
        [TestMethod]
        public void Ho()
        {
            Assert.AreEqual(KH.Ho, "Mai");
        }
        [TestMethod]
        public void Ten()
        {
            Assert.AreEqual(KH.Ten, "Hieu");
        }
        [TestMethod]
        public void DiaChi()
        {
            Assert.AreEqual(KH.DiaChi, "LamDong");
        }
        [TestMethod]
        public void QueQuan()
        {
            Assert.AreEqual(KH.QueQuan, "DaLat");
        }
        [TestMethod]
        public void NgaySinh()
        {
            Assert.AreEqual(KH.NgaySinh, "1/1/1990");
        }
        [TestMethod]
        public void Diem()
        {
            Assert.AreEqual(KH.DiemTL, 10);
        }
    }
}
