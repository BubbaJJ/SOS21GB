using System;
namespace Vecka3.Switch
{
    static class Exercise09
    {
        public static void Solution()
        {
            // Be användaren skriva in ett tal
            Console.Write("Skriv in ditt första tal: ");

            // Konvertera, och lagra, inmatningen
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Be användaren skriva in ett till tal
            Console.Write("Skriv in ditt andra tal: ");

            // Konvertera, och lagra, inmatningen
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Be användaren välja operator
            Console.Write("Välj operator: [+ - * /] ");

            // Konvertera, och lagra, inmatningen
            char opChoice = Convert.ToChar(Console.ReadLine());

            // Skapa en variabel som lagrar resultatet
            double result = 0;

            // Switch-sats, skicka med användarens inmatning.
            switch (opChoice)
            {
                case '+':                   // Om användaren har valt +
                    result = num1 + num2;   // Använd addition, lagra i result
                    break;                  // Avbryt switch-satsen

                case '-':                   // Om användaren har valt -
                    result = num1 - num2;   // Använd subtraktion, lagra i result
                    break;                  // Avbryt switch-satsen

                case '*':                   // Om användaren har valt *
                    result = num1 * num2;   // Använd multiplikation, lagra i result
                    break;                  // Avbryt switch-satsen

                case '/':                   // Om användaren har valt /
                    result = num1 / num2;   // Använd division, lagra i result
                    break;                  // Avbryt switch-satsen

                default:                    // Om inget annat "case" stämmer
                    break;                  // Avbryt switch-satsen
            }

            // Skriv ut resultatet
            Console.WriteLine(result);
        }
    }
}
