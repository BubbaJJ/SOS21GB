using System;
namespace Vecka1.IfElse
{
    static class Exercise19
    {
        public static void Solution()
        {
            // Be användaren skriva in två koordinater. (x, y)
            // Skriv ut i vilken kvadrant punkten ligger.
            // G: Inget, eller båda, värde får vara 0.
            // VG: Ta med villkor för samtliga scenario.

            Console.WriteLine("Övning 19: \n");
            Console.Write("Skriv in ett värde för koordinat x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ett värde för koordinat y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("{0} {1} ligger i origin.", x, y);
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("{0} {1} ligger i den första kvadranten.", x, y);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("{0} {1} ligger i den andra kvadranten.", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("{0} {1} ligger i den tredje kvadranten.", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("{0} {1} ligger i den fjärde kvadranten.", x, y);
            }
            else if (x == 0)
            {
                Console.WriteLine("{0} {1} ligger på X-axeln.", x, y);
            }
            else
            {
                Console.WriteLine("{0} {1} ligger på Y-axeln.", x, y);
            }
        }
    }
}
