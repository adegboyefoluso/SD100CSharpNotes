using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Inheritance
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Animal animal = new Animal();
            // animal.NumberOfLegs = 6;

            Mammal Nancy = new Mammal();
            Console.WriteLine(Nancy.NumberOfLegs);
            Console.WriteLine(Nancy.HasFur);

            Nancy.MakeSound();

            Horse horse = new Horse();
            horse.MakeSound();
            horse.Roar();
            Console.WriteLine(horse.ToString());

            Mustang musty = new Mustang();
            musty.MakeSound();
        }
    }
}
