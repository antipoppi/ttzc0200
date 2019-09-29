/*
 *=============================================================================
 * Name:        Program.cs
 * Part of:     Basics of programming course
 * Description: Demo04
 * Version:     1.0
 * Author:      Tatu Alatalo
 * License:     NoLicence
 * =============================================================================
 */
using System;

namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo04");

            // example of using namespace 'System', this way we can use Console class
            // without 'using System;'
            System.Console.WriteLine("This line will appear in my console app");
        }

        /// <summary>
        /// Sum function calculates sum of two numbers
        /// </summary>
        /// <param name="number1">first number to add to sum</param>
        /// <param name="number2">second number to add to sum</param>
        /// <returns>sum of number1 and number2</returns>
        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
