using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class DivisionTests
    {

        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Starting Division tests");

        }

        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("Division tests are finished");
        }

        [Test]
        [TestCase(6, 3)]
        [TestCase(5, 10)]
        [TestCase(2.2, 2)]
        public void DivisionTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(firstNumber/secondNumber, calc.Divide(firstNumber, secondNumber));
        }

        [Test]
        public void DividebyZeroTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(double.PositiveInfinity, calc.Divide(12, 0));
        }

        [Test]
        [TestCase(-6, -3)]
        public void DivideTwoNegativeNumbersResultPositiveTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Divide(firstNumber, secondNumber) > 0);
        }


        [Test]
        [TestCase(12, -3)]
        public void DividePositiveByNegativeNumberResultNegativeTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Divide(firstNumber, secondNumber) < 0);
        }

       
    }
}
