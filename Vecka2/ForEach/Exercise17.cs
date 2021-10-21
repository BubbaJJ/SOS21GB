using System;
namespace Vecka2.ForEach
{
    static class Exercise17
    {
        public static void Solution()
        {
            int number;
            int result;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= 10; j++)
                {
                    result = i * j;
                    Console.Write("{0} * {1} = {2} ", i, j, result);
                }
            }
        }
    }
}
