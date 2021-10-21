using System;
using System.Collections.Generic;

namespace Vecka2.ForEach
{
    static class Exercise11
    {
        public static void Solution()
        {
            bool palindrome = true;
            Console.Write("Enter a random string: ");
            string userInput = Console.ReadLine();

            List<char> userString = new List<char>();
            userString.AddRange(userInput);

            for (int i = 0; i < userString.Count / 2; i++)
            {
                if (userString[i] != userString[userString.Count - (i + 1)])
                {
                    palindrome = false;
                    Console.WriteLine("Not palindrome.");
                    break;
                }
            }

            if (palindrome)
            {
                Console.WriteLine("Palindrome!");
            }
        }
    }
}
