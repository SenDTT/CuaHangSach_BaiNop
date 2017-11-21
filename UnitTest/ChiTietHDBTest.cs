using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CuaHangSach;

namespace UnitTest
{
    [TestClass]
    public class ChiTietHDBTests
    {
        private ChiTietHDB cthdbObj;

        [TestInitialize]
        public void SetUp()
        {
            this.cthdbObj = new ChiTietHDB("11", "CN0001", 60000, 2);
        }

        [TestMethod]
        public void ChiTietHDBTest()
        {
            Assert.AreEqual(cthdbObj.MaHDB, "11");
        }

        [TestMethod]
        public void ChiTietHDBTest1()
        {
            Assert.AreEqual(cthdbObj.MaSach, "CN0001");
        }

        [TestMethod]
        public void ChiTietHDBTest2()
        {
            Assert.AreEqual(cthdbObj.DonGiaBan, 60000);
        }

        [TestMethod]
        public void ChiTietHDBTest3()
        {
            Assert.AreEqual(cthdbObj.SoLuong, 2);
        }
    }
}
