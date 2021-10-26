using System;
namespace Vecka3.Methods
{
    static class Exercise05
    {
        public static void OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} är ett jämnt tal.", number);
            }
            else
            {
                Console.WriteLine("{0} är inte ett jämnt tal.", number);
            }
        }
    }
}
