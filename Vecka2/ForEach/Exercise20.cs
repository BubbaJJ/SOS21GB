using System;
using System.Collections.Generic;

namespace Vecka2.ForEach
{
    static class Exercise20
    {
        public static void Solution()
        {
            void RemoveFor()
            {
                Console.WriteLine("Alternativ 1: Remove med for-loop");
                List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
                string name = "Handelsakademin";
                List<char> nameList = new List<char>();
                nameList.AddRange(name);

                for (int i = 0; i < vowels.Count; i++)
                {
                    for (int j = 0; j <= nameList.Count; j++)
                    {
                        if (nameList.Contains(vowels[i]))
                        {
                            nameList.Remove(vowels[i]); // Remove tar bort första förekomsten den hittar. Vi behöver därför loopa flera gånger för att hitta varje element som matchar.
                        }
                    }
                }

                foreach (var item in nameList)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

            void RemoveForEach()
            {
                Console.WriteLine("Alternativ 2: Remove med foreach-loop");
                List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
                string name = "Handelsakademin";
                List<char> nameList = new List<char>();
                nameList.AddRange(name);

                for (int i = 0; i < vowels.Count; i++)
                {
                    for (int j = 0; j <= nameList.Count; j++)
                    {
                        if (nameList.Contains(vowels[i]))
                        {
                            nameList.Remove(vowels[i]); // Remove tar bort första förekomsten den hittar. Vi behöver därför loopa flera gånger för att hitta varje element som matchar.
                        }
                    }
                }

                foreach (var item in nameList)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

            void RemoveAllFor()
            {
                Console.WriteLine("Alternativ 3: RemoveAll med for-loop");
                List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
                string name = "Handelsakademin";
                List<char> nameList = new List<char>();
                nameList.AddRange(name);

                for (int i = 0; i < vowels.Count; i++)
                {
                    for (int j = 0; j <= nameList.Count; j++)
                    {
                        if (nameList.Contains(vowels[i]))
                        {
                            nameList.Remove(vowels[i]);
                        }
                    }
                }

                foreach (char ch in nameList)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }

            void RemoveAllForEach()
            {
                Console.WriteLine("Alternativ 4: RemoveAll med foreach-loop");
                List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
                string name = "Handelsakademin";
                List<char> nameList = new List<char>();
                nameList.AddRange(name);

                foreach (char vowel in vowels)
                {
                    if (nameList.Contains(vowel))
                    {
                        nameList.RemoveAll(element => element == vowel); // Alla element där elementet är lika med vokalen.
                    }
                }

                foreach (char ch in nameList)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }

            RemoveFor();
            RemoveForEach();
            RemoveAllFor();
            RemoveAllForEach();
        }
    }
}
