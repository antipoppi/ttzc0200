using System;

struct Movie
{
    public Movie(string title, string director, int year)
    {
        Title = title;
        Director = director;
        Year = year;
    }
    public override string ToString()
    {
        return Title + ", " + Director + ", " + Year;
    }
    public string Title;
    public string Director;
    public int Year;

    // ---
}