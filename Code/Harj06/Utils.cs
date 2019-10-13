using System;

namespace Harj06
{
    class Utils
    {
        public static void Info() //L06T01
        {
            Console.WriteLine("Utils.Info");
        }

        public static int Subtract(int number1, int number2) //L06T02
        {
            return (number1 - number2);
        }

        public static double Average(double number1, double number2, double number3) //L06T03
        {
            return ((number1 + number2 + number3) / 3);
        }

        public static double AskValue(string title) //L06T04
        {
            double number;
            Console.WriteLine(title);
            string line = Console.ReadLine();
            double.TryParse(line, out number);
            return number;
        }

        public static void CalcConsumption(double autonKulutus, double polttoaineHinta, double kuljettuMatka)
        {
            Console.WriteLine("Matkalla kulunut " + ((autonKulutus * kuljettuMatka) / 100) + " litraa polttoainetta ja polttoaineeseen kului " + (((autonKulutus * kuljettuMatka) / 100) * polttoaineHinta) + " euroa");
        }
    }
}
