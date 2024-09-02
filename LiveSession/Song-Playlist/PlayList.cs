using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6_Song_Playlist
{
    class PlayList
    {
        private string _name;
        private List<Song> _songList;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Song> SongList
        {
            get { return _songList; }
            set { _songList = value; }
        }

        public PlayList()
        {
            _songList = new List<Song>();
        }

        public PlayList(string name)
        {
            _name = name;
            _songList = new List<Song>();
        }

        public void AddSongToPlaylist(Song song)
        {
            _songList.Add(song);
        }

        public bool RemoveSongFromPlaylist(string name)
        {
            var songToRemove = _songList.Find(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (songToRemove != null)
            {
                _songList.Remove(songToRemove);
                return true;
            }
            return false;
        }

        public void DisplaySongs()
        {
            if (_songList.Count == 0)
            {
                Console.WriteLine("No song to show");
            }
            else
            {
                Console.WriteLine($"Songs in {_name}");
                Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Rating", "No of Download", "Date Downloaded");
                foreach (var song in _songList)
                {
                    Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", song.Name, song.Artist, song.SongType, song.Rating, song.NumberOfDownloads, song.DateDownloaded.ToString("dd-MM-yyyy"));
                }
            }
        }
    }
}
