using System;
using System.Collections.Generic;

namespace Vecka3.Switch
{
    static class Exercise07
    {
        public static void Solution()
        {
            Dictionary<string, int> daysInMonth = new Dictionary<string, int>() { {"Januari", 31}, { "Februari", 28}, { "Mars", 31 }, { "April", 30 }, { "Maj", 31 }, { "Juni", 30 }, { "Juli", 31 }, { "Augusti", 31 }, { "September", 30 }, { "Oktober", 31 }, { "November", 30 }, { "December", 31 }, };

            // Be användaren skriva in ett tal 1-12
            Console.Write("Skriv in en Månad: ");

            // Konvertera, och lagra, inmatningen
            string month = Console.ReadLine();

            // Skapa en variabel som lagrar antal dagar
            int days = daysInMonth[month];

            // Skriv ut antal dagar
            Console.WriteLine(days);
        }
    }
}
