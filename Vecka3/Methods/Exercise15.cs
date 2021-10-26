using System;
namespace Vecka3.Methods
{
    static class Exercise15
    {
        public static int SmallestNumber(int[] numbers)
        {
            int smallest = numbers[0]; // Sätt det första värdet i arrayen till det minsta.

            for (int i = 1; i < numbers.Length; i++) // Börja på 1. Hoppa över det värde vi redan använt.
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            return smallest;
        }
    }
}
