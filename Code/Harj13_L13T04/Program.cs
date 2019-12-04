/* Tehtävänanto:
 * 
 * Toteuta Movie-tietue, jossa on elokuvan nimi (string), ohjaajan nimi (string) ja vuosiluku (int).
 * Tee ohjelma, jossa List-tietorakenteeseen lisätään 100 kappaletta elokuvia.
 * Generoi kullekin elokuvalle ja ohjaajalle yksilöllinen nimi, esimerkiksi käyttäen kirjaimia väliltä A-Z.
 * Generoi myös elokuvalle satunnainen vuosiluku väliltä 1896-2019.
 * Tulosta näytölle elokuvat tietoineen.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Harj13_L13T04 // Kokoelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> listaElokuvat = new List<Movie>(); // Elokuvien lisääminen listaan alkaa tästä
            do 
            {
                Movie elokuva;
                elokuva.Title = RandomNimi();
                elokuva.Director = RandomNimi();
                elokuva.Year = RandomVuosi();
                listaElokuvat.Add(elokuva);
                listaElokuvat.Distinct(); // poistaa saman nimiset arvot pois listasta
            } while (listaElokuvat.Count < 100);

            foreach (Movie value in listaElokuvat) // tulostetaan elokuvalista
            {
                Console.WriteLine(value);
            }
        }   
        public static string RandomNimi()
        {
            Random rnd = new Random();
            int pituus = rnd.Next(4, 10); // arvotaan nimen pituus
            string kirjaimet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder nimi = new StringBuilder();
            for (int i = 0; i < pituus; i++)
            {
                nimi.Append(kirjaimet[rnd.Next(0, 26)]); // lisää stringbuilderiin satunnaisen kirjaimen
            }
            return nimi.ToString();
        }
        public static int RandomVuosi()
        {
            Random rnd = new Random();
            int vuosi = rnd.Next(1896, 2019);
            return vuosi;
        }
    }
}
