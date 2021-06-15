using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    public class SinTests:BaseTest
    {
        [Test]
        public void SinTest()
        {
            Assert.AreEqual(Math.Sin(60), calc.Sin("60"), "Sin is incorrect");
        }
    }
}