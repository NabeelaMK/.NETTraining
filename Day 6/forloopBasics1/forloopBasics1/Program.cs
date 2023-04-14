using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopBasics1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;
            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b= int.Parse(Console.ReadLine());
            if(a<b)
            {
                for (i = a; i <= b; i++)
                {
                    Console.Write("{0}\t", i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The value of a= {0} is greater than value of b= {1}", a, b);
            }

            
        }
    }
}
