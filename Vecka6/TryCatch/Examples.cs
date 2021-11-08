using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka6.TryCatch
{
    class Examples
    {
        public static void TryCatchExample()
        {
            try
            {
                // Kod som ska testas.
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                double result = num1 / num2;
            }
            catch (Exception e)
            {
                // Kod som körs vid fel/exceptions.
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Kod som körs oavsett.
                Console.WriteLine("Finally!");
            }
        }
    }
}