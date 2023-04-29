using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace0To5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num: ");
            int num = int.Parse(Console.ReadLine());
            convertFive();
        }

        public static int convertFive()
        {
            int num = 0;
            if(num==0)
            {
                return 5;
            }
            else
            {
                int temp = 0;
                num = num % 10;
                if(num%10==0)
                {
                    return 5;
                }
                else
                {
                    while(num>0)
                    temp = temp * 10 + num;
                    num = num / 10;
                }
            }
            return num;
        }
    }
}
