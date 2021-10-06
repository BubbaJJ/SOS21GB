using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka1
{
    static class Monday
    {
        public static void Exercises()
        {
            // Övning 1
            // Skriv ut Hej och ditt namn på samma rad.
            Console.WriteLine("1. Greeting");
            Console.Write("Enter your name: ");
            string name1 = Console.ReadLine();
            Console.WriteLine();    // Tom rad för struktur.

            // alt 1
            Console.Write("Med Write & variabel: ");
            Console.Write("Hej ");
            Console.WriteLine(name1);

            // alt 2
            Console.Write("Med WriteLine & variabel: ");
            Console.WriteLine("Hej " + name1);

            // alt 3
            Console.Write("Med WriteLine & strängformattering: ");
            Console.WriteLine("Hej {0}", name1);
            Console.WriteLine();    // Tom rad för struktur.

            // Övning 2
            // Skriv ut Hej och ditt namn på separata rader.

            Console.WriteLine("2. Greeting - Separate lines");
            Console.Write("Enter your name: ");
            string name2 = Console.ReadLine();
            Console.WriteLine();    // Tom rad för struktur.

            Console.WriteLine("Hej");
            Console.WriteLine(name2);
            Console.WriteLine();    // Tom rad för struktur.

            // Övning 3
            // Ta in två tal, addera och skriv ut resultatet.
            Console.WriteLine("3. Addition");
            Console.Write("Enter your first number: ");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            // alt 1
            Console.Write("Solution 1: ");
            int sum3 = x3 + y3;
            Console.WriteLine(sum3);

            // alt 2
            Console.Write("Solution 2: ");
            Console.WriteLine(x3+y3);

            // alt 3
            Console.Write("Solution 3: ");
            Console.WriteLine(x3 + " + " + y3 + " = " + (x3+y3));

            // alt 4
            Console.Write("Solution 4: ");
            Console.WriteLine("{0} + {1} = {2}",x3, y3, x3+y3);
            Console.WriteLine();    // Tom rad för struktur.


            // Övning 4
            // Ta in två tal, dividera och skriv ut resultatet.
            Console.WriteLine("4. Division");
            Console.Write("Enter your first number: ");
            int x4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int y4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            // alt 1
            Console.Write("Solution 1: ");
            int sum4 = x4 / y4;
            Console.WriteLine(sum4);

            // alt 2
            Console.Write("Solution 2: ");
            Console.WriteLine(x4 / y4);

            // alt 3
            Console.Write("Solution 3: ");
            Console.WriteLine(x4 + " + " + y4 + " = " + (x4 / y4));

            // alt 4
            Console.Write("Solution 4: ");
            Console.WriteLine("{0} + {1} = {2}", x4, y4, x4 / y4);
            Console.WriteLine();    // Tom rad för struktur.


            // Övning 5
            // Ta in två tal, byt plats på värdena och skriv ut den nya ordningen.
            Console.WriteLine("5. Swap variables");
            Console.Write("Enter your first number: ");
            int x5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int y5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            Console.WriteLine("Before swap:");
            Console.Write("Solution 1: ");
            Console.WriteLine("x=" + (x5) + " y=" + (y5));

            Console.Write("Solution 2: ");
            Console.WriteLine("x={0} y={1}", x5, y5);
            Console.WriteLine();    // Tom rad för struktur.

            int temp = x5;      // Flytta värdet i x till den temporära variabeln.
            x5 = y5;            // Flytta värdet i y till variabel x
            y5 = temp;          // Flytta det temporära värdet till variabel y

            Console.WriteLine("After swap:");
            Console.Write("Solution 1: ");
            Console.WriteLine("x=" + (x5) + " y=" + (y5));

            Console.Write("Solution 2: ");
            Console.WriteLine("x={0} y={1}", x5, y5);
            Console.WriteLine();    // Tom rad för struktur.


            // Övning 6
            // Ta in tre tal, multiplicera och skriv ut resultatet.
            Console.WriteLine("6. Multiplication");
            Console.Write("Enter your first number: ");
            int x6 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int y6 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your third number: ");
            int z6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            // alt 1
            Console.Write("Solution 1: ");
            int result6 = x6 * y6 * z6;
            Console.WriteLine(result6);

            // alt 2
            Console.Write("Solution 2: ");
            Console.WriteLine(x6*y6*z6);

            // alt 3
            Console.Write("Solution 3: ");
            Console.WriteLine("{0}*{1}*{2} = {3}", x6, y6, z6, x6*y6*z6);
            Console.WriteLine();    // Tom rad för struktur.


            // Övning 7
            // Ta in två tal. Addera, subtrahera, multiplicera och dividera. Skriv ut resultatet.
            Console.WriteLine("7. Calculations");
            Console.Write("Enter your first number: ");
            int x7 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int y7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            // Utan strängformattering
            Console.WriteLine("Utan strängformattering:");
            Console.WriteLine(x7 + "+" + y7 + " = " + (x7 + y7));
            Console.WriteLine(x7 + "-" + y7 + " = " + (x7 - y7));
            Console.WriteLine(x7 + "*" + y7 + " = " + (x7 * y7));
            Console.WriteLine(x7 + "/" + y7 + " = " + (x7 / y7));
            Console.WriteLine();    // Tom rad för struktur.

            // Med strängformattering
            Console.WriteLine("Med strängformattering:");
            Console.WriteLine("{0} + {1} = {2}", x7, y7, x7+y7);
            Console.WriteLine("{0} - {1} = {2}", x7, y7, x7-y7);
            Console.WriteLine("{0} * {1} = {2}", x7, y7, x7*y7);
            Console.WriteLine("{0} / {1} = {2}", x7, y7, x7/y7);
            Console.WriteLine();    // Tom rad för struktur.

            // Övning 8
            // Ta in ett tal, skriv ut multiplikationstabellen. (0-10)
            Console.WriteLine("8. Multiplication");
            Console.Write("Enter a number: ");
            int x8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            // Utan strängformattering
            Console.WriteLine("Utan strängformattering:");
            Console.WriteLine(x8 + " * 0 = " + (x8 * 0));
            Console.WriteLine(x8 + " * 1 = " + (x8 * 1));
            Console.WriteLine(x8 + " * 2 = " + (x8 * 2));
            Console.WriteLine(x8 + " * 3 = " + (x8 * 3));
            Console.WriteLine(x8 + " * 4 = " + (x8 * 4));
            Console.WriteLine(x8 + " * 5 = " + (x8 * 5));
            Console.WriteLine(x8 + " * 6 = " + (x8 * 6));
            Console.WriteLine(x8 + " * 7 = " + (x8 * 7));
            Console.WriteLine(x8 + " * 8 = " + (x8 * 8));
            Console.WriteLine(x8 + " * 9 = " + (x8 * 9));
            Console.WriteLine(x8 + " * 10 = " + (x8 * 10));
            Console.WriteLine();    // Tom rad för struktur.

            // Med strängformattering
            Console.WriteLine("Med strängformattering:");
            Console.WriteLine("{0} * 0 = {1}", x8, x8 * 0);
            Console.WriteLine("{0} * 1 = {1}", x8, x8 * 1);
            Console.WriteLine("{0} * 2 = {1}", x8, x8 * 2);
            Console.WriteLine("{0} * 3 = {1}", x8, x8 * 3);
            Console.WriteLine("{0} * 4 = {1}", x8, x8 * 4);
            Console.WriteLine("{0} * 5 = {1}", x8, x8 * 5);
            Console.WriteLine("{0} * 6 = {1}", x8, x8 * 6);
            Console.WriteLine("{0} * 7 = {1}", x8, x8 * 7);
            Console.WriteLine("{0} * 8 = {1}", x8, x8 * 8);
            Console.WriteLine("{0} * 9 = {1}", x8, x8 * 9);
            Console.WriteLine("{0} * 10 = {1}", x8, x8 * 10);
            Console.WriteLine();    // Tom rad för struktur.


            // Övning 9
            // Ta in fyra tal, skriv ut medelvärdet.
            Console.WriteLine("9. Median");
            Console.Write("Enter your first number: ");
            int a9 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int b9 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your third number: ");
            int c9 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your fourth number: ");
            int d9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            Console.Write("Solution 1: ");
            int result = (a9+b9+c9+d9) / 4;
            Console.WriteLine("Median" + " = "+ result);

            Console.Write("Solution 2: ");
            Console.WriteLine("Median = {0}", result);
            Console.WriteLine();    // Tom rad för struktur.

            // Övning 10
            // Ta in en ålder, skriv ut "Du ser äldre ut än" och åldern.
            Console.WriteLine("10. Age");
            Console.Write("Enter your age: ");
            int age10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            Console.Write("Solution 1: ");
            Console.WriteLine("Du ser äldre ut än " + age10);
            Console.Write("Solution 2: ");
            Console.WriteLine("Du ser äldre ut än {0}", age10);
            Console.WriteLine();    // Tom rad för struktur.

            // Övning 11
            // Ta in tre tal. Skriv ut resultatet för (x+y)*z och x*y+y*z 
            Console.WriteLine("11. Calculations");
            Console.Write("Enter your first number: ");
            int x11 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int y11 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your third number: ");
            int z11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            Console.WriteLine("Solution 1:");
            Console.WriteLine((x11+y11)*z11);
            Console.WriteLine(x11*y11+y11*z11);
            Console.WriteLine();    // Tom rad för struktur.
            Console.WriteLine("Solution 2:");
            Console.WriteLine("({0} + {1}) * {2} = {3}", x11, y11, z11, (x11 + y11) * z11);
            Console.WriteLine("{0} * {1} + {1} * {2} = {3}", x11, y11, z11, (x11 * y11) + (y11 * z11));
            Console.WriteLine();    // Tom rad för struktur.

            // Övning 12
            // Ta in ett tal, skriv ut det fyra gånger. Med och utan mellanrum.
            Console.WriteLine("12. Print a number 4 times.");
            Console.Write("Enter a number: ");
            int x12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            // Utan strängformattering
            Console.WriteLine(x12 + " " + x12 + " " + x12 + " " + x12);
            Console.WriteLine(x12 + "" + x12 + "" + x12 + "" + x12);
            Console.WriteLine();    // Tom rad för struktur.


            // Övning 13
            // Ta in ett tal, skriv ut det fyra gånger. Med och utan mellanrum.
            Console.WriteLine("13. Print a number 4 times.");
            Console.Write("Enter a number: ");
            int x13 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            // Med strängformattering
            Console.WriteLine("{0} {0} {0} {0}",x13);
            Console.WriteLine("{0}{0}{0}{0}", x13);
            Console.WriteLine();    // Tom rad för struktur.


            // Övning 14
            // Ta in ett tal. Skriv ut en rektangel, 3 kolumner och 5 rader, med talet.
            Console.WriteLine("14. Rectangle");
            Console.Write("Enter a number: ");
            int x14 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            Console.WriteLine("{0}{0}{0}", x14);
            Console.WriteLine("{0} {0}", x14);
            Console.WriteLine("{0} {0}", x14);
            Console.WriteLine("{0} {0}", x14);
            Console.WriteLine("{0}{0}{0}", x14);
            Console.WriteLine();    // Tom rad för struktur.


            // Övning 15
            // Ta in ett värde (grader i celsius), konvertera till Fahrenheit och skriv ut resultatet.
            Console.WriteLine("15. Celsius to Fahrenheit");
            Console.Write("Enter your first number: ");
            int celsius15 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();    // Tom rad för struktur.

            Console.Write("Solution 1: ");
            int fahrenheit15 = celsius15 * 18 / 10 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit15);

            Console.Write("Solution 2: ");
            Console.WriteLine("Fahrenheit: {0}", fahrenheit15);

            Console.Write("Solution 3: ");
            Console.WriteLine("Fahrenheit: " + (celsius15 * 18 / 10 + 32));

            Console.Write("Solution 4: ");
            Console.WriteLine("Fahrenheit: {0}", (celsius15 * 18 / 10 + 32));
        }
    }
}
