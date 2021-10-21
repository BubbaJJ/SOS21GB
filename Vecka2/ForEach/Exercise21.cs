using System;
using System.Collections.Generic;

namespace Vecka2.ForEach
{
    static class Exercise21
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

                for (int i = nameList.Count - 1; i >= 0; i--)
                {
                    for (int j = 0; j < vowels.Count; j++)
                    {
                        if (vowels.Contains(nameList[i]))
                        {
                            nameList.Remove(nameList[i]);
                        }
                    }
                }

                foreach (char ch in nameList)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }

            void RemoveAllFor()
            {
                Console.WriteLine("Alternativ 2: RemoveAll med for-loop");
                List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
                string name = "Handelsakademin";
                List<char> nameList = new List<char>();
                nameList.AddRange(name);

                for (int i = nameList.Count - 1; i >= 0; i--)
                {
                    if (vowels.Contains(nameList[i]))
                    {
                        nameList.RemoveAll(item => item == nameList[i]);
                    }
                }

                foreach (char ch in nameList)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }


            RemoveFor();
            RemoveAllFor();
        }
    }
}
