using System;
namespace Vecka3.Enums
{
    static class Enums
    {
        enum Weekdays1
        {
            Måndag,
            Tisdag,
            Onsdag,
            Torsdag,
            Fredag,
            Lördag,
            Söndag
        }

        enum Weekdays2
        {
            Måndag = 1,
            Tisdag = 2,
            Onsdag = 3,
            Torsdag = 4,
            Fredag = 5,
            Lördag = 6,
            Söndag = 7
        }

        enum Weekdays3
        {
            Måndag = 1,
            Tisdag = 2,
            Onsdag = 3,
            Torsdag = 4,
            Fredag = 5,
            Lördag = 6,
            Söndag = 7
        }

        public static void Examples()
        {
            /*
                Syntax:
                enum Namn
                {
                    Värde1,         // "Index" 0
                    Värde2,         // "Index" 1
                    Värde3,         // "Index" 2
                    Värde4,         // "Index" 3
                    Värde5          // "Index" 4
                }

                enum Namn
                {
                    Värde1 = 1,     // "Index" 1
                    Värde2 = 2,     // "Index" 2
                    Värde3 = 3,     // "Index" 3
                    Värde4 = 4,     // "Index" 4
                    Värde5 = 5      // "Index" 5
                }

                enum Namn
                {
                    Värde1 = 1,     // "Index" 1
                    Värde2 = 3,     // "Index" 3
                    Värde3 = 5,     // "Index" 5
                    Värde4 = 13,    // "Index" 13
                    Värde5 = 34     // "Index" 34
                }

                enum Namn
                {
                    Värde1,         // "Index" 0
                    Värde2,         // "Index" 1
                    Värde3 = 7,     // "Index" 7
                    Värde4,         // "Index" 8
                    Värde5          // "Index" 9
                }

                // Hämta värde baserat på "index".
                Enum.GetName(typeof(EnumNamn), "index");

                // Hämta samtliga värden. Samlas i en array.
                Enum.GetNames(typeof(EnumNamn));

                // Hämta längden/antal Enums.
                Enum.GetNames(typeof(EnumNams)).Length;


            */
            int dayNum = (int)Weekdays1.Måndag;
            Console.WriteLine(dayNum);
            Console.WriteLine(Weekdays1.Måndag);
            Console.WriteLine(Weekdays2.Måndag);
        }
    }
}
