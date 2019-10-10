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

namespace Harj05_L05T02
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort height = 172; // using "ushort" -datatype because people can be taller than the max value (255) in the datatype "byte"
            Console.WriteLine("Henkilön pituus on " + height + "cm");
        }
    }
}
