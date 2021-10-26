using System;
namespace Vecka3.Switch
{
    static class Exercise03
    {
        enum Weekdays       // Samling värden som ska återanvändas.
        {
            Måndag = 1,     // Ändrar första "index" till 1.
            Tisdag = 2,     // "index" 2
            Onsdag = 3,     // "index" 3
            Torsdag = 4,    // "index" 4
            Fredag = 5,     // "index" 5
            Lördag = 6,     // "index" 6
            Söndag = 7      // "index" 7
        }

        public static void Solution()
        {
            // Be användaren skriva in ett tal 1-7
            Console.Write("Skriv in ett tal: [1-7]");

            // Konvertera, och lagra, inmatningen
            int choice = Convert.ToInt32(Console.ReadLine());

            // Switch-sats, skicka med användarens inmatning.
            switch (choice)
            {
                case 1:                                                     // Om användaren har valt 1
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 1));   // Hämta värdet lagrat på "index" 1 i Weekdays.
                    break;                                                  // Avbryt switch-satsen

                case 2:                                                     // Om användaren har valt 2
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 2));   // Hämta värdet lagrat på "index" 2 i Weekdays.
                    break;                                                  // Avbryt switch-satsen

                case 3:                                                     // Om användaren har valt 3
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 3));   // Hämta värdet lagrat på "index" 3 i Weekdays.
                    break;                                                  // Avbryt switch-satsen

                case 4:                                                     // Om användaren har valt 4
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 4));   // Hämta värdet lagrat på "index" 4 i Weekdays.
                    break;                                                  // Avbryt switch-satsen

                case 5:                                                     // Om användaren har valt 5
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 5));   // Hämta värdet lagrat på "index" 5 i Weekdays.
                    break;                                                  // Avbryt switch-satsen

                case 6:                                                     // Om användaren har valt 6
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 6));   // Hämta värdet lagrat på "index" 6 i Weekdays.
                    break;                                                  // Avbryt switch-satsen

                case 7:                                                     // Om användaren har valt 7
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 7));   // Hämta värdet lagrat på "index" 7 i Weekdays.
                    break;                                                  // Avbryt switch-satsen

                default:                                                    // Om inget annat "case" stämmer.
                    break;                                                  // Avbryt switch-satsen
            }

            // Det går också att använda choice tillsammans med GetName
            // Switch-satsen blir då överflödig.
            // Console.WriteLine(Enum.GetName(typeof(Weekdays), choice));
        }
    }
}
