using System;
namespace Vecka2.RandomInt
{
    static class RandomInt
    {
        public static void Examples()
        {
            /*
                Syntax:
                Random namn = new Random();

                För att generera en random integer.
                // Inget maxvärde. (0+)
                namn.Next();

                // Endast maxvärde (0-maxvärde(-1))
                namn.Next(maxvärde);

                // Från startvärde till maxvärde(-1).
                namn.Next(startvärde, maxvärde);
            */

            Random rnd = new Random();  // Skapar en ny instans av Random, ger den namnet rnd.

            rnd.Next();         // Genererar ett tal från 0 och uppåt.

            rnd.Next(50);       // Genererar ett tal från 0 - 49.

            rnd.Next(1, 100);   // Genererar ett tal från 1 - 99.

            Random r = new Random();    // Skapar en ny instans av Random, ger den namnet r.
        }
    }
}
