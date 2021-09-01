using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void FractionTest()
        {
            Calculator calc = new Calculator();
            string fractual = calc.DivideWithFractions(8, 5);
            string expected = "1 3/5";

            string fractual2 = calc.DivideWithFractions(5, 5);
            string expected2 = "1 0/5";

            Assert.AreEqual(expected, fractual);
            Assert.AreEqual(expected2, fractual2);
        }

        [TestMethod]
        public void PercentageTest()
        {
            Calculator calc = new Calculator();
            string actual = calc.GetPercentage(8, 5);
            string expected = "160%";

            Assert.AreEqual(expected, actual);
        }
    }
}
