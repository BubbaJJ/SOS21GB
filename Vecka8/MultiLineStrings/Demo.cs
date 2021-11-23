using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka8.MultiLineStrings
{
    class Demo
    {
        public static void Examples()
        {
            Console.WriteLine("\n- Multi-line strings -");
            Console.WriteLine("Kod:");
            Console.WriteLine("Console.WriteLine(@\"Main meny");
            Console.WriteLine("1. Start program");
            Console.WriteLine("2. Exit program\");\n");

            Console.WriteLine("Resultat:");
            Console.WriteLine(@"Main menu
1. Start program
2. Exit program");
        }
    }
}