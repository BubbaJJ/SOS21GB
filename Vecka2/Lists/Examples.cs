using System;
using System.Collections.Generic;

namespace Vecka2.Lists
{
    class Lists
    {
        public static void Examples()
        {
            /*  
                Syntax:
                List<datatyp> listNamn;

                Index:
                Börjar på 0.

                Listor är dynamiska, ändrar storlek efter behov.
                Listor kan tilldelas en bestämd längd; justeras dock vid behov.

                Längden != index;
            */

            // Deklarera en lista med integers, obestämd längd.
            List<int> firstList = new List<int>();

            // Deklarera en lista med integers, "bestämd" längd.
            List<string> secondList = new List<string>(5);

            // Deklarera och tilldela en lista, obestämd längd.
            List<string> thirdList = new List<string>() { "Jim", "Leo", "Eva", "Arasto" };

            // Deklarera och tilldela en lista, "bestämd" längd.
            List<string> fourthList = new List<string>(4) { "Jim", "Leo", "Eva", "Arasto" };

            string word = "Handelsakademin SOS21";

            List<char> charWord = new List<char>();

            charWord.AddRange(word); // Lägger till textsträngen i listan charWord. Konverterar automatiskt.

            foreach (char c in charWord)
            {
                Console.WriteLine(c);
            }

            // Lägg till element. - Adderas i slutet av listan.
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);

            // Lägg till flera element samtidigt med hjälp av en array.
            firstList.AddRange(new int[] { 4, 5, 4, 6 });
            secondList.AddRange(new string[] { "Göteborg", "Stockholm", "Malmö", "Karlstad", "Örebro" });

            // Lägg till element, på ett angivet index.
            // listNamn.Insert(index, element);
            firstList.Insert(2, 34);
            secondList.Insert(1, "Skövde");

            // Ta bort första förekomsten av ett element.
            firstList.Remove(4);

            // Ta bort element på ett angivet index.
            firstList.RemoveAt(4);

            // Läsa ett värde i listan.
            // listNamn[index];
            int number = firstList[0];
            string city = secondList[3];

            // Ta bort alla element som matchar ett angivet värde.
            // "Ta bort alla X där X är lika med 4"
            firstList.RemoveAll(item => item == 4);

            // Ta bort alla tal som är jämna.
            firstList.RemoveAll(item => item % 2 == 0);

            // Ta bort alla tal som är jämna - Med metod.
            firstList.RemoveAll(Even);

            static bool Even(int x)
            {
                return x % 2 == 0;
            }

            // Användbara kommandon.
            // Count - Returnernar antal element.
            int count = firstList.Count;

            // Capacity - Returnerar antal element som kan lagras; innan storleken behöver förändras.
            int capacity = firstList.Capacity;

            // Clear() - Raderar samtliga element.
            firstList.Clear();

            // Contains() - Returnerar om ett element existerar. (True/False)
            firstList.Contains(3);

            // Exists() - Returnerar om ett element existerar. (True/False)
            firstList.Exists(item => item == 3);

            // Sort() - Sorterar elementen.
            firstList.Sort();

            // Reverse() - Vänder ordningen på elementen.
            firstList.Reverse();

            // ToArray() - Kopierar samtliga element till en array.
            string[] cities = secondList.ToArray();

            // FindIndex() - Hittar första index för ett element.
            firstList.FindIndex(item => item == 4);

            // FindAll() - Returnerar alla element som matchar ett specifikt värde.
            firstList.FindAll(item => item == 4);

        }
    }
}
