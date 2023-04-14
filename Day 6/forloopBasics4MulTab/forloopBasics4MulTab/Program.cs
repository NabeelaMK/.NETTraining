using System;

namespace forloopBasics4MulTab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.Write("Enter an Integer, n: ");
            n=int.Parse(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                Console.WriteLine("\n{0} * {1} = {2}", n, i, n*i);
            }
            Console.WriteLine();
        }
    }
}
