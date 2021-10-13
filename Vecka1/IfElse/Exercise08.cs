using System;
namespace Vecka1.IfElse
{
    static class Exercise08
    {
        public static void Solution()
        {
            // Skriv ett program som skriver ut följande information om dig.
            // Namn, Ålder, Längd, Ord, Hobby, Superkraft
            // Samtliga värden ska tas in via input.

            Console.WriteLine("Övning 8: \n");
            Console.Write("Vad är ditt namn? ");
            string name = Console.ReadLine();
            Console.Write("Vad är din ålder? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vad är din längd? (cm) ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vart bor du? ");
            string location = Console.ReadLine();
            Console.Write("Vad är din hobby? ");
            string hobby = Console.ReadLine();
            Console.Write("Vad är din superkraft? ");
            string superpower = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Sammanfattning:");
            Console.WriteLine("Namn: {0}", name);
            Console.WriteLine("Ålder: {0}", age);
            Console.WriteLine("Längd: {0}cm", height);
            Console.WriteLine("Ort: {0}", location);
            Console.WriteLine("Hobby: {0}", hobby);
            Console.WriteLine("Superkraft: {0}", superpower);

        }
    }
}
