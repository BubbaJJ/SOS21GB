using System;
using System.Collections.Generic;

namespace Vecka3.Switch
{
    static class Exercise13
    {
        public static void Solution()
        {
            Dictionary<string, double> weekdayPricing = new Dictionary<string, double>() { { "Banan", 2.50 }, { "Äpple", 1.20 }, { "Apelsin", 0.85 }, { "Grapefrukt", 1.45 }, { "Kiwi", 2.70 }, { "Ananas", 5.50 }, { "Vindruvor", 3.85 } };
            Dictionary<string, double> weekendPricing = new Dictionary<string, double>() { { "Banan", 2.70 }, { "Äpple", 1.25 }, { "Apelsin", 0.90 }, { "Grapefrukt", 1.60 }, { "Kiwi", 3.00 }, { "Ananas", 5.60 }, { "Vindruvor", 4.20 } };

            // Be användaren skriva in veckodag 1-7
            Console.Write("Välj veckodag: [1-7] ");

            // Konvertera, och lagra, inmatningen
            int day = Convert.ToInt32(Console.ReadLine());

            // Be användaren välja frukt
            Console.Write("Välj frukt: [Banan, Äpple, Apelsin, Grapefrukt, Kiwi, Ananas, Vindruvor] ");

            // Lagra inmatningen
            string fruit = Console.ReadLine();

            // Be användaren välja önskat antal
            Console.Write("Du har valt {0}, skriv in önskat antal: ", fruit);

            // Konvertera, och lagra, inmatningen
            int amount = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            if(day >= 1 && day <= 5)
            {
                sum = weekdayPricing[fruit] * amount;
            }
            else
            {
                sum = weekendPricing[fruit] * amount;
            }

            Console.WriteLine("Att betala: {0}", sum);
        }
    }
}
