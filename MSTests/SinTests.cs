using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class SinTests
    {


        [TestMethod]
        public void SinTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(Math.Sin(60), calc.Sin("60"));

        }
    }
}
