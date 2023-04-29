using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subarray_with_sum
{
    //SubArray with given sum

    internal class Program
    {
        public static void SubArraySum(int[] A, int N, int S)
        {
            int cursum;

            for (int i = 0; i < N; i++) //Starting Point
            {
                cursum = A[i];
                if(cursum == S)
                {
                    Console.WriteLine("Subarray found at position " + (i + 1));
                    return;
                }
                else
                {
                }

                for (int j = i + 1; j < N; j++) //Trying all subarrays starting with i
                {
                    cursum = cursum + A[j];
                    if (cursum == S)
                    {
                        Console.WriteLine("Subarray found between positions " + (i + 1) + " and " + (j + 1));
                        return;
                    }                 
                }
            }
        }
        static void Main(string[] args)
        {
            int N, S;

            Console.WriteLine("Enter N: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter S: ");
            S = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Enter N elements: ");
            for(int i = 0; i < N; i++) 
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]);
            }
                SubArraySum(A, N, S);
        }

    }
}
