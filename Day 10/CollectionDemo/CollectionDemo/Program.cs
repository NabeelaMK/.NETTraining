using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine(arrayList.Capacity);
            arrayList.Add(125);
            arrayList.Add(244);
            arrayList.Add(145);
            arrayList.Add(129);
            arrayList.Add(245);
            arrayList.Add(156);
            arrayList.Add(346);
            arrayList.Add(106);
            arrayList.Add(true);
            arrayList.Add(new Emp());
            Console.WriteLine(arrayList.Capacity);
            foreach (object i in arrayList) 
            {
                Console.WriteLine(i);
            }


        }
    }
    class Emp
    {

    }
}
