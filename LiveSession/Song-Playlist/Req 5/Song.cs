using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Req_5_Song_Playlist
{
    public class Song
    {
        // Private member fields
        private string _name;
        private string _artist;
        private string _songType;
        private DateTime _dateDownloaded;
        private double _rating;
        private int _numberOfDownloads;

        // Properties for accessing private fields
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }
        }

        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }
        }

        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set { _numberOfDownloads = value; }
        }

        // Default constructor
        public Song() { }

        // Parameterized constructor
        public Song(string name, string artist, string songType, DateTime dateDownloaded, double rating, int numberOfDownloads)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _dateDownloaded = dateDownloaded;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
        }

        // Static method to calculate the number of songs of each type
        public static SortedDictionary<string, int> CalculateTypeCount(List<Song> list)
        {
            SortedDictionary<string, int> songTypeCount = new SortedDictionary<string, int>();

            foreach (Song song in list)
            {
                // If songType is already in the dictionary, increment the count
                if (songTypeCount.ContainsKey(song.SongType))
                {
                    songTypeCount[song.SongType]++;
                }
                else
                {
                    // Otherwise, add songType to the dictionary with count 1
                    songTypeCount[song.SongType] = 1;
                }
            }

            return songTypeCount;
        }
    }
}
