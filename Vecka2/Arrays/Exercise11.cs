using System;
using System.Collections.Generic;

namespace Vecka2.Arrays
{
    static class Exercise11
    {
        public static void Solution()
        {
            Console.WriteLine("\nÖvning 11:");

            // Skapa en lista som innehåller talen 1-10.
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 11a
            // Skriv ut antal element.
            Console.WriteLine(numbers.Count);

            // 11ab
            // Vänd ordningen på listan.
            numbers.Reverse();

            // 11c
            // Lägg till valfritt nummer, på valfritt index.
            numbers.Insert(3, 23); // Index: 3 tal: 23

            // 11d
            // Skriv ut antal element.
            Console.WriteLine(numbers.Count);

            // 11e
            // Sortera listan (Minst till störst)
            numbers.Sort();

            // 11f
            // Radera alla tal som är jämna. 
            numbers.RemoveAll(number => number % 2 == 0);

            // 11g
            // Lägg till tre nya tal i slutet av listan.

            // Alt 1 - Lägg in varje tal separat.
            numbers.Add(23);
            numbers.Add(45);
            numbers.Add(32);

            // Alt 2 - Lägg in alla tal tillsammans med hjälp av en array.
            numbers.AddRange(new int[] { 23, 45, 32 });
        }
    }
}
