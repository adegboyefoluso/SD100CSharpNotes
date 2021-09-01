using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Greeter
    {
        // 1 Access modifier => Visibility in the program
        // 2 Return type => What the method gives back
        // 3 Name => Uses PascalCase
        // 3(4) Method Signature => The method name and the Parameters
        // 4 Parameters => What we need to pass to the method
        // 5 Statements or body => Code executed
        // 1   2      3       4
        public void SayHello(string name)
        {
            // 5
            Console.WriteLine($"Hello {name}!");
        }

        // Overload, same name different signature
        public void SayHello()
        {
            Console.WriteLine("Hello stranger!");
        }

        Random _randy = new Random();

        public void RandomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello", "Hi", "Greetings", "Sup", "Good Afternoon", "Howdy", "What's poppin G?"};
                                                // 7 so means random is 0-6
            int randomNumber = _randy.Next(0, availableGreetings.Length);
                                                        // 0-6, using as index
            string randomGreeting = availableGreetings[randomNumber];
            Console.WriteLine(randomGreeting);
        }
    }
}
