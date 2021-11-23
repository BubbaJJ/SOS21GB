using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka8.Parameters
{
    class Demo
    {
        public static void OptionalParametersExamples()
        {
            Console.WriteLine("\n- Optional parameters -");

            Console.WriteLine("Greeting();");
            Greeting();
            Console.WriteLine("\nGreeting(\"Jim\");");
            Greeting("Jim");

            static void Greeting(string name = null)
            {
                if (String.IsNullOrEmpty(name))
                {
                    Console.WriteLine("That's disrepectful...");
                }
                else
                {
                    Console.WriteLine("Hello, {0}", name);
                }
            }

            List<User> userList = new List<User>()
            {
            new User("Kalle", 30, "Göteborg"),
            new User("Jim", 32, "Göteborg"),
            new User("Arasto", 28, "Göteborg"),
            new User("Tomas", 32, "Götene"),
            new User("Jörgen", 28, "Linköping"),
            new User("Rickard", 32, "Stora Höga")
            };

            void ListUsers(string location = null)
            {
                if (String.IsNullOrEmpty(location))
                {
                    foreach (var item in userList)
                    {
                        Console.WriteLine("Name: {0} \tAge: {1} \tLocation: {2}", item.Name, item.Age, item.Location);
                    }
                }
                else
                {
                    var queryUsers = userList.Where(x => x.Location == location);
                    foreach (var item in queryUsers)
                    {
                        Console.WriteLine("Name: {0} \tAge: {1} \tLocation: {2}", item.Name, item.Age, item.Location);
                    }
                }
            }

            Console.WriteLine("\nListUsers();");
            ListUsers();
            Console.WriteLine("\nListUsers(\"Göteborg\");");
            ListUsers("Göteborg");
            Console.WriteLine("\nListUsers(\"Stora Höga\");");
            ListUsers("Stora Höga");
        }

        public static void NamedParametersExamples()
        {
            Console.WriteLine("\n- Named parameters -");
            Console.WriteLine("Korrekt ordning:");
            Console.WriteLine("new User(\"Kalle\", 30, \"Göteborg\")");

            Console.WriteLine("\nValfri ordning:");
            Console.WriteLine("new User(age: 30, name: \"Kalle\", location: \"Göteborg\")");
        }
    }
}