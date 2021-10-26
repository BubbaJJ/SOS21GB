using System;
namespace Vecka3.Switch
{
    static class Exercise01
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal 1-7
            Console.Write("Skriv in ett tal: [1-7]");

            // Konvertera, och lagra, användarens inmatning
            int choice = Convert.ToInt32(Console.ReadLine());

            // Switch-sats, skicka med användarens inmatning.
            switch (choice)
            {
                case 1:                             // Om användaren har valt 1
                    Console.WriteLine("Måndag");    // Skriv ut Måndag
                    break;                          // Avbryt switch-satsen

                case 2:                             // Om användaren har valt 2
                    Console.WriteLine("Tisdag");    // Skriv ut Tisdag
                    break;                          // Avbryt switch-satsen

                case 3:                             // Om användaren har valt 3
                    Console.WriteLine("Onsdag");    // Skriv ut Onsdag
                    break;                          // Avbryt switch-satsen

                case 4:                             // Om användaren har valt 4
                    Console.WriteLine("Torsdag");   // Skriv ut Torsdag
                    break;                          // Avbryt switch-satsen

                case 5:                             // Om användaren har valt 5
                    Console.WriteLine("Fredag");    // Skriv ut Fredag
                    break;                          // Avbryt switch-satsen

                case 6:                             // Om användaren har valt 6
                    Console.WriteLine("Lördag");    // Skriv ut Lördag
                    break;                          // Avbryt switch-satsen

                case 7:                             // Om användaren har valt 7
                    Console.WriteLine("Söndag");    // Skriv ut Söndag
                    break;                          // Avbryt switch-satsen

                default:                            // Om inget annat "case" stämmer.
                    break;                          // Avbryt switch-satsen
            }
        }
    }
}
