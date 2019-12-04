/* Tehtävänanto:
 * 
 * Toteuta uusi metodi ja laita metodi heittämään NotImplementedException.
 * Kokeile kutsua metodia.
 * 
 */

using System;

namespace Harj14_L14T02
{
    class Program
    {
        static void Main(string[] args)
        {
            joskusJokuPäivä();
        }
        public static void joskusJokuPäivä()
        {
            throw new NotImplementedException();
        }

    }
}
