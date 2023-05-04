using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferdExec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 5, 2, 15, 19, 30, 21, 6, 4 };
            var query = from n in ar
                        where n % 2 == 0
                        select n;

            //Before replacement

            foreach (var n in query)
                Console.Write(n + " ");
            Console.WriteLine();
            ar[2] = 7;  //Earlier ar[2]=2 i.e., 2 is replaced by 7

            //After replacement

            foreach(var n in query)
                Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}
