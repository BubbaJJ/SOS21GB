using System;
namespace Vecka2.ForEach
{
    static class Exercise14
    {
        public static void Solution()
        {

            void For()
            {
                int[,] numbers = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
                int rows = numbers.GetLength(0);
                int cols = numbers.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.WriteLine(numbers[i, j]);
                    }
                }
            }

            void ForEach()
            {
                int[,] numbers = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }

            For();
            ForEach();
        }
    }
}
