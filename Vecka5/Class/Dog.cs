using System;

namespace Vecka5.Class
{
    public class Dog
    {
        #region Private Fields

        private int _age;

        private string _breed;

        // Private
        // Private
        private string _color;

        // Fields
        private string _name;

        #endregion Private Fields

        // Private

        // Private

        #region Public Constructors

        // Contructors
        public Dog()
        {
        }

        public Dog(string name, string breed)
        {
            this._name = name;      // this = detta objektet.
            this._breed = breed;    // this = detta objektet.
        }

        #endregion Public Constructors

        #region Public Properties

        public int Age
        {
            // Returnerar värdet i _age
            get
            {
                return _age;
            }
            // Tilldelar _age ett nytt värde
            set
            {
                _age = value;
            }
        }

        public string Breed
        {
            // Returnerar värdet i _breed
            get
            {
                return _breed;
            }
            // Tilldelar _breed ett nytt värde
            set
            {
                _breed = value;
            }
        }

        public string Color
        {
            // Returnerar värdet i _color
            get
            {
                return _color;
            }
            // Tilldelar _color ett nytt värde
            set
            {
                _color = value;
            }
        }

        // Properties
        public string Name
        {
            // Returnerar värdet i _name
            get
            {
                return _name;
            }
            // Tilldelar _name ett nytt värde
            set
            {
                _name = value;
            }
        }

        #endregion Public Properties

        #region Public Methods

        // Methods
        public static void Bark()
        {
            Console.WriteLine("Voff!");
        }

        #endregion Public Methods
    }
}