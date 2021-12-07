using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Vecka10.HTTPClient
{
    static class Demo
    {
        /* -- Skapar en HttpClient för att kommunicera med API -- */
        public static HttpClient client = new HttpClient();

        /* -- Async =   Resten av koden fortsätter att köras -- */
        /* -- Task  =   Uppgift som ska utföras -- */

        public static async Task APIDemo()
        {
            /* -- Adress till API -- */
            string uri = @"http://www.boredapi.com/api/activity";

            /* -- Hämtar data från API -- */
            var response = await client.GetAsync(uri);

            /* -- Kontrollerar så att Statuscode = 200 (Allt ok) -- */
            response.EnsureSuccessStatusCode();

            /* -- Läser ut json-strängen från response -- */
            string responseContent = await response.Content.ReadAsStringAsync();

            /* -- Mappar om json-strängen till .NET objekt (Klassen vi skapat) -- */
            BoredActivity boredActivity = JsonConvert.DeserializeObject<BoredActivity>(responseContent);

            /* -- Skriver ut fältet Activity för objektet -- */
            Console.WriteLine(boredActivity.Activity);
        }
    }
}