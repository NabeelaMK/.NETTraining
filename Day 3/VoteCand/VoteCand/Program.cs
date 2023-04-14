using System;

namespace VotingCandidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age of a candidate: ");
            age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Oops! You're not eligible for casting your vote:(");
            }
            else
            {
                Console.WriteLine("Congrats! You're eligible for casting your vote:)");
            }
        }

    }
}