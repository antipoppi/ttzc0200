using System;

namespace Harj12_L12T03 //Muistinhallinta, taulukot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < taulukko.Length; i++)
            if (taulukko[i] % 2 == 0)
            {
                Console.WriteLine(taulukko[i] + " EVEN");
            }
            else Console.WriteLine(taulukko[i] + " ");
        }
    }
}