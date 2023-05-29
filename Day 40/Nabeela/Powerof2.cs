using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeDay1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num: ");
            int num=int.Parse(Console.ReadLine());
            Inner.Private innerprivate = new Inner.Private();
            innerprivate.powerof2(num);          
        }

        public class Inner
        {
            public class Private
            {
                public void powerof2(int num)
                {
                    int flag = 0;
                    for (int i = 0; Math.Pow(2, i) <= num; i++)
                    {
                        if (Math.Pow(2, i) == num)
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 1)
                    {
                        Console.WriteLine("{0} is a power of 2", num);
                    }
                    else
                    {
                        Console.WriteLine("{0} not a power of 2", num);
                    }
                }
            }
        }
    }

}
