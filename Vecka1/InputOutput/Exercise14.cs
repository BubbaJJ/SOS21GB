using System;
namespace Vecka1.InputOutput
{
    static class Exercise14
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal.
            // Skriv ut en rektangel, 3 kolumner och 5 rader, med talet.
            // Med strängformattering.

            Console.WriteLine("Övnign 14:");
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
        }
    }
}
