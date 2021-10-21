using System;
using System.Collections.Generic;

namespace Vecka2.ForEach
{
    static class Exercise10
    {
        public static void Solution()
        {
            void For()
            {
                Console.Write("Enter a random string: ");
                string userInput = Console.ReadLine();

                List<char> userString = new List<char>();
                userString.AddRange(userInput);

                Console.Write("String entered: ");
                for (int i = 0; i < userString.Count; i++)
                {
                    Console.Write(userString[i]);
                }

                List<char> userStringReversed = new List<char>();
                for (int i = 0; i < userString.Count; i++)
                {
                    userStringReversed.Insert(0, userString[i]);
                }

                Console.WriteLine();

                Console.Write("\nString reversed: ");
                for (int i = 0; i < userStringReversed.Count; i++)
                {
                    Console.Write(userStringReversed[i]);
                }
            }

            void ForEach()
            {
                Console.Write("Enter a random string: ");
                string userInput = Console.ReadLine();

                List<char> userString = new List<char>();
                userString.AddRange(userInput);

                Console.Write("String entered: ");
                foreach (char c in userString)
                {
                    Console.Write(c);
                }

                Console.WriteLine();

                Console.Write("String reversed: ");
                List<char> userStringReversed = new List<char>();
                foreach (char c in userString)
                {
                    userStringReversed.Insert(0, c);
                }

                foreach (char c in userStringReversed)
                {
                    Console.Write(c);
                }
            }

            For();
            ForEach();
        }
    }
}
