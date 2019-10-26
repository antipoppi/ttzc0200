/* Tehtävänanto:
 * Mäkihypyssä käytetään viittä arvostelutuomaria.
 * Kirjoita ohjelma joka kysyy arvostelupisteet yhdelle hypylle.
 * Tulosta tyylipisteiden summa ja keskiarvo siten, että pisteistä on vähennetty pois pienin ja suurin tyylipiste.
 */

using System;

namespace Harj12_L12T04 //Muistinhallinta, taulukot
{
    class Program
    {
        static double AskNumber(string title)
        {
            double number;
            Console.WriteLine(title);
            string line = Console.ReadLine();
            double.TryParse(line, out number);
            return number;
        }
        static void Main(string[] args)
        {
            double[] tuomaritPisteet = new double[5];
            for (int i = 0; i < tuomaritPisteet.Length; i++)
            {
                tuomaritPisteet[i] = AskNumber("Syötä tuomarin antama tyylipistemäärä: (0-20 pistettä)"); 
            }
            Array.Sort(tuomaritPisteet);
            TulostaKa(tuomaritPisteet);
            
        }
        static void TulostaKa(double[] tuomaritPisteet)
        {
            double summa = 0;
            for (int i = 0; i < tuomaritPisteet.Length; i++)
                summa += tuomaritPisteet[i]; //lasketaan kaikkien tuomareiden pisteet yhteen
            double vähennetytPisteet = summa - tuomaritPisteet[0] - tuomaritPisteet[4]; //vähennetään pisteistä pienin ja suurin pistemäärä
            double keskiarvo = vähennetytPisteet / 3;
            Console.WriteLine("Hypyn tyylipisteiden summa on " + vähennetytPisteet + " ja keskiarvo on: " + keskiarvo);
        }
    }
}
