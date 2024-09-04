using System;
using System.Collections.Generic;
using System.Linq;


namespace Req_3_Song_Playlist
{


    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Songs:");
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songList = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                Console.WriteLine("Enter song details (name, artist, songType, rating, numberOfDownloads, dateDownloaded):");
                string[] details = Console.ReadLine().Split(',');

                string name = details[0];
                string artist = details[1];
                string songType = details[2];
                double rating = double.Parse(details[3]);
                int numberOfDownloads = int.Parse(details[4]);
                DateTime dateDownloaded = DateTime.Parse(details[5]);

                Song song = new Song(name, artist, songType, rating, numberOfDownloads, dateDownloaded);
                songList.Add(song);
            }

            SongBO songBO = new SongBO();

            Console.WriteLine("Enter a search type:\n1.Song Type\n2.Date of Download\n3.Rating");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the type:");
                    string type = Console.ReadLine();
                    List<Song> resultByType = songBO.FindSong(songList, type);
                    DisplaySongs(resultByType);
                    break;

                case 2:
                    Console.WriteLine("Enter the date (dd-MM-yyyy):");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    List<Song> resultByDate = songBO.FindSong(songList, date);
                    DisplaySongs(resultByDate);
                    break;

                case 3:
                    Console.WriteLine("Enter the rating:");
                    double rating = double.Parse(Console.ReadLine());
                    List<Song> resultByRating = songBO.FindSong(songList, rating);
                    DisplaySongs(resultByRating);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        public static void DisplaySongs(List<Song> songs)
        {
            if (songs.Count > 0)
            {
                Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Rating", "No of Download", "Date of Download");
                foreach (var song in songs)
                {
                    Console.WriteLine(song.ToString());
                }
            }
            else
            {
                Console.WriteLine("No songs found.");
            }
        }
    }

}
