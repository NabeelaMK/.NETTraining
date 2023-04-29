using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupReqt6
{
    internal class Song
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _artist;
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        private string _songType;
        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }
        }

        private double _rating;
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        private int _numberOfDownloads;
        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set { _numberOfDownloads = value; }
        }

        private DateTime _dateDownloaded;
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }
        }

        public Song()
        {
        }

        public Song(string name, string artist, string songType, DateTime dateDownloaded, double rating, int numberOfDownloads)
        {
            Name = name;
            Artist = artist;
            SongType = songType;
            Rating = rating;
            NumberOfDownloads = numberOfDownloads;
            DateDownloaded = dateDownloaded;
        }
        public static Dictionary<string, int> CalculateTypeCount(List<Song> list)
        {
            Dictionary<string, int> sd = new Dictionary<string, int>();
            foreach (var item in list)
            {
                if (sd.ContainsKey(item.SongType))
                {
                    sd[item.SongType]++;
                }
                else
                    sd.Add(item.SongType, 1);
            }
            return sd;
        }
        public static string PredictState(Dictionary<string, int>perTypeCount)
        {
           string str = new string();
            foreach (var item in perTypeCount)
            {
                if()
            }
            return str;
        }
    }
}
