using Newtonsoft.Json;
using System;

namespace Vecka10.Json
{
    static class Demo
    {
        public static void Example()
        {
            /* -- Skapa 2 nya devices -- */
            Device windows = new Device(1, "Windows");
            Device macOs = new Device(2, "MacOs");

            /* -- Skapa en användare -- */
            User user = new(1, "Bubba", new[] { windows, macOs });

            /* -- Skriv ut användarnamn för att testa -- */
            Console.WriteLine(user.Username);

            /* -- Skriv ut namn på samtliga devices för användaren -- */
            foreach (var item in user.Devices)
            {
                Console.WriteLine(item.OperatingSystem);
            }

            /* -- Skapa en json-sträng från objektet -- */
            string output = JsonConvert.SerializeObject(user);

            /* -- Skriv ut json-strängen -- */
            Console.WriteLine(output);

            /* -- Mappar om json-strängen till .NET objekt (Klassen vi skapat), igen -- */
            User jsonUser = JsonConvert.DeserializeObject<User>(output);

            /* -- Skriv ut användarnamn för det nya objektet -- */
            Console.WriteLine(jsonUser.Username);
        }
    }
}