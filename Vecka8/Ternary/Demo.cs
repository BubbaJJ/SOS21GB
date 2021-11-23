using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka8.Ternary
{
    class Demo
    {
        public static void Examples()
        {
            Console.WriteLine("\n- Ternary operator -");
            Console.WriteLine("Villkor ? Värde om sant : Värde om falskt");

            Example1();
            Example2();
        }

        private static void Example1()
        {
            Console.WriteLine("\nint age = 25;");
            int age = 25;

            Console.WriteLine("\nKod:");
            Console.WriteLine("Console.WriteLine(age > 20 ? \"20+\" : \"Too young!\");");

            Console.WriteLine("\nResultat:");
            Console.WriteLine(age > 20 ? "20+" : "Too young!");

            string verifiedAge;

            if (age >= 18)
            {
                if (age > 20)
                {
                    verifiedAge = "20+";
                }
                else
                {
                    verifiedAge = "Welcome inside!";
                }
            }
            else
            {
                verifiedAge = "Too young!";
            }

            // Villkor ? värde om sant : värde om falskt
            verifiedAge = age >= 18 ? "Welcome inside!" : "Too young!";

            verifiedAge = age >= 18 ? (age > 20 ? "20+" : "Welcome inside!") : "Too young!";

            Console.WriteLine();
            Console.WriteLine(verifiedAge);
        }

        private static void Example2()
        {
            Console.WriteLine("\nint age = 20;");
            int age = 20;

            string answer = age >= 18 ? "Welcome in!" : "Too young!";

            Console.WriteLine(answer);

            Console.WriteLine(age > 20 ? "Welcome!" : "Bye bye!");

            bool verified = age > 17 ? true : false;

            Console.WriteLine(verified);

            Console.Write("Input number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            string result;

            if (input > 10)
            {
                result = "High number!";
            }
            else
            {
                result = "Low number!";
            }

            result = input > 10 ? "High Number!" : "Low number!";

            Console.WriteLine(result);
        }
    }
}