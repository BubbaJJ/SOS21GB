using System;

namespace DesignPatterns.Prototype
{
    internal class PrototypeDemo
    {
        public static void NonStaticMethod()
        {
            Console.WriteLine("--- ICKE-STATISK METOD ---\n");

            // Skapar ett tomt InvitationCard.
            InvitationCard invitationCard = new();

            // Fyller invitationCard med information.
            invitationCard.To = "Arasto";
            invitationCard.Title = "It's partay!";
            invitationCard.Content = "You're invited to the bestest party!";
            invitationCard.Date = new DateTime(2022, 02, 27, 19, 30, 00);

            // Anropar metoden för att skriva ut informationen i invitationCard.
            invitationCard.PrintCard();

            // Array med personer som InvitationCards ska skickas till.
            string[] friends = { "Leo", "Lars", "Eva", "Marija", "Robin" };

            // Array som sparar skapade InvitationCards
            // Används för att kunna loopa igenom och skriva ut informationen senare.
            InvitationCard[] invitationCards = new InvitationCard[5];

            // Loopar igenom arrayen friends och skapar en kopia för varje namn.
            // Eftersom metoden inte är statisk (kopplad till objektet istället för klassen) så behöver INTE InvitationCard skickas med.
            for (int i = 0; i < friends.Length; i++)
            {
                invitationCards[i] = invitationCard.CloneCard();
                invitationCards[i].To = friends[i];
            }

            // Loopar igenom alla invitationCards och skriver ut innehållet.
            foreach (var item in invitationCards)
            {
                item.PrintCard();
            }
        }

        public static void StaticMethod()
        {
            Console.WriteLine("--- STATISK METOD ---\n");
            // Skapar ett tomt InvitationCard.
            InvitationCard invitationCard = new();

            // Fyller invitationCard med information.
            invitationCard.To = "Arasto";
            invitationCard.Title = "It's partay!";
            invitationCard.Content = "You're invited to the bestest party!";
            invitationCard.Date = new DateTime(2022, 02, 27, 19, 30, 00);

            // Anropar metoden för att skriva ut informationen i invitationCard.
            invitationCard.PrintCard();

            // Array med personer som InvitationCards ska skickas till.
            string[] friends = { "Leo", "Lars", "Eva", "Marija", "Robin" };

            // Array som sparar skapade InvitationCards
            // Används för att kunna loopa igenom och skriva ut informationen senare.
            InvitationCard[] invitationCards = new InvitationCard[5];

            // Loopar igenom arrayen friends och skapar en kopia för varje namn.
            // Eftersom metoden är statisk (kopplad till klassen istället för objektet) så behöver ett InvitationCard skickas med.
            for (int i = 0; i < friends.Length; i++)
            {
                invitationCards[i] = InvitationCard.CloneCardStatic(invitationCard);
                invitationCards[i].To = friends[i];
            }

            // Loopar igenom alla invitationCards och skriver ut innehållet.
            foreach (var item in invitationCards)
            {
                item.PrintCard();
            }
        }

    }
}