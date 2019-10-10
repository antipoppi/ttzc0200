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

namespace Harj05_L05T03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä kokonaisluku: ");
            string inputNumber1 = Console.ReadLine();
            int.TryParse(inputNumber1, out int integer1); //changing string to int

            Console.WriteLine("Syötä toinen kokonaisluku: ");
            string inputNumber2 = Console.ReadLine();
            int.TryParse(inputNumber2, out int integer2);

            Console.WriteLine("Kokonaislukujen summa on " + (integer1 + integer2));
        }
    }
}
