using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConDemo
{
    class sample
    {
        public static int y;
        public static int m;
        public static int d;

        static sample() 
        {
            DateTime dt;
            dt = DateTime.Now;
            y = dt.Year;
            m = dt.Month;
            d = dt.Day;
        }

        public static void showdate()
        {
            Console.WriteLine("Year\t" + y);
            Console.WriteLine("Month\t" + m);
            Console.WriteLine("Day\t" + d);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sample.showdate();
        }
    }
}
