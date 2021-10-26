using System;
namespace Vecka3.Switch
{
    static class Exercise12
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal
            Console.Write("Skriv in ditt första tal: ");

            // Konvertera, och lagra, inmatningen
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Be användaren skriva in ett till tal
            Console.Write("Skriv in ditt första tal: ");

            // Konvertera, och lagra, inmatningen
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Switch-sats, skicka med användarens inmatningar
            // Jämför talen
            switch (num1>num2)
            {
                case true:                                                  // Om num1>num2
                    Console.WriteLine("{0} är större än {1}", num1, num2);  // Skriv ut att num1 är större
                    break;                                                  // Avbryt switch-satsen

                default:                                                    // Om num1<num2
                    Console.WriteLine("{0} är större än {1}", num2, num1);  // Skriv ut att num2 är större
                    break;                                                  // Avbryt switch-satsen
            }
        }
    }
}
