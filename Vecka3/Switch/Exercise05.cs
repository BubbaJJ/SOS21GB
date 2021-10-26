using System;
using System.Collections.Generic;

namespace Vecka3.Switch
{
    static class Exercise05
    {
        public static void Solution()
        {
            Dictionary<int, string> weekdays = new Dictionary<int, string>() { { 1, "Måndag" }, { 2, "Tisdag" }, { 3, "Onsdag" }, { 4, "Torsdag" }, { 5, "Fredag" }, { 6, "Lördag" }, { 7, "Söndag" } };

            // Be användaren skriva in ett tal 1-7
            Console.WriteLine("Skriv in ett tal: [1-7]");

            // Konvertera, och lagra, inmatningen
            int input = Convert.ToInt32(Console.ReadLine());

            // Lagra rätt veckodag i en variabel
            string day = weekdays[input];

            // Skriv ut veckodagen
            Console.WriteLine(day);

        }
    }
}
