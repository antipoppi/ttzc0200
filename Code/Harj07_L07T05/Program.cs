using System;

namespace Harj07_L07T05 //Ehto- ja toistorakenteet
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
            int summa = 0;
            do
            {
                int number = AskNumber("Syötä luku: (syötä 0 lopettaaksesi)");
                if (number > 0)
                {
                    summa = (summa + number);
                    continue;
                }
                if (number == 0)
                {
                    Console.WriteLine("Syötettyjen lukujen summa on: " + summa);
                    break;
                }
            } while (true);
        }
    }
}
