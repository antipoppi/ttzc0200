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

namespace Harj05_L05T05
{
    class Program
    {
        static void Main(string[] args)
        {
            double tili = 0.0; // original amount of money in the account

            Console.WriteLine("Montako euroa lisätään saldoon?: ");
            string addedEuro = Console.ReadLine();
            int.TryParse(addedEuro, out int saldoEuro);

            Console.WriteLine("Montako senttiä lisätään saldoon?: ");
            string addedCent = Console.ReadLine();
            double.TryParse(addedCent, out double saldoCent); //using double because you can't divide integer with 100 to get decimals.

            double saldo = tili + (saldoEuro / 1.0) + (saldoCent / 100); //original amount of money + added amount of euros + added amount of cents

            Console.WriteLine("Pankkitilin saldo on " + saldo + " euroa.");
        }
    }
}
