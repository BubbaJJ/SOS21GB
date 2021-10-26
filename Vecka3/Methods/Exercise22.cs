using System;
namespace Vecka3.Methods
{
    static class Exercise22
    {
        public static int CountNumbers(string numbers)
        {
            int count = 0;

            foreach (char c in numbers)
            {
                if(c>= '0' && c<= '9')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
