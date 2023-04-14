using System;

namespace SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, Sum;
            Console.WriteLine("Enter value a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value b: ");
            b = int.Parse(Console.ReadLine());
            Sum = SumOfInt(a, b);
            Console.WriteLine("Sum of two integers: {0}", Sum);

        }
        static int SumOfInt(int a, int b)
        {
            int Sum = 0;
            Sum = a + b;
            if (a == b)
            {
                return (3 * (a + b));
            }
            else
            {
                return Sum;
            }
        }
    }
}
