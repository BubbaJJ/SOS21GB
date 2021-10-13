using System;
namespace Vecka2.ForEach
{
    class ForEach
    {
        public static void Examples()
        {
            /*
                Syntax:
                foreach(datatyp namn in samling)
                {
                    Do something...
                }

                foreach(int number in numbers)
                {
                    Do something...
                }

                Iterera igenom en samling variabler, t.ex. en array.
                Gör något för varje element.
            */


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            foreach (int number in numbers)
            {
                Console.WriteLine("i = {0}", number);
            }


            string[] student = { "Jim", "Leo", "Marcus", "Arasto" };

            foreach (string name in student)
            {
                Console.WriteLine(name);
            }


            string greeting = "Welcome";

            foreach (char c in greeting)
            {
                Console.WriteLine(c);
            }
        }
    }
}
