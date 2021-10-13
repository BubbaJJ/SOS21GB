using System;
namespace Vecka1.Operators
{
    class Operators
    {
        public static void Examples()
        {
            int num1 = 10;
            int num2 = 2;
            int result = 0;
            bool b = true;

            // Addition
            result = num1 + num2;

            result = result + num1;
            result += num1;

            // Subtraktion
            result = num1 - num2;

            result = result - num1;
            result -= num1;

            // Multiplikation
            result = num1 * num2;

            result = result * num1;
            result *= num1;

            // Division
            result = num1 / num2;

            result = result / num1;
            result /= num1;

            // Modulus
            result = num1 % num2;

            result = result % num1;
            result %= num1;

            // Öka med 1 (postfix - Ändrar värdet efteråt)
            result++;

            // Minska med 1 (postfix - Ändrar värdet efteråt)
            result--;

            // Öka med 1 (prefix - Ändrar värdet innan)
            ++result;

            // Minska med 1 (prefix - Ändrar värdet innan)
            --result;

            // Lika med
            b = num1 == num2;

            // Ej lika med
            b = num1 != num2;

            // Större än
            b = num1 > num2;

            // Mindre än
            b = num1 < num2;

            // Större än eller lika med
            b = num1 >= num2;

            // Större än eller lika med
            b = num1 <= num2;

            // Sant - Boolean
            if (b) { }

            // Falskt - Boolean
            if (!b) { }

            // Och
            if (b && num1 == 2) { }

            // Eller
            if (b || num1 == 2) { }

        }
    }
}
