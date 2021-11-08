using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka5.Exercises
{
    class Square
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

        public Square(int s)
        {
            this._base = s;
            this._height = _base;
        }

        public void PrintSquare()
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

    static class Exercise03
    {
        public static void Solution()
        {
            Square square = new Square(5);

            square.PrintSquare();
        }
    }
}