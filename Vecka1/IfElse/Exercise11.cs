using System;
namespace Vecka1.IfElse
{
    static class Exercise11
    {
        public static void Solution()
        {
            // Deklarera en variabel som heter ticketPrice.
            // Tilldela den valfritt värde.
            // Personer under 12 år ska få 30% rabatt på priset.
            // Personer över 65 år ska få 35% rabatt på priset.
            // Studenter ska få 20% rabatt på priset.
            // Priser ska beräknas efter input från användaren.
            // Skriv ut originalpriset, samt det nya priset.

            Console.WriteLine("Övning 11: \n");
            double ticketPrice = 100;
            double discountedPrice;
            double studentDiscount = 0.8;
            double childDiscount = 0.7;
            double seniorDiscount = 0.65;
            Console.Write("Vad är din ålder? ");
            int age = Convert.ToInt32(Console.ReadLine());


            if (age < 12)
            {
                discountedPrice = ticketPrice * childDiscount;
            }
            else if (age > 65)
            {
                discountedPrice = ticketPrice * seniorDiscount;
            }
            else
            {
                Console.Write("Är du student? (Ja/Nej)");
                string answer = Console.ReadLine();
                if (answer == "Ja")
                {
                    discountedPrice = ticketPrice * studentDiscount;
                }
                else
                {
                    discountedPrice = ticketPrice;
                }
            }
        }
    }
}
