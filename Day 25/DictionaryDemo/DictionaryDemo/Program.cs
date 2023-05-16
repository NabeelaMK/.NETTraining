using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "One");
            dic.Add(2, "Two");
            dic.Add(3, "Three");
            dic.Add(4, "Four");
            dic.Add(5, "five");

            foreach (KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine("Key: {0} Value: {1}", kvp.Key, kvp.Value);
                Console.WriteLine($"Key: {kvp.Key}  Value:  {kvp.Value}");
                Console.WriteLine(kvp.Key+" "+kvp.Value);
            }
            Console.WriteLine();
        }
    }
}
