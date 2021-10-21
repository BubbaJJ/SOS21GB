using System;
namespace Vecka2.ForEach
{
    static class Exercise09
    {
        public static void Solution()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            foreach (char c in name)
            {
                Console.WriteLine(c);
            }
        }
    }
}
