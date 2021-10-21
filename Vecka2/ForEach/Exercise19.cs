using System;
using System.Collections.Generic;

namespace Vecka2.ForEach
{
    static class Exercise19
    {
        public static void Solution()
        {
            void Alt1()
            {
                Console.WriteLine("Alternativ 1: Med Boolean");

                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
                string name = "Handelsakademin";
                bool cons = false;

                List<char> nameList = new List<char>();
                nameList.AddRange(name);

                for (int i = nameList.Count - 1; i >= 0; i--)
                {
                    cons = true;
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (nameList[i] == vowels[j])
                        {
                            cons = false;
                            break; ;
                        }
                    }
                    if (cons)
                    {
                        nameList.RemoveAt(i);
                    }
                }
                foreach (var item in nameList)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

            void Alt2()
            {
                Console.WriteLine("Alternativ 2: Med extra lista");

                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
                string name = "Handelsakademin";

                List<char> nameList = new List<char>();
                nameList.AddRange(name);

                List<char> charsToRemove = new List<char>();

                foreach (char c in nameList)
                {
                    if (!Array.Exists(vowels, item => item == c))
                    {
                        charsToRemove.Add(c);
                    }
                }

                foreach (char c in charsToRemove)
                {
                    nameList.RemoveAll(item => item == c);
                }
                foreach (var item in nameList)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

            void Alt3()
            {
                Console.WriteLine("Alternativ 3: Med modifierad for-loop");

                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
                string name = "Handelsakademin";

                List<char> nameList = new List<char>();
                nameList.AddRange(name);

                for (int i = 0; i < nameList.Count;)
                {
                    char c = nameList[i];
                    if (!Array.Exists(vowels, element => element == c))
                    {
                        nameList.RemoveAll(element => element == c); // Ökar inte iterationen om elementen tas bort.
                    }
                    else
                    {
                        i++; // Ökar iterationen om inget tas bort.
                    }
                }

                foreach (var item in nameList)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

            Alt1();
            Alt2();
            Alt3();
        }
    }
}
