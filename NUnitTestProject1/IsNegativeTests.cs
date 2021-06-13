using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class IsNegativeTests
    {
        [SetUp]
        public void Setup()
        {
        }

       [Test]
       [TestCase(-2)]
       public void IsNegativeTest(int number)
       {
           var calc = new CSharpCalculator.Calculator();
           Assert.IsTrue(calc.isNegative(number));
       }

        [Test]
        public void ZeroIsNotNegativeTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsFalse(calc.isNegative(0));
        }
    }
}