using System;

namespace Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amt, rem;
            Console.WriteLine("Enter an amount: ");
            amt=int.Parse(Console.ReadLine());
            rem = amt / 2000;
            amt = amt % 2000;
            Console.WriteLine("{0} of 2000", rem);
            rem = amt / 500;
            amt= amt % 500;
            Console.WriteLine("{0} of 500", rem);
            rem = amt / 200;
            amt= amt % 200;
            Console.WriteLine("{0} of 200", rem);
            rem= amt / 100;
            amt= amt % 100;
            Console.WriteLine("{0} of 100", rem);
            rem = amt / 50;
            amt = amt % 50;
            Console.WriteLine("{0} of 50", rem);
            rem = amt / 20;
            amt = amt % 20;
            Console.WriteLine("{0} of 20", rem);
            rem = amt/ 10;
            amt = amt % 10;
            Console.WriteLine("{0} of 10", rem);
            rem = amt / 5;
            amt = amt % 5;
            Console.WriteLine("{0} of 5", rem);
            rem = amt / 2;
            amt = amt % 2;
            Console.WriteLine("{0} of 2", rem);
            rem = amt / 1;
            amt = amt % 1;
            Console.WriteLine("{0} of 1", rem);




        }
    }
}
