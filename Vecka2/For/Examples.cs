using System;
namespace Vecka2.For
{
    class For
    {
        public static void Examples()
        {
            /*
                Syntax:
                for (initializer; condition; iterator)
                {
                    Do something...
                }

                for (startvärde; villkor; förändring)
                {
                    Do something...
                }


                Exempel:
                int rows = 3;

                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine(i);
                }

                Vart börjar vi?
                startvärde = 0 (int i = 0)

                Vad måste vara sant?
                Villkor (i < rows)

                Hur mycket ska vi öka varje gång?
                Iteration/Ökning (i++)

                // Omgång 1:
                    i = 0;              // Startvärde
                    i < rows == 0 < 3   // Villkor (Är i mindre än rows?)
                    Kör koden
                    i++ (i = 0 + 1)     // Ökning

                // Omgång 2:
                    i = 1;              // Startvärde
                    i < rows == 1 < 3   // Villkor (Är i mindre än rows?)
                    Kör koden
                    i++ (i = 1 + 1)     // Ökning

                // Omgång 3:
                    i = 2; // Startvärde
                    i < rows == 2 < 3   // Villkor (Är i mindre än rows?)
                    Kör koden
                    i++ (i = 2 + 1)     // Ökning

                // Omgång 4
                    i = 3;              // Startvärde
                    i < rows == 3 < 3   // Villkor
                    Avslutar loopen
            */

            for (int i = 0; i < 10; i++)        // Börjar på 0, avslutas på 9. Ökar med 1 för varje iteration.
            {
                Console.WriteLine("i = {0}", i);
            }

            for (int i = 0; i <= 10; i++)       // Börjar på 0, avslutas på 10. Ökar med 1 för varje iteration.
            {
                Console.WriteLine("i = {0}", i);
            }

            for (int i = 0; i <= 10; i += 2)    // Börjar på 0, avslutas på 10. Ökar med 2 för varje iteration.
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; i--)        // Börjar på 10, avslutas på 1. Minskar med 1 för varje iteration.
            {
                Console.WriteLine("i = {0}", i);
            }

            for (int i = 10; i >= 0; i--)       // Börjar på 10, avslutas på 0. Minskar med 1 för varje iteration.
            {
                Console.WriteLine("i = {0}", i);
            }

            for (int i = 10; i <= 0; i -= 2)    // Börjar på 10, avslutas på 0. Minskar med 2 för varje iteration.
            {
                Console.WriteLine(i);
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < numbers.Length; i++)    // Length returnerar längden på en array.
            {
                Console.WriteLine("i = {0}", numbers[i]);
            }

            for (int i = 0; i < 10; i++) // Nested for
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("i = {0} j = {1}", i, j);
                }
            }

            char[,] hello = new char[,] { { 'H', 'e' }, { 'l', 'l' }, { 'o', '!' } };

            for (int i = 0; i < hello.GetLength(0); i++)    // GetLength(0) returnerar antal "rader" i en 2D-array.
            {
                for (int j = 0; j < hello.GetLength(1); j++) // GetLength(0) returnerar antal "kolumner" i en 2D-array.
                {
                    Console.Write(hello[i, j]);
                }
            }
        }
    }
}
