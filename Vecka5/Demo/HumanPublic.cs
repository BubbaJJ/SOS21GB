using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka5.Demo
{
    class HumanPublic
    {
        // Fields
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _location;
        private bool _isParent;

        // Auto-implemented Property (get & set)
        public double Height { get; }

        // Metod
        public void PrintInfo()
        {
            Console.WriteLine("First name: {0}", _firstName);
            Console.WriteLine("Last name: {0}", _lastName);
            Console.WriteLine("Age: {0}", _age);
            Console.WriteLine("Location: {0}", _location);
            Console.WriteLine("Parent: {0}", _isParent);
            Console.WriteLine("Height: {0}", Height);
        }

        // Property (get & set)
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        // Konstruktor
        public HumanPublic()
        {
        }

        public HumanPublic(string firstName, string lastName, int age, string location, bool isParent, double height)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
            this._location = location;
            this._isParent = isParent;
            this.Height = height;
        }
    }
}