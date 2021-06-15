using NUnit.Framework;
using System;
using CSharpCalculator;

namespace NUnitTestProject1
{
    public class BaseTest
    {
        protected Calculator calc;

        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();
            Console.WriteLine("Starting Calculator Tests");
        }

        [TearDown]
        public void TearDown()
        {
            calc = null;
            Console.WriteLine("Tests are finished");
        }
    }
}
