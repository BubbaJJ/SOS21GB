using System;
namespace Vecka3.Methods
{
    static class Exercise07
    {
        public static bool EvenNumbers(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            return false;
        }

        public static bool EvenNumbersSimplified(int num1, int num2)
        {
            return num1 == num2;
        }
    }
}
