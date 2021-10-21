using System;
namespace Vecka3.Switch
{
    static class Switch
    {
        public static void Examples()
        {
            /*
                Syntax:

                switch (variabel)
                {
                    case 1:                 // Om variabeln = 1
                        // Do something...
                        break;
                    case 2:                 // Om variabeln = 2
                        // Do something...
                        break;
                    case 3:                 // Om variabeln = 3
                        // Do something...
                        break;
                    default:                // Om inget case matchar.
                        // Do something...
                        break;
                }

                / Kombinera alternativ /
                switch (variabel)
                {
                    case 1:                 // Om variabeln = 1
                        // Do something...
                        break;
                    case 2:                 // Om variabeln = 2 (I detta fall körs case 3)
                    case 3:                 // Om variabeln = 3
                        // Do something...
                        break;
                    default:                // Om inget case matchar.
                        // Do something...
                        break;
                }
            */

            int weekday = 4;

            switch (weekday)
            {
                case 1:
                    Console.WriteLine("Måndag");
                    break;
                case 2:
                    Console.WriteLine("Tisdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lördag");
                    break;
                case 7:
                    Console.WriteLine("Söndag");
                    break;
                default:
                    break;
            }

            int score = 4;

            switch(score)
            {
                case 1:
                    Console.WriteLine("IG");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("G");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("VG");
                    break;
                default:
                    Console.WriteLine("No grade.");
                    break;
            }
        }
    }
}
