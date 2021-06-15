using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class SinTests:BaseTest
    {
        [TestMethod]
        public void SinTest()
        {
            Assert.AreEqual(Math.Sin(60), calc.Sin("60"), "Sin is incorrect");
        }
    }
}
