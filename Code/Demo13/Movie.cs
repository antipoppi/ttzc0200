struct Movie
{
    // Movie struct constructor allows easier initialization of struct members.
    // Constructor is a special method that always has a same
    // name as struct (or class), and has no return value type specified
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
}

