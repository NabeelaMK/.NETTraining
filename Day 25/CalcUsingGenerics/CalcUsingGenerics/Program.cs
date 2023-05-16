using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalcUsingGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool IsEqual = CalcEqual.AreEqual(10, 20);
            if(IsEqual )
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("Both are different");
            }
            Console.WriteLine();
        }
    }

    public class CalcEqual
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
    }
}
