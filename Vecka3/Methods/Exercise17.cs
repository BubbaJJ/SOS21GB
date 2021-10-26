using System;
namespace Vecka3.Methods
{
    static class Exercise17
    {
        public static void Power()
        {
            int num = 2; // Tal från användaren.
            int exp = 3; // Exponent
            int sum = 1; // Börjar på 1 för att få korrekt startvärde.

            for (int i = 1; i <= exp; i++)
            {
                sum *= num;
            }

            Console.WriteLine("{0}^{1} = {2}", num, exp, sum);
        }
    }
}
