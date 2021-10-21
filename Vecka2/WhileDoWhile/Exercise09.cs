using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise09
    {
        public static void Solution()
        {
            void While()
            {
                Console.Write("Enter a number: ");
                int table = Convert.ToInt32(Console.ReadLine());
                int count = 0;

                while (count <= 10)
                {
                    Console.WriteLine("{0} * {1} = {2}", table, count, table * count);
                    count++;
                }
            }

            void DoWhile()
            {
                Console.Write("Enter a number: ");
                int table = Convert.ToInt32(Console.ReadLine());
                int count = 0;

                while (count <= 10)
                {
                    Console.WriteLine("{0} * {1} = {2}", table, count, table * count);
                    count++;
                }
            }

            While();
            DoWhile();
        }
    }
}
