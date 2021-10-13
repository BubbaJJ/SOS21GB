using System;
namespace Vecka1.IfElse
{
    static class Exercise06
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal mellan 1-7.
            // Skriv ut matchande veckodag.
            // T.ex. 1 skriver ut Måndag.

            Console.WriteLine("Övning 6: \n");
            Console.Write("Välj en veckodag: (1-7) ");
            int weekday = Convert.ToInt32(Console.ReadLine());

            if (weekday == 1)
            {
                Console.WriteLine("Måndag");
            }
            else if (weekday == 2)
            {
                Console.WriteLine("Tisdag");
            }
            else if (weekday == 3)
            {
                Console.WriteLine("Onsdag");
            }
            else if (weekday == 4)
            {
                Console.WriteLine("Torsdag");
            }
            else if (weekday == 5)
            {
                Console.WriteLine("Fredag");
            }
            else if (weekday == 6)
            {
                Console.WriteLine("Lördag");
            }
            else if (weekday == 7)
            {
                Console.WriteLine("Söndag");
            }
        }
    }
}
