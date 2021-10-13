using System;
namespace Vecka1.IfElse
{
    static class Exercise20
    {
        public static void Solution()
        {
            // Be användaren skriva in längden på varje sida i en triangel.
            // Skriv ut vilken sorts triangel det är.
            // Rätvinkling = Inga sidor är lika långa.
            // Likbent = Två sidor är lika långa.
            // Liksidig = Samtliga sidor är lika långa.
            
            Console.WriteLine("Övning 20: \n");
            Console.Write("Skriv in längden på den första sidan av triangeln: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in längden på den andra sidan av triangeln: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in längden på den tredje sidan av triangeln: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && a == c && b == c)
            {
                Console.WriteLine("Det är en liksidig triangel.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Det är en likbent triangel.");
            }
            else
            {
                Console.WriteLine("Det är en rätvinklig triangel.");
            }

        }
    }
}
