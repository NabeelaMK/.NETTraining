using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapWithoutTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b=int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a= {0}", a);
            Console.WriteLine("b= {0}\n", b);

        }
    }
}
