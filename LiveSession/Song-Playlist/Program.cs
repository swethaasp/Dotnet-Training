//Requirement 1

using System;

namespace D6_Song_Playlist
{


   

    class Program
    {
        static void Main()
        {
            //Requirement 1
            Console.WriteLine("Requiremnet 1");
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



            //Requirement 2
            Console.WriteLine("Requiremnet 2");

            Console.WriteLine("Enter the Play list name:");
            string playlistName = Console.ReadLine();
            PlayList myPlaylist = new PlayList(playlistName);

            while (true)
            {
                Console.WriteLine("1.Add Song");
                Console.WriteLine("2.Remove Song");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the number of Songs: ");
                        int numberOfSongs = int.Parse(Console.ReadLine());

                        for (int i = 0; i < numberOfSongs; i++)
                        {
                            Console.WriteLine($"Enter song {i + 1} detail:");
                            string[] songDetails = Console.ReadLine().Split(',');
                            Song song = new Song(songDetails[0].Trim(), songDetails[1].Trim(), songDetails[2].Trim(), double.Parse(songDetails[3]), int.Parse(songDetails[4]), DateTime.ParseExact(songDetails[5].Trim(), "dd-MM-yyyy", null));
                            myPlaylist.AddSongToPlaylist(song);
                        }
                        break;
                    case 2:
                        Console.Write("Enter the name of the song to be deleted: ");
                        string songName = Console.ReadLine();
                        if (myPlaylist.RemoveSongFromPlaylist(songName))
                        {
                            Console.WriteLine("Song successfully deleted");
                        }
                        else
                        {
                            Console.WriteLine("Song not found in the Play List");
                        }
                        break;
                    case 3:
                        myPlaylist.DisplaySongs();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }


            //Requirement 3
        }
    }

}
