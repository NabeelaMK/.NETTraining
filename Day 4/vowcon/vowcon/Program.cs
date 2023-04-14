//Write a program in C# Sharp to count a total number of vowel or consonant in a string.
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowcon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, vow = 0, cons = 0, len; 
            Console.WriteLine("Enter a String: ");
            str= Console.ReadLine();
            //len = str.Length;
            for (i=0; i<str.Length; i++)
            {
                if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ||
                    str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U') 
                {
                    vow++;
                }
                else if((str[i] >= 'a') && (str[i] <= 'z') || (str[i] >= 'A') && (str[i] <= 'Z'))
                {
                    cons++;
                }
            }
            Console.WriteLine("The number of vowels: {0}", vow);
            Console.WriteLine("The number of consonants: {0}", cons);



        }
    }
}
