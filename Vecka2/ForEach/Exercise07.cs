using System;
namespace Vecka2.ForEach
{
    static class Exercise07
    {
        public static void Solution()
        {
            Console.Write("Enter a number: ");
            int stop = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= stop; i++)
            {
                sum += i;
            }

            Console.WriteLine("Total sum: {0}", sum);
        }
    }
}
