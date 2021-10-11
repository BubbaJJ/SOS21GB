using System;
namespace Vecka1.IfElse
{
    static class Exercise18
    {
        public static void Solution()
        {
            // Be användaren skriva in ett årtal.
            // Skriv ut om året är ett skottår eller inte.
            // Skottår går att dela med 4.
            // Skottår går att dela med 400.
            // Skottår kan ej delas med 100, förutom om det även kan delas med 400.


            int year = Convert.ToInt32(Console.ReadLine());

            // alt 1
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("{0} is leapyear!", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leapyear", year);
            }


            // alt 2
            if (year % 400 == 0)
            {
                Console.WriteLine("{0} is leapyear!", year);
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("{0} is not a leapyear", year);
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("{0} is leapyear!", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leapyear", year);
            }


            // alt 3
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("{0} is leapyear!", year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a leapyear", year);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is leapyear!", year);
                }
            }
            else
            {
                Console.WriteLine("{0} is not a leapyear", year);
            }


            // alt 4
            Console.WriteLine(DateTime.IsLeapYear(year));
        }
    }
}
