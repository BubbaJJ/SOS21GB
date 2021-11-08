using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka5.Exercises
{
    class Rectangle
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

        public Rectangle(int h, int b)
        {
            this._height = h;
            this._base = b;
        }

        public void PrintRectangle()
        {
            for (int i = 1; i <= _height; i++)
            {
                for (int j = 1; j <= _base; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    static class Exercise04
    {
        public static void Solution()
        {
            Rectangle rectangle = new Rectangle(5, 3);

            rectangle.PrintRectangle();
        }
    }
}