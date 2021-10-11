using System;
namespace Vecka1.IfElse
{
    static class Exercise14
    {
        public static void Solution()
        {
            // Be användaren skriva in sitt namn.
            // Hälsa användaren välkommen.
            // Fråga om användaren vill spela ett spel.
            // Om användaren svarar ja:
                // Be användaren gissa på ett tal. (0-10)
                // Skriv ut något baserat på om svaret är korrekt eller inte.

            Console.WriteLine("Övning 14: \n");
            int correct = 8;
            Console.Write("Vad heter du? ");
            string name = Console.ReadLine();
            Console.WriteLine("Välkommen {0}", name);
            Console.WriteLine("Vill du spela ett spel? (Ja/Nej) ");
            string answerGame = Console.ReadLine();
            if (answerGame == "Ja")
            {
                Console.Write("Gissa på ett nummer: (0-10) ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == correct)
                {
                    Console.WriteLine("Du lyckades!");
                }
                else
                {
                    Console.WriteLine("Tyvärr, bättre lycka nästa gång...");
                }
            }
            else
            {
                Console.WriteLine("Tråkigt... Ha det!");
            }
        }
    }
}
