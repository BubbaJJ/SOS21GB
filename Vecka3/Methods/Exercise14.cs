using System;
namespace Vecka3.Methods
{
    static class Exercise14
    {
        public static int LargestNumber(int[] numbers)
        {
            int largest = 0;

            foreach(int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
            }

            return largest;
        }
    }
}
