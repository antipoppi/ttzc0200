/*  Tehtävänanto:
 *  Toteuta ohjelma joka tallentaa kaikki korttipelin kortit (hertta, ruutu, risti ja pata. Numerot 1-52.) valitsemaasi tietorakenteeseen
    Tulosta korttipakka konsoliin.
*/

using System;
using System.Collections.Generic;

namespace Harj13_L13T01 //Kokoelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> korttipakka = new Dictionary<string, int>();
            for (int i = 1; i < 15; i++) //loopataan Hertta-korttien luominen aloittamalla indeksistä 1
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
            foreach (KeyValuePair<string, int> kvp in korttipakka) //tulostaa korttipakan
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
