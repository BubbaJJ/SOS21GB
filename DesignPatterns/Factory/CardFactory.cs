using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }

    class PlatinumFactory : CardFactory
    {
        private double _creditLimit;
        private double _annualCharge;

        public PlatinumFactory(double creditLimit, double annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new PlatinumCard(_creditLimit, _annualCharge);
        }

    }
}
