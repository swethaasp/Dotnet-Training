class RatingComparer : IComparer<Song>
{
    public int Compare(Song x, Song y)
    {
        return x.Rating.CompareTo(y.Rating);
    }
}


RatingComparer rc = new RatingComparer();
ls.Sort(rc);
