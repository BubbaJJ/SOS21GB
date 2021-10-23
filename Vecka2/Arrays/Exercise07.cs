using System;
using System.Collections.Generic;

namespace Vecka2.Arrays
{
    public class Exercise07
    {
        public Exercise07()
        {
            // Skapa en textsträng.
            string name = "Handelsakademin SOS21GB";

            // Skapa en tom lista av chars.
            List<char> nameList = new List<char>();

            // Lägg till textsträngen i listan.
            nameList.AddRange(name);
        }
    }
}
