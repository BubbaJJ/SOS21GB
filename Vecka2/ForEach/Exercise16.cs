using System;
namespace Vecka2.ForEach
{
    static class Exercise16
    {
        public static void Solution()
        {
            int number;
            int result;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                result = i * i * i;
                Console.WriteLine("{0}³ = {1}", i, result);
            }
        }
    }
}
