using System;
using System.Collections.Generic;

namespace Vecka2.Arrays
{
    static class Exercise06
    {
        public static void Solution()
        {
            Console.WriteLine("\nÖvning 6:");

            // Skapa en lista med textsträngar, lagra 3 värden.
            List<string> names = new List<string>() { "Jim", "Leo", "Arasto" };

            // Skriv ut samtliga textsträngar, använd index.
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }
    }
}
