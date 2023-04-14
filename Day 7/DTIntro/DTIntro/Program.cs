using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt3 = new DateTime(2020, 04, 11, 5, 10, 20);
            Console.WriteLine(dt3);

            DateTime dt4= new DateTime(2020, 04, 11, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(dt4);

            DateTime dt5 = new DateTime(2020, 04, 11);
            TimeSpan span = new TimeSpan(25, 20, 55);
            DateTime dt6 = dt5.Add(span);
            System.Console.WriteLine(dt6);
        }
    }
}
