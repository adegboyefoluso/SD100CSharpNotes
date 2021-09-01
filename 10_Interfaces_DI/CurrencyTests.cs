using _10_Interfaces_DI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _10_Interfaces_DI
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            ICurrency dime = new Dime();

            Assert.AreEqual(0.1m, dime.Value);
            Assert.AreEqual("Dime", dime.Name);
        }

        [DataTestMethod]
        [DataRow(37.25)]
        [DataRow(1.50)]
        [DataRow(9.73)]
        public void EPaymentTests(double paymentValue)
        {
            // decimal convertedValue = Convert.ToDecimal(paymentValue);
            decimal convertedValue = (decimal)paymentValue;
            var ePayment = new ElectronicPayment(convertedValue);

            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment", ePayment.Name);
        }
    }
}
