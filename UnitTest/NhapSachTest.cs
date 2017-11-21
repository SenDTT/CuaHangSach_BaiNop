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
    public class NhapSachTests
    {
        private NhapSach nhapSach;

        [TestInitialize]
        public void SetUp()
        {
            this.nhapSach = new NhapSach(1, "2017-01-05", "6", 0, "CN0001", 50000, 50);
        }

        [TestMethod]
        public void NhapSachTest()
        {
            Assert.AreEqual(nhapSach.MaHDM, 1);
        }

        [TestMethod]
        public void NhapSachTest1()
        {
            Assert.AreEqual(nhapSach.NgayNhap, "2017-01-05");
        }

        [TestMethod]
        public void NhapSachTest2()
        {
            Assert.AreEqual(nhapSach.MaNCC, "6");
        }

        [TestMethod]
        public void NhapSachTest3()
        {
            Assert.AreEqual(nhapSach.Thue, 0);
        }

        [TestMethod]
        public void NhapSachTest4()
        {
            Assert.AreEqual(nhapSach.MaSach, "CN0001");
        }

        [TestMethod]
        public void NhapSachTest5()
        {
            Assert.AreEqual(nhapSach.GiaMua, 50000);
        }

        [TestMethod]
        public void NhapSachTest6()
        {
            Assert.AreEqual(nhapSach.SoLuong, 50);
        }
        [TestMethod]
        public void NhapSachTest7()
        {
            Assert.AreEqual(nhapSach.MaSach, "0001");
        }
    }
}