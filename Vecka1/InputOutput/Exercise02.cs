using System;
namespace Vecka1.InputOutput
{
    static class Exercise02
    {
        public static void Solution()
        {
            // Skriv ut Hej och ditt namn på separata rader.

            Console.WriteLine("2. Greeting - Separate lines");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hej");
            Console.WriteLine(name);
        }
    }
}
