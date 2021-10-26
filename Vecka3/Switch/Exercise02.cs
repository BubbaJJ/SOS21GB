using System;
namespace Vecka3.Switch
{
    static class Exercise02
    {
        enum Weekdays   // Samling värden som ska återanvändas.
        {
            Måndag,     // "index" 0
            Tisdag,     // "index" 1
            Onsdag,     // "index" 2
            Torsdag,    // "index" 3
            Fredag,     // "index" 4
            Lördag,     // "index" 5
            Söndag      // "index" 6
        }

        public static void Solution()
        {
            // Be användaren skriva in ett tal 1-7
            Console.Write("Enter a number: [1-7]");

            // Konvertera, och lagra, inmatningen
            int choice = Convert.ToInt32(Console.ReadLine());

            // Switch-sats, skicka med användarens inmatning.
            switch (choice)
            {
                case 1:                                 // Om användaren har valt 1
                    Console.WriteLine(Weekdays.Måndag); // Skriv ut Måndag, som lagrats i enum Weekdays
                    break;                              // Avbryt switch-satsen

                case 2:                                 // Om användaren har valt 2
                    Console.WriteLine(Weekdays.Tisdag); // Skriv ut Tisdag, som lagrats i enum Weekdays
                    break;                              // Avbryt switch-satsen

                case 3:                                 // Om användaren har valt 3
                    Console.WriteLine(Weekdays.Onsdag); // Skriv ut Onsdag, som lagrats i enum Weekdays
                    break;                              // Avbryt switch-satsen

                case 4:                                 // Om användaren har valt 4
                    Console.WriteLine(Weekdays.Torsdag);// Skriv ut Torsdag, som lagrats i enum Weekdays
                    break;                              // Avbryt switch-satsen

                case 5:                                 // Om användaren har valt 5
                    Console.WriteLine(Weekdays.Fredag); // Skriv ut Fredag, som lagrats i enum Weekdays
                    break;                              // Avbryt switch-satsen

                case 6:                                 // Om användaren har valt 6
                    Console.WriteLine(Weekdays.Lördag); // Skriv ut Lördag, som lagrats i enum Weekdays
                    break;                              // Avbryt switch-satsen

                case 7:                                 // Om användaren har valt 7
                    Console.WriteLine(Weekdays.Söndag); // Skriv ut Söndag, som lagrats i enum Weekdays
                    break;                              // Avbryt switch-satsen

                default:                                // Om inget annat "case" stämmer.
                    break;                              // Avbryt switch-satsen
            }
        }
    }
}
