using System;

namespace Harj09_L09T01 //Enumeraatiot ja tietueet
{
    enum Viikonpäivä
    {
        Maanantai,
        Tiistai,
        Keskiviikko,
        Torstai,
        Perjantai,
        Lauantai,
        Sunnuntai,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Viikonpäivä status = Viikonpäivä.Tiistai;
            switch (status)
            {
                case Viikonpäivä.Maanantai:
                    Console.WriteLine("Tänään on maanantai.");
                    break;
                case Viikonpäivä.Tiistai:
                    Console.WriteLine("Tänään on tiistai.");
                    break;
                case Viikonpäivä.Keskiviikko:
                    Console.WriteLine("Tänään on keskiviikko.");
                    break;
                case Viikonpäivä.Torstai:
                    Console.WriteLine("Tänään on torstai.");
                    break;
                case Viikonpäivä.Perjantai:
                    Console.WriteLine("Tänään on perjantai.");
                    break;
                case Viikonpäivä.Lauantai:
                    Console.WriteLine("Tänään on lauantai.");
                    break;
                case Viikonpäivä.Sunnuntai:
                    Console.WriteLine("Tänään on sunnuntai.");
                    break;
            }
        }
    }
}
