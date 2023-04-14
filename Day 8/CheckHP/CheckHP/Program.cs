using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckHP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "PHP is a programming language";

            if(str.Length>=2 && str.Substring(1,2).Equals("HP"))
            {
                str= str.Substring(0,1)+str.Substring(3);
            }
            Console.WriteLine(str);
        }
    }
}
