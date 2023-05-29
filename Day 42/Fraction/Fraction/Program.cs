using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int PosCount = 0, NegCount = 0, ZeroCount = 0; 
            foreach (int num in arr)
            {
                if (num > 0)
                {
                    PosCount++;
                }                
                else if (num < 0)
                {
                    NegCount++;
                }
                else
                {
                    ZeroCount++;
                }
            }

            double positiveRatio = (double)PosCount / n;
            double negativeRatio = (double)NegCount / n;
            double zeroRatio = (double)ZeroCount / n;
            Console.WriteLine("Positive Ratio: " + positiveRatio.ToString("F6"));
            Console.WriteLine("Negative Ratio: " + negativeRatio.ToString("F6"));
            Console.WriteLine("Zero Ratio: " + zeroRatio.ToString("F6"));
        }
    }
}