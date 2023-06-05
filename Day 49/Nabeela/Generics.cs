using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            string[] stringArray = { "Hello", "World" };

            Printer.PrintArray(intArray);
            Printer.PrintArray(stringArray);
        }
        class Printer
        {
            public static void PrintArray<T>(T[] array)
            {
                foreach (T element in array)
                {
                    Console.WriteLine(element);
                }
            }
        }

    }
}
