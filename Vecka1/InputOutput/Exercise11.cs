using System;
namespace Vecka1.InputOutput
{
    static class Exercise11
    {
        public static void Solution()
        {
            // Ta in tre tal. Skriv ut resultatet för (x+y)*z och x*y+y*z 
            Console.WriteLine("Övning 11:");
            Console.Write("Enter your first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your third number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int result1 = (x + y) * z;
            int result2 = x * y + y * z;

            // alt 1
            Console.WriteLine("Solution 1:");
            Console.WriteLine("(" + x + "+" + y + ") = " + result1);
            Console.WriteLine(x + "*" + y + "+" + y + "*" + z + " = " + result2);

            // alt 2
            Console.WriteLine("Solution 2:");
            Console.WriteLine("(" + x + "+" + y + ") = " + ((x + y) * z));
            Console.WriteLine(x + "*" + y + "+" + y + "*" + z + " = " + (x * y + y * z));

            // alt 3
            Console.WriteLine("Solution 3:");
            Console.WriteLine("({0} + {1}) * {2} = {3}", x, y, z, result1);
            Console.WriteLine("{0} * {1} + {1} * {2} = {3}", x, y, z, result2);

            // alt 4
            Console.WriteLine("Solution 4:");
            Console.WriteLine("({0} + {1}) * {2} = {3}", x, y, z, (x + y) * z);
            Console.WriteLine("{0} * {1} + {1} * {2} = {3}", x, y, z, (x * y) + (y * z));
        }
    }
}
