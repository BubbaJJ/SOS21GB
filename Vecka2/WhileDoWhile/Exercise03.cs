using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise03
    {
        public static void Solution()
        {
            // Skriv ut alla ojämna tal från x-y.
            // Låt användaren bestämma start- och slutpunkt.

            // Alt 1 - Med modulus
            int count = 1;
            while (count <= 100)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(count);
                }
                count++;
            }

            do
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(count);
                }
                count++;
            } while (count <= 100);

            // Alt 2 - Utan modulus
            count = 2;
            while (count <= 100)
            {
                Console.WriteLine(count);
                count += 2;
            }

            do
            {
                Console.WriteLine(count);
                count += 2;
            } while (count <= 100);
        }
    }
}
