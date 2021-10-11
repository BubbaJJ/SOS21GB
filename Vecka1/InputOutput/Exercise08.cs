using System;
namespace Vecka1.InputOutput
{
    static class Exercise08
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal.
            // Skriv ut multiplikationstabellen. (0-10)

            Console.WriteLine("Övning 8:");
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            // Utan strängformattering
            Console.WriteLine("Utan strängformattering:");
            Console.WriteLine(x + " * 0 = " + (x * 0));
            Console.WriteLine(x + " * 1 = " + (x * 1));
            Console.WriteLine(x + " * 2 = " + (x * 2));
            Console.WriteLine(x + " * 3 = " + (x * 3));
            Console.WriteLine(x + " * 4 = " + (x * 4));
            Console.WriteLine(x + " * 5 = " + (x * 5));
            Console.WriteLine(x + " * 6 = " + (x * 6));
            Console.WriteLine(x + " * 7 = " + (x * 7));
            Console.WriteLine(x + " * 8 = " + (x * 8));
            Console.WriteLine(x + " * 9 = " + (x * 9));
            Console.WriteLine(x + " * 10 = " + (x * 10));

            // Med strängformattering
            Console.WriteLine("Med strängformattering:");
            Console.WriteLine("{0} * 0 = {1}", x, x * 0);
            Console.WriteLine("{0} * 1 = {1}", x, x * 1);
            Console.WriteLine("{0} * 2 = {1}", x, x * 2);
            Console.WriteLine("{0} * 3 = {1}", x, x * 3);
            Console.WriteLine("{0} * 4 = {1}", x, x * 4);
            Console.WriteLine("{0} * 5 = {1}", x, x * 5);
            Console.WriteLine("{0} * 6 = {1}", x, x * 6);
            Console.WriteLine("{0} * 7 = {1}", x, x * 7);
            Console.WriteLine("{0} * 8 = {1}", x, x * 8);
            Console.WriteLine("{0} * 9 = {1}", x, x * 9);
            Console.WriteLine("{0} * 10 = {1}", x, x * 10);
        }
    }
}
