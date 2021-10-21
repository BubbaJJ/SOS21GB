using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise04
    {
        public static void Solution()
        {
            // Skriv ut alla ojämna tal från 1-100

            // Steg 1 - Utan input

            // Alt 1 - Med modulus
            int count = 1;
            while (count <= 100)
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
            } while (count <= 100);

            // Alt 2 - Utan modulus
            count = 1;
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

            // Steg 2 - Med input

            // Alt 1 - Med modulus
            Console.Write("Select start: ");
            count = Convert.ToInt32(Console.ReadLine());

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
            if (count % 2 == 0)
            {
                count++;
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
