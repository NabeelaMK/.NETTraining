using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmonymAdd
{
    public delegate int AddNum(int i, int j); 
    class Program
    {
        static void Main()
        {
            int Sum;
            AddNum add = delegate (int a, int b)
            {
                return a + b;
            };
            Sum=add(3, 5);
            Console.WriteLine(Sum);       
        }
    }
}
