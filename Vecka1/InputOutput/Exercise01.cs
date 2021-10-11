using System;
namespace Vecka1.InputOutput
{
    static class Exercise01
    {
        public static void Solution()
        {
            // Övning 1
            // Skriv ut Hej och ditt namn på samma rad.

            Console.WriteLine("Övning 1:");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // alt 1
            Console.Write("Med Write & variabel: ");
            Console.Write("Hej ");
            Console.WriteLine(name);

            // alt 2
            Console.Write("Med WriteLine & variabel: ");
            Console.WriteLine("Hej " + name);

            // alt 3
            Console.Write("Med WriteLine & strängformattering: ");
            Console.WriteLine("Hej {0}", name);

        }
    }
}
