using System;
namespace Vecka2.ForEach
{
    static class Exercise04
    {
        public static void Solution()
        {
            void WithoutModulus()
            {
                for (int i = 1; i <= 99; i += 2)
                {
                    Console.WriteLine(i);
                }
            }

            void WithModulus()
            {
                for (int i = 1; i <= 99; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            WithModulus();
            WithoutModulus();
        }
    }
}
