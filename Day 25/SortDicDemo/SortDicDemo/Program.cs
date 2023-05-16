using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortDicDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> dict = new SortedDictionary<int, string>();
            dict.Add(3, "Three");
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(5, "Five");
            dict.Add(4, "Four");
            foreach(KeyValuePair<int, string> pairs in dict)
            {
                Console.WriteLine("Key: {0} Value {1}", pairs.Key, pairs.Value);
            }
        }
    }
}
