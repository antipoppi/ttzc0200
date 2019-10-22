using System;

struct Movie
{
    public override string ToString()
    {
        return Title + ", " + Director + ", " + Year;
    }
    public string Title;
    public string Director;
    public int Year;

    // ---
}