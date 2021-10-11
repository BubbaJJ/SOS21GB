using System;
namespace Vecka1.IfElse
{
    static class Exercise03
    {
        public static void Solution()
        {
            // Ta in 2 tal.
            // Skriv ut resultatet.
            // Om talen är lika, skriv ut att användaren saknar fantasi.

            int tal1;
            int tal2;
            int result;

            Console.WriteLine("Övning 3: \n");
            Console.Write("Skriv in ditt första tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ditt andra tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            result = tal1 + tal2;
            Console.WriteLine("Summan av talen än {0}", result);

            if (tal1 == tal2)
            {
                Console.WriteLine("Ha lite bättre fantasi nästa gång...");
            }
        }
    }
}
