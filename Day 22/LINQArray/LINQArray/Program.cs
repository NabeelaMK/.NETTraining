using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose", "lotus", "lily", "hibiscus", "daffodil" };

            Console.WriteLine("Flower starting with d: ");
            var fQuery=from flower in flowers
                       where (flower.StartsWith("d"))
                       select flower;
            foreach (var f in fQuery)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("Flower with length between 5 and 7: ");
            var Iquery=from flower in flowers
                       let len=flower.Length
                       where (len>5 && len<7)
                       select flower;
            foreach (var f in Iquery)
            {
                Console.WriteLine(f);
            }
        }
    }
}
