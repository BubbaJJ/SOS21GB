using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class FactoryDemo
    {
        public static void RunFactory()
        {
            //CardFactory factory = null;
            CardFactory factory = new PlatinumFactory(100, 20);

            CreditCard creditCard = factory.GetCreditCard();

            Console.WriteLine("Cardtype: " + creditCard.CardType);
            Console.WriteLine("Creditlimit: " + creditCard.CreditLimit);
            Console.WriteLine("Annual charge: " + creditCard.AnnualCharge);
        }
    }
}
