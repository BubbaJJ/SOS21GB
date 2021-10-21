using System;
namespace Vecka2.ForEach
{
    static class Exercise15
    {
        public static void Solution()
        {
            int number;
            int iterations;
            int result;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of iterations: ");
            iterations = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= iterations; i++)
            {
                result = number * i;
                Console.WriteLine("{0} x {1} = {2}", number, i, result);
            }
        }
    }
}
