using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void PersonPropertyTests()
        {
            Person firstPerson = new Person("Jacob", "Brown", new DateTime(1991,5,4),"404-88-9999",800);

            //firstPerson.FirstName = "Jacob";
            //firstPerson.LastName = "Brown";
            //firstPerson.DateOfBirth = new DateTime(1991, 5, 4);
            //firstPerson.SocialSecurity = "404-88-9999";
            //firstPerson.CreditScore = 800;

            Console.WriteLine($"{firstPerson.FullName} was born on {firstPerson.DateOfBirth.ToShortDateString()}");

            Console.WriteLine($"{firstPerson.LastName} {firstPerson.SocialSecurity}");

            firstPerson.Transport = new Vehicle("Nissan", "GT-R R34", 40000, VehicleType.Car);

            Console.WriteLine($"{firstPerson.FirstName} drives a {firstPerson.Transport.Make} {firstPerson.Transport.Model}");

            Assert.AreEqual("Jacob B", firstPerson.FullName);

            firstPerson.Transport.TurnOn();

            Assert.IsTrue(firstPerson.Transport.IsRunning);
        }
    }
}
