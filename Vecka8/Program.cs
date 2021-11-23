using System;
using System.Collections.Generic;
using System.Linq;

namespace Vecka8
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Special characters (Escape sequence)
            SpecialCharacters.Demo.Examples();

            // Composite strings
            Interpolation.Demo.CompositeExamples();

            // Interpolated strings
            Interpolation.Demo.InterpolatedExamples();

            // Multi-line strings
            MultiLineStrings.Demo.Examples();

            // Named parameters
            Parameters.Demo.NamedParametersExamples();

            // Optional parameters
            Parameters.Demo.OptionalParametersExamples();

            // Ternary operator
            Ternary.Demo.Examples();
        }
    }
}