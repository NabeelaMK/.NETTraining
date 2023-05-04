using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Normal way 

            int[] ar = { 1, 5, 2, 15, 19, 30, 21, 6, 4 };
            Array.Sort(ar);
            foreach (int n in ar)
                if(n%2 == 0)
                    Console.Write(n + " ");
            Console.WriteLine();


            //LINQ

            var num = from n in ar
                      where n%2 == 0
                      select n;
            foreach (int x in num)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}
