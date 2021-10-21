using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise05
    {
        public static void Solution()
        {
            int[] numbers = { 12, 24, 2, 3, 54, 21, 213 };

            // While

            static void While(int[] numbers)
            {
                int count = 0;
                int sum = 0;
                while (count < numbers.Length)
                {
                    sum += numbers[count];
                    count++;
                }

                Console.WriteLine("While loop: {0}",sum);
            }

            While(numbers);

            // Do while

            static void DoWhile(int[] numbers)
            {
                int count = 0;
                int sum = 0;
                do
                {
                    sum += numbers[count];
                    count++;
                } while (count < numbers.Length);

                Console.WriteLine("DoWhile loop: {0}", sum);
            }

            DoWhile(numbers);
        }
    }
}
