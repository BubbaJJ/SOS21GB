using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    internal class InvitationCard
    {
        public string To { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        /* Metoder för att klona invitiationCard. */

        // Ej static - Anropas via objektet; behöver därför ingen indata.
        // Funkar både med och utan "this."
        public InvitationCard CloneCard()
        {
            // return (InvitationCard)MemberwiseClone();
            return (InvitationCard)this.MemberwiseClone();
        }

        // Static - Anropas via klassen.
        // Behöver indata för att veta vilket InvitationCard som ska klonas.
        public static InvitationCard CloneCardStatic(InvitationCard obj)
        {
            return (InvitationCard)obj.MemberwiseClone();
        }

        /* Metod för att skriva ut informationen. */
        public void PrintCard()
        {
            Console.WriteLine("To: {0}", To);
            Console.WriteLine(Title);
            Console.WriteLine(Content);
            Console.WriteLine("When? {0}", Date.ToString("g"));
            Console.WriteLine();
        }
    }
}