using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka8.Interpolation
{
    class Demo
    {
        public static void CompositeExamples()
        {
            string name = "Handelsakademin";
            string course = "SOS21GB";

            Console.WriteLine("\n- Composite formatting (index) -");
            Console.WriteLine("string name = \"Handelsakademin\"");
            Console.WriteLine("string course = \"SOS21GB\"");

            Console.WriteLine("\nKod:");
            Console.WriteLine("Console.WriteLine(\"Name: {0}\", name);");

            Console.WriteLine("\nResultat:");
            Console.WriteLine("Name: {0}", name);

            Console.WriteLine("\nKod:");
            Console.WriteLine("string fullComposite = String.Format(\"{0} {1}\", name, course);");
            string fullComposite = String.Format("{0} {1}", name, course);

            Console.WriteLine("\nResultat:");
            Console.WriteLine(fullComposite);
        }

        public static void InterpolatedExamples()
        {
            string name = "Handelsakademin";
            string course = "SOS21GB";

            Console.WriteLine("\n- Interpolated string (variabel) -");
            Console.WriteLine("string name = \"Handelsakademin\"");
            Console.WriteLine("string course = \"SOS21GB\"");

            Console.WriteLine("\nKod:");
            Console.WriteLine("Console.WriteLine($\"Name: {name}\");");

            Console.WriteLine("\nResultat:");
            Console.WriteLine($"Name: {name}");

            Console.WriteLine("\nKod:");
            Console.WriteLine("string fullInterpolation = $\"{name} {course}\";");
            string fullInterpolation = $"{name} {course}";

            Console.WriteLine("\nResultat:");
            Console.WriteLine(fullInterpolation);
        }
    }
}