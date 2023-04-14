using System;

namespace AbsoluteDiff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, AbDiff;
            Console.WriteLine("Enter a value: ");
            n = int.Parse(Console.ReadLine());
            AbDiff = CalcAbDiff(n);
            Console.WriteLine("Absolute Difference= {0} ", AbDiff);
        }
        static int CalcAbDiff(int nn)
        {
            int AbDiff = 0;
            AbDiff = nn - 51;
            if (nn > 51)
            {
                return (3 * AbDiff);

            }
            else
            {
                return AbDiff;
            }

        }
    }
}

