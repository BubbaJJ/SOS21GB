using System;
namespace Vecka3.Methods
{
    static class Exercise06
    {
        public static bool OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool OddOrEvenSimplified(int number)
        {
            return number % 2 == 0;
        }
    }
}
