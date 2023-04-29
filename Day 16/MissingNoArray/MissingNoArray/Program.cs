using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNoArray
{

    //Missing number in an array
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, Tot=0, Sum=0, MissNo=0;
            Console.WriteLine("Enter N: ");
            N=int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Enter N elements: ");
            for(int i = 0; i < N-1;i++) 
            {
                A[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is: ");

            for (int i=0; i < N-1; i++)
            {
                Console.WriteLine(A[i]);
                Tot = (N * (N + 1)) / 2;
                Sum = Sum + A[i];
                MissNo=Tot-Sum;
            }
            Console.WriteLine("Missing No: {0}", MissNo);
        }
    }
}
