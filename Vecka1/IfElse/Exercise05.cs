using System;
namespace Vecka1.IfElse
{
    static class Exercise05
    {
        public static void Solution()
        {
            // Deklarera fem strängar.
            // Tilldela värden till samtliga strängar.
            // Deklarera fem integers.
            // Tilldela värden till samtlinga integers.
            // Skriv ut första strängen + första integern.
                // T.ex. Console.WriteLine(firstString + firstInt)
                // Repetera för alla variabler.

            Console.WriteLine("Övning 5: \n");
            string myFirstString;
            string mySecondString;
            string myThirdString;
            string myFourthString;
            string myFifthString;
            myFirstString = "First String";
            mySecondString = "Second String";
            myThirdString = "Thid String";
            myFourthString = "Fourth String";
            myFifthString = "Fifth String";

            int myFirstInt;
            int mySecondInt;
            int myThirdInt;
            int myFourthInt;
            int myFifthInt;
            myFirstInt = 1;
            mySecondInt = 2;
            myThirdInt = 3;
            myFourthInt = 4;
            myFifthInt = 5;

            // Utan strängformattering
            Console.WriteLine(myFirstString + myFirstInt);
            Console.WriteLine(mySecondString + mySecondInt);
            Console.WriteLine(myThirdString + myThirdInt);
            Console.WriteLine(myFourthString + myFourthInt);
            Console.WriteLine(myFifthString + myFifthInt);

            // Med strängformattering
            Console.WriteLine("{0} {1}", myFirstString, myFirstInt);
            Console.WriteLine("{0} {1}", mySecondString, mySecondInt);
            Console.WriteLine("{0} {1}", myThirdString, myThirdInt);
            Console.WriteLine("{0} {1}", myFourthString, myFourthInt);
            Console.WriteLine("{0} {1}", myFifthString, myFifthInt);

        }
    }
}
