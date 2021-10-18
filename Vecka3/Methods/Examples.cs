using System;
namespace Vecka3.Methods
{
    static class Methods
    {
        public static void Examples()
        {
            /*
                Syntax:
                returtyp MetodNamn(ev. indata)
                {
                    Kod här
                }

                void MetodNamn()
                {
                    Gör något.
                }

                int MetodNamn()
                {
                    return ...
                }

                Namnet för indata existerar endast inom metoden.
                Namn utanför metoden existerar inte i metoden.

                MetodNamn(ev indata) för att anropa metoden.
            */

            void PrintSomeInfo()
            {
                Console.WriteLine("Information");
            }

            PrintSomeInfo();

            void PrintMyInfo(string name)
            {
                Console.WriteLine("I'm {0}.", name);
            }

            PrintMyInfo("Jim");

            int GetNumber()
            {
                int number = 10;
                return number;
            }

            Console.WriteLine(GetNumber());

            string ChangeName(string name)
            {
                name += " J!";
                return name;
            }

            string name = ChangeName("Bubba");
            Console.WriteLine(name);
        }
    }
}
