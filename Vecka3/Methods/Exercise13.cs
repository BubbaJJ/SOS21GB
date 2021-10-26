using System;
namespace Vecka3.Methods
{
    static class Exercise13
    {
        public static int ThrowDice(int throws)
        {
            Random rnd = new Random();
            int sum = 0;

            for (int i = 1; i <= throws; i++)
            {
                sum += rnd.Next(1,7);
            }

            return sum;
        }
    }
}
