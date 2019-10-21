using System;

namespace Harj07_L07T03 //Ehto- ja toistorakenteet
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
            int number = AskNumber("Add an integer:");
            switch (number)
            {
                case 10:
                case 20:
                    Console.WriteLine("Number is 10 or 20");
                    break;
                case 100:
                case 200:
                    Console.WriteLine("Number is 100 or 200");
                    break;
                default:
                    Console.WriteLine("Number is " + number);
                    break;
            }
                

        }
    }
}
