/*
 *=============================================================================
 * Name:        Program.cs
 * Part of:     Basics of programming course
 * Description: Harjoitustehtävät L05, Perustietotyypit ja muuttujat
 * Version:     1.0
 * Author:      Tatu Alatalo
 * License:     NoLicence
 * ============================================================================
 */
using System;

namespace Harj05_L05T04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä kokonaisluku: ");
            string inputNumber3 = Console.ReadLine();
            int.TryParse(inputNumber3, out int integer3);

            Console.WriteLine("Syötä toinen kokonaisluku: ");
            string inputNumber4 = Console.ReadLine();
            int.TryParse(inputNumber4, out int integer4);

            Console.WriteLine("Kokonaislukujen summa on " + (integer3 + integer4));
            Console.WriteLine("Kokonaislukujen erotus on " + (integer3 - integer4));
            Console.WriteLine("Kokonaislukujen tulo on " + (integer3 * integer4));
            Console.WriteLine("Kokonaislukujen jakolasku on " + ((integer3 / 1.0) / (integer4 / 1.0))); // changing integers to double when divided by 1.0
        }
    }
}
