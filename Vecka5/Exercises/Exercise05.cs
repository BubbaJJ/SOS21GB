using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka5.Exercises
{
    class Triangle
    {
        private int _base;
        private int _height;

        public int Base
        {
            get
            {
                return _base;
            }
            set
            {
                _base = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public Triangle(int h, int b)
        {
            this._height = h;
            this._base = b;
        }

        public void PrintTriangle()
        {
            for (int i = 1; i <= _height; i++)
            {
                for (int j = 1; j <= _base - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int k = 1; k < i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

        public void PrintRomb()
        {
            for (int i = 1; i <= _height; i++)
            {
                for (int j = 1; j <= _height - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i = _height - 1; i > 0; i--)
            {
                for (int j = 1; j <= _height - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }

    class Exercise05
    {
        public static void Solution()
        {
            Triangle triangle = new Triangle(5, 5);

            triangle.PrintTriangle();
        }
    }
}