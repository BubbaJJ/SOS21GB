using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise08
    {
        public static void Solution()
        {
            void While()
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 11);
                int guess;
                bool correctGuess = false;

                while (!correctGuess)
                {
                    Console.Write("Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == number)
                    {
                        Console.WriteLine("That's correct!");
                        correctGuess = true;
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
            }

            void DoWhile()
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 11);
                int guess;
                bool correctGuess = false;

                do
                {
                    Console.Write("Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == number)
                    {
                        Console.WriteLine("That's correct!");
                        correctGuess = true;
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                } while (!correctGuess);
            }

            While();
            DoWhile();
            
        }
    }
}
