using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class SqrtTests:BaseTest
    {
        [TestMethod]
        public void SqrtOfPositiveNumberTest()
        {
            object number = "4";
            Assert.AreEqual(2, calc.Sqrt(number), "Sqrt is incorrect");
        }

        [TestMethod]
        public void SqrtOfZeroTest()
        {
            Assert.AreEqual(0, calc.Sqrt(0), "Sqrt is incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void SqrtOfNegativeNumberImpossibleTest()
        {
            calc.Sqrt(-4);
        }
    }
}
