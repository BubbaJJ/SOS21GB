using System;
using System.Collections.Generic;

namespace Vecka4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1:
            /*
            static void Greeting()
            {
                Console.WriteLine("Hello!");
            }
            Greeting();
            */
            // 2:
            /*
            string name = "Wilma";

            static void GreetingInput(string str)
            {
                Console.WriteLine("Hello, {0}", str);
            }

            GreetingInput(name);
            */
            int userAge = 18;

            /*
            static bool VerifyAge(int age)
            {
                bool verified;
                if (age>18)
                {
                    verified = true;
                }
                else
                {
                    verified = false;
                }
                return verified;
            }
            */
            /*
            static bool VerifyAge()
            {
                Console.Write("Skriv in din ålder: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age > 18)
                {
                    return true;
                }
                return false;
            }

            Console.WriteLine(VerifyAge());
            */
            /*
            static int AddSum(int num1, int num2)
            {
                //int sum = num1 + num2;
                //return sum;
                return num1 + num2;
            }

            Console.WriteLine(AddSum(2,5));
            */

            static void AreaSquare(int b)
            {
                int area = b * b;
                Console.WriteLine("Arean är {0}", area);
            }

            static void AreaRectangle(int b, int h)
            {
                int area = b * h;
                Console.WriteLine("Arean är {0}", area);
            }

            static void AreaTriangle(int b, int h)
            {
                int area = b * h / 2;
                Console.WriteLine("Arean är {0}", area);
            }

            static void AreaCircle(double r)
            {
                double pi = 3.14;
                double area = pi * r * r;
                double circumference = 2 * r * pi;
                Console.WriteLine("Arean är {0}", area);
                Console.WriteLine("Omkretsen är {0}", circumference);
            }

            static int Dice(int throws)
            {
                int sum = 0;

                Random rnd = new Random();

                for (int i = 1; i <= throws; i++)
                {
                    sum += rnd.Next(1,7);
                }

                return sum;
            }
            Console.WriteLine("Number of throws: ");
            int userThrows = Convert.ToInt32(Console.ReadLine());

            Dice(userThrows);

            /*
            static int CountNumbers(string str)
            {
                int count = 0;
                int sum = 0;

                foreach (char c in str)
                {
                    if (c >= '0' && c <= '9')
                    {
                        count++;
                        sum += (int)Char.GetNumericValue(c);
                    }
                }
                Console.WriteLine(sum);
                return count;
            }

            Console.WriteLine(CountNumbers("h23hh234h23g4"));
            */
            // Input & Output

            // Ingen radbrytning efter utskrift.
            //Console.Write("Test");

            // Radbrytning efter utskrift.
            //Console.WriteLine("Test");

            // Inmatning från konsolen.
            // Tar in en textsträng.
            //Console.ReadLine();

            // Tar in textsträng, konverterar till ASCII.
            //Console.Read();

            // Registrerar vilken tangent som trycks in.
            //Console.ReadKey();

            //int selection = Convert.ToInt32(Console.ReadLine());
            //double number = Convert.ToDouble(Console.ReadLine());

            // If-satser
            // Villkor
            // == Lika med
            // != Inte lika med
            // > Större än
            // < Mindre än
            // >= Större än, eller lika med
            // <= Mindre än, eller lika med
            // ! Inte lika med (Boolean (Sant/Falskt))

            /*
            bool verifiedUser = true;

            if (!verifiedUser)
            {
                Console.WriteLine("Non-verified user!");
            }
            else
            {
                Console.WriteLine("Verified user!");
            }

            Console.WriteLine("Main menu:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");

            int choice = 2;

            if (choice == 1)
            {
                Console.WriteLine("Addition vald.");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Subtraktion vald.");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Multiplikation vald.");
            }
            else
            {
                Console.WriteLine("Fel input.");
            }
            */
            /*
            int age = 34;

            if (age >= 18)
            {
                if (age <= 64)
                {
                    Console.WriteLine("Vuxen"); // 18-64
                }
                else
                {
                    Console.WriteLine("Pensionär"); // 65 eller över
                }
            }
            else
            {
                Console.WriteLine("Under 18");
            }
            */


            // Arrays & Listor

            // string[] names = new string[3];

            //string[] names = new string[] {/*Index 0:*/"Elev 1",/*Index 1:*/"Elev 2", /*Index 2:*/"Elev 3" };
            /*
            Console.WriteLine(names[1]);

            names[0] = "Elev 23";

            int[] numbers = {1,2,3,4,5,6,7 };

            Console.WriteLine(numbers[3]);
            */
            /*
            int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine(numbers[1,0]); // 3
            Console.WriteLine(numbers[0,1]); // 2

            numbers[2,0] = 67; // Skriver över 5 med 67
            */
            /*
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            numbers.Add(3); // numbers = 1,2,3,4,5,3

            int[] num = { 3, 7, 32 };
            numbers.AddRange(num);
            numbers.AddRange(new int[] { 3, 5, 36, 65, 1 });

            numbers.Insert(2, 54); // Index 2, lägg till 54.

            numbers.Remove(3); // Ta bort första elementet som är lika med 3

            numbers.RemoveAll(element => element == 3); // Ta bort alla element som är lika med 3.

            numbers.RemoveAt(4); // Ta bort värdet som lagras i index 4.

            numbers.RemoveRange(2,3); // Börja på index 2, ta bort 3 värden i följd.

            numbers.Sort(); // Sortera listan. Minst till störst

            numbers.Reverse(); // Vänd ordning på hela listan.

            numbers.Reverse(3,2); // Vänd ordning på en del avc listan. Börja på index 3, byt plats på 2 element.
            */

            // While & Do While

            /*
            int count = 1;
            bool winner = false;

            Random rnd = new Random();

            int number = rnd.Next(1,11);

            while (count <= 3 && !winner)
            {
                Console.Write("Gissa på ett nummer: ");
                int answer = Convert.ToInt32(Console.ReadLine());

                if(answer == number)
                {
                    Console.WriteLine("Grattis! Rätt nummer.");
                    winner = true;
                }
                else
                {
                    Console.WriteLine("Tyvärr, fel svar.");
                    Console.WriteLine("Antal försök: {0}/3",count);
                    count++;
                }
            } 
            */

            // For & Foreach
            /*
            int[] numbers = { 2, 4, 6, 3, 7, 98, 45, 876, 23, 1 };

            for (int i = 0; i < numbers.Length; i++) // Startvärde: 0, Stoppvärde: 3, Ökning: 1
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (int tree in numbers)
            {
                Console.WriteLine(tree);
                /*
                tree = numbers[0];
                tree = numbers[1];
                tree = numbers[2];
                
            }
            
            /*
            foreach (var item in collection) // datatyp interntNamn in samling(array/lista)
            {

            }
            */
            /*
            string name = "Handelsakademin";
            foreach (char item in name)
            {
                Console.WriteLine(item);
            }
            */
            /*
            int exp = 3;
            int number = 2;
            int sum = 1;

            for (int i = 1; i <= exp; i++)
            {
                sum *= number;
            }

            Console.WriteLine(number);
            */
            // tal * tal * tal

            /*
             * Foreach övning 16
            int stop = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= stop; i++)
            {
                int result = i * i * i; // 1 * 1 *1 , 2 * 2 * 2, 3 * 3 * 3, 4 * 4 * 4
                Console.WriteLine(i + "³ = " + result);
                Console.WriteLine("{0}³ = {1}",i ,result);
            }
            */


            /*
             * Foreach Övning 17
            int number = Convert.ToInt32(Console.ReadLine());

            // Skriv ut multiplikationstabellen för varje tal.
            // Upp till det valda värdet.

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.Write("{0} * {1} = {2} ",i,j,result);
                }
                Console.WriteLine();
            }
            */

            /*
             * Foreach övning 10:
            string name = "Handelsakademin";
            List<char> nameList = new List<char>();
            nameList.AddRange(name);

            List<char> nameReversed = new List<char>();

            foreach (char currentChar in nameList)
            {
                nameReversed.Insert(0,currentChar); // Index 0, lägg till currentChar
            }

            // 0: 1, 1: 2, 2: 3, 3: 4
            // Lägg till talet 5 på index 2.
            // 0: 1, 1: 2, 2: 5, 3: 3, 4: 4
            */


            /*
             * Foreach övning 11:

            string input = "kajak";
            List<char> inputList = new List<char>();
            inputList.AddRange(input);

            foreach (char item in inputList)
            {
                Console.Write(item);
            }

            List<char> inputReversed = new List<char>();
            inputReversed.AddRange(input);
            inputReversed.Reverse();

            for (int i = 0; i < inputList.Count/2; i++)
            // Loopen igenom första halvan av listan.
            {
                if(inputList[i] == inputList[inputList.Count - (i - 1)])
                // inputList.Count = 5
                // inputList.Count - 0 = 5
                // inputList.Count - 0 - 1 = 4
                // inputList[0] == inputList[4]

                // inputList.Count = 5
                // inputList.Count - 1 = 4
                // inputList.Count - 1 - 1 = 3
                // inputList[1] == inputList[3]
                {
                    continue;
                }
            }
            */

            /*
             * Foreach övning 18:
            string name = "Handelsakademin";
            List<char> nameList = new List<char>();
            nameList.AddRange(name);

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

            /*
            for (int i = 0; i < vowels.Length; i++)
            {
                if (nameList.Contains(vowels[i]))
                {
                    nameList.RemoveAll(element => element == vowels[i]);
                }
            }
            */
            /*
            foreach (char vowel in vowels)
            {
                if (nameList.Contains(vowel))
                {
                    nameList.RemoveAll(element => element == vowel);
                }
            }

            foreach (char c in nameList)
            {
                Console.Write(c);
            }

            for (int i = 0; i < vowels.Length; i++)
            {
                for (int j = 0; j < nameList.Count; j++)
                {
                    if (nameList.Contains(vowels[i]))
                    {
                        nameList.Remove(vowels[i]);
                    }
                }
            }
            foreach (char vowel in vowels)
            {
                for (int i = 0; i < nameList.Count; i++)
                {
                    if (nameList.Contains(vowel))
                    {
                        nameList.Remove(vowel);
                    }
                }
            }
            string name = "Handelsakademin";
            List<char> nameList = new List<char>();
            nameList.AddRange(name);

            //char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

            for (int i = nameList.Count - 1; i >= 0; i--)
            {
                if (vowels.Contains(nameList[i]))
                {
                    nameList.RemoveAll(item => item == nameList[i]);
                }
            }

            bool cons = true;

            List<char> charsToRemove = new List<char>();

            for (int i = 0; i < nameList.Count;)
            {
                char c = nameList[i];
                if (!Array.Exists(vowels, item => item == c))
                {
                    nameList.RemoveAll(item => item == c);
                }
                else
                {
                    i++;
                }
            }

            foreach (char c in charsToRemove)
            {
                nameList.RemoveAll(item => item == c);
            }

            foreach (char item in nameList)
            {
                Console.Write(item);
            }


            foreach (char c in nameList)
            {
                if (!Array.Exists(vowels, item => item == c))
                {
                    charsToRemove.Add(c);
                }
            }


            for (int i = 0; i < nameList.Count; i++)
            {
                cons = true;
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (nameList[i] == vowels[j])
                    {
                        cons = false;
                        break;
                    }
                }
                if (cons)
                {
                    charsToRemove.Add(nameList[i]);
                }
            }
            /*

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
            string name = "Handelsakademin";
            List<char> nameList = new List<char>();
            nameList.AddRange(name);

            for (int i = nameList.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (Array.Exists(vowels, item => item == (nameList[i])))
                    {
                        nameList.Remove(nameList[i]);
                    }
                }
            }

            foreach (char ch in nameList)
            {
                Console.Write(ch);
            }
            */

        }
    }
}
