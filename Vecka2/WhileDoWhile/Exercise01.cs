using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise01
    {
        public static void Solution()
        {
            int count = 1;

            while (count<=10)
            {
                Console.WriteLine(count);
                count++;
            }

            do
            {
                Console.WriteLine(count);
                count++;
            } while (count<=10);
        }
    }
}
