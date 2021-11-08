using System;

namespace Vecka5.Exercises
{
    class HumanPublic
    {
        // Publika fields
        public string FirstName;

        public string LastName;
        public int Age;
        public string Location;
        public bool IsParent;

        // Tom konstruktor
        public HumanPublic()
        {
        }

        // Konstruktor med fem parametrar
        public HumanPublic(string fName, string lName, int age, string location, bool isParent)
        {
            this.FirstName = fName;     // Tilldelar FirstName
            this.LastName = lName;      // Tilldelar LastName
            this.Age = age;             // Tilldelar Age
            this.Location = location;   // Tilldelar Location
            this.IsParent = isParent;   // Tilldelar IsParent
        }

        // Metod utan retur
        // Skriver ut alla fields
        public void PrintInfo()
        {
            Console.WriteLine("First name: {0}", FirstName);
            Console.WriteLine("Last name: {0}", LastName);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Is a parent: {0}", IsParent);
        }
    }

    static class Exercise01
    {
        public static void Solution()
        {
            // Skapa en ny instans av Human
            HumanPublic human1 = new HumanPublic();     // Utan parametrar

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
            HumanPublic human2 = new HumanPublic("Jim", "Kaya", 32, "Göteborg", true); // Samtliga parametrar

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