using System;
using System.Collections.Generic;

namespace Vecka3.Switch
{
    static class Exercise08
    {
        public static void Solution()
        {
            Dictionary<string, int> daysInMonth = new Dictionary<string, int>() { { "Januari", 31 }, { "Februari", 28 }, { "Mars", 31 }, { "April", 30 }, { "Maj", 31 }, { "Juni", 30 }, { "Juli", 31 }, { "Augusti", 31 }, { "September", 30 }, { "Oktober", 31 }, { "November", 30 }, { "December", 31 }, };

            // Be användaren skriva in ett tal 1-12
            Console.Write("Skriv in en Månad: ");

            // Konvertera, och lagra, inmatningen
            string month = Console.ReadLine();

            // Skapa en variabel som lagrar antal dagar
            int days = 0;

            // Switch-sats, skicka med användarens inmatning
            switch (month)
            {
                case "Januari":                     // Om användaren har valt Januari
                    days = daysInMonth["Januari"];  // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Februari":                    // Om användaren har valt Februari
                    days = daysInMonth["Februari"]; // Ändra days till 28 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Mars":                        // Om användaren har valt Mars
                    days = daysInMonth["Mars"];     // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "April":                       // Om användaren har valt April
                    days = daysInMonth["April"];    // Ändra days till 30 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Maj":                         // Om användaren har valt Maj
                    days = daysInMonth["Maj"];      // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Juni":                        // Om användaren har valt Juni
                    days = daysInMonth["Juni"];     // Ändra days till 30 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Juli":                        // Om användaren har valt Juli
                    days = daysInMonth["Juli"];     // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Augusti":                     // Om användaren har valt Augusti
                    days = daysInMonth["Augusti"];  // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "September":                   // Om användaren har valt September
                    days = daysInMonth["September"];// Ändra days till 30 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Oktober":                     // Om användaren har valt Oktober
                    days = daysInMonth["Oktober"];  // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "November":                    // Om användaren har valt November
                    days = daysInMonth["November"]; // Ändra days till 30 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "December":                    // Om användaren har valt December
                    days = daysInMonth["December"]; // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                default:                            // Om inget annat "case" stämmer
                    break;                          // Avbryt switch-satsen

            }

            // Skriv ut antal dagar
            Console.WriteLine(days);
        }

        public static void AlternativSolution()
        {
            Dictionary<string, int> daysInMonth = new Dictionary<string, int>() { { "Januari", 31 }, { "Februari", 28 }, { "Mars", 31 }, { "April", 30 }, { "Maj", 31 }, { "Juni", 30 }, { "Juli", 31 }, { "Augusti", 31 }, { "September", 30 }, { "Oktober", 31 }, { "November", 30 }, { "December", 31 }, };

            // Be användaren skriva in ett tal 1-12
            Console.Write("Skriv in en Månad: ");

            // Konvertera, och lagra, inmatningen
            string month = Console.ReadLine();

            // Skapa en variabel som lagrar antal dagar
            int days = 0;

            // Switch-sats, skicka med användarens inmatning
            switch (month)
            {
                case "Januari":                     // Om användaren har valt Januari
                    days = daysInMonth[month];      // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Februari":                    // Om användaren har valt Februari
                    days = daysInMonth[month];      // Ändra days till 28 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Mars":                        // Om användaren har valt Mars
                    days = daysInMonth[month];      // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "April":                       // Om användaren har valt April
                    days = daysInMonth[month];      // Ändra days till 30 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Maj":                         // Om användaren har valt Maj
                    days = daysInMonth[month];      // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Juni":                        // Om användaren har valt Juni
                    days = daysInMonth[month];      // Ändra days till 30 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Juli":                        // Om användaren har valt Juli
                    days = daysInMonth[month];      // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Augusti":                     // Om användaren har valt Augusti
                    days = daysInMonth[month];      // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "September":                   // Om användaren har valt September
                    days = daysInMonth[month];      // Ändra days till 30 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Oktober":                     // Om användaren har valt Oktober
                    days = daysInMonth[month];      // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "November":                    // Om användaren har valt November
                    days = daysInMonth[month];      // Ändra days till 30 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "December":                    // Om användaren har valt December
                    days = daysInMonth[month];      // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                default:                            // Om inget annat "case" stämmer
                    break;                          // Avbryt switch-satsen

            }

            // Skriv ut antal dagar
            Console.WriteLine(days);
        }

        public static void AlternativeSolution2()
        {
            Dictionary<string, int> daysInMonth = new Dictionary<string, int>() { { "Januari", 31 }, { "Februari", 28 }, { "Mars", 31 }, { "April", 30 }, { "Maj", 31 }, { "Juni", 30 }, { "Juli", 31 }, { "Augusti", 31 }, { "September", 30 }, { "Oktober", 31 }, { "November", 30 }, { "December", 31 }, };

            // Be användaren skriva in ett tal 1-12
            Console.Write("Skriv in en Månad: ");

            // Konvertera, och lagra, inmatningen
            string month = Console.ReadLine();

            // Skapa en variabel som lagrar antal dagar
            int days = 0;

            // Switch-sats, skicka med användarens inmatning
            switch (month)
            {
                case "Januari":                     // Om användaren har valt Januari
                case "Mars":                        // Om användaren har valt Mars
                case "Maj":                         // Om användaren har valt Maj
                case "Juli":                        // Om användaren har valt Juli
                case "Augusti":                     // Om användaren har valt Augusti
                case "Oktober":                     // Om användaren har valt Oktober
                case "December":                    // Om användaren har valt December
                    days = daysInMonth[month];      // Ändra days till 31 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "Februari":                    // Om användaren har valt Februari
                    days = daysInMonth[month];      // Ändra days till 28 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                case "April":                       // Om användaren har valt April
                case "Juni":                        // Om användaren har valt Juni
                case "September":                   // Om användaren har valt September
                case "November":                    // Om användaren har valt November
                    days = daysInMonth[month];      // Ändra days till 30 (dagar), lagrat i daysInMonth
                    break;                          // Avbryt switch-satsen

                default:                            // Om inget annat "case" stämmer
                    break;                          // Avbryt switch-satsen

            }

            // Skriv ut antal dagar
            Console.WriteLine(days);
        }
    }
}
