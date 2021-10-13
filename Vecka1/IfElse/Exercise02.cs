using System;
namespace Vecka1.IfElse
{
    static class Exercise02
    {
        public static void Solution()
        {
            // Ta in 2 tal.
            // Skriv ut vilket tal som är störst resp. minst.
            // Skriv ut differensen mellan talen. (största - minsta)

            int tal1;
            int tal2;

            Console.WriteLine("Övning 2: \n");
            Console.Write("Skriv in ditt första tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ditt andra tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            if (tal1 > tal2)
            {
                Console.WriteLine("Det största talet är {0}", tal1);
                Console.WriteLine("Det största talet är {0}", tal2);
                Console.WriteLine("Differensen mellan talet är {0}", (tal1 - tal2));
            }
            else
            {
                Console.WriteLine("Det största talet är {0}", tal2);
                Console.WriteLine("Det största talet är {0}", tal1);
                Console.WriteLine("Differensen mellan talet är {0}", (tal2 - tal1));
            }
        }
    }
}
