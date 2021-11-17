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
            List<Student> students = new List<Student>()
            {
                new Student(firstName: "Jim", lastName: "Kaya", age: 32),
                new Student(firstName: "Arasto", lastName: "Sahbaei", age: 28),
                new Student(firstName: "Alexis", lastName: "Flach", age: 34),
                new Student(firstName: "Leo", lastName: "Möller", age: 34),
                new Student(firstName: "Carl", lastName: "Jendle", age: 26),
            };

            var studentsByAge = students.Where(x => x.age > 27 && x.age < 33).OrderBy(x => x.age);

            foreach (Student s in studentsByAge)
            {
                Console.WriteLine("Age: {0} Name: {1} {2}", s.age, s.firstName, s.lastName);
            }
        }
    }
}