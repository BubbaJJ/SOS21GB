using System;
namespace Vecka3.Methods
{
    static class Exercise08
    {
        public static void CelciusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius / 5) * 9 + 32;
            Console.WriteLine("{0}c = {1}F",celsius, fahrenheit);
        }
    }
}
