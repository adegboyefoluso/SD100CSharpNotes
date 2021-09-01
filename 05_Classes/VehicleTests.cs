using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void PropertiesTest()
        {
            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Make = "Nissan";

            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Skyline";
            firstVehicle.Mileage = 20000;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine($"My car is a {firstVehicle.Make} {firstVehicle.Model} with {firstVehicle.Mileage} miles on it.");

        }

        [TestMethod]
        public void MethodsTests()
        {
            Vehicle transport = new Vehicle();
            transport.TurnOn();
            Assert.IsTrue(transport.IsRunning);
            transport.TurnOff();
        }

        [TestMethod]
        public void TurnSignalTests()
        {
            Vehicle myCar = new Vehicle();
            myCar.TurnOn();
            myCar.LeftIndicator = new Indicator();
            myCar.RightIndicator = new Indicator();

            myCar.TurnRight();
            Console.WriteLine("Turning right now");

            CheckIndicators(myCar);

            myCar.TurnLeft();
            Console.WriteLine("Turning left");
            
            CheckIndicators(myCar);
        }

        public void CheckIndicators(Vehicle myCar)
        {
            Console.WriteLine($"Right Indicator: {myCar.RightIndicator.IsFlashing}");
            Console.WriteLine($"Left Indicator: {myCar.LeftIndicator.IsFlashing}");
        }

        [TestMethod]
        public void Constructors()
        {
            // old way, ew gross icky
            Vehicle car = new Vehicle();
            car.Make = "Toyota";
            car.Model = "Corolla";
            car.Mileage = 2119021;


            // New super awesome way
            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 300000, VehicleType.Spaceship);
            Console.WriteLine(rocket.Make);
            Console.WriteLine(rocket.Model);

        }
    }
}
