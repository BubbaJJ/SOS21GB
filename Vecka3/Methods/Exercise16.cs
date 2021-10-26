using System;
namespace Vecka3.Methods
{
    static class Exercise16
    {
        public static void Primenumber(int number)
        {
            bool primenumber = true;
            for (int i = 2; i < number/2; i++)
            {
                if (number % i == 0)
                {
                    primenumber = false;
                    break;
                }
            }
            if (primenumber)
            {
                Console.WriteLine("{0} is a primenumber.",number);
            }
            else
            {
                Console.WriteLine("{0} is not a primenumber.", number);
            }
        }
    }
}
