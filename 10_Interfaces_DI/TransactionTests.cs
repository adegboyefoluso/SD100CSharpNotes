using _10_Interfaces_DI.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _10_Interfaces_DI
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;

        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt.");
        }

        [TestInitialize]
        public void Arrange()
        {
            _debt = 9000.01m;
        }

        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new Penny());
            PayDebt(new ElectronicPayment(300m));

            decimal expected = 9000.01m - 301.01m;

            Assert.AreEqual(expected, _debt);

            var dollar = new Dollar();
            var ePayment = new ElectronicPayment(123.45m);
            var transaction = new Transaction(dollar);
            var otherTransaction = new Transaction(ePayment);

            Assert.AreEqual("Dollar", transaction.GetTransactionType());
            Assert.AreEqual("Electronic Payment", otherTransaction.GetTransactionType());
            Assert.AreEqual(123.45m, otherTransaction.GetTransactionAmount());
        }
    }
}
