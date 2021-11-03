using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka5.Examples
{
    class Human
    {
        // Fields
        private string _name;
        private int _age;
        private double _height;
        private string _location;

        // Properties (Get & Set)
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public double Height
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

        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }

        // Constructor
        public Human()
        {
        }

        public Human(string name, int age, double height, string location)
        {
            this._name = name;
            this._age = age;
            this._height = height;
            this._location = location;
        }

        // Methods
        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}", _name);
            Console.WriteLine("Age: {0}", _age);
            Console.WriteLine("Height:{0}", _height);
            Console.WriteLine("Location: {0}", _location);
        }
    }
}