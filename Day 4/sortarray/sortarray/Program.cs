using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, temp;
            int[] arr=new int[5];
            Console.WriteLine("Enter 5 numbers: ");
            for(i=0; i<arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            for(i=0; i<arr.Length; i++)
            {
                for(j=0; j<arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }


                }
            }
            for(i = 0; i<arr.Length;i++) 
            {
                Console.WriteLine();
                Console.WriteLine( arr[i]);
            }

        }
    }
}
