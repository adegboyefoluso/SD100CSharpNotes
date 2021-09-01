using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopChallenge
    {
        [TestMethod]
        public void Supercal()
        {
            string super = "Supercalifragilisticexpialidocious";

            foreach(char letter in super)
            {
                if (letter == 'i' || letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i or an l");
                }
            }

            int letterCount = 0;
            foreach(char letter in super)
            {
                ++letterCount;
            }
            Console.WriteLine(letterCount);

            Console.WriteLine(super.Length);
        }
    }
}
