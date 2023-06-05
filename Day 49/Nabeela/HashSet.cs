using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> pairs = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] pair = Console.ReadLine().Split(' ');
                string pairString = $"{pair[0]} {pair[1]}";
                pairs.Add(pairString);
                Console.WriteLine(pairs.Count);
            }
        }
    }
}
