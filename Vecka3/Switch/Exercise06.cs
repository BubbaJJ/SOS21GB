using System;
namespace Vecka3.Switch
{
    static class Exercise06
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal 1-12
            Console.Write("Skriv in ett tal: [1-12]");

            // Konvertera, och lagra, inmatningen
            int input = Convert.ToInt32(Console.ReadLine());

            // Skapa en variabel som lagrar antal dagar
            int days = 0;

            // Switch-sats, skicka med användarens inmatning
            switch (input)
            {
                case 1:         // Om användaren har valt 1
                    days = 31;  // Ändra days till 31 (dagar)
                    break;      // Avbryt switch-satsen

                case 2:         // Om användaren har valt 2
                    days = 28;  // Ändra days till 28 (dagar)
                    break;      // Avbryt switch-satsen

                case 3:         // Om användaren har valt 3
                    days = 31;  // Ändra days till 31 (dagar)
                    break;      // Avbryt switch-satsen

                case 4:         // Om användaren har valt 4
                    days = 30;  // Ändra days till 30 (dagar)
                    break;      // Avbryt switch-satsen

                case 5:         // Om användaren har valt 5
                    days = 31;  // Ändra days till 31 (dagar)
                    break;      // Avbryt switch-satsen

                case 6:         // Om användaren har valt 6
                    days = 30;  // Ändra days till 30 (dagar)
                    break;      // Avbryt switch-satsen

                case 7:         // Om användaren har valt 7
                    days = 31;  // Ändra days till 31 (dagar)
                    break;      // Avbryt switch-satsen

                case 8:         // Om användaren har valt 8
                    days = 31;  // Ändra days till 31 (dagar)
                    break;      // Avbryt switch-satsen

                case 9:         // Om användaren har valt 9
                    days = 30;  // Ändra days till 30 (dagar)
                    break;      // Avbryt switch-satsen

                case 10:        // Om användaren har valt 10
                    days = 31;  // Ändra days till 31 (dagar)
                    break;      // Avbryt switch-satsen

                case 11:        // Om användaren har valt 11
                    days = 30;  // Ändra days till 30 (dagar)
                    break;      // Avbryt switch-satsen

                case 12:        // Om användaren har valt 12
                    days = 31;  // Ändra days till 31 (dagar)
                    break;      // Avbryt switch-satsen

                default:        // Om inget annat "case" stämmer
                    break;      // Avbryt switch-satsen

            }

            // Skriv ut antal dagar
            Console.WriteLine(days);
        }

        public static void AlternativSolution()
        {
            // Be användaren skriva in ett tal 1-12
            Console.Write("Skriv in ett tal: [1-12]");

            // Konvertera, och lagra, inmatningen
            int input = Convert.ToInt32(Console.ReadLine());

            // Skapa en variabel som lagrar antal dagar
            int days = 0;

            // Switch-sats, skicka med användarens inmatning
            switch (input)
            {
                case 1:         // Om användaren har valt 1
                case 3:         // Om användaren har valt 3
                case 5:         // Om användaren har valt 5
                case 7:         // Om användaren har valt 7
                case 8:         // Om användaren har valt 8
                case 10:        // Om användaren har valt 10
                case 12:        // Om användaren har valt 12
                    days = 31;  // Ändra days till 31 (dagar)
                    break;      // Avbryt switch-satsen

                case 2:         // Om användaren har valt 2
                    days = 28;  // Ändra days till 28 (dagar)
                    break;      // Avbryt switch-satsen

                case 4:         // Om användaren har valt 4
                case 6:         // Om användaren har valt 6
                case 9:         // Om användaren har valt 9
                case 11:        // Om användaren har valt 11
                    days = 30;  // Ändra days till 30 (dagar)
                    break;      // Avbryt switch-satsen

                default:        // Om inget annat "case" stämmer
                    break;      // Avbryt switch-satsen

            }

            // Skriv ut antal dagar
            Console.WriteLine(days);
        }
    }
}
