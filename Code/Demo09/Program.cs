using System;

namespace Demo09
{
    enum Appstatus
    {
        Loading,
        Running,
        Suspended,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo09 - enums and structs");

            Appstatus status = Appstatus.Running;
            switch (status)
            {
                case Appstatus.Loading:
                    Console.WriteLine("App status is Loading");
                    break;
                case Appstatus.Running:
                    Console.WriteLine("App status is Running");
                    break;
                case Appstatus.Suspended:
                    Console.WriteLine("App status is Suspended");
                    break;
            }

            Console.WriteLine("App status is " + status);


            Movie classic;
            classic.Title = "Enter the Dragon";
            classic.Director = "Robert Clouse";
            classic.Year = 1973;

            Console.WriteLine(classic);
        }
    }
}
