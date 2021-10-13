using System;
namespace Vecka1.IfElse
{
    static class Exercise15
    {
        public static void Solution()
        {
            // Be användaren skriva in sin ålder.
            // Baserat på användarens ålder ska något av följande skrivas ut:
                // 0-12: Barn
                // 13-19: Ungdom
                // 20-64: Vuxen
                // 65+: Pensionär

            Console.WriteLine("Övning 15: \n");
            Console.Write("Hur gammal är du? ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 12)
            {
                Console.WriteLine("Barn");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Ungdom");
            }
            else if (age >= 20 && age <= 64)
            {
                Console.WriteLine("Vuxen");
            }
            else
            {
                Console.WriteLine("Pensionär");
            }
        }
    }
}
