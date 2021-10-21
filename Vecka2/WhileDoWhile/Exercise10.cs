using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise10
    {
        public static void Solution()
        {
            void While()
            {
                Console.Write("Enter desired number of elements: ");
                int elements = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[elements];
                int count = 0;

                while (count < elements)
                {
                    Console.Write("Enter a number to insert: ");
                    numbers[count] = Convert.ToInt32(Console.ReadLine());
                    count++;
                }

                count = 0;
                while (count < elements)
                {
                    Console.WriteLine(numbers[count]);
                    count++;
                }
            }


            void DoWhile()
            {
                Console.Write("Enter desired number of elements: ");
                int elements = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[elements];
                int count = 0;

                do
                {
                    Console.Write("Enter a number to insert: ");
                    numbers[count] = Convert.ToInt32(Console.ReadLine());
                    count++;
                } while (count < elements);

                count = 0;
                do
                {
                    Console.WriteLine(numbers[count]);
                    count++;
                } while (count < elements);
            }


            While();
            DoWhile();
        }
    }
}
