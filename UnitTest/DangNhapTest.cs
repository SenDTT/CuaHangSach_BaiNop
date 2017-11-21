using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class DangNhapTest
    {
        private DangNhap dn;

        [TestInitialize]
        public void SetUp()
        {
            this.dn = new DangNhap(17701, "TN00417701");
        }
        // true
        [TestMethod]
        public void TestDN1()
        {
            Assert.AreEqual(dn.U, 17701);
        }
        //true
        [TestMethod]
        public void TestDN2()
        {
            Assert.AreEqual(dn.P, "TN00417701");
        }
        // true
        [TestMethod]
        public void TestDN3()
        {
            Assert.AreEqual(dn.KiemTraSo("17701"), true);
        }
        // true
        [TestMethod]
        public void TestDN4()
        {
            Assert.AreEqual(dn.KiemTraSo("TN00417701"), false);
        }

        // true
        [TestMethod]
        public void TestDN5()
        {
            Assert.IsNotNull(dn.U, "User nhập hợp lệ");
        }
        //fail do user không rỗng
        [TestMethod]
        public void TestDN6()
        {
            Assert.IsNull(dn.U, "User nhập không hợp lệ");
        }
        // fail do không phải user trong setup
        [TestMethod]
        public void TestDN7()
        {
            Assert.AreEqual(dn.U, 17702);
        }
        // fail do không phải pass trong setup
        [TestMethod]
        public void TestDN8()
        {
            Assert.AreEqual(dn.P, "17702");
        }

        // fail do không đúng kiểu dữ liệu
        [TestMethod]
        public void TestDN9()
        {
            Assert.AreEqual(dn.U, "17702");
        }
        // fail do không đúng kiểu dữ liệu
        [TestMethod]
        public void TestDN10()
        {
            Assert.AreEqual(dn.P, 17702);
        }


    }
    internal class DangNhap
    {

        private int u;
        private string p;

        public int U
        {
            get
            {
                return u;
            }

            set
            {
                u = value;
            }
        }

        public string P
        {
            get
            {
                return p;
            }

            set
            {
                p = value;
            }
        }

        public DangNhap(int u, string p)
        {

            this.U = u;
            this.P = p;
        }

        public bool KiemTraSo(string user)
        {

            try
            {
                int so = Convert.ToInt32(user);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
