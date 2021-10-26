using System;
using System.Collections.Generic;

namespace Vecka3.Switch
{
    static class Exercise04
    {
        enum Weekdays   // Samling värden som ska återanvändas.
        {
            Måndag = 1, // Ändrar första "index" till 1. Övriga ökar med 1.
            Tisdag,     // 2
            Onsdag,     // 3
            Torsdag,    // 4
            Fredag,     // 5
            Lördag,     // 6
            Söndag      // 7
        }

        public static void Solution()
        {
            // Skapa en tom Dictionary. Key = int, Value = string
            Dictionary<int, string> weekdays = new Dictionary<int, string>();

            // Skapa en loop för varje dag.
            for (int i = 1; i <= 7; i++)
            {
                // Be användaren skriva in namn för varje veckodag.
                Console.Write("Skriv in namn för veckodag {0}: ", i);
                string day = Console.ReadLine();

                // Lägg till varje dag i Dictionary. Key = i, Value = Användarens inmatning.
                weekdays.Add(i, day);
            }

            // Skriv ut alal värden för kontroll.
            // KeyValuePair används för Dictionary.
            foreach (KeyValuePair<int, string> days in weekdays)
            {
                Console.WriteLine("Key: {0} Value: {1}",days.Key, days.Value);
            }
        }

        public static void AlternativeSolution()
        {
            // Skapa en tom Dictionary. Key = int, Value = string
            Dictionary<int, string> weekdays = new Dictionary<int, string>();

            // Skapa en loop för varje dag.
            for (int i = 1; i <= 7; i++)
            {
                // Hämta namnet för varje dag med hjälp av enum.
                // Lägg till varje dag i Dictionary. Key = i, Value = Hämtad enum
                weekdays.Add(i, Enum.GetName(typeof(Weekdays), i));
            }

            // Skriv ut alal värden för kontroll.
            // KeyValuePair används för Dictionary.
            foreach (KeyValuePair<int, string> days in weekdays)
            {
                Console.WriteLine("Key: {0} Value: {1}", days.Key, days.Value);
            }
        }
    }
}
