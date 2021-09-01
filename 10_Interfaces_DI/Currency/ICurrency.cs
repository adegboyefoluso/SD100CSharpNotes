using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_DI.Currency
{
    public interface ICurrency
    {
        // Dependency Injection - When a class depends on some type of object being "injected" into it. DI allows for "interchangeable parts"
        string Name { get; }
        decimal Value { get; }
    }
}
