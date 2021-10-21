using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise12
    {
        public static void Solution()
        {
            void TwoArrays()
            {
                string answer;
                int count = 0;
                int wrongAnswers = 0;
                int correctAnswers = 0;
                string[] countries = { "Sverige", "Finland", "Norge", "Tyskland" };
                string[] cities = { "Stockholm", "Helsingfors", "Oslo", "Berlin" };

                while (count < countries.Length)
                {
                    Console.WriteLine("Vad heter huvudstaden i {0}", countries[count]);
                    answer = Console.ReadLine();

                    if (answer == cities[count])
                    {
                        Console.WriteLine("Correct!");
                        correctAnswers++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect.");
                        wrongAnswers++;
                    }
                    count++;
                }

                Console.WriteLine("\nThank you for playing!");
                Console.WriteLine("You got {0}/{1} correct!", correctAnswers, countries.Length);
            }

            void OneArray()
            {
                string answer;
                int countCountries = 0;
                int wrongAnswers = 0;
                int correctAnswers = 0;
                string[,] questions = { { "Sverige", "Stockholm" }, { "Finland", "Helsingfors" }, { "Norge", "Oslo" }, { "Tyskland", "Berlin" } };

                while (countCountries < questions.GetLength(0))
                {
                        Console.WriteLine("Vad heter huvudstaden i {0}", questions[countCountries, 0]);
                        answer = Console.ReadLine();

                        if (answer == questions[countCountries, 1])
                        {
                            Console.WriteLine("Correct!");
                            correctAnswers++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect.");
                            wrongAnswers++;
                        }
                    countCountries++;
                }

                Console.WriteLine("\nThank you for playing!");
                Console.WriteLine("You got {0}/{1} correct!", correctAnswers, questions.GetLength(1));
            }

            TwoArrays();
            OneArray();
        }
    }
}
