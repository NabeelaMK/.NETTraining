using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsEqual = CalcEqual.AreEqual("ABC","ABD");
            if(IsEqual)
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("Both are different");
            }
        }
    }
    public class CalcEqual
    {
        public static bool AreEqual(object a, object b)
        {
            return a == b;
        }
    }
}
