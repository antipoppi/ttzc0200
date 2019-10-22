using System;

namespace Harj07_L07T06 //Ehto- ja toistorakenteet
{
    class Program
    {
        public static int AskNumber(string title)
        {
            int vuosiluku;
            Console.WriteLine(title);
            string line = Console.ReadLine();
            int.TryParse(line, out vuosiluku);
            return vuosiluku;
        }
        static void Main(string[] args)
        {
            int vuosiluku = AskNumber("Syötä vuosiluku tietääksesi, onko kyseinen vuosi karkausvuosi: ");
            if (vuosiluku % 400 == 0)
            {
                Console.WriteLine("On karkausvuosi");
            }
            else if (vuosiluku % 100 == 0 || vuosiluku % 4 > 0)
            {
                Console.WriteLine("Ei ole karkausvuosi");
            }
            else if (vuosiluku % 4 == 0)
            {
                Console.WriteLine("On karkausvuosi");
            }
        }
    }
}
