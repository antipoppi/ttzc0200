/* Tehtävänanto:
 *
 * Tee ohjelma joka käsittelee TV-ohjelmia.
 * TV-ohjelman tietoina tulee käsitellä:
 * 
 * - ohjelman nimi
 * - kanava (jolta ohjelma tulee)
 * - alku- ja loppuaika
 * - infoteksti ohjelmasta.
 * 
 * Luo pääohjelmassa muutamia TV-ohjelmamuuttujia (tiedot voit alustaa suoraan koodissa, ei tarvitse kysyä käyttäjältä) ja tallenna ne levylle.
 * Mieti käytätkö jotain kokoelmaa apunasi.
 * Toteuta ohjelmaan myös tiedoston lukeminen ja tulosta TV-ohjelmien tiedot konsoliin.
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace Harj15_L15T05 // Tiedostot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<TV> ohjelmat = new List<TV>();
                ohjelmat.Add(new TV("Täydelliset naiset", "MTV3", "21:00", "22:00", "Tässä jaksossa tapahtuu sitä ja tätä."));
                ohjelmat.Add(new TV("Selviytyjät Suomi", "4", "19:30", "20:50", "Tällä kertaa viidakon valtijuudesta kisaavat sekä julkkikset että tavikset - tutut ja tuntemattomat!"));
                ohjelmat.Add(new TV("Top Gear", "Sub", "22:45", "23:55", "Huonoille liikemiehille sopiva sporttisedan, Vauxhall VXR8 Bathurst Edition sekä HSV Ute Maloo, vauhdinnälkäisen duunarin valinta."));
                ohjelmat.Add(new TV("Arto Nyberg", "TV1", "16:00", "16:45", "Suorassa lähetyksessä haastateltavina taiteilija Arja Saijonmaa."));
                ohjelmat.Add(new TV("Emmerdale", "MTV3", "10:00", "10:30", "Suru puserossa, osa 1/2."));
                ohjelmat.Add(new TV("Huutokaupan metsästäjät", "FOX", "16:00", "16:30", "Kausi 11. Jakso 14. Tour de Van Nuys. Ivy etsiskelee polkupyöriä. Mary saa itselleen niin mageen varaston ja Dave joutuu venytyspenkkiin."));
                TallennaOhjelmat(ohjelmat, "TV-Ohjelmat.txt"); // metodilla tallennetaan ohjelmat tiedostoon
                Console.WriteLine("Tallennettiin " + ohjelmat.Count + " tv-ohjelman tiedot tekstitiedostoon.");
                LueOhjelmat(ohjelmat, "TV-Ohjelmat.txt"); // metodilla tulostetaan tiedot tiedostosta konsoliin
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void TallennaOhjelmat(List<TV> ohjelmat, string tiedostonimi)
        {
            StreamWriter tvTiedot = null;
            try
            {
                tvTiedot = new StreamWriter(tiedostonimi);
                foreach (TV value in ohjelmat)
                {
                    tvTiedot.WriteLine(value);
                }
                tvTiedot.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ei voi tallentaa ohjelmatietoja: " + ex.Message);
            }
            finally
            {
                if (tvTiedot != null)
                {
                    tvTiedot.Close();
                }
            }
        }
        public static void LueOhjelmat(List<TV> ohjelmat, string tiedostonimi)
        {
            try
            {
                string sisältö = File.ReadAllText(tiedostonimi); // tallennetaan tekstitiedoston sisältö stringiin
                Console.WriteLine("\n" + tiedostonimi + " -tiedoston sisältö on seuraava" + ":\n" + sisältö);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Tiedostoa ei löydy: " + ex.Message);
            }
        }
    }
}
