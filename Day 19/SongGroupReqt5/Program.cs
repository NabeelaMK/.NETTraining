using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupReqt5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            Console.WriteLine("Enter the no. of Songs: ");
            int num = int.Parse(Console.ReadLine());
            for(int i=0; i<num; i++)
            {
                string[] str = Console.ReadLine().Split(',');
                string name = str[0];
                string artist = str[1];
                string songType = str[2];
                DateTime dateDownloaded = DateTime.ParseExact(str[3], "dd-MM-yyyy", null);
                double rating = double.Parse(str[4]);
                int numberOfDownloads = int.Parse(str[5]);
                Song s = new Song(name, artist, songType, dateDownloaded, rating, numberOfDownloads);
                list.Add(s);
            }
            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
            sd = Song.CalculateTypeCount(list);
            Console.WriteLine("{0} {1,15}", "Song type", "Count");
            foreach(var item in sd) 
            {
                Console.WriteLine("{0} {1,15}", item.Key, item.Value);
            }

        }
    }
}
