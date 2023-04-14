using System;

namespace Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dist, time, speed, speed1;
            Console.WriteLine("Enter distance in Km: ");
            dist = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter time in hour: ");
            time = double.Parse(Console.ReadLine());
            speed = CalcSpeed(dist, time);
            Console.WriteLine("Speed in Km/hr: {0}", speed);
            speed1 = CalcSpeed1(dist, time);
            Console.WriteLine("Speed in Miles/hr: {0}", speed1);
        }
        static double CalcSpeed(double dist, double time)
        {
            double speed = 0.0;
            speed = dist / time;
            return speed;
        }
        static double CalcSpeed1(double dist, double time)
        {
            double speed1 = 0.0;
            speed1 = (dist / time) * 0.621;
            return speed1;
        }
    }
}

