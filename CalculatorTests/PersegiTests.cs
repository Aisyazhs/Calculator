using CalculatorBangunDatar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorBangunDatarTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestLuasPersegi()
        {
            Persegi ps = new Persegi();
            double result = ps.LuasPersegi(5);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestKelilingPersegi()
        {
            Persegi ps = new Persegi();
            double result = ps.KelilingPersegi(5);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestLuasPersegiPanjang()
        {
            PersegiPanjang pp = new PersegiPanjang();
            double result = pp.LuasPersegiPanjang(4, 6);
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void TestKelilingPersegiPanjang()
        {
            PersegiPanjang pp = new PersegiPanjang();
            double result = pp.KelilingPersegiPanjang(4, 6);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestLuasLingkaran()
        {
            Lingkaran lk = new Lingkaran();
            double result = lk.LuasLingkaran(3);
            Assert.AreEqual(28.26, result, 0.01);
        }

        [TestMethod]
        public void TestKelilingLingkaran()
        {
            Lingkaran lk = new Lingkaran();
            double result = lk.KelilingLingkaran(6);
            Assert.AreEqual(18.84, result, 0.01);
        }
    }
}
