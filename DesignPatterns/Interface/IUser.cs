using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interface
{
    interface IUser
    {
        string Name { get; }
        string Email { get; }
        string Password { get; }

        public void PrintInfo();
    }
}
