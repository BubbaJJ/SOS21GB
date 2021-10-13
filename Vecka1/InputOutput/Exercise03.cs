using System;
namespace Vecka1.InputOutput
{
    public class Exercise03
    {
        public Exercise03()
        {
            // Ta in två tal
            // Addera talen
            // Skriv ut resultatet.

            Console.WriteLine("Övning 3:");
            Console.Write("Enter your first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;

            // alt 1
            Console.Write("Solution 1: ");
            Console.WriteLine(x + y);

            // alt 2
            Console.Write("Solution 2: ");
            Console.WriteLine(x + " + " + y + " = " + (x + y));

            // alt 3
            Console.Write("Solution 3: ");
            Console.WriteLine(x + " + " + y + " = " + sum);

            // alt 4
            Console.Write("Solution 4: ");
            Console.WriteLine("{0} + {1} = {2}", x, y, sum);

            // alt 5
            Console.Write("Solution 5: ");
            Console.WriteLine("{0} + {1} = {2}", x, y, (x + y));

        }
    }
}
