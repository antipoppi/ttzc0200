/* Tehtävänanto:
 *
 * Tee ohjelma joka kysyy käyttäjältä lukuja (joko kokonaisluku tai liukuluku) ja tallenna kokonaisluvut eri tiedostoon kuin liukuluvut.
 * Sovellus tulee lopettaa jos käyttäjä ei syötä kokonais- tai liukulukua.
 * Tarkista tiedostojen sisältö tekstieditorilla.
 * 
 */

using System;
using System.IO;
using System.Text;

namespace Harj15_L15T04
{
    class Program // tiedostot
    {
        static void Main(string[] args)
        {
            StreamWriter kokonaisluvut = null;
            StreamWriter liukuluvut = null;
            try {
                kokonaisluvut = new StreamWriter("kokonaisluvut.txt");
                liukuluvut = new StreamWriter("liukuluvut.txt");
                while (true)
                {
                    Console.WriteLine("Syötä joko kokonaisluku tai liukuluku: ");
                    string inputMerkkijono = Console.ReadLine();
                    try
                    {
                        double syötettyLuku = double.Parse(inputMerkkijono);
                        int koko = (int)syötettyLuku;
                        if (syötettyLuku == koko)
                        {
                            kokonaisluvut.WriteLine(inputMerkkijono);
                        }
                        else
                        {
                            liukuluvut.WriteLine(inputMerkkijono);
                        }
                    }
                    catch (ArgumentNullException ex)
                    {
                        Console.WriteLine("Syötettä ei saanut muutettua luvuksi: " + ex.Message);
                        kokonaisluvut.Close();
                        liukuluvut.Close();
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Et syöttänyt lukua: " + ex.Message);
                        kokonaisluvut.Close();
                        liukuluvut.Close();
                        break;
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("Syötit liian ison tai liian pienen luvun: " + ex.Message);
                        kokonaisluvut.Close();
                        liukuluvut.Close();
                        break;
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("tiedostoa ei voi luoda: " + ex.Message);
            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Ei tarpeeksi muistia: " + ex.Message);
            }
            catch (EncoderFallbackException ex)
            {
                Console.WriteLine("Tiedostoa ei saanut suljettua: " + ex.Message);
            }
            finally
            {
                try
                {
                    if (kokonaisluvut != null)
                    {
                        kokonaisluvut.Close();
                    }
                    else if (liukuluvut != null)
                    {
                        liukuluvut.Close();
                    }
                }
                catch (EncoderFallbackException ex)
                {
                    Console.WriteLine("Tiedostoa ei saanut suljettua: " + ex.Message);
                }
            }
        }
    }
}
