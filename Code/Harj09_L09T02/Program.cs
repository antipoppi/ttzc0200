using System;

namespace Harj09_L09T02 //Enumeraatiot ja tietueet
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo auto1;
            auto1.Valmistaja = "Seat";
            auto1.Merkki = "Leon";
            auto1.Vuosimalli = 2005;
            auto1.Hinta = 3000;

            Console.WriteLine(auto1);

            Ajoneuvo auto2;
            auto2.Valmistaja = "Volkswagen";
            auto2.Merkki = "Golf";
            auto2.Vuosimalli = 1989;
            auto2.Hinta = 700;

            Console.WriteLine(auto2);

            Ajoneuvo auto3;
            auto3.Valmistaja = "Volvo";
            auto3.Merkki = "V60";
            auto3.Vuosimalli = 2018;
            auto3.Hinta = 36900;

            Console.WriteLine(auto3);
        }
    }
}
