using System;
using System.Collections.Generic;

namespace Vecka2.Arrays
{
    static class Exercise10
    {
        public static void Solution()
        {
            Console.WriteLine("\nÖvning 10:");

            // Skapa en lista av chars, lagra ditt namn i den.
            List<char> name = new List<char>() { 'J', 'i', 'm' };

            // Skriv ut hela namnet på samma rad, använd index.
            Console.Write(name[0]);
            Console.Write(name[1]);
            Console.Write(name[2]);
        }
    }
}
