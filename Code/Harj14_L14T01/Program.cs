/* Tehtävänanto:
 * 
 * Tee ohjelma joka aiheuttaa System.OverflowException poikkeuksen.
 * Korjaa ohjelma niin ettei se kaadu.
 * 
 */

using System;

namespace Harj14_L14T01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string lukuMerkkeinä = "123456789101112131415";
                int käännös = int.Parse(lukuMerkkeinä);
                Console.WriteLine(käännös);
            } catch (OverflowException ex)
            {
                Console.WriteLine("Käännettävä luku on liian suuri! " + ex.Message);
            }
        }
    }
}
