using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeIntroo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            DateTime dt= new DateTime();
            Console.WriteLine(dt);
            DateTime dt1= new DateTime(1999, 3, 28);
            Console.WriteLine(dt1);
            Console.WriteLine(dt1.ToLongDateString());
            Console.WriteLine(dt1.ToLongTimeString());
            DateTime dt2 = new DateTime(2023, 04, 11);
            Console.WriteLine(dt2);
            Console.WriteLine(dt2.DayOfYear);
            Console.WriteLine(dt2.Year);
            Console.WriteLine(dt2.Month);
            Console.WriteLine(dt2.Day);
            Console.WriteLine(dt2.Hour);
            Console.WriteLine(dt2.Minute);
            Console.WriteLine(dt2.Second);
            Console.WriteLine(dt2.Millisecond);

        }
    }
}
