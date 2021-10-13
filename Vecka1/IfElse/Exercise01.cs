using System;
namespace Vecka1.IfElse
{
    static class Exercise01
    {
        public static void Solution()
        {
            // Ta in 3 tal.
            // Skriv ut talen i storleksordning. (Störst först)

            int tal1;
            int tal2;
            int tal3;

            Console.WriteLine("Övning 1:");
            Console.Write("Skriv in ditt första tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ditt andra tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ditt tredje tal: ");
            tal3 = Convert.ToInt32(Console.ReadLine());

            // Alt 1
            if (tal1 > tal2) // Om tal1 är större än tal2
            {
                if (tal1 > tal3) // Om tal1 är större än tal3 = tal1 är störst.
                {
                    if (tal2 > tal3) // Om tal2 är större än tal3 = tal2 är näst störst.
                    {
                        Console.WriteLine("Storleksordning: {0} {1} {2}", tal1, tal2, tal3);
                    }
                    else // Om tal2 inte är större än tal3 = tal3 är näst störst.
                    {
                        Console.WriteLine("Storleksordning: {0} {1} {2}", tal1, tal3, tal2);
                    }
                }
                else // Om tal1 inte är större än tal3 = Tal3 är störtst, tal1 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal3, tal1, tal2);
                }
            }
            else // Om tal1 inte är större än tal2
            {
                if (tal2 > tal3) // Om tal2 är större än tal3 = tal2 är störst.
                {
                    if (tal1 > tal3) // Om tal1 är större än tal3 = tal1 är näst störst.
                    {
                        Console.WriteLine("Storleksordning: {0} {1} {2}", tal2, tal1, tal3);
                    }
                    else // Om tal1 inte är större än tal3 = tal2 är näst störst.
                    {
                        Console.WriteLine("Storleksordning: {0} {1} {2}", tal2, tal3, tal1);
                    }
                }
                else // Om tal2 inte är större än tal3
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal3, tal2, tal1);
                }
            }

            // Alt 2
            if(tal1 > tal2 && tal1 > tal3) // Om tal1 är störra än tal2 OCH tal3.
            {
                if (tal2 > tal3)    // Om tal2 är större än tal3 = tal2 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal1, tal2, tal3);
                }
                else                // Om tal2 inte är större än tal3 = tal3 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal1, tal3, tal2);
                }
            }
            if(tal2 > tal1 && tal2 > tal3) // Om tal2 är större än tal1 OCH tal3.
            {
                if (tal1 > tal3)    // Om tal1 är större än tal3 = tal1 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal2, tal1, tal3);
                }
                else                // Om tal1 inte är större än tal3 = tal3 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal2, tal3, tal1);
                }
            }
            else    // Om inte tal1 eller tal2 är störst = tal3 är störst.
            {
                if (tal1 > tal2)    // Om tal1 inte är större än tal2 = tal1 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal3, tal1, tal2);
                }
                else                // Om tal1 inte är större än tal2 = tal2 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal3, tal2, tal1);
                }
            }
        }
    }
}
