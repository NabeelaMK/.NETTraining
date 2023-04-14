using System;


namespace forloopBasics2EVEN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1; i<=100; i++)
            {
                if(i%2==0)
                {
                    Console.Write("\t{0}", i);
                }
            }
            Console.WriteLine();
        }
    }
}
