using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_NonGenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generics:

            //1. List
            List<int> ls = new List<int>();
            ls.Add(66);
            ls.Add(76);
            ls.Add(86);
            ls.Add(96);

            foreach(int l in ls)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine();

            //2. Dictionary
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Sunday");
            dic.Add(2, "Monday");
            dic.Add(3, "Tuesday");
            dic.Add(4, "Wednesday");
            dic.Add(5, "Thursday");
            dic.Add(6, "Friday");
            dic.Add(7, "Saturday");

            foreach(KeyValuePair<int, string> days in dic)
            {
                Console.WriteLine("Key: {0} Value: {1}", days.Key, days.Value);
            }
            Console.WriteLine();


            //Non-Generics

            //1. ArrayList
            ArrayList al = new ArrayList();
            al.Add("Bobby");
            al.Add(35);
            al.Add("Trivandrum");
            al.Add(200000);
            /*{ "Bobby", 38,
         "Trivandrum", 200000 };*/
            foreach(var arraylist in al)
            {
                Console.WriteLine(arraylist);
            }
            Console.WriteLine();
        }
    }
}
