using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        // Addition
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        // Subtraction
        public int Sub(int x, int y)
        {
            return x - y;
        }

        // Multiplication
        public int Mul(int x, int y)
        {
            return x * y;
        }
        // Division
        public int Div(int x, int y)
        {
            return x / y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }

        public string GetPercentage(double num, double total)
        {
            // adding (concatenating) anything to a string turns it into a string
            return num / total * 100 + "%";
        }

        public string DivideWithFractions(int x, int y)
        {
            int whole = Div(x, y);
            int remainder = Remainder(x, y);
            return whole + " " + remainder + "/" + y;
        }

        // Remainder
        public int Remainder(int x, int y)
        {
            return x % y;
        }

        // Age Calculation
        public int CalculateAge(DateTime birthDate)
        {
            TimeSpan ageSpan = DateTime.Now - birthDate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            double ageRounded = Math.Floor(totalAgeInYears);
            int years = Convert.ToInt32(ageRounded);
            return years;
        }

        public double AddAll(double[] numbers)
        {
            double sum = 0;
            for (int i=0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;

            foreach (double num in numbers)
            {
                sum += num;
            }

            return numbers.Sum();
        }

        public double Average(double[] numbers)
        {
            double sum = AddAll(numbers);
            return sum / numbers.Length;
        }
    }
}
