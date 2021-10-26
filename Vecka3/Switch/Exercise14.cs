using System;
namespace Vecka3.Switch
{
    static class Exercise14
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal 1-10
            Console.Write("Skriv in ett tal: [1-10] ");

            // Konvertera, och lagra, inmatningen
            int score = Convert.ToInt32(Console.ReadLine());

            // Switch-sats, skicka med användarens inmatning
            switch (score)
            {
                case 0:                             // Om användaren har skrivit in 0
                    Console.WriteLine("Betyg F");   // Skriv ut Betyg F
                    break;                          // Avbryt switch-satsen

                case 1:                             // Om användaren har skrivit in 1
                    Console.WriteLine("Betyg F");   // Skriv ut Betyg F
                    break;                          // Avbryt switch-satsen

                case 2:                             // Om användaren har skrivit in 2
                    Console.WriteLine("Betyg E");   // Skriv ut Betyg E
                    break;                          // Avbryt switch-satsen

                case 3:                             // Om användaren har skrivit in 3
                    Console.WriteLine("Betyg E");   // Skriv ut Betyg E
                    break;                          // Avbryt switch-satsen

                case 4:                             // Om användaren har skrivit in 4
                    Console.WriteLine("Betyg D");   // Skriv ut Betyg D
                    break;                          // Avbryt switch-satsen

                case 5:                             // Om användaren har skrivit in 5
                    Console.WriteLine("Betyg D");   // Skriv ut Betyg D
                    break;                          // Avbryt switch-satsen

                case 6:                             // Om användaren har skrivit in 6
                    Console.WriteLine("Betyg C");   // Skriv ut Betyg C
                    break;                          // Avbryt switch-satsen

                case 7:                             // Om användaren har skrivit in 7
                    Console.WriteLine("Betyg C");   // Skriv ut Betyg C
                    break;                          // Avbryt switch-satsen

                case 8:                             // Om användaren har skrivit in 8
                    Console.WriteLine("Betyg B");   // Skriv ut Betyg B
                    break;                          // Avbryt switch-satsen

                case 9:                             // Om användaren har skrivit in 9
                    Console.WriteLine("Betyg B");   // Skriv ut Betyg B
                    break;                          // Avbryt switch-satsen

                case 10:                            // Om användaren har skrivit in 10
                    Console.WriteLine("Betyg A");   // Skriv ut Betyg A
                    break;                          // Avbryt switch-satsen

                default:                            // Om inget annat "case" stämmer
                    break;                          // Avbryt switch-satsen
            }
        }
        public static void AlternativeSolution()
        {
            // Be användaren skriva in ett tal 1-10
            Console.Write("Skriv in ett tal: [1-10] ");

            // Konvertera, och lagra, inmatningen
            int score = Convert.ToInt32(Console.ReadLine());

            // Switch-sats, skicka med användarens inmatning
            switch (score)
            {
                case 0:                             // Om användaren har skrivit in 0
                case 1:                             // Om användaren har skrivit in 1
                    Console.WriteLine("Betyg F");   // Skriv ut Betyg F
                    break;                          // Avbryt switch-satsen
                case 2:                             // Om användaren har skrivit in 2
                case 3:                             // Om användaren har skrivit in 3
                    Console.WriteLine("Betyg E");   // Skriv ut Betyg E
                    break;                          // Avbryt switch-satsen

                case 4:                             // Om användaren har skrivit in 4
                case 5:                             // Om användaren har skrivit in 5
                    Console.WriteLine("Betyg D");   // Skriv ut Betyg D
                    break;                          // Avbryt switch-satsen

                case 6:                             // Om användaren har skrivit in 6
                case 7:                             // Om användaren har skrivit in 7
                    Console.WriteLine("Betyg C");   // Skriv ut Betyg C
                    break;                          // Avbryt switch-satsen

                case 8:                             // Om användaren har skrivit in 8
                case 9:                             // Om användaren har skrivit in 9
                    Console.WriteLine("Betyg B");   // Skriv ut Betyg B
                    break;                          // Avbryt switch-satsen

                case 10:                            // Om användaren har skrivit in 10
                    Console.WriteLine("Betyg A");   // Skriv ut Betyg A
                    break;                          // Avbryt switch-satsen

                default:                            // Om inget annat "case" stämmer
                    break;                          // Avbryt switch-satsen
            }
        }
    }
}
