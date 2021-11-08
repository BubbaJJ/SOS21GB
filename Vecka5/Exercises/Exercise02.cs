using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka5.Exercises
{
    class HumanPrivate
    {
        // Privata fields
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _location;
        private bool _isParent;

        // Properties (Get & Set)
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

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
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

        public bool IsParent
        {
            get
            {
                return _isParent;
            }
            set
            {
                _isParent = value;
            }
        }

        // Tom konstruktor
        public HumanPrivate()
        {
        }

        // Konstruktor med fem parametrar
        public HumanPrivate(string fName, string lName, int age, string location, bool isParent)
        {
            this._firstName = fName;     // Tilldelar FirstName
            this._lastName = lName;      // Tilldelar LastName
            this._age = age;             // Tilldelar Age
            this._location = location;   // Tilldelar Location
            this._isParent = isParent;   // Tilldelar IsParent
        }

        // Metod utan retur
        // Skriver ut alla fields
        public void PrintInfo()
        {
            Console.WriteLine("First name: {0}", _firstName);
            Console.WriteLine("Last name: {0}", _lastName);
            Console.WriteLine("Age: {0}", _age);
            Console.WriteLine("Location: {0}", _location);
            Console.WriteLine("Is a parent: {0}", _isParent);
        }
    }

    static class Exercise02
    {
        public static void Solution()
        {
            // Skapa en ny instans av Human
            HumanPrivate human1 = new HumanPrivate();     // Utan parametrar

            // Ändra samtliga fields
            human1.FirstName = "Kalle";     // Ändrar FirstName
            human1.LastName = "Karlsson";   // Ändrar LastName
            human1.Age = 12;                // Ändrar Age
            human1.Location = "Karlstad";   // Ändrar Location
            human1.IsParent = false;        // Ändrar IsParent

            // Läs samtliga fields
            Console.WriteLine(human1.FirstName);    // Skriver ut FirstName
            Console.WriteLine(human1.LastName);     // Skriver ut LastName
            Console.WriteLine(human1.Age);          // Skriver ut Age
            Console.WriteLine(human1.Location);     // Skriver ut Location
            Console.WriteLine(human1.IsParent);     // Skriver ut IsParent

            // Testa metoden
            human1.PrintInfo();     // Skriver ut all information för human1

            // Skapa en ny instans av Human
            HumanPrivate human2 = new HumanPrivate("Jim", "Kaya", 32, "Göteborg", true); // Samtliga parametrar

            // Ändra samtliga fields
            human2.FirstName = "Johan";     // Ändra FirstName
            human2.LastName = "Johansson";  // Ändra LastName
            human2.Age = 16;                // Ändra Age
            human2.LastName = "Jonsered";   // Ändra Location
            human2.IsParent = false;        // Ändra IsParent

            // Läs samtliga fields
            Console.WriteLine(human2.FirstName);    // Skriv ut FirstName
            Console.WriteLine(human2.LastName);     // Skriv ut LastName
            Console.WriteLine(human2.Age);          // Skriv ut Age
            Console.WriteLine(human2.Location);     // Skriv ut Location
            Console.WriteLine(human2.IsParent);     // Skriv ut IsParent

            // Testa metoden
            human2.PrintInfo();
        }
    }
}