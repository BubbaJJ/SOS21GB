using System;
namespace Vecka1.IfElse
{
    static class Exercise07
    {
        public static void Solution()
        {
            // Ta in två strängar från användaren.
            // Skriv ut om strängarna matchar varandra eller inte.

            Console.WriteLine("Övning 7: \n");
            Console.Write("Skriv in din första textsträng: ");
            string firstString = Console.ReadLine();
            Console.Write("Skriv in din andra textsträng: ");
            string secondString = Console.ReadLine();

            if (firstString == secondString)
            {
                Console.WriteLine("Strängarna matchar varandra.");
            }
            else
            {
                Console.WriteLine("Strängarna matcher inte varandra.");
            }
        }
    }
}
