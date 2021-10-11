using System;
namespace Vecka1.InputOutput
{
    static class Exercise12
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal.
            // Skriv ut det fyra gånger.
            // Med och utan mellanrum.
            // Utan strängformattering.

            Console.WriteLine("Övning 12:");
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            // Utan strängformattering
            Console.WriteLine(x + " " + x + " " + x + " " + x);
            Console.WriteLine(x + "" + x + "" + x + "" + x);
        }
    }
}
