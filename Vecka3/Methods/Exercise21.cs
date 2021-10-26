using System;
namespace Vecka3.Methods
{
    static class Exercise21
    {
        public static int NextNumber(int num1, int num2)
        {
            int number = 0;

            int result = num1 + num2;
            for (int i = result; i < 1000; i++)
            {
                if (i % num2 == 0)
                {
                    number = i;
                    break;
                }
            }

            return number;
        }
    }
}
