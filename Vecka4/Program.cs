using System;
using System.Collections.Generic;

namespace Vecka4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = {"Måndag", "Tisdag", "Onsdag" };
            Console.WriteLine("Välj dag: [1-3] ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(weekdays[choice-1]); 
            /*
            List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10 };

            Console.WriteLine(numbers.Count);

            numbers.Reverse();

            foreach(int number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();
            numbers.Insert(0,23);

            foreach (int number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();
            Console.WriteLine(numbers.Count);

            numbers.Sort();

            foreach (int number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            numbers.RemoveAll(item => item%2 == 0);

            foreach (int number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            numbers.AddRange(new int[] {23,2,24 });

            foreach (int number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();
            */
            /*
            int[,] numbers = new int[3,2] {{1,2 },{3,4 },{5,6 } };
            int[] numbersRad0 = new int[] { 1, 2 };
            int[] numbersRad1 = new int[] { 3, 4 };
            int[] numbersRad2 = new int[] { 5, 6 };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine(numbers[i,1]);
            }

            Console.WriteLine(numbers[0, 0]); // Rad 0, Kolumn 0 == 1
            Console.WriteLine(numbers[0, 1]); // Rad 0, Kolumn 1 == 2
            Console.WriteLine(numbers[1, 0]); // Rad 1, Kolumn 0 == 3
            Console.WriteLine(numbers[1, 1]); // Rad 1, Kolumn 1 == 4
            Console.WriteLine(numbers[2, 0]); // Rad 2, Kolumn 0 == 5
            Console.WriteLine(numbers[2, 1]); // Rad 2, Kolumn 1 == 6
            */
            /*
            int[] numbers = new int[]{1,2,3,4,5,6,7,8,9,10 };
            int[] numbersEmpty = new int[5];

            for (int i = 0; i < numbersEmpty.Length; i++)
            {
                Console.WriteLine("Skriv in tal för index {0}: ",i);
                numbersEmpty[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int number in numbersEmpty)
            {
                Console.WriteLine(number);
            }
            */
            // Skriv ut alla tal 0-100 med en for-loop
            /*
            for (int i = 0;i<=100;i++)
            {
                Console.WriteLine("i = {0}",i);
            }
            */
            // Skriv ut alla tal 100-0 med en for-loop
            /*
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine("i = {0}", i);
            }
            */
            // Skriv ut alla jämna tal 0-100 med en for-loop
            /*
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("i = {0}", i);
                }
            }
            */
            /*
            for (int i = 1; i <= 99; i += 2)
            {
                Console.WriteLine("i = {0}", i);
            }
            */
            // Skriv ut alla ojämna tal mellan 1-99 med for-loop



            /*
            int[] numbers = {1,2,3,4,5 };
            
            for (int i = 0;i<=10 ;i++) // Börja räkna från 0, så länge i är mindre än 10 - kör loopen, öka i med 1 för varje loop
            {
                Console.WriteLine("i = {0}", i);
            }
            int age = 30;
            int stop = 65;

            while (age<stop)
            {
                Console.WriteLine(age);
            }
            /*
            foreach (int num in numbers)
            {
                if (num == 3)
                {
                Console.WriteLine(num);
                }
            }
            */

            /*
            for (int i = 0; i < 10; i++)
            {
                continue;
                for (int j = 0; j < 5; j++)
                {
                if (j % 2 != 0)
                {
                    break;
                }
                Console.WriteLine(j);
                }
                Console.WriteLine(i);
            }

            Console.ReadKey();
            */
            /*
            // Skapa en variabel som heter memory, värde 0
            int memory = 0;

            // Skapa en variabel som heter value, värde 0
            int value = 0;

            // While-loop, villkor value >= 0
            while(value >= 0)
            {
                // Be användare om värde
                Console.Write("Skriv in valfritt tal: ");
                // Omvandla, och lagra, värdet
                value = Convert.ToInt32(Console.ReadLine());
                // Addera till memory
                memory += value; // memory = memory + value;
                // memory = memory: 10 + value: 5 = 15
                // memory = memory: 15 + value: 7 = 22
                Console.WriteLine(memory);
            }

            // När loopen bryts, skriv ut summan
            Console.WriteLine("Total summa: {0}", memory);

            */

            /*
            // Be användaren om ålder
            Console.Write("Skriv in din ålder: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Antal år till pension
            int retirementAge = 65;
            int yearsLeft = retirementAge - age;
            Console.WriteLine("Du har {0} år kvar till pension.", yearsLeft);
            
            // Fråga om att spola fram tiden
            // Räkna upp till pension
            Console.Write("Vill du spola fram till pension? [J/N] ");
            char choice = Convert.ToChar(Console.ReadLine());
            if(choice == 'J')
            {
                int originalAge = age;
                // Skriv ut ålder varje år
                while (age<retirementAge)
                {
                    age++;
                    Console.WriteLine("Du är nu {0} år.",age);
                }

                Console.Write("Vill du stanna kvar här? J eller N ");
                choice = Convert.ToChar(Console.ReadLine());

                if(choice == 'N')
                {
                    while (age>originalAge)
                    {
                        age--;
                        Console.WriteLine("Du är nu {0} år.", age);
                    }
                }
                else
                {
                    Console.WriteLine("Okej, njut av pensionen!");
                }
            }
            else
            {
                Console.WriteLine("Okej, njut av livet!");
            }
            Console.WriteLine("Tack för att du deltog!");

            

            // Fråga om att spola tillbaka

            // Om ja, räkna ner, skriv ut ålder

            // Om nej, avsluta

            // Skriv ut något..

            */

            /*

            void SwapVariables() { 
            int a = 4;
            int b = 7;
            int c; // Temporär lagring

            c = a;   // temp = 4
            a = b;   // a = 7
            b = c;   // b = 4
            }

            SwapVariables();
            */
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
            //int userAge = 18;

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
            /*
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
            */
            //Dice(userThrows);

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



            //Foreach övning 11:
            /*
            string input = "kajrak";
            List<char> inputList = new List<char>();
            inputList.AddRange(input);

            foreach (char item in inputList)
            {
                Console.Write(item);
            }

            List<char> inputReversed = new List<char>();
            inputReversed.AddRange(input);
            inputReversed.Reverse();

            if (inputList == inputReversed)
            {
                Console.WriteLine("test");
            }

            for (int i = 0; i < inputList.Count/2; i++)
            // Loopen igenom första halvan av listan.
            {
                if(inputList[i] == inputList[inputList.Count - (i + 1)])
                // count = 5        i = 0 + 1 == 1 /Count - 1
                // count = 5        i = 1 + 1 == 2 /Count - 2

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
