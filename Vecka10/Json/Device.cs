using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka10.Json
{
    class Device
    {
        public int Id { get; init; }
        public string OperatingSystem { get; init; }
        public DateTime DateAdded { get; init; } = DateTime.Now;

        public Device(int id, string operatingSystem)
        {
            this.Id = id;
            this.OperatingSystem = operatingSystem;
        }
    }
}