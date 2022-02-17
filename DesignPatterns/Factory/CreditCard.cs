using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract double CreditLimit { get; set; }
        public abstract double AnnualCharge { get; set; }
    }

    class PlatinumCard : CreditCard
    {
        private readonly string _cardType;
        private double _creditLimit;
        private double _annualCharge;

        public PlatinumCard(double creditLimit, double annualCharge)
        {
            _cardType = "Platinum";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType
        {
            get
            {
                return _cardType;
            }
        }
        public override double CreditLimit
        {
            get
            {
                return _creditLimit;
            }
            set
            {
                _creditLimit = value;
            }
        }
        public override double AnnualCharge
        {
            get
            {
                return _annualCharge;
            }
            set
            {
                _annualCharge = value;
            }
        }
    }
}
