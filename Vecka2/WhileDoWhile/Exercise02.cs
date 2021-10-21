using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise02
    {
        public static void Solution()
        {
            int count = 10;

            while (count > 0)
            {
                Console.WriteLine(count);
                count--;
            }

            do
            {
                Console.WriteLine(count);
                count--;
            } while (count > 0);
        }
    }
}
