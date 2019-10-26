using System;

namespace Harj12_L12T02 //Muistinhallinta, taulukot
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
            int indeksiLkm = AskNumber("Syötä kuinka monta kokonaislukua luodaan: ");
            int[] taulukko = new int[indeksiLkm];
            for (int i = 0; i < taulukko.Length; i++)
            {
                taulukko[i] = i + 10;
            }
            Array.Reverse(taulukko);
            PrintArray(taulukko);

        }
        static void PrintArray (int[] taulukko)
        {
            foreach (int value in taulukko)
            {
                Console.WriteLine(value);
            }
        }
    }
}
