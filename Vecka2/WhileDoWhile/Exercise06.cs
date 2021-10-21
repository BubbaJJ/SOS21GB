using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise06
    {
        public static void Solution()
        {
            void While()
            {
                int age, originalAge, pensionAge;
                char choice;

                Console.Write("Skriv in din ålder: ");
                age = Convert.ToInt32(Console.ReadLine());
                pensionAge = 65;

                Console.WriteLine("Du har {0} år kvar till pension.", 65 - age);
                Console.Write("Vill du spola fram tiden till din pension? [J/N] ");
                choice = Convert.ToChar(Console.ReadLine());

                if (choice == 'J')
                {
                    originalAge = age;
                    Console.WriteLine("Då kör vi!");
                    while (age < pensionAge)
                    {
                        age++;
                        Console.WriteLine("Din ålder just nu: {0}", age);
                    }

                    Console.WriteLine("\nGrattis! Du är nu pensionär.\n");

                    Console.Write("Vill du stanna kvar här? [J/N] ");
                    choice = Convert.ToChar(Console.ReadLine());
                    if (choice == 'N')
                    {
                        Console.WriteLine("Då backar vi igen!");
                        while (age > originalAge)
                        {
                            age--;
                            Console.WriteLine("Din ålder just nu: {0}", age);
                        }
                        Console.WriteLine("Nu är du {0} år igen.", age);
                    }
                    else
                    {
                        Console.WriteLine("Gött! Njut av pensionen.");
                    }

                }
                else if (choice == 'N')
                {
                    Console.WriteLine("Okej då, njut av livet.");
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning...");
                }
                Console.WriteLine();
                Console.WriteLine("Avslutar programmet...");
                Console.WriteLine("Ha det gött!");
            }

            void DoWhile()
            {
                int age, originalAge, pensionAge;
                char choice;

                Console.Write("Skriv in din ålder: ");
                age = Convert.ToInt32(Console.ReadLine());
                pensionAge = 65;

                Console.WriteLine("Du har {0} år kvar till pension.", 65 - age);
                Console.Write("Vill du spola fram tiden till din pension? [J/N] ");
                choice = Convert.ToChar(Console.ReadLine());

                if (choice == 'J')
                {
                    originalAge = age;
                    Console.WriteLine("Då kör vi!");

                    do
                    {
                        age++;
                        Console.WriteLine("Din ålder just nu: {0}", age);
                    } while (age < pensionAge);

                    Console.WriteLine("\nGrattis! Du är nu pensionär.\n");

                    Console.Write("Vill du stanna kvar här? [J/N] ");
                    choice = Convert.ToChar(Console.ReadLine());
                    if (choice == 'N')
                    {
                        Console.WriteLine("Då backar vi igen!");

                        do
                        {
                            age--;
                            Console.WriteLine("Din ålder just nu: {0}", age);
                        } while (age > originalAge);
                    }
                    else
                    {
                        Console.WriteLine("Gött! Njut av pensionen.");
                    }

                }
                else if (choice == 'N')
                {
                    Console.WriteLine("Okej då, njut av livet.");
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning...");
                }
                Console.WriteLine();
                Console.WriteLine("Avslutar programmet...");
                Console.WriteLine("Ha det gött!");
            }

            While();
            DoWhile();
        }
    }
}
