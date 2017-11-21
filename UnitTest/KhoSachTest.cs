using Microsoft.VisualStudio.TestTools.UnitTesting;
using CuaHangSach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangSach.Tests
{
    [TestClass]
    public class KhoSachTests
    {
        private KhoSach khoSach;

        [TestInitialize]
        public void SetUp()
        {
            this.khoSach = new KhoSach("CN0001", "Yoga An Thần", "NXB Thanh Hóa", "CN", 3, "", 60000, 40, 50, "đang kinh doanh");
        }

        [TestMethod]
        public void KhoSachTest()
        {
            Assert.AreEqual(khoSach.MaSach, "CN0001");
        }


        [TestMethod]
        public void KhoSachTest1()
        {
            Assert.AreEqual(khoSach.TenSach, "Yoga An Thần");
        }

        [TestMethod]
        public void KhoSachTest2()
        {
            Assert.AreEqual(khoSach.NhaXB, "NXB Thanh Hóa");
        }

        [TestMethod]
        public void KhoSachTest3()
        {
            Assert.AreEqual(khoSach.MaTheLoai, "CN");
        }

        [TestMethod]
        public void KhoSachTest4()
        {
            Assert.AreEqual(khoSach.MaNCC, 3);
        }

        [TestMethod]
        public void KhoSachTest5()
        {
            Assert.AreEqual(khoSach.MaGiamGia, "");
        }

        [TestMethod]
        public void KhoSachTest6()
        {
            Assert.AreEqual(khoSach.DonGiaBan, 60000);
        }

        [TestMethod]
        public void KhoSachTest7()
        {
            Assert.AreEqual(khoSach.SLTrongKho, 40);
        }

        [TestMethod]
        public void KhoSachTest8()
        {
            Assert.AreEqual(khoSach.SLDatHang, 50);
        }

        [TestMethod]
        public void KhoSachTest9()
        {
            Assert.AreEqual(khoSach.TinhTrang, "đang kinh doanh");
        }
    }
}