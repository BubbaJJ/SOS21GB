using System;
namespace Vecka2.ForEach
{
    static class Exercise05
    {
        public static void Solution()
        {
            void For()
            {
                int[] numbers = {1,4,78,14,76,98,2,54,23,86 };
                int largest = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i > largest)
                    {
                        largest = i;
                    }
                }
            }

            void ForEach()
            {
                int[] numbers = { 1, 4, 78, 14, 76, 98, 2, 54, 23, 86 };
                int largest = 0;

                foreach (int number in numbers)
                {
                    if (number > largest)
                    {
                        largest = number;
                    }
                }
            }

            For();
            ForEach();
        }
    }
}
