//Requirement 1

using System;

namespace D6_Song_Playlist
{


    class Song
    {
        private string _name;
        private string _artist;
        private string _songType;
        private double _rating;
        private int _numberOfDownloads;
        private DateTime _dateDownloaded;

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

        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }
        }

        public Song() { }

        public Song(string name, string artist, string songType, double rating, int numberOfDownloads, DateTime dateDownloaded)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
            _dateDownloaded = dateDownloaded;
        }

        public override string ToString()
        {
            return $"Name:{_name}\nArtist:{_artist}\nSong Type:{_songType}\nRating:{_rating:F1}\nNumber of Downloads:{_numberOfDownloads}\nDate Downloaded:{_dateDownloaded:dd-MM-yyyy}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Song other = (Song)obj;
            return string.Equals(_name, other._name, StringComparison.OrdinalIgnoreCase) &&
                   string.Equals(_artist, other._artist, StringComparison.OrdinalIgnoreCase) &&
                   string.Equals(_songType, other._songType, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_name.ToLower(), _artist.ToLower(), _songType.ToLower());
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter song 1 detail:");
            string[] song1Details = Console.ReadLine().Split(',');

            Console.WriteLine("Enter song 2 detail:");
            string[] song2Details = Console.ReadLine().Split(',');

            Song song1 = new Song(song1Details[0].Trim(), song1Details[1].Trim(), song1Details[2].Trim(), double.Parse(song1Details[3]), int.Parse(song1Details[4]), DateTime.ParseExact(song1Details[5].Trim(), "dd-MM-yyyy", null));
            Song song2 = new Song(song2Details[0].Trim(), song2Details[1].Trim(), song2Details[2].Trim(), double.Parse(song2Details[3]), int.Parse(song2Details[4]), DateTime.ParseExact(song2Details[5].Trim(), "dd-MM-yyyy", null));

            Console.WriteLine("Song 1:");
            Console.WriteLine(song1);
            Console.WriteLine();
            Console.WriteLine("Song 2:");
            Console.WriteLine(song2);

            if (song1.Equals(song2))
            {
                Console.WriteLine("Song 1 is same as Song 2");
            }
            else
            {
                Console.WriteLine("Song 1 and Song 2 are different");
            }
        }
    }

}
