using System;
namespace Vecka1.IfElse
{
    static class Exercise13
    {
        public static void Solution()
        {
            // Deklarera en boolean som heter bokad.
            // Tilldena den värdet false.
            // Låt användaren välja mellan fem filmer.
            // När användaren valt film ska priset visas.
            // Användaren ska få frågan om att boka en biljett.
            // Om användaren väljer att boka en biljett ska bokad ändras till true.
            // Skapa en ny if-sats
            // Skriv ut om biljetten är bokad eller inte.


            Console.WriteLine("Övning 13: \n");
            bool bokad = false;
            Console.WriteLine("Välj en film:");
            Console.WriteLine("1. Star Wars");
            Console.WriteLine("2. Toy Story");
            Console.WriteLine("3. Lejonkungen");
            Console.WriteLine("4. Deadpool");
            Console.WriteLine("5. Borat");

            int moviePicked = Convert.ToInt32(Console.ReadLine());

            if (moviePicked == 1)
            {
                Console.WriteLine("Du har valt Star Wars.");
                Console.WriteLine("Priset för denna film är 120kr.");
                Console.Write("Vill du boka en biljett? (Ja/Nej) ");
                if (Console.ReadLine() == "Ja")
                {
                    bokad = true;
                }
            }
            else if (moviePicked == 2)
            {
                Console.WriteLine("Du har valt Toy Story.");
                Console.WriteLine("Priset för denna film är 90kr.");
                Console.Write("Vill du boka en biljett? (Ja/Nej) ");
                if (Console.ReadLine() == "Ja")
                {
                    bokad = true;
                }
            }
            else if (moviePicked == 3)
            {
                Console.WriteLine("Du har valt Lejonkungen.");
                Console.WriteLine("Priset för denna film är 95kr.");
                Console.Write("Vill du boka en biljett? (Ja/Nej) ");
                if (Console.ReadLine() == "Ja")
                {
                    bokad = true;
                }
            }
            else if (moviePicked == 4)
            {
                Console.WriteLine("Du har valt Deadpool.");
                Console.WriteLine("Priset för denna film är 125kr.");
                Console.Write("Vill du boka en biljett? (Ja/Nej) ");
                if (Console.ReadLine() == "Ja")
                {
                    bokad = true;
                }
            }
            else if (moviePicked == 5)
            {
                Console.WriteLine("Du har valt Borat.");
                Console.WriteLine("Priset för denna film är 105kr.");
                Console.Write("Vill du boka en biljett? (Ja/Nej) ");
                if (Console.ReadLine() == "Ja")
                {
                    bokad = true;
                }
            }

            if (bokad)
            {
                Console.WriteLine("Biljetten är bokad.");
            }
            else
            {
                Console.WriteLine("Biljetten är inte bokad.");
            }
        }
    }
}
