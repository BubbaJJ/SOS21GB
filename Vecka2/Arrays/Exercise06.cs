using System;
using System.Collections.Generic;

namespace Vecka2.Arrays
{
    static class Exercise06
    {
        public static void Solution()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Skriv ut samtliga element.
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Lägg till valfritt nummer, på valfritt index.
            numbers.Insert(3, 23); // Index: 3 tal: 23

            // Skriv ut samtliga element.
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Sortera listan - Från minsta till största.
            numbers.Sort();

            // Radera alla tal som är jämna. 
            numbers.RemoveAll(number => number%2 == 0);

            // Alt 1 - Lägg in varje tal separat.
            numbers.Add(23);
            numbers.Add(45);
            numbers.Add(32);

            // Alt 2 - Lägg in alla tal tillsammans med hjälp av en array.
            numbers.AddRange(new int[] {23, 45, 32 });
        }
    }
}
