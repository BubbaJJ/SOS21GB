using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Vecka10
{
    class Program
    {
        static void Main(string[] args)
        {
            Json.Demo.Example();
            HTTPClient.Demo.APIDemo().Wait();
        }
    }
}