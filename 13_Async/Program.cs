using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to make a meal");
            Console.ReadKey();

            Kitchen kitchen = new Kitchen();
            Potato potato = new Potato();

            // Synchronous, can't do other tasks
            potato.Peel();

            // Asynchronous, so we can do other things.
            // Async needs to do Tasks
            // Tasks are "jobs" and not actual objects, yet.

            var fries = kitchen.FryPotatoesAsync(potato);

            // Synchronous
            Hamburger hamburger = kitchen.AssembleHamburger();

            if (!fries.IsCompleted)
                Console.WriteLine("Waiting on fries.");

            // Synchronous, but can't start until our fries Task<> is finished because we need the result.
            kitchen.ServeMeal(fries.Result, hamburger);
            Console.ReadKey();
        }
    }
}
