using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDemo
{
    delegate void CountIt();
    class AnonMethDemo
    {
        static void Main()
        {
            CountIt count = delegate
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            };
            count();
        }
    }
}
