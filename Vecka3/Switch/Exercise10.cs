using System;
namespace Vecka3.Switch
{
    static class Exercise10
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal
            Console.Write("Skriv in ett tal: ");

            // Konvertera, och lagra, inmatningen
            int number = Convert.ToInt32(Console.ReadLine());

            // Switch-sats, skicka med användarens inmatning
            // Modulus används för att kontrollera om det är jämnt eller inte.
            switch (number%2)
            {
                case 0:                                                 // Om number%2 == 0
                    Console.WriteLine("{0} är ett jämnt tal.",number);  // Skriv ut att talet är jämnt
                    break;                                              // Avbryt switch-satsen

                default:                                                // Om number%2 != 0
                    Console.WriteLine("{0} är ett ojämnt tal.", number);// Skriv ut att talet är ojämnt
                    break;                                              // Avbryt switch-satsen
            }
        }
    }
}
