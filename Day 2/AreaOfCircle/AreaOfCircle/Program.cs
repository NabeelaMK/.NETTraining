using System;

namespace RadOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Area, r = 0.0;
            Console.WriteLine("Enter the radius of a circle: ");
            r = double.Parse(Console.ReadLine());
            Area = 3.14 * r * r;
            Console.WriteLine($"Area of the circle: {Area}");

            //By using fuction

            Area = CalcArea(r);
            Console.WriteLine("Area of circle having radius {0} is {1}", r, Area);
            Console.WriteLine("Changes Made");
            //hi
        }
        static double CalcArea(double rr)
        {
            double Area = 0.0;
            Area = 3.14 * rr * rr;
            return Area;

        }
    }
}

