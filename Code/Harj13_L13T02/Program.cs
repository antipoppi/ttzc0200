/*  Tehtävänanto:
 *  Jatkoa edelliseen; Toteuta korttipakan sekoittaminen.
 *  Toteuta Shuffle metodi joka sekoittaa pakan kortit satunnaiseen järjestykseen.
 *  Kutsu Suffle metodia ja tulosta korttipakka konsoliin.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Harj13_L13T01 //Kokoelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> korttipakka = new Dictionary<string, int>();
            for (int i = 1; i < 15; i++)
            {
                korttipakka.Add("Hertta " + i.ToString(), i);
            }
            for (int i = 1; i < 15; i++)
            {
                korttipakka.Add("Ruutu " + i.ToString(), i);
            }
            for (int i = 1; i < 15; i++)
            {
                korttipakka.Add("Risti " + i.ToString(), i);
            }
            for (int i = 1; i < 15; i++)
            {
                korttipakka.Add("Pata " + i.ToString(), i);
            }
            foreach (KeyValuePair<string, int> kvp in korttipakka)
            {
                Console.WriteLine(kvp.Key);
            }

            Random sekoitus = new Random(); 
            korttipakka = korttipakka.OrderBy(x => sekoitus.Next()).ToDictionary(item => item.Key, item => item.Value);
            //OrderBy & ToDictionary metodit tarvitsee System.Linq nimiavaruuden käyttöä. 
            //OrderBy lajittelee sanakirjan arvotun indeksinumeron perusteella. Random indeksiluku annetaan siis molemmille avaimelle että arvolle.

            foreach (KeyValuePair<string, int> kvp in korttipakka)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
