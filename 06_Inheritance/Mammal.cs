using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    public class Mammal : Animal
    {
        public string FurColor { get; set; }
        public Mammal()
        {
            HasFur = true;
            NumberOfLegs = 4;
            Console.WriteLine("This is the Mammal constructor");
        }
        public override void MakeSound()
        {
            Console.WriteLine("ROAR!");
        }

    }

    public class Horse : Mammal
    {
        // protected = private + w/in inherited classes
        public double Speed { get; protected set; } = 30d;
        public Horse()
        {
            
        }
        public void Roar()
        {
            base.MakeSound();
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The {GetType().Name} says Neigh!");
        }

        public override string ToString()
        {
            return "HOOOOOORSE";
        }
    }

    public class Mustang : Horse
    {
        public Mustang()
        {
            Speed = 35d;
        }
    }

    public class Dog : Mammal
    {
        public bool HasFloppyEars { get; set; }
        public Dog()
        {
            
        }


    }

    public class Reptile : Animal
    {
        public Reptile()
        {
            
        }
    }
}
