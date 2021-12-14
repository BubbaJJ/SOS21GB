using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Vecka11
{
    class Program
    {
        /* -- Skapar en HttpClient för att kommunicera med API -- */
        public static HttpClient client = new HttpClient();

        /* -- Async =   Resten av koden fortsätter att köras -- */
        /* -- Task  =   Uppgift som ska utföras -- */

        static async Task Main(string[] args)
        {
            ///* -- Adress till API -- */
            //int id = 237;
            //string uriSpecificPlayer = $"https://www.balldontlie.io/api/v1/players/{id}";

            ///* -- Hämtar data från API -- */
            //var response = await client.GetAsync(uriSpecificPlayer);

            ///* -- Kontrollerar så att Statuscode = 200 (Allt ok) -- */
            //response.EnsureSuccessStatusCode();

            ///* -- Läser ut json-strängen från response -- */
            //string responseContent = await response.Content.ReadAsStringAsync();

            ///* -- Mappar om json-strängen till .NET objekt (Klassen vi skapat) -- */
            //Player player = JsonConvert.DeserializeObject<Player>(responseContent);

            ///* -- Skriver ut information för objektet -- */
            //Console.WriteLine(player.first_name);
            //Console.WriteLine(player.last_name);
            //Console.WriteLine(player.position);
            //Console.WriteLine(player.team.full_name);

            string uriAllPlayers = @"https://www.balldontlie.io/api/v1/players";

            /* -- Hämtar data från API -- */
            var response = await client.GetAsync(uriAllPlayers);

            /* -- Kontrollerar så att Statuscode = 200 (Allt ok) -- */
            response.EnsureSuccessStatusCode();

            /* -- Läser ut json-strängen från response -- */
            string responseContent = await response.Content.ReadAsStringAsync();

            /* -- Mappar om json-strängen till .NET objekt (Klassen vi skapat) -- */
            ListOfPlayers allPlayers = JsonConvert.DeserializeObject<ListOfPlayers>(responseContent);

            /* -- Skriver ut information för objektet -- */
            //Console.WriteLine(allPlayers.data.Count);
            //Console.WriteLine(allPlayers.data[3].first_name);
            //Console.WriteLine(allPlayers.data[3].last_name);

            foreach (var item in allPlayers.data)
            {
                Console.WriteLine("{0}: {1}", allPlayers.data.IndexOf(item), item.first_name);
            }

            Console.WriteLine("Select ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(allPlayers.data[id].first_name);
            Console.WriteLine(allPlayers.data[id].last_name);
        }
    }
}