using System;
namespace Vecka1.IfElse
{
    class IfElse
    {
        public static void Examples()
        {
            int x = 2;
            bool runAgain = false;

            // Exempel 1 - If
            if (x == 2)             // Om x är lika med 2
            {
                // Do something...
                Console.WriteLine("Test");
            }

            // Exempel 2 - If med else
            if (x == 2)             // Om x är lika med 2
            {
                // Do something...
            }
            else                    // Om x inte är lika med 2
            {
                // Do something else...
            }

            // Exempel 3 - If med else if
            if (x == 2)             // Om x är lika med 2
            {
                // Do something...
            }
            else if(x == 4)         // Om x är lika med 4
            {
                // Do something...
            }
            else                    // Om x inte är lika med varken 2 eller 4
            {
                // Do something else...
            }

            // Exempel 4 - If med flera else if

            if (x == 1)
            {
                Console.WriteLine("Option 1..");
            }
            else if (x == 2)
            {
                Console.WriteLine("Option 2..");
            }
            else if (x == 3)
            {
                Console.WriteLine("Option 3..");
            }
            else if (x == 4)
            {
                Console.WriteLine("Option 4..");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

            // Exempel 5 
            if (x == 2 || x == 4)   // Om x är lika med 2 eller 4
            {
                // Do something...
            }
            else                    // Om x inte är lika med varken 2 eller 4
            {
                // Do something...
            }

            // Exempel 6
            if (x == 2 || x == 4)   // Om x är lika med 2 eller 4
            {
                if(x == 2)      // Om x är lika med 2
                {
                    // Do something...
                }
                else            // Om x inte är lika med 2
                {
                    // Do something...
                }
            }
            else                    // Om x inte är lika med varken 2 eller 4
            {
                // Do something...
            }

            // Exempel 7
            if (runAgain)           // Om runAgain är 'true'
            {
                // Do something...
            }
            else                    // Om runAgain inte är 'true'
            {
                // Do something...
            }


            // Exempel 8
            if (!runAgain)           // Om runAgain är 'false'
            {
                if (x == 1)         // Om x är lika med 1
                {
                    // Do something...
                }
                else if (x == 2)    // Om x är lika med 2
                {
                    // Do something...
                }
                else if (x == 3)    // Om x är lika med 3
                {
                    // Do something...
                }
                else
                {
                    // Do something...
                }
            }
        }
    }
}
