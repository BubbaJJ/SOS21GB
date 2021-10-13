using System;
namespace Vecka1.IfElse
{
    static class Exercise16
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal.
            // Skriv ut om talet är jämnt eller inte.
            // Använd modulus.


            Console.WriteLine("Övning 16: \n");
            Console.Write("Skriv in ett tal: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("{0} är ett jämnt tal.", number);
            }
            else
            {
                Console.WriteLine("{0} är inte ett jämnt tal.", number);
            }
        }
    }
}
