using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka8
{
    class User
    {
        public string Name;
        public int Age;
        public string Location;

        public User(string name, int age, string location)
        {
            this.Name = name;
            this.Age = age;
            this.Location = location;
        }
    }
}