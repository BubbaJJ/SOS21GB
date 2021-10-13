using System;
namespace Vecka1.InputOutput
{
    static class Exercise09
    {
        public static void Solution()
        {
            // Be användaren skriva in fyra tal.
            // Skriv ut medelvärdet.

            Console.WriteLine("Övning 9:");
            Console.Write("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your fourth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            // alt 1
            Console.Write("Solution 1: ");
            int result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Median" + " = " + result);

            // alt 2
            Console.Write("Solution 2: ");
            Console.WriteLine("Median = {0}", result);

            // alt 3
            Console.Write("Solution 3: ");
            Console.WriteLine("Median of {0}, {1}, {2} & {3} is {4}", num1, num2, num3, num4, result);

            // alt 4
            Console.Write("Solution 4: ");
            Console.WriteLine("Median of {0}, {1}, {2} & {3} is {4}", num1, num2, num3, num4, (num1+num2+num3+num4)/4);
        }
    }
}
