/*  Tehtävänanto:
 *  Toteuta ratkaisu joka simuloi kaupan kassalla olevaa asiakasvirtaa.
 *  Käytä ratkaisussa Queue kokoelmaa.
 *  */

using System;
using System.Collections.Generic;

namespace Harj13_L13T03 //kokoelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kassajono = new Queue<string>();
            for (int i = 1; i < 6; i++)
            {
                kassajono.Enqueue("Asiakas nro" + i.ToString());
            }
            while (kassajono.Count > 0)
            {
                Console.WriteLine("Ensimmäisenä jonossa on " + kassajono.Peek() + " ja jonossa on " + kassajono.Count + " asiakasta.");
                string ensimmäinen = kassajono.Dequeue();
                Console.WriteLine("Jonon ensimmäinen " + ensimmäinen + " maksoi ostoksensa ja lähti kotiin.");
            }
            Console.WriteLine("Kassa on suljettu");
        }
    }
}
