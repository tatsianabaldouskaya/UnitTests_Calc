using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    public class SqrtTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SqrtOfPositiveNumberTest()
        {
            object number = "4";
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(2, calc.Sqrt(number));
        }

        [Test]
        public void SqrtOfZeroTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Sqrt(0));
        }

        [Test]
        public void SqrtOfNegativeNumberImpossibleTest()
        {
            var calc = new CSharpCalculator.Calculator();
            object a = calc.Sqrt(-4);
            Assert.Throws<NotFiniteNumberException>((TestDelegate)a);

        }
    }
}