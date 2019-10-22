using System;

namespace Harj07_L07T04 //Ehto- ja toistorakenteet
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
            int number = AskNumber("Syötä pisteesi: (0-12)");
            switch (number)
            {
                case 0:
                case 1:
                    Console.WriteLine("Arvosanasi on: 0");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Arvosanasi on: 1");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Arvosanasi on: 2");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Arvosanasi on: 3");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Arvosanasi on: 4");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Arvosanasi on: 5");
                    break;
                default:
                    Console.WriteLine("Et syöttänyt pisterajoissa olevaa numeroa");
                    break;
            }
        }
    }
}
