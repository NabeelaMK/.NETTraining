using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 2;
            int[] a = new int[5];
            try
            {
                int i = 10 / b;
                a[4] = 9;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero error");
            }
            catch(IndexOutOfRangeException e) 
            {
                Console.WriteLine("Index out of bounds");
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("Remaining program");
        }
    }
}
