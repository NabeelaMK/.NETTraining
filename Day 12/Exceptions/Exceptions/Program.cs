using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Compilation error, Divide by zero
            // int k = 10;
            //k = k / 0;
            //Console.WriteLine("Hello");

            //Using exceptions

            int k = 10;
            int i=0;
            try
            {
                i=int.Parse(Console.ReadLine());
                k = k / i;
                Console.WriteLine("Hello");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
