using System;
using System.Collections.Generic;

namespace Vecka2.WhileDoWhile
{
    static class Exercise13
    {
        public static void Solution()
        {
            bool winner = false;
            int correctLetters = 0;
            char c;
            List<char> guessedChars = new List<char>();

            string word = "Handelsakademin";

            char[] partialWord = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                partialWord[i] = '_';
            }

            List<char> wordList = new List<char>();
            wordList.AddRange(word);

            while (!winner)
            {
                foreach (char ch in partialWord)
                {
                    Console.Write("{0} ", ch);
                }
                do
                {
                    Console.Write("\nEnter your guess: ");
                    c = Convert.ToChar(Console.ReadLine());
                } while (guessedChars.Contains(c));

                guessedChars.Add(c);

                if (wordList.Contains(c))
                {
                    Console.WriteLine("Correct guess! {0} is in the word.",c);
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == c)
                        {
                            partialWord[i] = c;
                            correctLetters++;
                        }
                        if(correctLetters == word.Length)
                        {
                            Console.WriteLine("Congrats! You guessed the word!");
                            winner = true;
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, {0} is not in the word.",c);
                }
            }
        }
    }
}
