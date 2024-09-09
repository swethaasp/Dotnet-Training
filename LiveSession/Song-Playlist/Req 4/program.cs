using System;
using System.Collections.Generic;

// Song class implementing IComparable interface
public class Song : IComparable<Song>
{
    // Private fields
    private string _name;
    private string _artist;
    private string _songType;
    private DateTime _dateDownloaded;
    private double _rating;
    private int _numberOfDownloads;

    // Properties for each field
    public string Name { get => _name; set => _name = value; }
    public string Artist { get => _artist; set => _artist = value; }
    public string SongType { get => _songType; set => _songType = value; }
    public DateTime DateDownloaded { get => _dateDownloaded; set => _dateDownloaded = value; }
    public double Rating { get => _rating; set => _rating = value; }
    public int NumberOfDownloads { get => _numberOfDownloads; set => _numberOfDownloads = value; }

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

    // Static method to create a Song object from a comma-separated string
    public static Song CreateSong(string detail)
    {
        string[] details = detail.Split(',');
        return new Song(details[0], details[1], details[2], DateTime.Parse(details[3]), double.Parse(details[4]), int.Parse(details[5]));
    }

    // Implementation of IComparable interface to sort by name
    public int CompareTo(Song other)
    {
        return this.Name.CompareTo(other.Name);
    }

    // Override ToString method for custom output format
    public override string ToString()
    {
        return string.Format("{0,-15} {1,-15} {2,-15} {3,-15:dd-MM-yyyy} {4,-15} {5,-15}", _name, _artist, _songType, _dateDownloaded, _rating, _numberOfDownloads);
    }
}

// Comparer class to sort songs by rating
public class RatingComparer : IComparer<Song>
{
    public int Compare(Song x, Song y)
    {
        return x.Rating.CompareTo(y.Rating);
    }
}

// Comparer class to sort songs by number of downloads
public class PopularityComparer : IComparer<Song>
{
    public int Compare(Song x, Song y)
    {
        return x.NumberOfDownloads.CompareTo(y.NumberOfDownloads);
    }
}

class Program
{
    static void Main()
    {
        // Read the number of songs
        Console.WriteLine("Enter the number of the songs:");
        int n = int.Parse(Console.ReadLine());

        List<Song> songList = new List<Song>();

        // Read each song detail and create a Song object
        for (int i = 0; i < n; i++)
        {
            string songDetail = Console.ReadLine();
            songList.Add(Song.CreateSong(songDetail));
        }

        // Prompt for sorting choice
        Console.WriteLine("Enter a type to sort:\n1.Sort by name\n2.Sort by Rating\n3.Sort by Popularity");
        int choice = int.Parse(Console.ReadLine());

        // Sorting based on user choice
        switch (choice)
        {
            case 1:
                songList.Sort(); // Sort by name using IComparable
                break;
            case 2:
                songList.Sort(new RatingComparer()); // Sort by rating using IComparer
                break;
            case 3:
                songList.Sort(new PopularityComparer()); // Sort by downloads using IComparer
                break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        // Display the sorted list
        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15}", "Name", "Artist", "Song Type", "Date of Download", "Rating", "No of Downloads");
        foreach (Song song in songList)
        {
            Console.WriteLine(song.ToString());
        }
    }
}
