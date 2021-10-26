using System;
namespace Vecka3.Methods
{
    static class Exercise12
    {
        public static void AreaCircle(double radius)
        {
            double pi = 3.14;
            double area = 2 * pi * radius;
            double circumference = pi * radius * radius;

            Console.WriteLine("Circumference of the circle is {0}", circumference);
            Console.WriteLine("Area of the circle is {0}", area);
        }
    }
}
