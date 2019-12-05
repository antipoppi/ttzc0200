/* Tehtävänanto:
 *
 * Tee ohjelma joka lukee tekstitiedostosta henkilöitten nimiä ja kertoo montako nimeä löytyy ja montako kertaa kukin nimi esiintyy.
 * Kopioi (tai luo itse vastaava tiedosto) tiedosto ja ohjelmoi koodisi tarkistamaan onko em.hakemistossa tiedostoa.
 * Käytä File.Exist-metodia.
 * Huomioi myös muut mahdolliset poikkeukset joita tiedoston käsittely voi aiheuttaa.
 */

using System;
using System.IO;
using System.Linq;


namespace Harj15_L15T02 // tiedostot
{
    class Program
    {
        static void Main(string[] args) // olen pyrkinyt käsin laittamaan poikkeukset, vaikka sen voi laittaa pelkästään Exception -määreellä yleisesti poimimaan kaikki.
        {
            try
            { /* HOX! Muuta tarvittaessa aseman kirjain/polku, tiedosto on kyllä kansiossa!
               */
                if (File.Exists("H:\\git\\ttzc0200\\code\\harj15_L15T02\\nimet.txt")) // katsotaan löytyykö nimet.txt. 
                {
                    Console.WriteLine("Tiedosto nimet.txt löytyy!");
                    try
                    {
                        string[] nimet = File.ReadAllLines("H:\\git\\ttzc0200\\code\\harj15_L15T02\\nimet.txt"); // luodaan nimet-taulukko nimet.txt:stä
                        Console.WriteLine("\nTiedostosta nimet.txt löytyy " + nimet.Length + " nimeä.\n");

                        string[] laskettuLista = new string[nimet.Length]; // luodaan laskettuLista-taulukko, johon tallennetaan tiedot montako kertaa nimi esiintyy
                        for (int i = 0; i < nimet.Length; i++)
                        {
                            int laskuri = 0;
                            string nimi = nimet[i].ToString();
                            for (int j = 0; j < nimet.Length; j++)
                            {
                                if (nimet[j] == nimi)
                                {
                                    laskuri++; // laskuriin tallennetaan, montako kertaa nimi esiintyy taulukossa eri indeksi-arvolla välillä 0-nimet.Length
                                }
                            }
                            string montakoKpl = nimi + " esiintyy " + laskuri + " kertaa tiedostossa.";
                            laskettuLista[i] = montakoKpl;
                        }
                        string[] järjestettyLista = laskettuLista.Distinct().ToArray(); // luodaan järjestetty lista josta poistetaan identtiset tekstit
                        Console.WriteLine("Tulostettavasta taulukosta on nyt poistettu samat toistuvat nimet. \nNämä nimet esiintyvät tiedostossa: \n");
                        foreach (string i in järjestettyLista)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    catch (FileLoadException ex)
                    {
                        Console.WriteLine("Tiedostoa ei voi lukea: " + ex.Message);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("Indeksinumero ei ole validi: " + ex.Message);
                    }
                    catch (System.Security.SecurityException)
                    {
                        Console.WriteLine("Turvallisuus-virhe: ");
                    }
                }
                else
                {
                    Console.WriteLine("Tiedostoa nimet.txt ei löydy!");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Ei oikeuksia katsoa löytyykö tiedostoa: " + ex.Message);
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Muistia ei ole tarpeeksi: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O erroria pukkaa: " + ex.Message);
            }
        }
    }
}