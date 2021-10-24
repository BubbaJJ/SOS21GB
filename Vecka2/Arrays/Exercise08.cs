using System;
using System.Collections.Generic;

namespace Vecka2.Arrays
{
    static class Exercise08
    {
        public static void Solution()
        {
            Console.WriteLine("\nÖvning 8:");

            // Skapa en lista med alla veckodagar.
            List<string> weekdays = new List<string>() { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag" };

            // Låt användaren välja veckodag, 1-7.
            Console.Write("Välj veckodag: [1-7]");

            // Konvertera inmatningen från användaren.
            int selection = Convert.ToInt32(Console.ReadLine());

            // Skriv ut rätt veckodag baserat på användarens val.
            if (selection == 1)
            {
                Console.WriteLine(weekdays[0]);
            }
            else if (selection == 2)
            {
                Console.WriteLine(weekdays[1]);
            }
            else if (selection == 3)
            {
                Console.WriteLine(weekdays[2]);
            }
            else if (selection == 4)
            {
                Console.WriteLine(weekdays[3]);
            }
            else if (selection == 5)
            {
                Console.WriteLine(weekdays[4]);
            }
            else if (selection == 6)
            {
                Console.WriteLine(weekdays[5]);
            }
            else if (selection == 7)
            {
                Console.WriteLine(weekdays[6]);
            }
        }
    }
}
