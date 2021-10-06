using System;
namespace Vecka1
{
    static class Wednesday
    {
        public static void Exercises()
        {
            // Övning 1

        }

        public static void Demo()
        {
            Console.Write("Pick a number: ");
            int x = Convert.ToInt32(Console.ReadLine());


            // Exempel 1 - If utan else
            
            if(x == 2)
            {
                Console.WriteLine("Sant!");
            }
            

            // Exempel 2 - If med else
            
            if(x == 2)
            {
                Console.WriteLine("Sant!");
            }
            else
            {
                Console.WriteLine("Falskt!");
            }
            

            // Exempel 3 - Else if
            
            if(x == 2)
            {
                Console.WriteLine("Sant 1");
            }
            else if(x == 3)
            {
                Console.WriteLine("Sant 2");
            }
            else
            {
                Console.WriteLine("Falskt!");
            }
            

            // Exempel 4 - Else if (Flera)
            
            if(x == 1)
            {
                Console.WriteLine("Option 1..");
            }
            else if(x == 2)
            {
                Console.WriteLine("Option 2..");
            }
            else if (x == 3)
            {
                Console.WriteLine("Option 3..");
            }
            else if(x == 4)
            {
                Console.WriteLine("Option 4..");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            

            bool runAgain = true;

            // Exempel 5 - If (Boolean)
            if(runAgain)
            {
                Console.WriteLine("Sant!");
            }
            else
            {
                Console.WriteLine("Falskt!");
            }
            

            // Exempel 6 - If (Nested)
            if(x == 5 || x == 6)
            {
                if(x == 6)
                {
                    Console.WriteLine("6");
                    if(x%2 == 0)
                    {
                        Console.WriteLine("It works!");
                    }
                }
                else
                {
                    Console.WriteLine("5");
                }
            }
            else
            {
                Console.WriteLine("Falskt!");
            }
            
            Console.WriteLine("Finished!");
        }
    }
}
