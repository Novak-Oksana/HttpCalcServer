using System;
using HttpCalcServer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        //[DataTestMethod]
        //[DataRow(1, 2, "+", 3)]
        //[DataRow(1, 2, "*", 2)]
        //[DataRow(1, 2, "-", -1)]
        //[DataRow(2, 2, "/", 1)]

        //[TestMethod()]
        //public void funct_calcTest(int a, int b, string op, int exp)
        //{
        //    int res = HttpServer.Calc(a, b, op);
        //    Assert.AreEqual(exp, res); ;
        //}

        [TestMethod()]
        public void calcTest1()
        {
            int res = HttpServer.Calc(1, 2, "+");
            Assert.AreEqual(3, res); ;
        }

        [TestMethod()]
        public void calcTest2()
        {
            int res = HttpServer.Calc(1, 2, "*");
            Assert.AreEqual(2, res); ;
        }

        [TestMethod()]
        public void calcTest3()
        {
            int res = HttpServer.Calc(1, 2, "-");
            Assert.AreEqual(-1, res); ;
        }

        [TestMethod()]
        public void calcTest4()
        {
            int res = HttpServer.Calc(2, 2, "/");
            Assert.AreEqual(1, res); ;
        }
    }
}
