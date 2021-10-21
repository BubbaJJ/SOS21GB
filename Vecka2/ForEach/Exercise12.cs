using System;
namespace Vecka2.ForEach
{
    static class Exercise12
    {
        public static void Solution()
        {
            int fib1 = 0;
            int fib2 = 1;
            int fib3;

            Console.Write("Enter a number: ");
            int stop = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n{0} {1} ",fib1, fib2);

            for (int i = 0; i <=stop; i++)
            {
                fib3 = fib1 + fib2;
                Console.Write("{0} ",fib3);
                fib1 = fib2;
                fib2 = fib3;
            }
        }
    }
}
