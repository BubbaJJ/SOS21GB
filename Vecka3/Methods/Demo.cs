using System;
namespace Vecka3.Methods
{
    static class Demo
    {
        public static void Examples()
        {
            /*
List<string> education = new List<string>() { "utveckling", "Objekt", "orienterad", " ", "System" };

for (int i = 0; i < education.Count-1; i++){
    education.Reverse(i, 2);
}

foreach (string name in education)
{
    Console.Write(name);
}
*/
            /*
                Syntax:
                returtyp MetodNamn(ev. indata)
                {
                    Do something...
                }
            
            */
            /*
            void PrintSomething()
            {
                Console.WriteLine("Something");
            }

            PrintSomething();
            */
            /*
            string firstName = "Elham";
            string name = "Jim";

            void PrintSomethingInput(string name)
            {
                Console.WriteLine("My name is {0}",name);
            }

            PrintSomethingInput(firstName);
            */
            /*
            int AddSum(int tal1, int tal2)
            {
                int result = tal1 + tal2;
                return result;
            }

            Console.WriteLine(AddSum(1,2));

            int sum = AddSum(2,3);

            Console.WriteLine(sum);

            int GetAge()
            {
                int age = 30;
                return age;
            }

            Console.WriteLine(GetAge());
            int userAge = GetAge();
            
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            */
            /*
            Greeting();

            void Greeting()
            {
                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Welcome, {0}", userName);
            }
            */


            /*
            string name = "Elham"; // Name är Elham

            string ChangeName(string firstName) // firstName är Elham
            {
                firstName = "123"; // Skriver över Elham, ersätter med 123.
                return firstName; // Returnernar 123.
            }

            name = ChangeName(name); // Skriver över Elham med 123.
            */
            /*
            bool evenNumber = false;
            int tal1 = 234234;

            bool OddOrEven(int num)
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            */
            /*
            void PrintNumbers(int num, int exp)
            {
                for(int i = 1; i < exp; i++)
                {
                    num *= i;
                    Console.WriteLine(num);
                }
            }
            PrintNumbers(23, 4);
            */
        }
    }
}
