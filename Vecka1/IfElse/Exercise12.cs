using System;
namespace Vecka1.IfElse
{
    static class Exercise12
    {
        public static void Solution()
        {
            // Be användaren skriva ut en summa.
            // Användaren ska få provision baserat på summan.
            // Över 1000 = 8%
            // Över 500 = 6%
            // 500 eller lägre = 3%
            // Skriv ut procentsatsen samt vad summan för användaren blir.

            Console.WriteLine("Övning 12: \n");
            Console.Write("Hur mycket har du sålt för? ");
            int amountSold = Convert.ToInt32(Console.ReadLine());

            if (amountSold > 1000)
            {
                Console.WriteLine("Din provision är 8%");
                Console.WriteLine("Din summa blir: {0}", (amountSold * 0.08));
            }
            else if (amountSold > 500)
            {
                Console.WriteLine("Din provision är 6%");
                Console.WriteLine("Din summa blir: {0}", (amountSold * 0.06));
            }
            else
            {
                Console.WriteLine("Din provision är 3%");
                Console.WriteLine("Din summa blir: {0}", (amountSold * 0.03));
            }
        }
    }
}
