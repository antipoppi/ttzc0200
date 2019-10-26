/* Tehtävänanto:
 * Tee taulukko jossa on 10 satunnaista kokonaislukua. 
 * Järjestä taulukko suurimmasta pienimpään. 
 * Tulosta taulukon sisältö konsoliin.
 */

using System;

namespace Harj12_L12T05 //Muistinhallinta, taulukot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randTaulukko = new int[10];
            Random random = new Random(); 
            //esitellään Random tässä, ettei sitä tarvitse esitellä uudestaan ja uudestaan loopissa. 
            //Jättämällä () tyhjäksi, random ottaa tietokoneen kellosta siemenluvun.
            for (int i = 0; i < randTaulukko.Length; i++)
            {
                randTaulukko[i] = random.Next(1, 100); //arpoo numeron 1-100 välillä.
            }
            Array.Sort(randTaulukko);
            Array.Reverse(randTaulukko);
            PrintArray(randTaulukko);
        }
        static void PrintArray(int[] randTaulukko)
        {
            foreach (int value in randTaulukko)
            {
                Console.WriteLine(value);
            }
        }
    }
}
