using System;

namespace Harj10_L10T01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle ajoneuvo;
            CheckEfficiency(out ajoneuvo);
            Console.WriteLine(ajoneuvo);       
        }
        public static void CheckEfficiency(out Vehicle ajoneuvo)
        {
            ajoneuvo.Name = "Seat Leon";
            ajoneuvo.ModelYear = 2005;
            if (ajoneuvo.ModelYear < 1990)
            {
                ajoneuvo.Efficiency = 10;
            }
            else if (ajoneuvo.ModelYear >= 1990 && ajoneuvo.ModelYear <= 2010)
            {
                ajoneuvo.Efficiency = 50;
            }
            else
            {
                ajoneuvo.Efficiency = 100;
            }
        }
    }
}