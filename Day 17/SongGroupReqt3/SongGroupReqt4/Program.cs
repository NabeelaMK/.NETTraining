using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupReqt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            List<Song> ls = SongRepo.GetAllSongs();
            Console.WriteLine("Name\t\t\t\tArtist\t     Song Type\tRating\tNO.of Downloads\tDate Downloaded");
            foreach (Song S in ls)
            {
                Console.WriteLine(S);
            }
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("\nEnter a type to sort: ");
                Console.WriteLine("\n1) Sort by Name");
                Console.WriteLine("\n2) Sort by Rating");
                Console.WriteLine("\n3) Sort by Popularity");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        ls.Sort();
                        Console.WriteLine("Sorting song list on name");
                        Console.WriteLine("Name\t\t\t\tArtist\t     Song Type\tRating\tNO.of Downloads\tDate Downloaded");
                        foreach (Song S in ls)
                        {
                            Console.WriteLine(S);
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        ls.Sort(new RatingComparer());
                        Console.WriteLine("Sorting song list on rating");
                        Console.WriteLine("Name\t\t\t\tArtist\t     Song Type\tRating\tNO.of Downloads\tDate Downloaded");
                        foreach (Song S in ls)
                        {
                            Console.WriteLine(S);
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        ls.Sort(new PopularityComparer());
                        Console.WriteLine("Sorting song list on popularity");
                        Console.WriteLine("Name\t\t\t\tArtist\t     Song Type\tRating\tNO.of Downloads\tDate Downloaded");
                        foreach (Song S in ls)
                        {
                            Console.WriteLine(S);
                        }
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            }
        }
    }
}

