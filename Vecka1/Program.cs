using System;

namespace Vecka1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kommentar i koden.

            /*
             Kommentar över flera rader.
            */
            
            // Tar in en textsträng.
            string x = Console.ReadLine();
            Console.WriteLine(x);

            // Registerar nästa knapptryckning.
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(key.Key);

            // Returnerar ASCII värde.
            int y = Console.Read();
            Console.WriteLine(y);

            // Skapar en tom variabel.
            // Datatyp string
            string name;

            // Ändrar name till Kalle.
            name = "Kalle";

            // Skriver ut värdet i variabeln name.
            Console.WriteLine(name);

            // Ändrar name till Johan.
            name = "Johan";

            // Skriver ut värdet i variabeln name.
            Console.WriteLine(name);

            // Ändrar name till Wilma.
            name = "Wilma";

            // Skriver ut värdet i variabeln name.
            Console.WriteLine(name);

            // Ändrar name till Elham.
            name = "Elham";

            // Skriver ut värdet i variabeln name.
            Console.WriteLine(name);
        }
    }
}
