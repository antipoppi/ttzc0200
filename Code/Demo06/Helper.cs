using System;

namespace Demo06
{
    class Helper
    {
        public static void PrintInfo()
        {
            Console.WriteLine("Info");
        }

        public static int PrintAndReturnNumber()
        {
            Console.WriteLine("Info - returning 123");
            return 123;
        }

        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int AskNumber(string title)
        {
            int number;
            Console.WriteLine(title);
            string line = Console.ReadLine();
            int.TryParse(line, out number);
            return number;
        }
    }
}
