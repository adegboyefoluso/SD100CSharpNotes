using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            // Addition
            int sum = a + b;
            // Subtraction
            int difference = a - b;
            // Multiplication
            int product = a * b;
            // Division
            int quotient = a / b;
            // Remainder
            int remainder = a % b;

            DateTime today = DateTime.UtcNow;
            DateTime someDay = new DateTime(1980, 1, 5);
            TimeSpan timeSpan = today - someDay;
        }
    }
}
