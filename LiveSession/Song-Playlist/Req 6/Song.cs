using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Req__6_Song_Playlist
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
        public static Dictionary<string, int> CalculateTypeCount(List<Song> list)
        {
            Dictionary<string, int> songTypeCount = new Dictionary<string, int>();

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

        // Static method to predict the user's state of mind
        public static string PredictState(Dictionary<string, int> perTypeCount)
        {
            // Determine the user's state of mind based on the song type with the highest count
            if (perTypeCount.ContainsKey("Emotional") && perTypeCount["Emotional"] >= perTypeCount.GetValueOrDefault("Celebration", 0)
                && perTypeCount["Emotional"] >= perTypeCount.GetValueOrDefault("Motivational", 0))
            {
                return "depressed";
            }
            else if (perTypeCount.ContainsKey("Celebration") && perTypeCount["Celebration"] >= perTypeCount.GetValueOrDefault("Emotional", 0)
                && perTypeCount["Celebration"] >= perTypeCount.GetValueOrDefault("Motivational", 0))
            {
                return "happy";
            }
            else if (perTypeCount.ContainsKey("Motivational") && perTypeCount["Motivational"] >= perTypeCount.GetValueOrDefault("Emotional", 0)
                && perTypeCount["Motivational"] >= perTypeCount.GetValueOrDefault("Celebration", 0))
            {
                return "energetic";
            }

            return "unknown"; // In case no dominant type is found
        }
    }
}
