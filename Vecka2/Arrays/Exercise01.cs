using System;
namespace Vecka2.Arrays
{
    static class Exercise01
    {
        public static void Solution()
        {
            // Skapa en array med textsträngar, lagra 3 värden.
            string[] names = new string[] {"Jim","Leo","Arasto" };

            // Skriv ut samtliga textsträngar, använd index.
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }
    }
}
