using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray012
{

    //Sorting of 0s, 1s & 2s

    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter N: ");
            N=int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            Console.WriteLine("Enter N elements: ");
            for(int i = 0; i < N; i++) 
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is: ");
            SortArr(arr);
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static int[] SortArr(int[] arr)
        {
            int c0=0, c1=0;   
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==0)
                {
                    c0++;
                }
                if (arr[i]==1)
                {
                    c1++;
                }
            }
            for(int i=0;i<c0;i++)
            {
                arr[i]=0;
            }
            for(int i=c0;i<(c0+c1);i++)
            {
                arr[i]=1;
            }
            for(int i=(c0+c1);i<arr.Length; i++)
            {
                arr[i] = 2;
            }
            return arr;
        }
    }
}
