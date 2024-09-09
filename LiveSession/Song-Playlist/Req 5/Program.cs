namespace Req_5_Song_Playlist
{
    using System;
    using System.Collections.Generic;

   

    public class Program
    {
        public static void Main(string[] args)
        {
            // Read the number of songs
            Console.WriteLine("Enter the number of songs");
            int numberOfSongs = int.Parse(Console.ReadLine());

            // List to hold Song objects
            List<Song> songList = new List<Song>();

            // Read song details
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songDetails = Console.ReadLine().Split(',');

                string name = songDetails[0];
                string artist = songDetails[1];
                string songType = songDetails[2];
                DateTime dateDownloaded = DateTime.Parse(songDetails[3]);
                double rating = double.Parse(songDetails[4]);
                int numberOfDownloads = int.Parse(songDetails[5]);

                // Create a Song object and add it to the list
                Song song = new Song(name, artist, songType, dateDownloaded, rating, numberOfDownloads);
                songList.Add(song);
            }

            // Calculate the type count using the static method in Song class
            SortedDictionary<string, int> result = Song.CalculateTypeCount(songList);

            // Print the result
            Console.WriteLine("{0} {1,15}", "Song type", "Count");
            foreach (var entry in result)
            {
                Console.WriteLine("{0} {1,15}", entry.Key, entry.Value);
            }
        }
    }

}

