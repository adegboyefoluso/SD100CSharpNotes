using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_DI.Currency
{
    public class Penny : ICurrency
    {
        public string Name => "Penny";
        public decimal Value => 0.01m;
    }

    public class Dime : ICurrency
    {
        public string Name => "Dime";
        public decimal Value => 0.1m;
    }

    public class Dollar : ICurrency
    {
        public string Name { get; } = "Dollar";

        // public decimal Value => 1.00m;
        // public decimal Value { get; } = 1.00;
        public decimal Value
        {
            get
            {
                return 1.00m;
            }
        }

        /*
        private string _symbol = "USD";
        public string Symbol
        {
            get
            {
                return _symbol;
            }
            set
            {
                _symbol = value;
            }
        }
        */
    }

    public class ElectronicPayment : ICurrency
    {
        public string Name => "Electronic Payment";
        public decimal Value { get; }
        public ElectronicPayment(decimal paymentValue)
        {
            Value = paymentValue;
        }
    }
}
