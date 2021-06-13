using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{

    [TestClass]
    public class SqrtTests
    {


        [TestMethod]
        public void SqrtOfPositiveNumberTest()
        {
            object number = "4";
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(2, calc.Sqrt(number));
        }

        [TestMethod]
        public void SqrtOfZeroTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Sqrt(0));
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void SqrtOfNegativeNumberImpossibleTest()
        {
            var calc = new CSharpCalculator.Calculator();
            calc.Sqrt(-4);
        }

    }
}
