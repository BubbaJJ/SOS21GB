using System;
using System.Collections.Generic;

namespace Vecka3.Methods
{
    static class Exercise23
    {
        public static void SumOfNumbers(string numbers)
        {
            int sum = 0;
            List<int> numList = new List<int>();

            foreach (char c in numbers)
            {
                if (c >= '0' && c <= '9')
                {
                    sum += c - '0';
                    sum += Convert.ToInt32(c.ToString());
                    sum += (int)Char.GetNumericValue(c);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
