using System;
using System.Collections;
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
            SortedList s = new SortedList();
            s.Add("Maharastra     ", "Munbai");
            s.Add("Karnataka      ", "Banglore");
            s.Add("Kerala         ", "Thiruvananthapuram");
            s.Add("Andhra Pradesh ", "Hyderabad");
            s.Add("Tamil Nadu     ", "Chennai");
            s.Add("Bihar          ", "Patna");
            s.Add("Rajastan       ", "Jaipur");
            s.Add("Orissa         ", "Bhubaneswar");

            Console.WriteLine("Elemnts in the SortedList: ");
            foreach(var item in s.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach(var item in s.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            IDictionaryEnumerator e = s.GetEnumerator();
            while(e.MoveNext())
            {
                Console.WriteLine(e.Key + "\t" + e.Value);
            }
        }
    }
}
