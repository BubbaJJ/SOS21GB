using System;
namespace Vecka3.Methods
{
    static class Exercise19
    {
        public static double Tax(double price, double tax)
        {
            double priceWithTax;

            tax = tax / 100 + 1;            // Momsen / 100 + 1 ger rätt värde för uträkning.
            priceWithTax = price * tax;     // Priset * det nya värdet ger totala priset.

            return priceWithTax;
        }
    }
}
