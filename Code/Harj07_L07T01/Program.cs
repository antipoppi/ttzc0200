using System;

namespace Harj07_L07T01 //Ehto- ja toistorakenteet
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
            int number = AskNumber("Mikä on ikäsi?");

            if (number < 13)
            {
                Console.WriteLine("child");
            }
            else if (number >= 13 && number <= 19)
            {
                Console.WriteLine("teen");
            }
            else if (number >= 20 && number <= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("senior");
            }
        }
    }
}
