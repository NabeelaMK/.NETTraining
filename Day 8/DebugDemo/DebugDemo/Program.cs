using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int i= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int j= int.Parse(Console.ReadLine());
            follow(i, j);       //function calling
            Console.WriteLine("\nDebugging Over");
        }

        private static void follow(int x, int y)  // the called function
        {
            int t=100;
            for(int i=x; i<=y; i++)
            {
                Console.WriteLine("\nHey");
                t = t + 40;
            }
            Console.WriteLine("\n");
            Console.WriteLine(t);
        }
    }
}
