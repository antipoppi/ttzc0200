/* Tehtävänanto:
 * 
 * Tee taulukko jossa on 5 merkkijonoa.
 * Kysy käyttäjältä indeksi mihin kohtaan taulukkoa käyttäjä haluaa syöttää uuden tekstin.
 * Kysy käyttäjältä uusi teksti ja laita se taulukkoon käyttäjän antamaan indeksiin.
 * Tulosta taulukon sisältö.
 * Korjaa ohjelma niin ettei se kaadu jos käyttäjä syöttää indeksin joka on taulukon ulkopuolella.
 * Kerro käyttäjälle mikäli indeksi ei ole kelvollinen ja pyydä syöttämään se uudestaan.
 */

using System;

namespace Harj14_L14T03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] taulukko = new string[5]; // luodaan tyhjä viiden merkkijonon mittainen taulukko
            for (int i = 0; i < taulukko.Length; i++)
            {
                taulukko[i] = "tyhjä";
            }
            Console.Write("Syötä indeksinumero (0-4) mihin kohtaan taulukkoa haluat syöttää tekstin: ");
            string syöteIndeksi = Console.ReadLine(); // tallennetaan syötetty teksti string-muuttujaan
            int.TryParse(syöteIndeksi, out int indeksi); // TryParse nappaa virheen muunnoksessa numeroksi, jos esim käyttäjä on syöttänyt tyhjää.
            Console.Write("Syötä uusi teksti joka sijoitetaan antamaasi indeksinumeroon " + indeksi + ": ");
            string syötettyTeksti = Console.ReadLine();
            try
            {
                taulukko[indeksi] = syötettyTeksti;
            }
            catch (IndexOutOfRangeException e)
            {
                do // looppaa pyyntöä validista indeksistä niin kauan, kuin ehdot täyttyvät.
                {
                    Console.Write(e.Message + " Syötit kelvottoman indeksinumeron! Syötä uusi väliltä 0-4: ");
                    indeksi = int.Parse(Console.ReadLine());
                }while (indeksi >= taulukko.Length);
                taulukko[indeksi] = syötettyTeksti;
            }
            foreach (string value in taulukko) // tulostaa taulukon
            {
                Console.WriteLine(value);
            }
        }
    }
}
