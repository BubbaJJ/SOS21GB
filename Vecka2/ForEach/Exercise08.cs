using System;
using System.Collections.Generic;

namespace Vecka2.ForEach
{
    static class Exercise08
    {
        public static void Solution()
        {
            List<string> education = new List<string>() { "utveckling", "Objekt", "orienterad", " ", "System" };

            for (int i = 0; i < education.Count - 1; i++)
            {
                education.Reverse(i, 2);
            }

            foreach (string word in education)
            {
                Console.Write(word);
            }
        }
    }
}
