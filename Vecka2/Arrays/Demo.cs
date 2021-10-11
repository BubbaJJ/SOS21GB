using System;
namespace Vecka2.Arrays
{
    public class Demo
    {
        public static void ExamplesSingle()
        {
            /*  
                Array syntax:
                Datatyp[] arrayNamn

                Index:
                Börjar på 0.

                Arrays har fast längd; efter tilldelning.

                Längden != index;
            */

            // Deklarera en array av integers, obestämd längd.
            // Längden bestäms vid tilldelning.
            int[] firstArray;

            // Deklarera en array av integers, bestämd längd.
            // Kan ändras fram till tilldelning.
            int[] testArray = new int[4];
            testArray = new int[3] { 1, 2, 3 };

            int[] testIgen = new int[4];
            testIgen[0] = 2;
            testIgen[1] = 4;
            testIgen[2] = 6;
            testIgen[3] = 8;

            // Tilldela en array.
            firstArray = new int[] { 1, 2, 3 };

            // Deklarera och tilldela en array av integers.
            // Antal värden bestämmer längden.
            int[] secondArray = { 1, 2, 3 };
            int[] thirdString = new int[] { 1, 2, 3, 4 };

            // Deklarera och tilldela en array av integers.
            // Bestämt antal värden krävs.
            int[] fourthString = new int[4] { 1, 2, 3, 4 };

            // Deklarera och tilldela en array av strings.
            string[] citiesV1 = { "Göteborg", "Paris", "Berlin" };
            string[] citiesV2 = new string[] { "Göteborg", "Paris", "Berlin" };
            string[] citiesV3 = new string[3] { "Göteborg", "Paris", "Berlin" };

            // Deklarera och tilldela en array av chars.
            char[] charsV1 = { 'G', 'P', 'B' };
            char[] charsV2 = new char[] { 'G', 'P', 'B' };
            char[] charsV3 = new char[3] { 'G', 'P', 'B' };

            // Deklarera och tilldela en array av booleans.
            bool[] booleansV1 = { true, true, false };
            bool[] booleansV2 = new bool[] { true, true, false };
            bool[] booleansV3 = new bool[3] { true, true, false };

            // Deklarera och tilldela en array av integers.
            int[] numbersV1 = { 1, 3, 5 };
            int[] numbersV2 = new int[] { 1, 3, 5 };
            int[] numbersV3 = new int[3] { 1, 3, 5 };

            // Deklarera och tilldela en array av doubles.
            double[] pricesV1 = { 25.99, 349.00, 3.14 };
            double[] pricesV2 = new double[] { 25.99, 349.00, 3.14 };
            double[] pricesV3 = new double[3] { 25.99, 349.00, 3.14 };

            // Läsa värden i en array.
            // arrayName[index]
            string location = citiesV1[0];
            Console.WriteLine(location);
        }



        public static void ExamplesMulti2D()
        {
            // Multidimensional arrays
            // Rader och kolumner

            // Syntax
            // datatyp[rader , kolumner] arrayNamn

            // 2D array
            // Deklarera en array av integers.  
            int[,] numbers2d;   // { 0, 1 }

            // Tildela en array av integers.    
            numbers2d = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            // Läsa värden i en array.
            // arrayName[rad, kolumn]
            int luckyNumber = numbers2d[0, 0];
            Console.WriteLine(luckyNumber);

            // Exempel 1
            string[,] names = { { "Jim", "Kaya" }, { "Leo", "Möller" }, { "Eva", "Hagner" } };
            Console.WriteLine();
            Console.WriteLine("{\"Jim\", \"Kaya\"}");
            Console.WriteLine("{\"Leo\", \"Möller\"}");
            Console.WriteLine("{\"Eva\", \"Hagner\"}");
            Console.WriteLine();
            Console.Write("[0, 0]: ");
            Console.WriteLine(names[0, 0]); // Output = Jim
            Console.Write("[0, 1]: ");
            Console.WriteLine(names[0, 1]); // Output = Kaya
            Console.Write("[1, 0]: ");
            Console.WriteLine(names[1, 0]); // Output = Leo
            Console.Write("[1, 1]: ");
            Console.WriteLine(names[1, 1]); // Output = Möller
            Console.Write("[2, 0]: ");
            Console.WriteLine(names[2, 0]); // Output = Eva
            Console.Write("[2, 1]: ");
            Console.WriteLine(names[2, 1]); // Output = Hagner
            Console.WriteLine();
            Console.ReadKey();

            // Exempel 2
            string[,] countries = { { "Sweden", "Stockholm" }, { "Denmark", "Copenhagen" }, { "Germany", "Berlin" } };
            Console.WriteLine("string[,] countries = { { \"Sweden\", \"Stockholm\" }, { \"Denmark\", \"Copenhagen\" }, { \"Germany\", \"Berlin\" } };");
            Console.ReadKey();
            Console.WriteLine("Country: {0} Capitol: {1}", countries[0, 0], countries[0, 1]);
            Console.WriteLine("Country: {0} Capitol: {1}", countries[1, 0], countries[1, 1]);
            Console.WriteLine("Country: {0} Capitol: {1}", countries[2, 0], countries[2, 1]);

        }

