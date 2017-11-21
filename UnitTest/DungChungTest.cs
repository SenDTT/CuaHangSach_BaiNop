using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CuaHangSach;

namespace UnitTest
{
    [TestClass]
    public class DungChungTest
    {
        [TestMethod]
        public void kiemtrarong()
        {
            TestDungChung test = new TestDungChung();
            Assert.AreEqual(test.kiemtrarong(""), true);///sai
            Assert.AreEqual(test.kiemtrarong("abc"), false);///dúng
        }
        [TestMethod]
        public void KiemTraTonTai()
        {
            TestDungChung test1 = new TestDungChung();
            Assert.AreEqual(test1.kiemtratontai("1"), true);//Ma này da tồn tai
            Assert.AreEqual(test1.kiemtratontai("100"), false);//Ma này chưa có

        }
        [TestMethod]
        public void Kiemtrakitu()
        {
            TestDungChung test2 = new TestDungChung();
            Assert.AreEqual(test2.kiemtrakitu("ạ"), true);
            Assert.AreEqual(test2.kiemtrakitu("@"), false);
        }
        [TestMethod]

        public void KiemtraSDttontai()
        {
            TestDungChung test3 = new TestDungChung();
            Assert.AreEqual(test3.kiemtrSDTtontai("123"), false);//SDT này chưa có
            Assert.AreEqual(test3.kiemtrSDTtontai("01348762894"), true);//SDt này đã tồn tại
        }
        [TestMethod]

        public void KiemtraCMNDtontai()
        {
            TestDungChung test4 = new TestDungChung();
            Assert.AreEqual(test4.kiemtrCMNDtontai("123"), false);//CMND này chưa có
            Assert.AreEqual(test4.kiemtrCMNDtontai("243897127"), true);//CMND này đã tồn tại
        }
        [TestMethod]
        public void dodaiSDT()
        {
            TestDungChung test5 = new TestDungChung();
            Assert.AreEqual(test5.DodaiSDT("1234567890"), true);
            Assert.AreEqual(test5.DodaiSDT("1234567"), false);
        }
        [TestMethod]
        public void dodaiCMND()
        {
            TestDungChung test5 = new TestDungChung();
            Assert.AreEqual(test5.DodaiCMND("272609131"), true);
            Assert.AreEqual(test5.DodaiSDT("1234567"), false);
        }
    }
}
