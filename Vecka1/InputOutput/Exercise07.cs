using System;
namespace Vecka1.InputOutput
{
    static class Exercise07
    {
        public static void Solution()
        {
            // Be användaren skriva in två tal.
            // Addera
            // Subtrahera
            // Multiplicera
            // Dividera
            // Skriv ut resultaten.

            Console.WriteLine("Övning 7:");
            Console.Write("Enter your first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // Utan strängformattering
            Console.WriteLine("Utan strängformattering:");
            Console.WriteLine(x + "+" + y + " = " + (x + y));
            Console.WriteLine(x + "-" + y + " = " + (x - y));
            Console.WriteLine(x + "*" + y + " = " + (x * y));
            Console.WriteLine(x + "/" + y + " = " + (x / y));

            // Med strängformattering
            Console.WriteLine("Med strängformattering:");
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        }
    }
}
