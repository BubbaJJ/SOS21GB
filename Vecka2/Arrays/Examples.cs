using System;
using System.Linq;

namespace Vecka2.Arrays
{
    class Arrays
    {
        public static void ExamplesSingle()
        {
            /*
                Syntax:
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
            testArray = new int[3] {1,2,3};

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
            int[] thirdString = new int[] {1,2,3,4};

            // Deklarera och tilldela en array av integers.
            // Bestämt antal värden krävs.
            int[] fourthString = new int[4] {1,2,3,4};

            // Deklarera och tilldela en array av strings.
            string[] citiesV1 = { "Göteborg", "Paris", "Berlin" };
            string[] citiesV2 = new string[]{ "Göteborg", "Paris", "Berlin" };
            string[] citiesV3 = new string[3]{ "Göteborg", "Paris", "Berlin" };

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
            int luckyNumber = numbers2d[0,0];
            Console.WriteLine(luckyNumber); // Output = 1

            // Exempel 1
            string[,] names = { {"Jim","Kaya" },{"Leo", "Möller" },{"Eva", "Hagner" } };
            Console.WriteLine(names[0, 0]); // Output = Jim
            Console.WriteLine(names[0, 1]); // Output = Kaya
            Console.WriteLine(names[1, 0]); // Output = Leo
            Console.WriteLine(names[1, 1]); // Output = Möller
            Console.WriteLine(names[2, 0]); // Output = Eva
            Console.WriteLine(names[2, 1]); // Output = Hagner

            // Exempel 2
            string[,] countries = { { "Sweden", "Stockholm" }, { "Denmark", "Copenhagen" }, { "Germany", "Berlin" } };
            Console.WriteLine("Country: {0} Capitol: {1}", countries[0, 0], countries[0, 1]);   // Output = Sweden & Stockholm
            Console.WriteLine("Country: {0} Capitol: {1}", countries[1, 0], countries[1, 1]);   // Output = Denmark & Copenhagen
            Console.WriteLine("Country: {0} Capitol: {1}", countries[2, 0], countries[2, 1]);   // Output = Germany & Berlin
            Console.WriteLine("Country: {0} Capitol: {1}", countries[0, 0], countries[1, 1]);   // Output = Sweden & Copenhagen
        }

        public static void ExamplesMulti3D()
        {
            // 3D array
            // Rader, kolumner, "djup".
            // Deklarera en array av integers.  
            int[,,] numbers3d;  // { 0, 1, 2 }

            // Tildela en array av integers.    
            numbers3d = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            Console.WriteLine(numbers3d[0, 0, 0]);  // Output = 1
            Console.WriteLine(numbers3d[0, 0, 1]);  // Output = 2
            Console.WriteLine(numbers3d[0, 0, 2]);  // Output = 3
            Console.WriteLine(numbers3d[0, 1, 0]);  // Output = 4
            Console.WriteLine(numbers3d[0, 1, 1]);  // Output = 5
            Console.WriteLine(numbers3d[0, 1, 2]);  // Output = 6
            Console.WriteLine(numbers3d[1, 0, 0]);  // Output = 7
            Console.WriteLine(numbers3d[1, 0, 1]);  // Output = 8
            Console.WriteLine(numbers3d[1, 0, 2]);  // Output = 9
            Console.WriteLine(numbers3d[1, 1, 0]);  // Output = 10
            Console.WriteLine(numbers3d[1, 1, 1]);  // Output = 11
            Console.WriteLine(numbers3d[1, 1, 2]);  // Output = 11
        }
    }
}
