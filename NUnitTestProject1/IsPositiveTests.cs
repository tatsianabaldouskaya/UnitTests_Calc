using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class IsPositiveTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2)]
        public void IsPositiveTest(int number)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.isPositive(number));
        }

        [Test]
        public void ZeroIsNotPositiveTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsFalse(calc.isPositive(0));
        }
    }
}