        public static void ExamplesMulti3D()
        {
            // 3D array
            // Rader, kolumner, "djup".
            // Deklarera en array av integers.  
            int[,,] numbers3d;  // { 0, 1, 2 }

            // Tildela en array av integers.    
            numbers3d = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            Console.WriteLine(numbers3d[0, 0, 0]);
            Console.WriteLine(numbers3d[0, 0, 1]);
            Console.WriteLine(numbers3d[0, 0, 2]);
            Console.WriteLine(numbers3d[0, 1, 0]);
            Console.WriteLine(numbers3d[0, 1, 1]);
            Console.WriteLine(numbers3d[0, 1, 2]);
            Console.WriteLine(numbers3d[1, 0, 0]);
            Console.WriteLine(numbers3d[1, 0, 1]);
            Console.WriteLine(numbers3d[1, 0, 2]);
            Console.WriteLine(numbers3d[1, 1, 0]);
            Console.WriteLine(numbers3d[1, 1, 1]);
            Console.WriteLine(numbers3d[1, 1, 2]);
        }

        public static void Visual2D()
        {
            // Visuellt exempel 2d-array
            int width2cols = 16;

            Console.WriteLine("datatyp[3,2] arrayNamn; \n");
            Console.ReadKey();
            Console.WriteLine("Rad || Col | Col");
            Console.WriteLine(new string('-', width2cols));
            Console.WriteLine("[0] || [0] | [1]");
            Console.WriteLine(new string('-', width2cols));
            Console.WriteLine("[1] || [0] | [1]");
            Console.WriteLine(new string('-', width2cols));
            Console.WriteLine("[2] || [0] | [1]");
            Console.WriteLine();
            Console.ReadKey();

            // Visuellt exempel 2d-array
            int width3cols = 22;

            Console.WriteLine("datatyp[3,3] arrayNamn;  \n");
            Console.ReadKey();
            Console.WriteLine("Rad || Col | Col | Col");
            Console.WriteLine(new string('-', width3cols));
            Console.WriteLine("[0] || [0] | [1] | [2]");
            Console.WriteLine(new string('-', width3cols));
            Console.WriteLine("[1] || [0] | [1] | [2]");
            Console.WriteLine(new string('-', width3cols));
            Console.WriteLine("[2] || [0] | [1] | [2]");
            Console.WriteLine();
            Console.ReadKey();

            // Visuellt exempel 2d-array
            int width4cols = 28;

            Console.WriteLine("datatyp[2,4] arrayNamn;  \n");
            Console.ReadKey();
            Console.WriteLine("Rad || Col | Col | Col | Col");
            Console.WriteLine(new string('-', width4cols));
            Console.WriteLine("[0] || [0] | [1] | [2] | [3]");
            Console.WriteLine(new string('-', width4cols));
            Console.WriteLine("[1] || [0] | [1] | [2] | [3]");
            Console.WriteLine();
            Console.ReadKey();

            int[,] numbers2d = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine("numbers2D = new int[]{{1,2},{3,4},{5,6}}");
            Console.WriteLine();
            Console.WriteLine("Rad || [0] | [1]");
            Console.WriteLine(new string('-', width2cols));
            Console.WriteLine("[0] ||  1  |  2");
            Console.WriteLine(new string('-', width2cols));
            Console.WriteLine("[1] ||  3  |  4");
            Console.WriteLine(new string('-', width2cols));
            Console.WriteLine("[2] ||  5  |  6");
            Console.WriteLine();

            Console.WriteLine("Första raden, första kolumnen:");
            Console.Write("[0, 0]: ");
            Console.ReadKey();
            Console.WriteLine(numbers2d[0, 0]);
            Console.ReadKey();
            Console.WriteLine("Första raden, andra kolumnen:");
            Console.Write("[0, 1]: ");
            Console.ReadKey();
            Console.WriteLine(numbers2d[0, 1]);
            Console.ReadKey();
            Console.WriteLine("Andra raden, första kolumnen:");
            Console.Write("[1, 0]: ");
            Console.ReadKey();
            Console.WriteLine(numbers2d[1, 0]);
            Console.ReadKey();
            Console.WriteLine("Andra raden, andra kolumnen:");
            Console.Write("[1, 1]: ");
            Console.ReadKey();
            Console.WriteLine(numbers2d[1, 1]);
            Console.ReadKey();
            Console.WriteLine("Tredje raden, första kolumnen:");
            Console.Write("[2, 0]: ");
            Console.ReadKey();
            Console.WriteLine(numbers2d[2, 0]);
            Console.ReadKey();
            Console.WriteLine("Tredje raden, andra kolumnen:");
            Console.Write("[2, 1]: ");
            Console.ReadKey();
            Console.WriteLine(numbers2d[2, 1]);
            Console.WriteLine();
        }
    }
}

