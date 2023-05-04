using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Welcome to Corporates World";

            int wordCount = myFun.GetWordCount(s);
            Console.WriteLine(wordCount);
        }
    }
    public static class myFun
    {
        public static int GetWordCount(this string str)
        {
            if (!String.IsNullOrEmpty(str))
                return str.Split(' ').Length;
            return 0;
        }
    }
}
