using System;
namespace Vecka1.InputOutput
{
    static class Exercise05
    {
        public static void Solution()
        {
            // Be användaren skriva in två tal.
            // Byt plats på värdena.
            // Skriv ut den nya ordningen.

            Console.WriteLine("Övning 5:");
            Console.Write("Enter your first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap:");
            Console.Write("Solution 1: ");
            Console.WriteLine("x = " + x + " y= " + y);

            Console.Write("Solution 2: ");
            Console.WriteLine("x = {0} y = {1}", x, y);

            int temp = x;      // Flytta värdet i x till den temporära variabeln.
            x = y;            // Flytta värdet i y till variabel x
            y = temp;          // Flytta det temporära värdet till variabel y

            Console.WriteLine("After swap:");
            Console.Write("Solution 1: ");
            Console.WriteLine("x = " + (x) + " y = " + (y));

            Console.Write("Solution 2: ");
            Console.WriteLine("x = {0} y = {1}", x, y);
        }
    }
}
