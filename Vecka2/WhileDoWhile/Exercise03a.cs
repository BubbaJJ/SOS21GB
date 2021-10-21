using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise03a
    {
        public static void Solution()
        {
            // Skriv ut alla jämna tal från x-y.
            // Låt användaren bestämma start- och slutpunkt.

            // Alt 1 - Med modulus
            Console.Write("Select start: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select stop: ");
            int stop = Convert.ToInt32(Console.ReadLine());

            while (count <= stop)
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
            } while (count <= stop);

            // Alt 2 - Utan modulus
            count = 2;
            while (count <= stop)
            {
                Console.WriteLine(count);
                count += 2;
            }

            do
            {
                Console.WriteLine(count);
                count += 2;
            } while (count <= stop);
        }
    }
}
