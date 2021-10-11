using System;
namespace Vecka1.IfElse
{
    static class Exercise04
    {
        public static void Solution()
        {
            // Ta in användarens ålder.
            // Skriv ut hur många år det är kvar till pension.
            // Fråga om användaren vill spola fram tiden tills pension.
            // Svaret från användaren ska vara en char. (J/N)
            // Om ja, ändra åldern till 65.
            // Fråga om användaren vill stanna kvar vid denna ålder.
                // Lista med WriteLine
                // 1. Jag vill stanna kvar på denna ålder.
                // 2. Nej, jag ångrar mig. Ta mig tillbaka!
            // Om 1: Skriv ut något lämpligt och avsluta programmet.
            // Om 2: Ändra åldern till den ursprungliga åldern.
            // Skriv något passande och avsluta programmet.

            int age;
            int originalAge;
            char choice;
            int regret;
            Console.WriteLine("Övning 4: \n");
            Console.Write("Skriv in din ålder: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Du har {} år kvar till pension.", (65-age));
            Console.Write("Vill du spola fram tiden till din pension? (J/N)");
            choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'J')
            {
                originalAge = age;
                age = 65;
                Console.WriteLine("Din ålder är nu {0}", age);
                Console.WriteLine("Vill du stanna kvar här?");
                Console.WriteLine("1. Jag vill stanna kvar på denna ålder.");
                Console.WriteLine("2. Jag ångrar mig! Ta mig tillbaks!");
                regret = Convert.ToInt32(Console.ReadLine());
                if (regret == 1)
                {
                    Console.WriteLine("Njut av pensionen!");
                }
                else
                {
                    age = originalAge;
                    Console.WriteLine("Du är nu {0} år ung igen!", age);
                }
            }
            Console.WriteLine("Farväl");
        }
    }
}
