using System;

namespace DecToBin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rem;
            Console.WriteLine("Enter an integer: ");
            n=int.Parse(Console.ReadLine());
            rem = n % 2;
            Console.WriteLine(rem);
            n = n / 2;
            Console.WriteLine(n);




            
        }
        
    }
}
