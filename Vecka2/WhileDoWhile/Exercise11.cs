using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise11
    {
        public static void Solution()
        {
            void While()
            {
                int memory = 0;
                int value = 0;

                while (value >= 0)
                {
                    Console.Write("Enter a value: ");
                    value = Convert.ToInt32(Console.ReadLine());

                    memory += value;
                }
                Console.WriteLine("Total in memory: {0}", memory);
            }

            void DoWhile()
            {
                int memory = 0;
                int value = 0;

                while (value >= 0)
                {
                    Console.Write("Enter a value: ");
                    value = Convert.ToInt32(Console.ReadLine());

                    memory += value;
                }
                Console.WriteLine("Total in memory: {0}", memory);
            }

            While();
            DoWhile();
        }
    }
}
