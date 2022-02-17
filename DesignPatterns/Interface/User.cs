using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interface
{
    class User : IUser
    {
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }

        public void PrintInfo()
        {
            Console.WriteLine(Name);
        }
    }
}
