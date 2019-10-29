/*  Tehtävänanto:
 *  Jatkoa edelliseen; Toteuta korttipakan sekoittaminen.
 *  Toteuta Shuffle metodi joka sekoittaa pakan kortit satunnaiseen järjestykseen.
 *  Kutsu Suffle metodia ja tulosta korttipakka konsoliin.
 *  
 *  V2.0: Tehtävä on tehty kokonaan uusiksi. 
 *  Aikaisemman version lähdekoodi on laitettu kommentiksi ohjelman alle. 
 *  Korttipakan koko on nyt 52, eikä 56.
 *  Alunperin käytin sanakirjaa, mutta se oli tässä tapauksessa tietorakenteena kömpelö valinta,
 *  sillä kortteihin sidottiin myös kokonaisluku arvoksi joka jäi käyttämättä. 
 *  Lista toimii huomattavasti paremmin tässä tarkoituksessa. 
 *  Lisäksi tässä versiossa on luotu/kutsuttu Shuffle metodi, joka jäi luomatta edellisessä versiossa.
 *  Summa summarum, opinpahan miten saa sekoitettua sanakirjan halutessa...
 */

using System;
using System.Collections.Generic;
//using System.Linq; V1.0 tarvitsee tämän käyttämistä.

namespace Harj13_L13T01 //Kokoelmat
{
    class Program
    {
        public static List<T>Shuffle<T>(List<T> korttipakka)
        {
            Random rnd = new Random();
            for (int i = 0; i < korttipakka.Count; i++) //loopataan sekoitus koko pakkaan kortti kerrallaan
            {
                int k = rnd.Next(0, i); // antaa kortille satunnaisen arvon jo sekoitettujen korttien välillä.
                T value = korttipakka[k]; //type parametriin tallennetaan satunnaisen arvotun numeron arvo
                korttipakka[k] = korttipakka[i]; //tallennetaan k-arvoksi järjestyksessä olevan kortin numero
                korttipakka[i] = value; //lopulta sekoitettu kortti saa uuden arvon ja sijoitetaan arvotulle kohdalle, toistetaan niin kauan että koko pakka läpi.
            }
            return korttipakka;
        }
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
            Shuffle(korttipakka); //kutsutaan Shuffle-metodi
            foreach (string value in korttipakka)
            {
                Console.WriteLine(value);
            }
            
            /*V1.0 ENSIMMÄINEN VERSIO
             *
             * 
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
             *
             * 
             */
        }
    }
}
