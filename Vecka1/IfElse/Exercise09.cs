using System;
namespace Vecka1.IfElse
{
    static class Exercise09
    {
        public static void Solution()
        {
            // Ta in användarens ålder.
            // Skriv ut något lämpligt baserat på:
            // Om användaren är under 18
            // Om användaren är mellan 18 och 65
            // Om användaren är över 65
            // Använd Else If

            Console.WriteLine("Övning 9; \n");
            Console.Write("Skriv in din ålder: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Under 18");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("Mellan 18 och 65");
            }
            else
            {
                Console.WriteLine("Över 65");
            }
        }
    }
}
