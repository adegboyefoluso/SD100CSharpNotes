using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            // if keyword
            // if(Conditional in parentheses)
            // {statement in brackets}
            if (userIsHungry)
            {
                Console.WriteLine("You should eat something");
            }

            bool didYouStudy = false;

            if (!didYouStudy)
            {
                Console.WriteLine("You should've studied!");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;

            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the movies!");
            }
            else
            {
                Console.WriteLine("You must stay home and finish your chores!");
            }

            // Nesting Conditionals
            string input = "3";
            int totalSleep = int.Parse(input);

            if(totalSleep >= 8)
            {
                Console.Write("You should be well rested");
            }
            else
            {
                Console.WriteLine("You might be tired today");

                if (totalSleep < 4)
                {
                    Console.WriteLine("You should get more sleep!");
                }
            }
        }

        [TestMethod]
        public void IfElseIf()
        {
            int age = 21;

            if(age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else
            {
                Console.WriteLine("You're underage");

                if(age > 6)
                {
                    Console.WriteLine("You're a kid!");
                }
                else if(age > 0)
                {
                    Console.WriteLine("You're too young to use a computer");
                }
                else
                {
                    Console.WriteLine("You're not even born yet");
                }
            }

            if(age >= 55)
            {
                Console.WriteLine("Senior Discout time!");
            }
            else if (age > 21 && age < 65)
            {
                Console.WriteLine("You're an adult.");
            }
            else if (age == 21)
            {
                Console.WriteLine("You can drink now!");
            }
            else if (age <= 19)
            {
                Console.WriteLine("You're a teenager, or will be soon");
            }
            else
            {
                Console.WriteLine("You must be 20!");
            }

        }
    }
}
