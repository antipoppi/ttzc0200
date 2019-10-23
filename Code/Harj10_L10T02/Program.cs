using System;

namespace Harj10_L10T02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = AskNumber("Syötä kokonaisluku: ");
            int param1 = 0;
            int param2 = 0;
            int param3 = 0;
            int param4 = 0;
            int param5 = 0;
            Init(ref num, ref param1, ref param2, ref param3, ref param4, ref param5);
            Console.Write(param1 + "\n" + param2 + "\n" + param3 + "\n" + param4 + "\n" + param5);
        }
        public static int AskNumber(string title)
        {
            int number;
            Console.WriteLine(title);
            string line = Console.ReadLine();
            int.TryParse(line, out number);
            return number;
        }
        public static void Init(ref int num, ref int param1, ref int param2, ref int param3, ref int param4, ref int param5)
        {
            param1 = num * 2;
            param2 = num * 10;
            param3 = num * 100;
            param4 = num * 1000;
            param5 = num * 10000;
        }
    }
}
