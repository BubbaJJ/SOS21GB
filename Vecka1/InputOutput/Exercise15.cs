using System;
namespace Vecka1.InputOutput
{
    static class Exercise15
    {
        public static void Solution()
        {
            // Be användaren skriva in ett värde. (Grader i celsius)
            // Konvertera till Fahrenheit
            // Skriv ut resultatet.
            Console.WriteLine("Övning 15:");
            Console.Write("Enter your first number: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            int fahrenheit = celsius * 18 / 10 + 32;

            // alt 1
            Console.Write("Solution 1: ");
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            // alt 2
            Console.Write("Solution 3: ");
            Console.WriteLine("Fahrenheit: " + (celsius * 18 / 10 + 32));

            // alt 3
            Console.Write("Solution 2: ");
            Console.WriteLine("Fahrenheit: {0}", fahrenheit);

            // alt 4
            Console.Write("Solution 4: ");
            Console.WriteLine("Fahrenheit: {0}", (celsius * 18 / 10 + 32));
        }
    }
}
