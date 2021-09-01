using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ResourceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string declared;

            declared = "This is initiliatized";

            string declaredAndInitiliazed = "This is both declared and initiliazed";

            string firstName = "Jacob";
            string lastName = "Brown";

            // Concatenation
            string concatenatedFullName = firstName + " " + lastName; // "Jacob Brown"

            // Composite Format
            string compositeFormatting = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine("Hi, I'm {0}!!", firstName);

            // Interpolation
            // Most popular, most useful
            string interpolatedFormatting = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFormatting);
            Console.WriteLine(interpolatedFormatting);

        }

        [TestMethod]
        public void Collections()
        {
            // Arrays
            string greeting = "Greetings";

            string[] stringArray = { "Hello", "Hi", "Goodbye", greeting };

            // Index starts at zero
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            stringArray[2] = "Good Morning";
            Console.WriteLine(stringArray[2]);

            // Lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();

            listOfStrings.Add("Here's a string");
            listOfStrings.Add("292919");

            listOfInts.Add(7);

            // Queue's
            // Queues first object added, is first object returned
            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm next");

            Console.WriteLine(firstInFirstOut.Peek());

            firstInFirstOut.Dequeue();

            Console.WriteLine( firstInFirstOut.Peek() );

            // Stacks
            // Stacks last object added, is first object returned
            Stack<string> firstInLastOut = new Stack<string>();

            firstInLastOut.Push("I'm a bottom bun");
            firstInLastOut.Push("I'm a meat");
            firstInLastOut.Push("I'm a top bun");

            Console.WriteLine(firstInLastOut.Peek());


            // Dictionaries
            // Key value Pair
            // Key  Value
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(7, "Agent");

            string atSeven = keyAndValue[7];

            Dictionary<string, string> dictionaryDefinition = new Dictionary<string, string>();

            dictionaryDefinition.Add("Duck", "It quacks");

            string defintionOfDuck = dictionaryDefinition["Duck"];

            Console.WriteLine(defintionOfDuck);
        }

        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next();

            Console.WriteLine(randomNumber);
        }
    }
}
