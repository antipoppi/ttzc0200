using System;

namespace Harj06
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.Info(); //L06T01

            int theSubtract = Utils.Subtract(50, 13); //L06T02
            Console.WriteLine(theSubtract);

            double theAverage = Utils.Average(3, 4, 6); //L06T03
            Console.WriteLine(theAverage);

            double autonKulutus = Utils.AskValue("Paljonko on auton kulutus litraa/100km? "); //L06T04
            double polttoaineHinta = Utils.AskValue("Paljonko on polttoaineen hinta? ");
            double kuljettuMatka = Utils.AskValue("Paljonko on kuljettu matka kilometreissä? ");
            Utils.CalcConsumption(autonKulutus, polttoaineHinta, kuljettuMatka);
        }
    }
}
