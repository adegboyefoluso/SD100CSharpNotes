using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_IntroToAPI.Models
{
    public class Person
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Mass { get; set; }
        public string Homeworld { get; set; }
        public string[] Vehicles { get; set; }
    }
}
