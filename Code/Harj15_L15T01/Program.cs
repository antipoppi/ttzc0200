/* Tehtävänanto:
 *
 * Tee ohjelma joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon (lopetusehdon voit päättää itse) ja sulje tiedosto.
 * Avaa tämän jälkeen tiedosto lukemista varten ja tulosta konsoliin tiedoston sisältö riveittäin.
 * Huomioi mahdolliset poikkeukset joita tiedoston käsittely voi aiheuttaa.
 */

using System;
using System.IO;

namespace Harj15_L15T01 // tiedostot
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter tiedosto = null;
            try {
                tiedosto = new StreamWriter("Harj15.txt");
                Console.WriteLine("Tämä ohjelma tallentaa kaikki merkkijonot mitä syötät. Lopettaaksesi kirjoita !stop");
                while (true) // syötetään merkkijonoja niin kauan, että syötetään !stop
                {
                    Console.WriteLine("Syötä merkkijono minkä haluat lisätä tiedostoon:");
                    try {
                        string uusiRivi = Console.ReadLine();
                        if (uusiRivi == "!stop")
                        {
                            tiedosto.Close();
                            break;
                        }
                        else tiedosto.WriteLine(uusiRivi);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Syötetty teksti on virheellinen: " + ex.Message);
                    }
                }
                try { // !stop jälkeen tulostaa Harj15.txt:n sisällön ja ohjelma päättyy.
                    string sisältö = File.ReadAllText("Harj15.txt");
                    Console.WriteLine("Tiedoston sisältö on seuraava: " + "\n" + sisältö);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine("Sinulla ei ole oikeutta lukea tiedostoa: " + ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Tiedostoa ei löydy: " + ex.Message);
                }
                catch (FileLoadException ex)
                {
                    Console.WriteLine("Tiedostoa ei voi ladata: " + ex.Message);
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Muistia ei ole tarpeeksi: " + ex.Message);
            }
            finally 
            {
                if (tiedosto != null)
                {
                    tiedosto.Close();
                }
            }
        }
    }
}