using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka7.LINQ
{
    class Demo
    {
        public static void DemoStuff()
        {
            // LINQ
            // Language Integrated Query

            // Query
            // Fråga efter data
            // Vilken data och hur ska den se ut.

            // IEnumerable

            // LINQ - Query
            // from variabelNamn in samlingAvData where variabelNamn.Length > 5 select variabelNamn;

            // LINQ - Lambda
            // samlingAvData.Where(item => item.Length > 5);

            // Data för demo
            List<Student> students = new List<Student>()
            {
                new Student(firstName: "Jim", lastName: "Kaya", age: 32),
                new Student(firstName: "Arasto", lastName: "Sahbaei", age: 28),
                new Student(firstName: "Alexis", lastName: "Flach", age: 34),
                new Student(firstName: "Leo", lastName: "Möller", age: 34),
                new Student(firstName: "Carl", lastName: "Jendle", age: 26),
            };

            int[] numbers = { 12, 34, 123, 546, 45, 2334, 12, 3, 25, 6 };

            // Where

            Console.WriteLine("LINQ - Where");
            Console.WriteLine("- Age over 30 -");

            var ageOver30 = students.Where(name => name.age > 30);
            foreach (var currentObject in ageOver30)
            {
                Console.WriteLine("Age: {0} Name: {1} {2}", currentObject.age, currentObject.firstName, currentObject.lastName);
            }
            // OrderBy

            Console.WriteLine("\nLINQ - OrderBy");
            Console.WriteLine("- Lastname - A to Z -");

            var orderByLastName = students.OrderBy(name => name.lastName);
            foreach (var currentObject in orderByLastName)
            {
                Console.WriteLine("Age: {0} Name: {1} {2}", currentObject.age, currentObject.firstName, currentObject.lastName);
            }

            // OrderByDescending
            Console.WriteLine("\nLINQ - OrderByDescending");
            Console.WriteLine("- Age - High to low -");

            var orderByAge = students.OrderByDescending(name => name.age);

            foreach (var currentObject in orderByAge)
            {
                Console.WriteLine("Age: {0} Name: {1} {2}", currentObject.age, currentObject.firstName, currentObject.lastName);
            }

            // ThenBy
            Console.WriteLine("\nLINQ - ThenBy");
            Console.WriteLine("- Lastname - A to Z -");
            var thenByLastName = students.OrderBy(name => name.age).ThenBy(name => name.lastName);

            foreach (var currentObject in thenByLastName)
            {
                Console.WriteLine("Age: {0} Name: {1} {2}", currentObject.age, currentObject.firstName, currentObject.lastName);
            }

            // ThenByDescending
            Console.WriteLine("\nLINQ - ThenByDescending");
            Console.WriteLine("- Lastname - Z to A -");
            var thenByLastNameDescending = students.Where(name => name.age > 30).OrderByDescending(name => name.age).ThenByDescending(name => name.lastName);

            foreach (var currentObject in orderByAge)
            {
                Console.WriteLine("Age: {0} Name: {1} {2}", currentObject.age, currentObject.firstName, currentObject.lastName);
            }

            // Max
            Console.WriteLine("\nLINQ - Max");
            var highest = numbers.Max();

            Console.WriteLine(highest);

            // Min
            Console.WriteLine("\nLINQ - Min");
            var lowest = numbers.Min();

            Console.WriteLine(lowest);

            // Sum
            Console.WriteLine("\nLINQ - Sum");
            var result = numbers.Sum();

            Console.WriteLine(result);

            // Average
            Console.WriteLine("\nLINQ - Average");
            var avg = numbers.Average();

            Console.WriteLine(avg);

            // Take
            Console.WriteLine("\nLINQ - Take");
            var takeNumbers = numbers.Take(3);

            foreach (var item in takeNumbers)
            {
                Console.WriteLine(item);
            }

            // Skip
            Console.WriteLine("\nLINQ - Skip");
            var skipNumbers = numbers.Skip(6);

            foreach (var item in skipNumbers)
            {
                Console.WriteLine(item);
            }

            // First
            Console.WriteLine("\nLINQ - First");
            var first = numbers.First();

            Console.WriteLine(first);

            // FirstOrDefault
            Console.WriteLine("\nLINQ - FirstOrDefault");
            var firstOrDefault = numbers.FirstOrDefault();

            Console.WriteLine(firstOrDefault);

            // Last
            Console.WriteLine("\nLINQ - Last");
            var last = numbers.Last();

            Console.WriteLine(last);

            // LastOrDefualt
            Console.WriteLine("\nLINQ - LastOrDefault");
            var lastOrDefault = numbers.LastOrDefault();

            Console.WriteLine(lastOrDefault);

            // GroupBy
            // IGrouping
            Console.WriteLine("\nLINQ - GroupBy");
            Console.WriteLine("- Group by age -");

            var groupByAge = students.OrderBy(x => x.lastName).GroupBy(x => x.age);

            foreach (var group in groupByAge)
            {
                Console.WriteLine(group.Key);
                foreach (Student currentObject in group)
                {
                    Console.WriteLine("Age: {0} Name: {1} {2}", currentObject.age, currentObject.firstName, currentObject.lastName);
                }
            }

            // Any
            Console.WriteLine("\nLINQ - Any");
            bool resAny = students.Where(name => name.age > 30).Any();
            Console.WriteLine(resAny); udent s in studentsByAge)
            {
                Console.WriteLine("Age: {0} Name: {1} {2}", s.age, s.firstName, s.lastName);
            }
        }
    }
}