using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPatt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.WriteLine("Enter a value: ");
            n=int.Parse(Console.ReadLine());
            for(i = 1; i <= n; i++) 
            {
                for(j = 1; j <= i; j++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
