using System;
using System.Collections.Generic;

namespace Vecka3.Switch
{
    static class Exercise16
    {
        public static void SolutionFor()
        {
            Dictionary<int, string> weekdays = new Dictionary<int, string>() { { 1, "Måndag" }, { 2, "Tisdag" }, { 3, "Onsdag" }, { 4, "Torsdag" }, { 5, "Fredag" }, { 6, "Lördag" }, { 7, "Söndag" } };

            Dictionary<string, int> weekdaysSwapped = new Dictionary<string, int>();

            Console.WriteLine(weekdays.Count);

            for (int i = weekdays.Count; i > 0; i--)
            {
                weekdaysSwapped.Add(weekdays[i], i);
                weekdays.Remove(i);
            }
            Console.WriteLine(weekdays.Count);

            foreach (KeyValuePair<string, int> item in weekdaysSwapped)
            {
                Console.WriteLine("Key: {0} Value: {1}",item.Key, item.Value);
            }
        }

        public static void SolutionForEach()
        {
            Dictionary<int, string> weekdays = new Dictionary<int, string>() { { 1, "Måndag" }, { 2, "Tisdag" }, { 3, "Onsdag" }, { 4, "Torsdag" }, { 5, "Fredag" }, { 6, "Lördag" }, { 7, "Söndag" } };

            Dictionary<string, int> weekdaysSwapped = new Dictionary<string, int>();

            Console.WriteLine(weekdays.Count);

            foreach (KeyValuePair<int, string> item in weekdays)
            {
                weekdaysSwapped.Add(item.Value, item.Key);
                weekdays.Remove(item.Key);
            }

            Console.WriteLine(weekdays.Count);

            foreach (KeyValuePair<string, int> item in weekdaysSwapped)
            {
                Console.WriteLine("Key: {0} Value: {1}", item.Key, item.Value);
            }
        }
    }
}
