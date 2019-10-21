using System;

namespace Harj07_L07T02 //Ehto- ja toistorakenteet
{
    class Program
    {
        public static int AskNumber(string title)
        {
            int number;
            Console.WriteLine(title);
            string line = Console.ReadLine();
            int.TryParse(line, out number);
            return number;
        }
        static void Main(string[] args)
        {
            int number = AskNumber("Syötä ensimmäinen luku:");
            int number2 = AskNumber("Syötä toinen luku:");
            int number3 = AskNumber("Syötä kolmas luku:");
            if (number > number2 && number > number3)
            {
                Console.WriteLine("Suurin syöttämäsi luku on " + number);
            }
            else if (number2 > number && number2 > number3)
            {
                Console.WriteLine("Suurin syöttämäsi luku on " + number2);
            }
            else if (number3 > number && number3 > number2)
            {
                Console.WriteLine("Suurin syöttämäsi luku on " + number3);
            }
        }
    }
}
