using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Req_3_Song_Playlist
{
    public class SongBO
    {
        public List<Song> FindSong(List<Song> songList, string type)
        {
            return songList.Where(song => song.SongType == type).ToList();
        }

        public List<Song> FindSong(List<Song> songList, DateTime dateDownloaded)
        {
            return songList.Where(song => song.DateDownloaded.Date == dateDownloaded.Date).ToList();
        }

        public List<Song> FindSong(List<Song> songList, double rating)
        {
            return songList.Where(song => song.Rating == rating).ToList();
        }
    }
}
