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
    public class HoaDonBanTest
    {
        private HoaDonBan HDBobj;

        [TestInitialize]
        public void SetUp()
        {
            this.HDBobj = new HoaDonBan("11", "2017-11-18", 1, "17701", 0);
        }


        [TestMethod]
        public void TestHDBObj1()
        {
            Assert.AreEqual(HDBobj.MaHDB, "11");
        }

        [TestMethod]
        public void TestHDBObj2()
        {
            Assert.AreEqual(HDBobj.NgayBan, "2017-11-18");
        }

        [TestMethod]
        public void TestHDBObj3()
        {
            Assert.AreEqual(HDBobj.MaKH, 1);
        }

        [TestMethod]
        public void TestHDBObj4()
        {
            Assert.AreEqual(HDBobj.MaNV, "17701");
        }

        [TestMethod]
        public void TestHDBObj5()
        {
            Assert.AreEqual(HDBobj.Thue, 0);
        }

        [TestMethod]
        public void TestHDBObj6()
        {
            Assert.IsNotNull(HDBobj.MaHDB, "Mã hóa đơn bán không được null");
        }
    }
}
