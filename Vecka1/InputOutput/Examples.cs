using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka1.InputOutput
{
    class InputOutput
    {
        public static void Examples()
        {
            // Läser in ett tecken, konverterar till ASCII.
            Console.Read();

            // Läser in, och tilldelar, ett tecken; konverterar till ASCII.
            int x = Console.Read();

            // Läser in nästkommande knapptryck.
            Console.ReadKey();

            // Läser in, och tilldelar, nästkommande knapptryck.
            ConsoleKeyInfo key = Console.ReadKey();

            // Läser in en textsträng.
            Console.ReadLine();

            // Läser in, och tilldelar, en textsträng
            string name = Console.ReadLine();

            // Konverterar en variabel till int; om möjligt.
            Convert.ToInt32(name);

            // Konverterar inmatning från användaren till int; om möjligt.
            Convert.ToInt32(Console.ReadLine());

            // Konverterar till int, och tilldelar; om möjligt.
            int nameInt = Convert.ToInt32(name);
            int inputInt = Convert.ToInt32(Console.ReadLine());

            // // Konverterar en variabel till double; om möjligt..
            Convert.ToDouble(name);

            // Konverterar inmatning från användaren till double; om möjligt.
            Convert.ToDouble(Console.ReadLine());

            // Konverterar till int, och tilldelar; om möjligt.
            double nameDouble = Convert.ToDouble(name);
            double inputDouble = Convert.ToDouble(Console.ReadLine());


            // Skriver ut Hej i konsolen; ej radbrytning efter.
            Console.Write("Hej");

            // Skriver ut Hej i konsolen; med radbrytning efter.
            Console.WriteLine("Hej");

            // Skriver ut ett lagrat värde i konsolen; ej radbrytning efter.
            Console.Write(name);

            // Skriver ut ett lagrat värde i konsolen; med radbrytning efter.
            Console.WriteLine(name);


            // Strängformattering med variabler.
            // Index följer ordningen inom parentesen
            Console.WriteLine("{0} {1} {2}",name, nameInt, inputDouble);
            // Index 0 = name, index 1 = nameInt index 2 = inputDouble
            // Output ordningen blir: name nameInt inputDouble

            Console.WriteLine("{1} {2} {0}", name, nameInt, inputDouble);
            // Index 0 = name, index 1 = nameInt index 2 = inputDouble
            // Output ordningen blir: nameInt inputDouble name

            // Strängformattering med nya värden.
            Console.WriteLine("{0} {1}", "Kalle", 32);
            // Index 0 = Kalle, index 1 = 32
            // Output ordningen blir: Kalle 32
        }

    }
}
