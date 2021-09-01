using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Room
    {
        /*
        -Create a Room class that has three properties: one each for the length, width, and height.
        -Create a method that calculates total square footage.
        -We also would like to include some constants that the define a minimum and maximum length, width, and height.
        -When setting the properties, make sure to compare the values to the min/max and only set them if the value is valid.

        Bonus:
        Create a method that calculates total lateral surface area. (LSA)
        -Only allow the properties to be set from inside the class itself
        Throw an exception if the given value is outside the permitted range.
        Test the code like we did with the Vehicle tests.
        */

        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        // propfull
        private double _length;
        private double _width;
        private double _height;

        // Length
        public double Length
        {
            get { return _length; }
            set 
            { 
                if (value < MinLength || value > MaxLength)
                {
                    // Don't store it

                    // Throwing an exception (error) if not within our values
                    throw new ArgumentException($"The length needs to be between {MinLength} and {MaxLength}");
                }
                _length = value; 
                
            }
        }

        // Width
        public double Width
        {
            get { return _width; }
            set {
                if (value < MinWidth || value > MaxWidth)
                {
                    throw new ArgumentException($"The width needs to be between {MinWidth} and {MaxWidth}");
                }
                _width = value; }
        }

        // Height
        public double Height
        {
            get { return _height; }
            set {
                if(value < MinHeight || value > MaxHeight)
                {
                    throw new ArgumentException($"The height needs to be at least {MinHeight} this short, or this {MaxHeight} tall.");
                }
                _height = value; }
        }

        private const double MaxLength = 40;
        private const double MinLength = 5;

        private const double MaxWidth = 30;
        private const double MinWidth = 3;

        private const double MaxHeight = 13;
        private const double MinHeight = 4;

        public double CalcuteSquareFootage()
        {
            double squareFootage = Length * Width;
            return squareFootage;
        }

        public double CalculateLateralSurfaceArea()
        {
            double lengthLSA = Length * Height * 2;
            double widthLSA = Width * Height * 2;
            return lengthLSA + widthLSA;
        }
    }
}
