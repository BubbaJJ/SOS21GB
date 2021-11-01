using System;
namespace Vecka5.Class
{
    /*
    Syntax:
    accessModifier class ClassName
    {
        // Variabler
        Field:
        "Vanliga" variabler.
        Utgå alltid från private.

        private int _age;
        pivate string _name;

        Property:
        En "metod" som läser/skriver fields. (get & set)
        Variabel som syns utåt.

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

        // Metoder
        public void printInfo()
        {
            Console.WriteLine("Name: {0}",_name);
            Console.WriteLine("Age: {0}",_age);
        }


        // Konstruktor(-er)
        public Class()
        {

        }

        public Class(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
    */

    public class Class
    {
        private int _age;
        private string _name;

        string _height;

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

        public void printInfo()
        {
            Console.WriteLine("Name: {0}",_name);
            Console.WriteLine("Age: {0}",_age);
        }

        public Class()
        {

        }

        public Class(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
    }
}
