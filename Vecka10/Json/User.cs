using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka10.Json
{
    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Device[] Devices { get; set; }

        public User(int id, string username, Device[] devices)
        {
            this.Id = id;
            this.Username = username;
            this.Devices = devices;
        }
    }
}