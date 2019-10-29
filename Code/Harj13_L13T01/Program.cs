/*  Tehtävänanto:
 *  Toteuta ohjelma joka tallentaa kaikki korttipelin kortit (hertta, ruutu, risti ja pata. Numerot 1-52.) valitsemaasi tietorakenteeseen
 *  Tulosta korttipakka konsoliin.
 *  
 *  V2.0: Tehtävä on tehty kokonaan uusiksi. 
 *  Aikaisemman version lähdekoodi on laitettu kommentiksi ohjelman alle. 
 *  Korttipakan koko on nyt 52, eikä 56.
 *  Alunperin käytin tietorakenteena sanakirjaa, mutta se oli tässä tapauksessa kömpelö valinta,
 *  sillä kortteihin sidottiin myös kokonaisluku arvoksi joka jäi käyttämättä. 
 *  Lista toimii huomattavasti paremmin tässä tarkoituksessa.
 */

using System;
using System.Collections.Generic;

namespace Harj13_L13T01 //Kokoelmat
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<string> korttipakka = new List<string>();
            for (int i = 1; i < 14; i++)
            {
                korttipakka.Add("Hertta " + i.ToString());
            }
            for (int i = 1; i < 14; i++)
            {
                korttipakka.Add("Ruutu " + i.ToString());
            }
            for (int i = 1; i < 14; i++)
            {
                korttipakka.Add("Risti " + i.ToString());
            }
            for (int i = 1; i < 14; i++)
            {
                korttipakka.Add("Pata " + i.ToString());
            }
            foreach (string value in korttipakka)
            {
                Console.WriteLine(value);
            }

            /*V1.0 ENSIMMÄINEN VERSIO
             *
             * 
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
             *
             * 
             */
        }
    }
}
