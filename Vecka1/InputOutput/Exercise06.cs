using System;
namespace Vecka1.InputOutput
{
    static class Exercise06
    {
        public static void Solution()
        {
            // Be användaren skriva in tre tal.
            // Multiplicera talen.
            // Skriv ut resultatet.

            Console.WriteLine("Övning 6:");
            Console.Write("Enter your first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your third number: ");
            int z = Convert.ToInt32(Console.ReadLine());
            int result = x * y * z;

            // alt 1
            Console.Write("Solution 1: ");
            Console.WriteLine(result);

            // alt 2
            Console.Write("Solution 2: ");
            Console.WriteLine(x * y * z);

            // alt 3
            Console.Write("Solution 3: ");
            Console.WriteLine(x + " * " + y + " * " + z + " = " + result);

            // alt 4
            Console.Write("Solution 4: ");
            Console.WriteLine(x + " * " + y + " * " + z + " = " + (x*y*z));

            // alt 5
            Console.Write("Solution 5: ");
            Console.WriteLine("{0}*{1}*{2} = {3}", x, y, z, result);

            // alt 6
            Console.Write("Solution 6: ");
            Console.WriteLine("{0}*{1}*{2} = {3}", x, y, z, (x * y * z));


        }
    }
}
