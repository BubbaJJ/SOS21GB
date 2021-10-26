using System;
namespace Vecka3.Switch
{
    static class Exercise11
    {
        public static void Solution()
        {
            // Be användaren skriva in en bokstav
            Console.WriteLine("Skriv in en bokstav: [a-z] ");

            // Konvertera, och lagra, inmatningen
            char c = Convert.ToChar(Console.ReadLine());

            // Switch-sats, skicka med användarens inmatning
            switch (c)
            {
                case 'a':                                       // Om användaren har skrivit in a
                    Console.WriteLine("{0} är en vokal.", c);   // Skriv ut att bokstaven är en vokal
                    break;                                      // Avbryt switch-satsen

                case 'e':                                       // Om användaren har skrivit in e
                    Console.WriteLine("{0} är en vokal.", c);   // Skriv ut att bokstaven är en vokal
                    break;                                      // Avbryt switch-satsen

                case 'i':                                       // Om användaren har skrivit in i
                    Console.WriteLine("{0} är en vokal.", c);   // Skriv ut att bokstaven är en vokal
                    break;                                      // Avbryt switch-satsen

                case 'o':                                       // Om användaren har skrivit in o
                    Console.WriteLine("{0} är en vokal.", c);   // Skriv ut att bokstaven är en vokal
                    break;                                      // Avbryt switch-satsen

                case 'u':                                       // Om användaren har skrivit in u
                    Console.WriteLine("{0} är en vokal.", c);   // Skriv ut att bokstaven är en vokal
                    break;                                      // Avbryt switch-satsen

                case 'y':                                       // Om användaren har skrivit in y
                    Console.WriteLine("{0} är en vokal.", c);   // Skriv ut att bokstaven är en vokal
                    break;                                      // Avbryt switch-satsen

                case 'å':                                       // Om användaren har skrivit in å
                    Console.WriteLine("{0} är en vokal.", c);   // Skriv ut att bokstaven är en vokal
                    break;                                      // Avbryt switch-satsen

                case 'ä':                                       // Om användaren har skrivit in ä
                    Console.WriteLine("{0} är en vokal.", c);   // Skriv ut att bokstaven är en vokal
                    break;                                      // Avbryt switch-satsen

                case 'ö':                                       // Om användaren har skrivit in ö
                    Console.WriteLine("{0} är en vokal.", c);   // Skriv ut att bokstaven är en vokal
                    break;                                      // Avbryt switch-satsen

                default:                                        // Om inget annat "case" stämmer
                    Console.WriteLine("{0} är en konsonant", c);// Skriv ut att bokstaven är en konsonant
                    break;                                      // Avbryt switch-satsen
            }
        }

        public static void AlternativeSolution()
        {
            // Be användaren skriva in en bokstav
            Console.WriteLine("Skriv in en bokstav: [a-z] ");

            // Konvertera, och lagra, inmatningen
            char c = Convert.ToChar(Console.ReadLine());

            // Switch-sats, skicka med användarens inmatning
            switch (c)
            {
                case 'a':                                       // Om användaren har skrivit in a
                case 'e':                                       // Om användaren har skrivit in e
                case 'i':                                       // Om användaren har skrivit in i
                case 'o':                                       // Om användaren har skrivit in o
                case 'u':                                       // Om användaren har skrivit in u
                case 'y':                                       // Om användaren har skrivit in y
                case 'å':                                       // Om användaren har skrivit in å
                case 'ä':                                       // Om användaren har skrivit in ä
                case 'ö':                                       // Om användaren har skrivit in ö
                    Console.WriteLine("{0} är en vokal.", c);   // Skriv ut att bokstaven är en vokal
                    break;                                      // Avbryt switch-satsen

                default:                                        // Om inget annat "case" stämmer
                    Console.WriteLine("{0} är en konsonant", c);// Skriv ut att bokstaven är en konsonant
                    break;                                      // Avbryt switch-satsen
            }
        }
    }
}
