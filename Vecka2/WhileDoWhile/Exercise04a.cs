using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise04a
    {
        public static void Solution()
        {
            // Skriv ut alla ojämna tal från x-y.
            // Låt användaren bestämma start- och slutpunkt.

            // Alt 1 - Med modulus
            Console.Write("Select start: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select stop: ");
            int stop = Convert.ToInt32(Console.ReadLine());

            while (count <= stop)
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine(count);
                }
                count++;
            }

            do
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine(count);
                }
                count++;
            } while (count <= stop);

            // Alt 2 - Utan modulus

            if (count % 2 == 0) // Om det är ett jämnt startvärde.
            {
                count++;        // addera 1 för att börja på ett ojämnt värde.
            }

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
