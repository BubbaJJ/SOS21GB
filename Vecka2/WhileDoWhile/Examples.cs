using System;
namespace Vecka2.WhileDoWhile
{
    class WhileDoWhile
    {
        public static void Examples()
        {
            // While
            // Kontrollera villkoret.
            // Om uppfyllt, kör koden.

            /* 
                Syntax:
                while (villkor)
                {
                    // Do something...
                }
            */

            int count;
            count = 0;

            while (count <= 10) // Kontrollera om villkortet är uppfyllt.
            {
                Console.WriteLine(count);   // Skriv ut värdet som är lagrat i count.
                count++;                    // Öka count med 1.
            }

            bool runAgain;
            runAgain = true;
            int choice;

            while (runAgain)    // Kontrollera om villkoret är uppfyllt.
            {
                Console.WriteLine("Exit program?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)        // Kontrollera om choice är lika med 1.
                {
                    runAgain = false;   // Ändra runAgain till false.
                }
            }

            string[] names = {"Jim", "Leo", "Eva", "Arasto" };
            int i = 0;

            while (i < names.Length) // Kontrollera om i är mindre än längden på arrayen.
            {
                Console.WriteLine(names[i]); // Skriv ut elementet på position(index) i.
                i++;        // Öka i med 1.
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = numbers.Length - 1;

            while (index >= 0)
            {
                Console.WriteLine(numbers[index]);
                index--;        // Minska i med 1.
            }

            int n = 0;

            while (n < 10)
            {
                if (n % 2 == 0)
                {
                    count++;    // Ökar count med 1. (Annars ökar aldrig värdet.)
                    continue;   // Hoppar vidare till nästa iteration.
                }
                else if (n % 3 == 0)
                {
                    break;      // Bryter loopen.
                }
                Console.WriteLine(count);
                count++;
            }

            // Do While
            // Kör koden.
            // Kontrollera villkoret.
            // Om uppfyllt, kör koden igen.

            /*
                Syntax:
                do
                {
                    // Do something...
                } while (villkor);
            */

            int number;
            number = 10;

            do
            {
                Console.WriteLine(number);      // Skriv ut värdet som lagras i number.
                number++;                       // Öka number med 1.
            } while (number<10);                // Kontrollera om number är mindre än 10.

            bool tryAgain;
            tryAgain = false;

            do
            {
                Console.WriteLine(tryAgain);    // Skriv ut värdet som lagras i tryAgain.
            } while (tryAgain);                 // Kontrollera om tryAgain är true.
        }
    }
}
