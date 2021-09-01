using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Async
{
    public class Kitchen
    {
        public async Task<Fries> FryPotatoesAsync(Potato potato)
        {
            if (potato.IsPeeled)
            {
                PrettyPrint("Dropping the fries in the fryer", 14);
                // await means the thread can continue but the method cannot.
                // await is scoped to the method.
                await Task.Delay(5000);
                PrettyPrint("Fries are still cooking", 14);
                await Task.Delay(5000);
                PrettyPrint("Ding! Fries are done", 14);
                return new Fries(potato);
            }
            else
            {
                Console.WriteLine("This potato needs to be peeled first");
                return null;
            }
        }
        // Synchronous (Can't do other tasks during)
        public Hamburger AssembleHamburger()
        {
            Random randy = new Random();
            var time = randy.Next(900,2000);
            PrettyPrint("Assembling the burger", 13);
            PrettyPrint("Set the bun down", 4);
            Task.Delay(time).Wait();
            PrettyPrint("Place the patty delicately", 12);
            Task.Delay(time).Wait();
            PrettyPrint("Laying down the cheese", 6);
            Task.Delay(time).Wait();
            PrettyPrint("Adding some lettuce", 10);
            Task.Delay(time).Wait();
            PrettyPrint("Throwing on some pickles", 2);
            Task.Delay(time).Wait();
            PrettyPrint("Spraying it with Ketchup and Mustard", 12);
            Task.Delay(time).Wait();
            PrettyPrint("Place the top bun down", 4);
            PrettyPrint("Burger Assembled", 13);
            return new Hamburger();
        }
        public bool ServeMeal(Fries fries, Hamburger hamburger)
        {
            if(fries == null)
            {
                Console.WriteLine("The fries weren't ready!");
                return false;
            }
            else
            {
                Console.WriteLine("You put the fries and the burger together");
                return true;
            }
        }

        // Recursive method, runs itself until satisfied
        public int AddTwo(int a)
        {
            int result = a + 2;
            if (result == 100)
            {
                return result;
            }
            else
               return AddTwo(a);
        }


        public void PrettyPrint(string process, int color)
        {
            //Black   0
            //DarkBlue    1
            //DarkGreen   2
            //DarkCyan    3
            //DarkRed 4
            //DarkMagenta 5
            //DarkYellow  6
            //Gray    7
            //DarkGray    8
            //Blue    9
            //Green   10
            //Cyan    11
            //Red 12
            //Magenta 13
            //Yellow  14
            //White   15
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(process);
            Console.ResetColor();
        }

    }
}
