using System;
namespace Vecka3.Methods
{
    static class Exercise03
    {
        public static bool VerifyAge(int age)
        {
            if (age > 18)
            {
                return true;
            }
            return false;
        }

        public static bool VerifyAgeSimplified(int age)
        {
            return age > 18;
        }
    }
}
