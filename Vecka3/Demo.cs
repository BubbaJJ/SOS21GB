using System;
using System.Collections.Generic;

namespace Vecka3
{
    public class Demo
    {
        enum veckodagar
        {
            Måndag = 1, // 1
            Tisdag = 2, // 2
            Onsdag = 3, // 3
            Torsdag = 4,// 4
            Fredag = 5, // 5
            Lördag = 6, // 6
            Söndag = 7  // 7
        }

        static void Program(string[] args)
        {
            int choice = 6;
            Console.WriteLine(Enum.GetName(typeof(veckodagar), choice));

            Console.WriteLine(Methods.Exercise22.CountNumbers("asdq34dfs32r23d32d3"));
            Methods.Exercise23.SumOfNumbers("asdq34dfs32r23d32d3");
            Console.ReadKey();
            int number = 21;
            bool primenumber = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    primenumber = false;
                    break;
                }
            }
            if (primenumber)
            {
                Console.WriteLine("{0} is a primenumber.", number);
            }
            else
            {
                Console.WriteLine("{0} is not a primenumber.", number);
            }
            Console.ReadKey();

            int celsius = 26;
            int fahrenheit = (celsius / 5) * 9 + 32;
            Console.WriteLine("{0}c = {1}F", celsius, fahrenheit);

            /*
            // Switch
            int dag = 4;

            switch (dag)
            {
                case 1: // dag == 1
                    Console.WriteLine(veckodagar.Måndag);
                    break;
                case 2: // dag == 2
                    Console.WriteLine(veckodagar.Tisdag);
                    break;
                case 3: // dag == 3
                    Console.WriteLine(veckodagar.Onsdag);
                    break;
                case 4: // dag == 4
                case 5: // dag == 5
                    Console.WriteLine(veckodagar.Torsdag);
                    break;
                case 6: // dag == 6
                    Console.WriteLine("Lördag");
                    break;
                case 7: // dag == 7
                    Console.WriteLine("Söndag");
                    break;
                default: // Inget matchar.
                    Console.WriteLine("Fel input.");
                    break;
            }
            /*
            int result = 4;

            // 0-2 IG
            // 3-5 G
            // 6-8 VG
            // 9-10 MVG

            switch (result)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("IG");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("G");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("VG");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("MVG");
                    break;
                default:
                    break;
            }
            */

            // Dictionary
            Dictionary<int, string> weekdays = new Dictionary<int, string>() { { 1, "Måndag" }, { 2, "Tisdag" }, { 3, "Onsdag" }, { 4, "Torsdag" } };

            Console.WriteLine(weekdays[1]);

            weekdays.Add(5, "Fredag");
            weekdays.Add(6, "Lördag");
            weekdays.Add(7, "Söndag");

            Console.WriteLine(weekdays[7]);

            weekdays.Remove(3);

            Console.WriteLine(Enum.GetName(typeof(veckodagar), 4));

            foreach (string s in Enum.GetNames(typeof(veckodagar)))
            {
                Console.WriteLine(s);
            }
            Enum.GetNames(typeof(veckodagar));

            weekdays[1] = "Fredag";
            Console.WriteLine(weekdays[1]);
            foreach (KeyValuePair<int, string> item in weekdays)
            {
                Console.WriteLine("K: {0} V: {1}", item.Key, item.Value);
            }


            // While
            /*
            string[,] info = new string[3,4];

            int rows = info.GetLength(0);
            int cols = info.GetLength(1);
            int i = 0;


            while (i<rows)
            {
                int j = 0;
                while (j<cols)
                {
                    info[i, j] = "test";
                    j++;
                }
                i++;
            }
            while (i < rows)
            {
                int j = 0;
                while (j < cols)
                {
                    Console.WriteLine(info[i, j]); 
                    j++;
                }
                i++;
            }
            */
            /*
            Random rnd = new Random();

            int correctNumber = rnd.Next(1,11);
            int guess;


            while (true)
            {
                Console.Write("Enter a number: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (correctNumber == guess)
                {
                    Console.WriteLine("Rätt tal!");
                    break;
                }
                else
                {
                    Console.WriteLine("Fel! Försök igen.");
                }
            }
            */
            /*
            int number = 4;
            int i = 0;

            while (i <= 10)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number*i);
                i++;
            }
            */
            /*
            int memory = 0;
            int value = 0;

            while (value>=0)
            {
                value = Convert.ToInt32(Console.ReadLine());
                memory += value;
            }

            Console.WriteLine(memory);
            */
            /*
            string[,] countries = new string[,] { { "Sverige", "Stockholm" }, { "Norge", "Oslo" }, { "Tyskland", "Berlin" } };
            string[] cities = new string[] { "Stockholm", "Oslo" };
            int i = 0;
            int rows = countries.GetLength(0);
            string answer;

            while (i < rows)
            {
                Console.WriteLine("Vad heter huvudstaden i {0}: ", countries[i, 0]);
                answer = Console.ReadLine();

                if (answer == cities[i])
                {
                    Console.WriteLine("Rätt svar!");
                }
                else
                {
                    Console.WriteLine("Fel svar.");
                }
                i++;
            }
            */
        }
    }
}
