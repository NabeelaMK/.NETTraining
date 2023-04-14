using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans;
            string res;

            Console.Write("Input a Number: ");
            ans=Console.ReadLine();

            int num=Convert.ToInt32(ans);
            res = "";
            while (num>1) 
            {
                int rem = num % 2;
                res = Convert.ToString(rem) + res;
                num = num / 2;
            }
            res=Convert.ToString(num) + res;
            Console.WriteLine("Binary: {0}", res);
        }
    }
}
