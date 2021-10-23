using System;
namespace Vecka2.Arrays
{
    static class Exercise03
    {
        public static void Solution()
        {
            // Skapa en array av chars, lagra ditt namn i den.
            char[] name = new char[] { 'J','i','m' };

            // Skriv ut hela namnet på samma rad, använd index.
            Console.Write(name[0]);
            Console.Write(name[1]);
            Console.Write(name[2]);
        }
    }
}