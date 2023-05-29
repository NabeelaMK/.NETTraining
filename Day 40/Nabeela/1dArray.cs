using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeExp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size: ");
            int size=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array: ");
            int[] arr= new int[size];   
            for(int i=0;i<size;i++)
            {
                arr[i] =int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i=0;i<size; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }

        }
    }
}
