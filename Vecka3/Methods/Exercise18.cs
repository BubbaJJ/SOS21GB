using System;
using System.Collections.Generic;

namespace Vecka3.Methods
{
    static class Exercise18
    {
        public static void CheckChar(char c)
        {
            List<char> wovels = new List<char>() { 'a', 'A', 'e','E', 'i','I', 'o','O', 'u','U', 'y','Y', 'å','Å', 'ä','Ä', 'ö','Ö' };

            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                Console.WriteLine("{0} is a letter.", c);
                if (wovels.Contains(c))
                {
                    Console.WriteLine("{0} is a wovel.", c);
                }
                else
                {
                    Console.WriteLine("{0} is a consonant.", c);
                }
            }
            else
            {
                Console.WriteLine("{0} is a number.", c);
            }
        }

        public static void CheckCharV2(char c)
        {
            List<char> wovels = new List<char>() { 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };
            c = Char.ToUpper(c);
            if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine("{0} is a letter.", c);
                if (wovels.Contains(c))
                {
                    Console.WriteLine("{0} is a wovel.", c);
                }
                else
                {
                    Console.WriteLine("{0} is a consonant.", c);
                }
            }
            else
            {
                Console.WriteLine("{0} is a number.", c);
            }
        }

        public static void CheckCharV3(char c)
        {
            List<char> wovels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
            c = Char.ToLower(c);
            if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine("{0} is a letter.", c);
                if (wovels.Contains(c))
                {
                    Console.WriteLine("{0} is a wovel.", c);
                }
                else
                {
                    Console.WriteLine("{0} is a consonant.", c);
                }
            }
            else
            {
                Console.WriteLine("{0} is a number.", c);
            }
        }
    }
}
