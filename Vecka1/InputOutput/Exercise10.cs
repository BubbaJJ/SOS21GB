using System;
namespace Vecka1.InputOutput
{
    static class Exercise10
    {
        public static void Solution()
        {
            // Ta in en ålder, skriv ut "Du ser äldre ut än" och åldern.
            Console.WriteLine("Övning 10:");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            // alt 1
            Console.Write("Solution 1: ");
            Console.WriteLine("Du ser äldre ut än " + age);

            // alt 2
            Console.Write("Solution 2: ");
            Console.WriteLine("Du ser äldre ut än {0}", age);
        }
    }
}
