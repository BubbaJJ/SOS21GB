using System;
using System.Collections.Generic;

namespace Vecka2.Arrays
{
    static class Exercise09
    {
        public static void Solution()
        {
            Console.WriteLine("\nÖvning 9:");

            // Skapa en lista med alla månader.
            List<string> months = new List<string>() { "Januari", "Februari", "Mars", "April", "Maj", "Juni", "Juli", "Augusti", "September", "Oktober", "November", "December" };

            // Låt användaren välja en månad, 1-12.
            Console.Write("Välj månad: [1-12]");

            // Konvertera inmatningen från användaren.
            int selection = Convert.ToInt32(Console.ReadLine());

            // Skriv ut rätt månad baserat på användarens val.
            if (selection == 1)
            {
                Console.WriteLine(months[0]);
            }
            else if (selection == 2)
            {
                Console.WriteLine(months[1]);
            }
            else if (selection == 3)
            {
                Console.WriteLine(months[2]);
            }
            else if (selection == 4)
            {
                Console.WriteLine(months[3]);
            }
            else if (selection == 5)
            {
                Console.WriteLine(months[4]);
            }
            else if (selection == 6)
            {
                Console.WriteLine(months[5]);
            }
            else if (selection == 7)
            {
                Console.WriteLine(months[6]);
            }
            else if (selection == 8)
            {
                Console.WriteLine(months[7]);
            }
            else if (selection == 9)
            {
                Console.WriteLine(months[8]);
            }
            else if (selection == 10)
            {
                Console.WriteLine(months[9]);
            }
            else if (selection == 11)
            {
                Console.WriteLine(months[10]);
            }
            else if (selection == 12)
            {
                Console.WriteLine(months[11]);
            }
        }
    }
}
