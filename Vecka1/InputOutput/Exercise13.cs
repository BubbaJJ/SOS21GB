using System;
namespace Vecka1.InputOutput
{
    static class Exercise13
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal.
            // Skriv ut det fyra gånger.
            // Med och utan mellanrum.
            // Med strängformattering.

            Console.WriteLine("Övning 12:");
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            // Med strängformattering
            Console.WriteLine("{0} {0} {0} {0}", x);
            Console.WriteLine("{0}{0}{0}{0}", x);
        }
    }
}
