using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupReqt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> Songs = SongRepo.GetAllSongs();
            {
                foreach(Song S in Songs)
                {
                    Console.WriteLine(S.ToString());
                }
                Console.WriteLine();
                while (true)
                {
                    Console.WriteLine("\nEnter a type to sort: ");
                    Console.WriteLine("\n1) Song Type");
                    Console.WriteLine("\n2) Date of downloaded");
                    Console.WriteLine("\n3) Rating");
                    choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                    }
                }
        }
    }
}
