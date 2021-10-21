using System;
using System.Collections.Generic;

namespace Vecka3.Dictionary
{
    public class Dictionary
    {
        public static void Examples()
        {
            /*
                Syntax:
                Dictionary<nyckel, värde> name = new Dictionary<nyckel, värde>();

                // Skapa en dictionary.
                Dictionary<datatyp, datatyp> name = new Dictionary<datatyp, datatyp>();

                // Lägga till värden.
                dictionaryNamn.Add(nyckel, värde);

                // Ta bort värden.
                dictionaryNamn.Remove(nyckel);

                // Radera samtliga värden.
                dictionaryNamn.Clear();

                // Se om dictionary innehåller en specifik nyckel.
                dictionaryNamn.ContainsKey(nyckel);

                // Se om dictionary innehåller ett specifik värde.
                dictionaryNamn.ContainsValue(värde);

                // Ändra värdet associerat till en nyckel.
                dictionaryNamn[nyckel] = värde;

                // Läsa ett värde.
                dictionaryNamn[nyckel];
            */

            Dictionary<string, string> cities = new Dictionary<string, string>();
            Dictionary<int, string> numbers = new Dictionary<int, string>() { { 1, "One" }, { 2, "Two" }, { 3, "Three" }, { 4, "Four" } };

            cities.Add("UK", "London");
            cities.Add("USA", "New York");
            cities.Add("France", "Paris");

            Console.WriteLine(cities["UK"]);

            cities.Remove("UK");
            foreach (KeyValuePair<string, string> item in cities)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            cities["France"] = "Oslo";

            foreach (KeyValuePair<string, string> item in cities)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
