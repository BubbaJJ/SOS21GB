using System;
namespace Vecka1.IfElse
{
    static class Exercise17
    {
        public static void Solution()
        {
            // Be användaren skriva in en vecka. (0-52)
            // Be användaren skriva in ett datum. (0-31)
            // Användaren får endast tvätta på ojämna veckor och jämna datum.
            // Skriv ut om användaren får tvätta eller inte.

            Console.WriteLine("Övning 17: \n");
            Console.Write("Vilken vecka vill du tvätta? (1-52) ");
            int week = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vilket datum vill du tvätta? (0-31) ");
            int date = Convert.ToInt32(Console.ReadLine());

            if (week % 2 != 0 && date % 2 == 0)
            {
                Console.WriteLine("Du får tvätta på det valda datumet.");
            }
            else
            {
                Console.WriteLine("Du får inte tvätta på det valda datumet.");
            }
        }
    }
}
